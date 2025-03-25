using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors.Controls;
using ImageReview.Logic;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace ImageReview.UI
{
    public partial class frmDashboard : DevExpress.XtraEditors.XtraForm
    {
        bool _IsDataLoaded = true;
        SelectedPlateDetail _pd;
        bool IsImgsLoaded = true;
        string CurrentFolder = "";
        bool CloseFromTimeOut = false;
        DateTime dtReadTime = DateTime.Now;
        List<int> lstSalikLocations = new List<int>();
        List<int> lstIgnoreAccessPoints = new List<int>();

        System.Timers.Timer tmIdle = new System.Timers.Timer() { Enabled = false, Interval = (2 * 1000) };
        System.Timers.Timer tmAppClose = new System.Timers.Timer() { Enabled = true, Interval = (60 * 1000) };
        System.Timers.Timer tmTimer = new System.Timers.Timer() { Enabled = false, Interval = 1000 };
        System.Timers.Timer tmExitPlates = new System.Timers.Timer() { Enabled = true, Interval = 1000 * 60 }; // 5 mints

        #region General & Events

        [DllImport("User32.dll")]
        private static extern bool GetLastInputInfo(ref LASTINPUTINFO plii);
        internal struct LASTINPUTINFO
        {
            public uint cbSize;
            public uint dwTime;
        }

        public static uint GetIdleTime()
        {
            LASTINPUTINFO LastUserAction = new LASTINPUTINFO();
            LastUserAction.cbSize = (uint)Marshal.SizeOf(LastUserAction);
            GetLastInputInfo(ref LastUserAction);
            return ((uint)Environment.TickCount - LastUserAction.dwTime);
        }

        public frmDashboard()
        {
            InitializeComponent();
        }

        private void frmDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            try
            {
                DisplaySettings();

                pnlWait.InvokeControl(l => l.Visible = true);

                UpdateAPandSalikLoc();
                FillReasons();
                FillCities();
                if (Utilis.UserType == "user")
                {
                    bbSystemUsers.Visibility = BarItemVisibility.Never;
                    gcRecentPlates.InvokeControl(l => l.Visible = false);
                    lblForwardedUser.InvokeControl(l => l.Visible = false);
                    lblFalseTriger.InvokeControl(l => l.Visible = false);
                    lblFalseTrigerCap.InvokeControl(l => l.Visible = false);
                }

                if (Utilis.UserName.ToLower() == "waheed" || Utilis.UserName.ToLower() == "zohaib")
                    bbReports.Visibility = BarItemVisibility.Always;

                btnVideo.InvokeControl(l => l.Enabled = false);
                btnIgnore.InvokeControl(l => l.Enabled = false);
                btnSave.InvokeControl(l => l.Enabled = false);
                btnForward.InvokeControl(l => l.Enabled = false);

                GetNextPlate();

                tmIdle.Elapsed += TmIdle_Elapsed;
                tmAppClose.Elapsed += TmAppClose_Elapsed;
                tmTimer.Elapsed += TmTimer_Elapsed;
                tmExitPlates.Elapsed += TmExitPlates_Elapsed;
                tmZoomPlate.Elapsed += TmZoomPlate_Elapsed;

                FillLocationAndAccessPoints();

                ImgSliderW = imgSlider.Width;
                ImgSliderH = imgSlider.Height;
                picZoomW = picZoom.Width;
                picZoomH = picZoom.Height;
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error dashboard : {0}", ee.Message));
                MessageBox.Show("Error : " + ee.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            pnlWait.InvokeControl(l => l.Visible = false);
        }


        public static List<AccessPoint> lstAccessPointsData = new List<AccessPoint>();
        public static List<Location> lstLocations = new List<Location>();

        private async void FillLocationAndAccessPoints()
        {
            try
            {
                IRestResponse resp = await APIs_DAL.GetSitesAndAccessPoints();
                if (resp.IsSuccessful && resp.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    SitesAndAccessPointsResponse rest = JsonConvert.DeserializeObject<SitesAndAccessPointsResponse>(resp.Content);
                    if (rest.status)
                    {
                        //access points
                        lstAccessPointsData.Clear();
                        lstLocations = rest.data;

                        foreach (Location lo in rest.data)
                        {
                            foreach (AccessPoint ap in lo.gates)
                            {
                                lstAccessPointsData.Add(new AccessPoint()
                                {
                                    locationID = lo.id,
                                    locationName = lo.name,
                                    id = ap.id,
                                    name = string.Format("{0} - {1} - {2}", ap.id, ap.name, lo.name),
                                    is_exit = ap.is_exit
                                });
                            }
                        }
                    }
                    else
                    {
                        LogFile.UpdateLogFile(string.Format("Error while loading location and access points data."));
                    }
                }
                else
                {
                    LogFile.UpdateLogFile(string.Format("Sites API is not accessible"));
                }
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error FillLocationAndAccessPoints : {0}", ee.Message));
            }
        }


        private void TmTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            try
            {
                TimeSpan difference = DateTime.Now - dtReadTime;
                lblTimer.InvokeControl(l => l.Text = difference.ToString(@"mm\:ss"));
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error TmTimer_Elapsed : {0}", ee.Message));
            }
        }

        private async void TmAppClose_Elapsed(object sender, ElapsedEventArgs e)
        {
            try
            {
                if (GetIdleTime() > (2 * 60 * 1000) && _pd != null) //2 mints
                {
                    LogFile.UpdateLogFile(string.Format("Time-Out, System closing application"));
                    int aa = await MySqlDAL.UpdateLoginActivity();

                    CloseFromTimeOut = true;
                    tmAppClose.Enabled = false;
                    tmAppClose.Elapsed -= TmAppClose_Elapsed;
                    Application.Exit();
                }
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error TmAppClose_Elapsed : {0}", ee.Message));
            }
        }

        private void TmIdle_Elapsed(object sender, ElapsedEventArgs e)
        {
            try
            {
                tmIdle.Enabled = false;
                UpdateAPandSalikLoc();
                GetNextPlate(true);
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error TmIdle_Elapsed : {0}", ee.Message));
            }
        }

        private void DisplaySettings()
        {
            //conf grid,
            //dgvCharConf.Width = this.Width - (pnlPlateDetail.Location.X + pnlPlateDetail.Width) - 50;
            pnlButtons.Location = new Point(((this.Width / 2) - (pnlButtons.Width / 2)),
                (pnlPlateDetail.Location.Y + pnlPlateDetail.Height + 30));

            pnlWait.Location = new Point(((pnlButtons.Width / 2) - (pnlWait.Width / 2)),
                ((pnlButtons.Height / 2) - (pnlWait.Height / 2)));

            imgSlider.Height = this.Height - (pnlButtons.Location.Y + pnlButtons.Height + 50);
            picZoom.Location = imgSlider.Location;

            if (Utilis.UserType == "admin")
            {
                btnForward.Visible = false;
                btnActiveTrip.Visible = true;
                bbForward.Visibility = BarItemVisibility.Never;
                //btnSave.Location = new Point((pnlButtons.Width / 2) - (btnSave.Width / 2), 4);
            }
            else
            {
                btnForward.Visible = true;
                btnActiveTrip.Visible = false;
                //btnSave.Location = new Point(168, 4);
                //btnForward.Location = new Point(476, 4);
            }
        }

        private void FillCities()
        {
            try
            {
                DataTable dt = new DataTable();

                dt.Columns.Add("city");

                dt.Rows.Add("Dubai");
                dt.Rows.Add("Abu Dhabi");
                dt.Rows.Add("Sharjah");
                dt.Rows.Add("RAK");
                dt.Rows.Add("Ajman");
                dt.Rows.Add("Fujairah");
                dt.Rows.Add("UAQ");
                dt.Rows.Add("KSA");
                dt.Rows.Add("Oman");
                dt.Rows.Add("Government");

                dt.Rows.Add("Bahrain");
                dt.Rows.Add("Egypt");
                dt.Rows.Add("Europe");
                dt.Rows.Add("Iran");
                dt.Rows.Add("Iraq");
                dt.Rows.Add("Jordan");
                dt.Rows.Add("Kuwait");
                dt.Rows.Add("Lebanon");
                dt.Rows.Add("Libya");
                dt.Rows.Add("Qatar");
                dt.Rows.Add("Russia");
                dt.Rows.Add("Sudan");
                dt.Rows.Add("Yemen");

                cmbCity.DataSource = dt;
                cmbCity.DisplayMember = "city";
                cmbCity.SelectedIndex = -1;
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error FillCities : {0}", ee.Message));
                MessageBox.Show("Error : " + ee.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateAPandSalikLoc()
        {
            UpdateIgnoreAccessPoints();
            UpdateSalikLocations();
        }

        private async void UpdateIgnoreAccessPoints()
        {
            try
            {
                lstIgnoreAccessPoints = await MySqlDAL.GetIgnoreAccessPoints();
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error UpdateIgnoreAccessPoints : {0}", ee.Message));
            }
        }

        private async void UpdateSalikLocations()
        {
            try
            {
                lstSalikLocations = await MySqlDAL.GetSalikLocations();
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error UpdateSalikLocations : {0}", ee.Message));
            }
        }

        private async void FillReasons()
        {
            try
            {
                List<Reason> lst = await MySqlDAL.GetReasons();

                cmbReason.DataSource = lst;
                cmbReason.DisplayMember = "name";
                cmbReason.ValueMember = "id";
                cmbReason.SelectedIndex = -1;
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error FillCities : {0}", ee.Message));
            }
        }

        private void bbExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void bbReports_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmReports frm = new frmReports();
            frm.Show();
        }

        private void bbSystemUsers_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmSystemUsersList frm = new frmSystemUsersList();
            frm.ShowDialog();
        }

        private void bbChangePassword_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmChangePassword frm = new frmChangePassword();
            frm.ShowDialog();
        }

        private void bbBtnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            SavePlate();
        }

        private void bbBtnIgnore_ItemClick(object sender, ItemClickEventArgs e)
        {
            IgnorePlate();
        }

        private void bbViewImage_ItemClick(object sender, ItemClickEventArgs e)
        {
            ViewSliderImage(imgSlider.CurrentImage);
        }

        private void bbBtnPlayVideo_ItemClick(object sender, ItemClickEventArgs e)
        {
            btnVideo_Click(sender, new EventArgs());
        }

        private void btnIgnore_Click(object sender, EventArgs e)
        {
            IgnorePlate();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SavePlate();
        }

        private void imgSlider_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.X > 75 && e.X < (imgSlider.Width - 75))
                {
                    ViewSliderImage(imgSlider.CurrentImage);
                }
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error imgSlider_MouseClick : {0}", ee.Message));
                MessageBox.Show("Error : " + ee.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                UpdateAPandSalikLoc();
                await MySqlDAL.MakeUserIdle();
                ReSet();
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error btnRefresh_ItemClick : {0}", ee.Message));
            }
        }

        private async void frmDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CloseFromTimeOut || MessageBox.Show("Are you sure you want to close application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int aa = await MySqlDAL.UpdateLoginActivity();
                e.Cancel = false;
            }
            else
                e.Cancel = true;
        }

        private void imgSlider_CurrentImageIndexChanged(object sender, ImageSliderCurrentImageIndexChangedEventArgs e)
        {
            try
            {
                if (IsImgsLoaded && imgSlider.CurrentImageIndex > -1)
                {
                    ViewSliderImage(imgSlider.Images[imgSlider.CurrentImageIndex], true);
                }
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error imgSlider_CurrentImageIndexChanged : {0}", ee.Message));
            }
        }

        #endregion

        #region Recent Plates

        private async void BindRecentPlatesGrid(string AccessPointID, string EventTime)
        {
            try
            {
                gvRecentPlates.Columns.Clear();
                gcRecentPlates.InvokeControl(l => l.DataSource = null);

                IRestResponse resp = await APIs_DAL.GetRecentPlatesResponce(AccessPointID, EventTime);
                if (resp.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    RecentPlates res = JsonConvert.DeserializeObject<RecentPlates>(resp.Content);
                    if (res != null && res.status && res.data.Count > 0)
                    {
                        BindingList<RecentPlatesData> lst = new BindingList<RecentPlatesData>();

                        foreach (RecentPlate de in res.data)
                            lst.Add(new RecentPlatesData(de.time, de.image, de.plate_code,
                                de.plate_number, de.emirates, de.trip_id, this));

                        gcRecentPlates.InvokeControl(l => l.DataSource = lst);
                        gvRecentPlates.OptionsView.RowAutoHeight = false;
                        gvRecentPlates.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent;

                        gvRecentPlates.OptionsView.ColumnAutoWidth = true;
                        gvRecentPlates.BestFitColumns();
                        FormatRecentPlatesColumns();

                        lst.ListChanged += (s, args) =>
                        {
                            if (args.PropertyDescriptor != null && args.PropertyDescriptor.Name == "plateImage")
                                gvRecentPlates.LayoutChanged();
                        };
                    }
                }
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("BindRecentPlatesGrid Error: {0}", ee.Message));
            }
        }

        private void FormatRecentPlatesColumns()
        {
            try
            {
                gvRecentPlates.Columns["ImageURL"].Visible = false;
                gvRecentPlates.Columns["TripID"].Visible = false;

                gvRecentPlates.Columns["EventTime"].Caption = "Time";
                gvRecentPlates.Columns["PlateNo"].Caption = "Plate";
                gvRecentPlates.Columns["plateImage"].Caption = "Image";

                gvRecentPlates.Columns["plateImage"].AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
                gvRecentPlates.Columns["EventTime"].AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
                gvRecentPlates.Columns["PlateNo"].AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;

                gvRecentPlates.Columns["plateImage"].AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
                gvRecentPlates.Columns["EventTime"].AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
                gvRecentPlates.Columns["PlateNo"].AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error FormatSearchGridColumns : {0}", ee.Message));
            }
        }

        #endregion

        #region Load Next Plate

        private string GetPendingPlate(List<string> lstLocked, int UsersCount)
        {
            try
            {
                /*
                 [0] = transaction id
                 [1] = access point id
                 [2] = location id
                 [3] = entry/exit, 1 = exit, 0 = entry
                 [4] = priority, 1 = high, 0 = low
                 */

                //get free plates, order by priority
                //only entry plates or salik locations, ignore the marked access points
                int num = 0;
                List<string> lstPending = new DirectoryInfo(Utilis.CorrectionFolderPath)
                    .GetDirectories()
                    .Select(y => y.Name)
                    .Where(y => (y.Split('_').Length >= 4)
                    && (!lstLocked.Contains(y))
                    && (!lstIgnoreAccessPoints.Contains(Convert.ToInt32(y.Split('_')[1])))
                    && (y.Split('_')[3] == "0" || lstSalikLocations.Contains(Convert.ToInt32(y.Split('_')[2]))))
                    .OrderByDescending(s =>
                    {
                        if (int.TryParse(s.Split('_').Last(), out num))
                            return num;
                        return int.MinValue; // Push non-numeric to the end
                    })
                    .ToList();

                //in case of arabic user try to fetch ksa plates first
                //but if queue is less then active users, then no need to check, as already limited plates are there
                string JsonTxt = "";
                if (Utilis.IsArabicUser && lstPending.Count > UsersCount)
                {
                    foreach (string fldr in lstPending)
                    {
                        DirInfo = new DirectoryInfo(string.Format("{0}\\{1}", Utilis.CorrectionFolderPath, fldr));
                        if (DirInfo.Exists)
                        {
                            fJson = DirInfo.GetFiles().ToList().Where(x => x.Extension.ToLower().Contains("json")).FirstOrDefault();
                            JsonTxt = fJson != null ? File.ReadAllText(fJson.FullName) : "";
                            if (JsonTxt.ToLower().Contains("ksa"))
                                return fldr;
                        }
                    }
                }

                return lstPending.FirstOrDefault(
                //    s => s.Split('_').Length >= 4
                //&& (s.Split('_')[3] == "0" || lstSalikLocations.Contains(Convert.ToInt32(s.Split('_')[2])))
                //&& (!lstIgnoreAccessPoints.Contains(Convert.ToInt32(s.Split('_')[1])))
                );
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error GetPendingPlate : {0}", ee.Message));
                return "";
            }
        }

        DirectoryInfo DirInfo;
        List<FileInfo> fPic;
        FileInfo fJson;
        FileInfo imgFrame;
        private async void GetNextPlate(bool IsFromTimer = false)
        {
            try
            {
                //  LogFile.UpdateLogFile(string.Format("Get Next Plate"));
                int QueueCount = GetCurrentCount();
                if (_IsDataLoaded)
                {
                    _IsDataLoaded = false;
                    pnlWait.InvokeControl(l => l.Visible = true);

                    //check priority for the user
                    LoginIDAndUserCount lu = await MySqlDAL.GetPriorityLoginID();
                    LogFile.UpdateLogFile(string.Format("Priority : {0}, User Count : {1}, Queue : {2}",
                        lu.LoginID, lu.UsersCount, QueueCount));

                    //skip the priority if more plates are in pending then active users
                    if (QueueCount < lu.UsersCount && lu.LoginID != Utilis.LoginID)
                    {
                        if (lu.LoginID == 0)// if no user is avaiable and current user is asking for data, 
                        {
                            int rec = await MySqlDAL.MakeUserIdle();
                            if (rec == 0) // session timed-out
                            {
                                SessionTimedOut();
                                return;
                            }
                        }

                        LogFile.UpdateLogFile(string.Format("Priority is for the loginID : {0}, current user loginID: {1}",
                            lu.LoginID, Utilis.LoginID));
                        tmIdle.Enabled = true;
                        pnlWait.InvokeControl(l => l.Visible = false);
                        _IsDataLoaded = true;
                        return;
                    }

                    //first get the locked folders
                    List<string> lstLocked = await MySqlDAL.GetCurrentFolders();
                    CurrentFolder = GetPendingPlate(lstLocked, lu.UsersCount);

                    if (!string.IsNullOrEmpty(CurrentFolder))
                    {
                        //lock this folder 
                        int rec = await MySqlDAL.UpdateCurrentFolder(CurrentFolder);
                        if (rec == 0)
                        {
                            SessionTimedOut();
                            return;
                        }

                        LogFile.UpdateLogFile(string.Format("Current Folder : {0}", CurrentFolder));
                        tmIdle.Enabled = false;

                        //load images from path
                        DirInfo = new DirectoryInfo(string.Format("{0}\\{1}", Utilis.CorrectionFolderPath, CurrentFolder));
                        fPic = DirInfo.GetFiles().ToList().Where(x => x.Extension.ToLower().Contains("jpg")).ToList();

                        if (fPic.Count > 20)
                            fPic = fPic.GetRange(0, 19);

                        //Read JsonFile
                        fJson = DirInfo.GetFiles().ToList().Where(x => x.Extension.ToLower().Contains("json")).FirstOrDefault();
                        string JsonTxt = fJson != null ? File.ReadAllText(fJson.FullName) : "";
                        _pd = JsonConvert.DeserializeObject<SelectedPlateDetail>(JsonTxt);

                        //set display data
                        if (_pd != null && _pd.correction != null && _pd.correction.transactionid != "")
                        {
                            imgFrame = fPic.Where(x => x.Name.ToLower().Contains("frame")).FirstOrDefault();
                            SetPlateData(imgFrame != null ? imgFrame.FullName : "");

                            btnVideo.InvokeControl(l => l.Enabled = true);
                            btnIgnore.InvokeControl(l => l.Enabled = true);
                            btnSave.InvokeControl(l => l.Enabled = true);
                            btnForward.InvokeControl(l => l.Enabled = true);

                            LoadSliderImages(fPic);
                            if (IsFromTimer)
                                PlayRingTone();

                            cmbCity.InvokeControl(l => l.Focus());
                            //start timer
                            dtReadTime = DateTime.Now;
                            tmTimer.Enabled = true;

                            fJson = null;
                            fPic = null;
                            DirInfo = null;

                            if (Utilis.UserType == "admin")
                            {
                                GetPlateForwardedReason(_pd.correction.transactionid);
                                BindRecentPlatesGrid(_pd.correction.access_point_id, _pd.correction.event_datetime);
                            }
                        }
                        else
                        {
                            LogFile.UpdateLogFile(string.Format("Invalid Folder Data :  {0}", CurrentFolder));
                            Directory.Delete(string.Format("{0}\\{1}", Utilis.CorrectionFolderPath, CurrentFolder), true);
                            ReSet();
                        }
                    }
                    else // check after 2 sec
                    {
                        //clear existing folders 
                        LogFile.UpdateLogFile(string.Format("Invalid/Empty Current Folder"));
                        await MySqlDAL.ClearCurrentFolders();
                        tmIdle.Enabled = true;
                    }
                    pnlWait.InvokeControl(l => l.Visible = false);
                    _IsDataLoaded = true;
                }
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error lstPendingPlates : {0}", ee.Message));
                await MySqlDAL.MakeUserIdle();
                tmIdle.Enabled = true;
                ReSet();
            }
        }

        private async void GetPlateForwardedReason(string TransID)
        {
            try
            {
                CorrectionLog cl = await MySqlDAL.GetForwardedDetail(TransID);
                if (cl != null && cl.UserName != "")
                {
                    if (cl.ReasonID > 0)
                        cmbReason.InvokeControl(l => l.SelectedValue = cl.ReasonID);
                    txtNoPlateRemarks.InvokeControl(l => l.Text = cl.UserRemarks);
                    lblForwardedUser.InvokeControl(l => l.Text = cl.UserName);
                }
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error GetPlateForwardedReason : {0}", ee.Message));
            }
        }

        private void SessionTimedOut()
        {
            LogFile.UpdateLogFile(string.Format("Your session has expired. Please log in again."));
            MessageBox.Show("Your session has expired. Please log in again.", "Login Session Expired", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            pnlWait.InvokeControl(l => l.Visible = false);
            _IsDataLoaded = true;
        }

        private async void LoadSliderImages(List<FileInfo> fPic)
        {
            //display images
            await Task.Run(() =>
            {
                try
                {
                    imgSlider.Invoke((MethodInvoker)delegate
                    {
                        IsImgsLoaded = false;
                        imgSlider.Images.Clear();
                        int PlatePicIndex = 0, i = 0;
                        foreach (FileInfo fil in fPic)
                        {
                            if (File.Exists(fil.FullName))
                            {
                                using (MemoryStream stream = new MemoryStream(File.ReadAllBytes(fil.FullName)))
                                {
                                    imgSlider.Images.Add(Image.FromStream(stream));
                                }
                            }

                            if (fil.Name.ToLower().Contains("plate"))
                                PlatePicIndex = i;
                            i++;
                        }
                        imgSlider.CurrentImageIndex = PlatePicIndex;
                        ViewSliderImage(imgSlider.CurrentImage, true);
                        IsImgsLoaded = true;
                    });
                }
                catch (Exception ee)
                {
                    LogFile.UpdateLogFile(string.Format("Error Inner List Exception : {0}", ee.Message));
                }
            });
        }

        private void PlayRingTone()
        {
            try
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.NotificationSound);
                player.Play();
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error PlayRingTone : {0}", ee.Message));
            }
        }

        private void SetPlateData(string FrameImage)
        {
            try
            {
                txtANPRMessage.InvokeControl(l => l.Text = _pd.correction.anpr.message);
                lblEntryDateTime.InvokeControl(l => l.Text = _pd.correction.event_datetime);
                txtTransID.InvokeControl(l => l.Text = _pd.correction.transactionid);

                txtCode.InvokeControl(l => l.Text = _pd.correction.anpr.category);
                txtPlateNo.InvokeControl(l => l.Text = _pd.correction.anpr.text);
                cmbCity.InvokeControl(l => l.Text = _pd.correction.anpr.country);

                if (FrameImage != "")
                {
                    using (MemoryStream stream = new MemoryStream(File.ReadAllBytes(FrameImage)))
                    {
                        picPlateImage.InvokeControl(l => l.BackgroundImage = Image.FromStream(stream));
                    }
                }
                else
                    picPlateImage.InvokeControl(l => l.BackgroundImage = null);
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error SetPlateData : {0}", ee.Message));
            }
        }

        #endregion

        #region Not Present Plates / exit plates

        Thread thExitPlates;
        private void TmExitPlates_Elapsed(object sender, ElapsedEventArgs e)
        {
            try
            {
                if (thExitPlates != null && thExitPlates.IsAlive)
                    thExitPlates.Abort();

                thExitPlates = new Thread(new ThreadStart(IgnoreAPAndExitPlates));
                thExitPlates.Start();
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error TmExitPlates_Elapsed : {0}", ee.Message));
            }
        }

        int PreFalseTriggerCount = 0;
        private async void IgnoreAPAndExitPlates()
        {
            CreateLogForExitPlates();
            IgnoreAPPlates();
            await ReadReviewPlates();
            if (Utilis.UserType == "admin")
            {
                int rec = await RefreshFalseTriggeringData();
                if (PreFalseTriggerCount != rec)
                    ShowNotification(rec);
                PreFalseTriggerCount = rec;
            }
        }

        public async Task<int> RefreshFalseTriggeringData()
        {
            try
            {
                List<FalseTrigger> lstFT = await MySqlDAL.GetFalseTriggeringData();
                lblFalseTriger.InvokeControl(l => l.Text = lstFT.Count.ToString());
                lblFalseTriger.InvokeControl(l => l.ForeColor = lstFT.Count > 0 ? Color.Red : Color.Black);
                return lstFT.Count;
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error RefreshFalseTriggeringData : {0}", ee.Message));
                return 0;
            }
        }

        private void lblFalseTriger_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error lblFalseTriger_Click : {0}", ee.Message));
            }
        }

        private void ShowNotification(int Count)
        {
            try
            {
                NotifyIcon notifyIcon = new NotifyIcon
                {
                    Icon = SystemIcons.Warning,
                    Visible = true
                };

                notifyIcon.ShowBalloonTip((1000 * 60 * 1), "False Triggering Cases Update",
                    string.Format("{0} false triggering cases are pending.", Count), ToolTipIcon.Warning);
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error ShowNotification : {0}", ee.Message));
            }
        }

        List<FalseTrigger> lstFT;
        string[] strs;
        private async Task<int> ReadReviewPlates()
        {
            try
            {
                List<string> lstFldr = new DirectoryInfo(Utilis.ReviewPath)
                    .GetDirectories()
                    .Select(y => y.Name)
                    .Take(15)
                    .ToList();

                lstFT = new List<FalseTrigger>();
                foreach (string folder in lstFldr)
                {
                    strs = folder.Split('_');
                    if (strs.Length > 2)
                    {
                        lstFT.Add(new FalseTrigger()
                        {
                            FolderName = folder,
                            AccessPointID = Convert.ToInt32(strs[1]),
                            EventDate = Utilis.ConvertTransactionIDToDateTime(strs[0], strs[1]).ToString("yyyy-MM-dd HH:mm:ss")
                        });
                        MoveFolderToModification(folder, Utilis.ReviewPath);
                        Directory.Delete(string.Format("{0}\\{1}", Utilis.ReviewPath, folder), true);
                    }
                }

                //save data to db
                if (lstFT.Count > 0)
                {
                    int rec = await MySqlDAL.InsertFalseTriggeringData(lstFT);
                    LogFile.UpdateLogFile(string.Format("False Triggering Data Saved : {0}", rec));
                }

                return lstFT.Count;
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error ReadReviewPlates : {0}", ee.Message));
                return 0;
            }
        }

        private void IgnoreAPPlates()
        {
            try
            {
                //get only ignored AP
                List<string> lstAP = new DirectoryInfo(Utilis.CorrectionFolderPath)
                    .GetDirectories()
                    .Select(y => y.Name)
                    .Where(s => s.Split('_').Length >= 4
                    && lstIgnoreAccessPoints.Contains(Convert.ToInt32(s.Split('_')[1])))
                    .ToList();

                foreach (string str in lstAP)
                {
                    string folderPath = Path.Combine(Utilis.CorrectionFolderPath, str);
                    FileInfo fJson = new DirectoryInfo(folderPath)
                        .GetFiles("*.json", SearchOption.TopDirectoryOnly)
                        .FirstOrDefault();

                    string jsonTxt = fJson != null ? File.ReadAllText(fJson.FullName) : "";
                    SelectedPlateDetail PlateD = JsonConvert.DeserializeObject<SelectedPlateDetail>(jsonTxt);

                    //delete the folder and save log 
                    DeletePlateFile(str, PlateD, Utilis.CorrectionFolderPath, ActionMaster.IgnoredAP);
                }
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error IgnoreAPPlates : {0}", ee.Message));
            }
        }

        private void CreateLogForExitPlates()
        {
            try
            {
                //get only exit plates, other than salik locations 
                List<string> lstExitPlates = new DirectoryInfo(Utilis.CorrectionFolderPath)
                    .GetDirectories()
                    .Select(y => y.Name)
                    .Where(s => s.Split('_').Length >= 4
                    && !lstSalikLocations.Contains(Convert.ToInt32(s.Split('_')[2]))
                    && s.Split('_')[3] == "1")
                    .ToList();

                foreach (string str in lstExitPlates)
                {
                    string folderPath = Path.Combine(Utilis.CorrectionFolderPath, str);
                    FileInfo fJson = new DirectoryInfo(folderPath)
                        .GetFiles("*.json", SearchOption.TopDirectoryOnly)
                        .FirstOrDefault();

                    string jsonTxt = fJson != null ? File.ReadAllText(fJson.FullName) : "";
                    SelectedPlateDetail PlateD = JsonConvert.DeserializeObject<SelectedPlateDetail>(jsonTxt);

                    //delete the folder and save log 
                    DeletePlateFile(str, PlateD, Utilis.CorrectionFolderPath, ActionMaster.ExitPlates);
                    SaveCorrectionLog(ActionMaster.ExitPlates, PlateD, "", "", "", "", 0, str);
                }
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error CreateLogForExitPlates : {0}", ee.Message));
            }
        }

        #endregion

        #region Action Logic

        private void ReSet()
        {
            try
            {
                _IsDataLoaded = false;
                _pd = null;
                dtReadTime = DateTime.Now;
                tmTimer.Enabled = false;
                lblTimer.InvokeControl(l => l.Text = "00:00");

                txtANPRMessage.InvokeControl(l => l.Text = "");
                lblEntryDateTime.InvokeControl(l => l.Text = "");
                txtTransID.InvokeControl(l => l.Text = "");
                imgSlider.InvokeControl(l => l.Images.Clear());

                picPlateImage.InvokeControl(l => l.BackgroundImage = null);
                //cmbCity.InvokeControl(l => l.Text = "");
                cmbCity.InvokeControl(l => l.SelectedIndex = -1);
                txtCode.InvokeControl(l => l.Text = "");
                txtPlateNo.InvokeControl(l => l.Text = "");
                chkManualType.InvokeControl(l => l.Checked = false);

                cmbReason.InvokeControl(l => l.SelectedIndex = -1);
                txtNoPlateRemarks.InvokeControl(l => l.Text = "");

                btnVideo.InvokeControl(l => l.Enabled = false);
                btnIgnore.InvokeControl(l => l.Enabled = false);
                btnSave.InvokeControl(l => l.Enabled = false);
                btnForward.InvokeControl(l => l.Enabled = false);

                if (Utilis.UserType == "admin")
                {
                    gvRecentPlates.Columns.Clear();
                    gcRecentPlates.InvokeControl(l => l.DataSource = null);
                    lblForwardedUser.InvokeControl(l => l.Text = "");
                }

                picZoom.InvokeControl(l => l.BackgroundImage = null);
                lblTimer.InvokeControl(l => l.Text = "00:00");
                _IsDataLoaded = true;
                GetNextPlate();
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error ReSet : {0}", ee.Message));
                MessageBox.Show("Error : " + ee.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetCurrentCount()
        {
            try
            {
                List<string> lstPending = new DirectoryInfo(Utilis.CorrectionFolderPath)
                    .GetDirectories()
                    .Select(y => y.Name)
                    .Where(s =>
                    {
                        return s.Split('_').Length >= 4
                        && (!lstIgnoreAccessPoints.Contains(Convert.ToInt32(s.Split('_')[1])))
                        && (s.Split('_')[3] == "0" || lstSalikLocations.Contains(Convert.ToInt32(s.Split('_')[2])));
                    })
                    .ToList();

                //only entry or salik locations exit, ignore marked ap
                lblQueueCount.InvokeControl(l => l.Text = lstPending.Count.ToString());
                return lstPending.Count;
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error GetCurrentCount : {0}", ee.Message));
                return 0;
            }
        }

        private void SavePlate()
        {
            try
            {
                if (_pd != null && _pd.correction != null && _pd.correction.transactionid != "")
                {
                    string code = "", plateNo = "", plateCity = "", userRemarks = "";
                    int ReasonID = 0, cityIndex = -1;
                    bool TypeCityname = false;

                    chkManualType.InvokeControl(l => TypeCityname = l.Checked);
                    txtCode.InvokeControl(l => code = l.Text.Trim());
                    txtPlateNo.InvokeControl(l => plateNo = l.Text.Trim());
                    cmbCity.InvokeControl(l => plateCity = l.Text.Trim());
                    cmbCity.InvokeControl(l => cityIndex = l.SelectedIndex);
                    txtNoPlateRemarks.InvokeControl(l => userRemarks = l.Text.Trim());
                    cmbReason.InvokeControl(l => ReasonID = l.SelectedIndex > -1 ? Convert.ToInt32(l.SelectedValue) : 0);

                    if (!TypeCityname && cityIndex == -1)
                    {
                        MessageBox.Show("Select a city from the list or enable [Type City Name] to enter it manually.", "Invalid Plate City", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (string.IsNullOrEmpty(plateNo) || string.IsNullOrEmpty(plateCity))
                    {
                        MessageBox.Show("Plate number and city is mandatory", "Invalid Plate Detail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    code = FormatData(code);
                    plateNo = FormatData(plateNo);
                    plateCity = FormatData(plateCity);
                    userRemarks = FormatData(userRemarks);
                    if (plateCity.ToLower() == "ksa")
                        code = code.Replace(" ", "");

                    if (code.Length > 3 && DialogResult.No == MessageBox.Show(string.Format("Plate code consists of {0} characters. Are you sure it's valid?", code.Length),
                        "Reconfirm the plate code", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {
                        txtCode.InvokeControl(l => l.Focus());
                        return;
                    }
                    if (plateNo.Length > 5 && DialogResult.No == MessageBox.Show(string.Format("Plate number consists of {0} characters. Are you sure it's valid?", plateNo.Length),
                        "Reconfirm the plate number", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {
                        txtPlateNo.InvokeControl(l => l.Focus());
                        return;
                    }

                    pnlWait.InvokeControl(l => l.Visible = true);
                    //30-jan2025, waheed asked to remove this condition, and save all corrections to aws
                    //in case of any correction, move data to the modification folder
                    //if admin is doing something save that also
                    Anpr an = _pd.correction.anpr;
                    if (Utilis.UserType == "admin" ||
                        code.ToLower() != an.category.ToLower() ||
                        plateNo.ToLower() != an.text.ToLower() ||
                        plateCity.ToLower() != an.country.ToLower())
                    {
                        MoveFolderToModification(CurrentFolder, Utilis.CorrectionFolderPath);
                    }
                    SaveCorrectedData(code, plateNo, plateCity, userRemarks);

                    //save data to local server
                    PlateSavedActions("Plate Correction", code, plateNo, plateCity, userRemarks, ReasonID);
                }
                else
                    MessageBox.Show("Invalid transaction ID to save the no plate", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Save Button Error : {0}", ee.Message));
            }
            pnlWait.InvokeControl(l => l.Visible = false);
        }

        private void MoveFolderToModification(string folderName, string SrcPath)
        {
            try
            {
                string targetPath = string.Format("{0}\\{1}", Utilis.ModificationFolderPath, folderName);
                string srcPath = string.Format("{0}\\{1}", SrcPath, folderName);//

                //source should exist, but target shoudn't exists
                if (Directory.Exists(srcPath) && !Directory.Exists(targetPath))
                {
                    DirectoryInfo target = Directory.CreateDirectory(targetPath);
                    foreach (FileInfo fi in (new DirectoryInfo(srcPath)).GetFiles())
                    {
                        if (fi.Exists)
                            fi.CopyTo(Path.Combine(target.FullName, fi.Name), false);
                    }
                }
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("MoveFolderToModification Error : {0}", ee.Message));
            }
        }

        private async void SaveCorrectedData(string code, string plateNo, string plateCity, string userRemarks)
        {
            try
            {
                Correction cor = _pd.correction;
                IRestResponse rsp = await APIs_DAL.CorrectPlateNoAWS(cor.transactionid, cor.access_point_id,
                       code, plateNo, plateCity, cor.event_datetime == "" ?
                       Utilis.ConvertTransactionIDToDateTime(cor.transactionid, cor.access_point_id).ToString("yyyy-MM-dd HH:mm:ss")
                       : cor.event_datetime, 0, userRemarks,
                       string.IsNullOrEmpty(cor.spot_number) ? "" : cor.spot_number);

                if (rsp.IsSuccessful && rsp.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    PlateCorrectResponce res = JsonConvert.DeserializeObject<PlateCorrectResponce>(rsp.Content);
                    if (res != null && res.status)
                    {
                        LogFile.UpdateLogFile(string.Format("Data has been successfully saved on the portal."));
                        return;
                    }
                    else
                    {
                        LogFile.UpdateLogFile(string.Format("Error while saving data on the portal: {0}", res.message));
                        MessageBox.Show(res.message, "Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    LogFile.UpdateLogFile(string.Format("SaveCorrectedData Error : {0}", rsp != null ? rsp.Content : ""));
                    MessageBox.Show("Web portal is not accessible, please check your internet.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error SaveCorrectedData : {0}", ee.Message));
            }
        }

        private void PlateSavedActions(string type, string code, string plateNo,
            string plateCity, string userRemarks, int ReasonID)
        {
            try
            {
                SaveCorrectionLog(ActionMaster.Correction, _pd, code, plateNo, plateCity, userRemarks,
                    ReasonID, CurrentFolder);

                LogFile.UpdateLogFile(string.Format(@"Success, Captured Plate : {0}-{1} {2}, Corrected Plate : {5}-{6} {7}, Trans. ID : {3} Location : {4}, Type: {8}",
                  _pd.correction.anpr.category,
                  _pd.correction.anpr.text,
                  _pd.correction.anpr.country,
                  _pd.correction.transactionid,
                  _pd.correction.location,
                  code,
                  plateNo,
                  plateCity,
                  type));

                Directory.Delete(string.Format("{0}\\{1}", Utilis.CorrectionFolderPath, CurrentFolder), true);
                ReSet();
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("PlateSavedActions Error : {0}", ee.Message));
                ReSet();
            }
        }

        private void IgnorePlate()
        {
            try
            {
                pnlWait.InvokeControl(l => l.Visible = true);
                _IsDataLoaded = false;

                string code = "", plateNo = "", plateCity = "", userRemarks = "";
                int ReasonID = 0;

                txtCode.InvokeControl(l => code = l.Text.Trim());
                txtPlateNo.InvokeControl(l => plateNo = l.Text.Trim());
                cmbCity.InvokeControl(l => plateCity = l.Text.Trim());
                txtNoPlateRemarks.InvokeControl(l => userRemarks = l.Text.Trim());
                cmbReason.InvokeControl(l => ReasonID = l.SelectedIndex > -1 ? Convert.ToInt32(l.SelectedValue) : 0);

                code = FormatData(code);
                plateNo = FormatData(plateNo);
                plateCity = FormatData(plateCity);
                userRemarks = FormatData(userRemarks);

                //   if (Utilis.UserType == "admin")
                MoveFolderToModification(CurrentFolder, Utilis.CorrectionFolderPath);

                DeletePlateFile(CurrentFolder, _pd, Utilis.CorrectionFolderPath, ActionMaster.Ignored);
                SaveCorrectionLog(ActionMaster.Ignored, _pd, code, plateNo, plateCity, userRemarks,
                    ReasonID, CurrentFolder);
                ReSet();
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Ignore Button Error : {0}", ee.Message));
                ReSet();
            }
            pnlWait.InvokeControl(l => l.Visible = false);
        }

        private void DeletePlateFile(string FolderName, SelectedPlateDetail plateDetail, string srcPath, ActionMaster act)
        {
            try
            {
                Directory.Delete(string.Format("{0}\\{1}", srcPath, FolderName), true);

                if (plateDetail != null && plateDetail.correction != null && plateDetail.correction.transactionid != "")
                {
                    LogFile.UpdateLogFile(string.Format("Warning Plate {5}, {6}-{7} Plate : {0}-{1} {2} Trans. ID : {3} Location : {4}",
                       plateDetail.correction.anpr.category,
                       plateDetail.correction.anpr.text,
                       plateDetail.correction.anpr.country,
                       plateDetail.correction.transactionid,
                       plateDetail.correction.location, act.ToString(), Utilis.UserName, Utilis.LoginID));
                }
                else
                {
                    LogFile.UpdateLogFile(string.Format("Warning invalid folder: {0} deleted.", FolderName));
                }
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error DeletePlateFile : {0}", ee.Message));
            }
        }

        public void DisposeFrmZoom()
        {
            try
            {
                if (frmZoom != null)
                {
                    //frmZoom.Close();
                    //frmZoom.Dispose();
                    frmZoom = null;
                }
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error DisposeFrmZoom : {0}", ee.Message));
            }
        }

        frmZoomInImage frmZoom = null;
        private void ViewSliderImage(Image img, bool UpdateImg = false)
        {
            try
            {
                if (img != null)
                {
                    if (frmZoom != null)
                    {
                        frmZoom.UpdateImage(img);
                    }
                    else if (!UpdateImg)
                    {
                        frmZoom = new frmZoomInImage();
                        frmZoom.Tag = this;
                        frmZoom.Show(img);
                    }
                }
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error ViewSliderImage : {0}", ee.Message));
                MessageBox.Show("Error : " + ee.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nnNextImage_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (imgSlider.CurrentImageIndex < imgSlider.Images.Count - 1)
                {
                    imgSlider.SetCurrentImageIndex(imgSlider.CurrentImageIndex + 1, true);
                }
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error nnNextImage : {0}", ee.Message));
                MessageBox.Show("Error : " + ee.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bbPreviousImage_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (imgSlider.CurrentImageIndex > 0)
                {
                    imgSlider.SetCurrentImageIndex(imgSlider.CurrentImageIndex - 1, true);
                }
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error bbPreviousImage : {0}", ee.Message));
                MessageBox.Show("Error : " + ee.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVideo_Click(object sender, EventArgs e)
        {
            try
            {
                if (_pd != null && _pd.correction != null && _pd.correction.transactionid != "")
                {
                    DirectoryInfo info = new DirectoryInfo(string.Format("{0}\\{1}", Utilis.CorrectionFolderPath, CurrentFolder));
                    FileInfo fVid = info.GetFiles().ToList().Where(x => x.Extension.ToLower().Contains("mp4")).FirstOrDefault();
                    if (fVid != null)
                    {
                        frmPlayVideo frm = new frmPlayVideo();
                        frm.Show(fVid.FullName);
                    }
                    else
                        MessageBox.Show("Video not found.", "Invalid File", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error btnVideo_Click : {0}", ee.Message));
            }
        }

        private async void SaveCorrectionLog(ActionMaster action, SelectedPlateDetail data,
           string code, string plateNo, string plateCity, string userRemarks, int reasonID,
           string folderName)
        {
            try
            {
                if (data != null && data.correction != null)
                {
                    int ActID = (int)action;
                    Correction co = data.correction;
                    await MySqlDAL.AddCorrectionLog(new CorrectionLog()
                    {
                        ActionType = ActID,
                        TransactionID = co.transactionid,
                        AccessPointID = Convert.ToInt32(co.access_point_id),
                        AccessPointName = co.entrance_Name,
                        UserID = ActID == 4 ? 0 : Utilis.UserID,
                        LocationID = co.location_id,
                        LocationName = co.location,
                        EventDateTime = co.event_datetime,
                        IsExit = co.is_exit,
                        ANPRMsg = co.anpr != null ? co.anpr.message : "",
                        CapturedCode = co.anpr != null ? co.anpr.category : "",
                        CapturedPlateNo = co.anpr != null ? co.anpr.text : "",
                        CapturedCity = co.anpr != null ? co.anpr.country : "",
                        CorrectedCity = plateCity,
                        CorrectedCode = code,
                        CorrectedPlateNo = plateNo,
                        UserRemarks = ActID == 4 ? string.Format("user:{0},login:{1}", Utilis.UserID, Utilis.LoginID) : userRemarks,
                        LoginID = ActID == 4 ? 0 : Utilis.LoginID,
                        FolderName = folderName,
                        PlateReadTime = ActID == 4 ? DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") : dtReadTime.ToString("yyyy-MM-dd HH:mm:ss"),
                        ReasonID = reasonID
                    });
                }
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error SaveCorrectionLog : {0}", ee.Message));
            }
        }

        #endregion

        #region Forward to admin
        //save forward data also, which user forwarded the data to admin

        private void btnForward_Click(object sender, EventArgs e)
        {
            ForwardPlate();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            ForwardPlate();
        }

        private string FormatData(string str)
        {
            return Regex.Replace(str, @"[^\p{L}\p{N} ]", "");
        }

        private void ForwardPlate()
        {
            try
            {
                int ReasonID = 0;
                cmbReason.InvokeControl(l => ReasonID = l.SelectedIndex > -1 ? Convert.ToInt32(l.SelectedValue) : 0);
                if (ReasonID <= 0)
                {
                    cmbReason.InvokeControl(l => l.Focus());
                    MessageBox.Show("Please select a forward reason before proceeding.", "Forward Reason Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                pnlWait.InvokeControl(l => l.Visible = true);
                _IsDataLoaded = false;

                string code = "", plateNo = "", plateCity = "", userRemarks = "";
                txtCode.InvokeControl(l => code = l.Text.Trim());
                txtPlateNo.InvokeControl(l => plateNo = l.Text.Trim());
                cmbCity.InvokeControl(l => plateCity = l.Text.Trim());
                txtNoPlateRemarks.InvokeControl(l => userRemarks = l.Text.Trim());

                code = FormatData(code);
                plateNo = FormatData(plateNo);
                plateCity = FormatData(plateCity);
                userRemarks = FormatData(userRemarks);

                ForwardFolderToAdmin(CurrentFolder);
                DeletePlateFile(CurrentFolder, _pd, Utilis.CorrectionFolderPath, ActionMaster.Forwarded);
                SaveCorrectionLog(ActionMaster.Forwarded, _pd, code, plateNo, plateCity, userRemarks,
                    ReasonID, CurrentFolder);
                ReSet();
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Forward Button Error : {0}", ee.Message));
                ReSet();
            }
            pnlWait.InvokeControl(l => l.Visible = false);
        }

        private void ForwardFolderToAdmin(string folderName)
        {
            try
            {
                string targetPath = string.Format("{0}\\{1}", Utilis.ForwardFolderPath, folderName);
                string srcPath = string.Format("{0}\\{1}", Utilis.CorrectionFolderPath, folderName);

                //source should exist, but target shoudn't exists
                if (Directory.Exists(srcPath) && !Directory.Exists(targetPath))
                {
                    DirectoryInfo target = Directory.CreateDirectory(targetPath);
                    foreach (FileInfo fi in (new DirectoryInfo(srcPath)).GetFiles())
                    {
                        if (fi.Exists)
                            fi.CopyTo(Path.Combine(target.FullName, fi.Name), false);
                    }
                }
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("ForwardFolderToAdmin Error : {0}", ee.Message));
            }
        }

        #endregion

        private void chkActiveTrip_Click(object sender, EventArgs e)
        {
            CheckActiveTrip();
        }

        private async void CheckActiveTrip()
        {
            try
            {
                if (txtPlateNo.Text.Trim() == "" || cmbCity.SelectedIndex == -1)
                {
                    MessageBox.Show("Plate no and city is mandatory", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbCity.Focus();
                    return;
                }

                pnlWait.InvokeControl(l => l.Visible = true);
                string code = txtCode.Text.Trim(), plate = txtPlateNo.Text.Trim(), city = cmbCity.Text.Trim();
                IRestResponse res = await APIs_DAL.GetPlateActiveTripDetail(code, plate, city);

                if (res.IsSuccessful && res.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    PlateActiveTripDetail obj = JsonConvert.DeserializeObject<PlateActiveTripDetail>(res.Content);
                    if (obj != null && obj.status)
                    {
                        MessageBox.Show(string.Format("Active trip detail of :{0}{1} {2}\nEntry Time: {3}\nGate: {4}\nLocation: {5}",
                            (code == "" ? "" : (code + "-")), plate, city, obj.data.entry_time, obj.data.entry_gate, obj.data.location), "Active Trip Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show(string.Format("No active trip found for {0}{1} {2}", (code == "" ? "" : (code + "-")), plate, city), "No Active Trip", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    LogFile.UpdateLogFile(string.Format("Save Button Error : {0}", res != null ? res.Content : ""));
                    MessageBox.Show("Server is not accessible", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("CheckActiveTrip Error : {0}", ee.Message));
                MessageBox.Show(string.Format("Error : {0}", ee.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            pnlWait.InvokeControl(l => l.Visible = false);
        }

        private void frmDashboard_Resize(object sender, EventArgs e)
        {
            try
            {
                DisplaySettings();
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error frmDashboard_Resize : {0}", ee.Message));
            }
        }

        #region Zoom Image

        System.Timers.Timer tmZoomPlate = new System.Timers.Timer() { Enabled = true, Interval = 300 };
        Point lastMousePos = new Point();
        Image imgMain;
        private void TmZoomPlate_Elapsed(object sender, ElapsedEventArgs e)
        {
            try
            {
                tmZoomPlate.Stop(); // Reset the timer

                picZoom.InvokeControl(l => l.Visible = true);
                imgSlider.InvokeControl(l => imgMain = l.CurrentImage != null ? new Bitmap(l.CurrentImage) : null);
                if (imgMain == null) return;

                // Convert to image coordinates and update zoom
                var imagePos = GetImagePosition(lastMousePos, imgMain);
                UpdateZoom(imagePos, imgMain);
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error TmZoomPlate_Elapsed : {0}", ee.Message));
            }
        }

        private void imgSlider_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                lastMousePos = e.Location;
                // Start/restart the timer to debounce rapid movements
                tmZoomPlate.Stop();
                tmZoomPlate.Start();
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error imgSlider_MouseMove : {0}", ee.Message));
            }
        }

        int ImgSliderW = 0, ImgSliderH = 0, picZoomW = 0, picZoomH = 0;
        private Point GetImagePosition(Point mousePos, Image imgMain)
        {
            try
            {
                // Calculate scaling and offsets
                float imgWidth = imgMain.Width;
                float imgHeight = imgMain.Height;
                float ratio = Math.Min(ImgSliderW / imgWidth, ImgSliderH / imgHeight);
                int scaledWidth = (int)(imgWidth * ratio);
                int scaledHeight = (int)(imgHeight * ratio);
                int offsetX = (ImgSliderW - scaledWidth) / 2;
                int offsetY = (ImgSliderH - scaledHeight) / 2;

                // Adjust mouse position to image coordinates
                float scaleX = imgWidth / scaledWidth;
                float scaleY = imgHeight / scaledHeight;
                int imageX = (int)((mousePos.X - offsetX) * scaleX);
                int imageY = (int)((mousePos.Y - offsetY) * scaleY);

                // Clamp values to image bounds
                imageX = Clamp(imageX, 0, imgMain.Width - 1);
                imageY = Clamp(imageY, 0, imgMain.Height - 1);

                return new Point(imageX, imageY);
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error GetImagePosition : {0}", ee.Message));
            }
            return new Point();
        }

        private int Clamp(int value, int min, int max)
        {
            try
            {
                // Ensure value is within [min, max]
                if (value < min) return min;
                if (value > max) return max;
                return value;
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error Clamp : {0}", ee.Message));
            }
            return 0;
        }

        Rectangle srcRect;
        Bitmap srcBitmap;



        Bitmap zoomed;
        Graphics g;
        private void UpdateZoom(Point imagePos, Image imgMain)
        {
            try
            {
                int zoomAreaSize = 100; // Size of the area to capture
                int zoomFactor = 2;     // Zoom level (e.g., 2x)

                // Define the source area to zoom
                srcRect = new Rectangle(
                   imagePos.X - zoomAreaSize / 2,
                   imagePos.Y - zoomAreaSize / 2,
                   zoomAreaSize,
                   zoomAreaSize
               );

                // Ensure the rectangle stays within the image bounds
                srcRect.X = Clamp(srcRect.X, 0, imgMain.Width - srcRect.Width);
                srcRect.Y = Clamp(srcRect.Y, 0, imgMain.Height - srcRect.Height);

                // Create the zoomed image
                using (srcBitmap = new Bitmap(imgMain))
                using (zoomed = new Bitmap(picZoomW, picZoomH)) // zoomAreaSize * zoomFactor, zoomAreaSize * zoomFactor
                {
                    using (g = Graphics.FromImage(zoomed))
                    {
                        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                        g.DrawImage(
                            srcBitmap,
                            new Rectangle(0, 0, zoomed.Width, zoomed.Height),
                            srcRect,
                            GraphicsUnit.Pixel
                        );
                    }
                    picZoom.InvokeControl(l => l.BackgroundImage?.Dispose());
                    picZoom.InvokeControl(l => l.BackgroundImage = new Bitmap(zoomed));
                }
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error UpdateZoom : {0}", ee.Message));
            }
        }

        #endregion
    }


    public class RecentPlatesData : INotifyPropertyChanged
    {
        private readonly Control _uiControl; // Reference to the UI control/form for thread safety
        private Image _plateImage; // Backing field for the plateImage property (note the underscore and camelCase)

        public string PlateNo { get; set; }
        public string EventTime { get; set; }
        public string ImageURL { get; set; }
        public string TripID { get; set; }

        // Corrected property definition
        public Image PlateImage // Changed to PascalCase for consistency with C# conventions
        {
            get { return _plateImage; }
            set
            {
                _plateImage = value;
                OnPropertyChanged(nameof(PlateImage)); // Match the property name exactly
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public RecentPlatesData(string _eventTime, string _imageUrl, string _code, string _plateNo, string _city, string _tripID, Control uiControl)
        {
            if (uiControl == null)
            {
                throw new ArgumentNullException("uiControl");
            }
            _uiControl = uiControl;
            //   _uiControl = uiControl ?? throw new ArgumentNullException(nameof(uiControl)); // Ensure a valid control is provided

            try
            {
                EventTime = _eventTime;
                PlateNo = string.Format("{0}-{1} {2}", _code, _plateNo, _city);
                ImageURL = _imageUrl;
                TripID = _tripID;

                PlateImage = ResourceImageHelper.CreateImageFromResources("DevExpress.XtraEditors.Images.loading.gif", typeof(BackgroundImageLoader).Assembly);
                LoadImageAsync();
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error RecentPlatesData class : {0}", ee.Message));
            }
        }

        private void LoadImageAsync()
        {
            BackgroundImageLoader bg = new BackgroundImageLoader();
            bg.Load(ImageURL);
            bg.Loaded += (s, e) =>
            {
                try
                {
                    Image result = bg.Result ?? ResourceImageHelper.CreateImageFromResources("DevExpress.XtraEditors.Images.Error.png", typeof(BackgroundImageLoader).Assembly);

                    // Marshal to UI thread safely
                    if (_uiControl.IsHandleCreated && !_uiControl.IsDisposed)
                    {
                        if (_uiControl.InvokeRequired)
                        {
                            _uiControl.Invoke(new Action(() =>
                            {
                                PlateImage = result; // Update via property to raise PropertyChanged
                            }));
                        }
                        else
                        {
                            PlateImage = result;
                        }
                    }
                }
                catch (Exception ex)
                {
                    LogFile.UpdateLogFile($"Error loading image: {ex.Message}");
                }
                finally
                {
                    bg.Dispose();
                }
            };
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    //public class RecentPlatesData : INotifyPropertyChanged
    //{
    //    public string PlateNo { get; set; }
    //    public string EventTime { get; set; }
    //    public string ImageURL { get; set; }
    //    public string TripID { get; set; }
    //    public Image plateImage { get; set; }
    //    public event PropertyChangedEventHandler PropertyChanged;

    //    public RecentPlatesData(string _eventTime, string _imageUrl, string _code, string _plateNo, string _city, string _tripID)
    //    {
    //        try
    //        {
    //            EventTime = _eventTime;
    //            PlateNo = string.Format("{0}-{1} {2}", _code, _plateNo, _city);
    //            ImageURL = _imageUrl;
    //            TripID = _tripID;

    //            plateImage = ResourceImageHelper.CreateImageFromResources("DevExpress.XtraEditors.Images.loading.gif", typeof(BackgroundImageLoader).Assembly);
    //            BackgroundImageLoader bg = new BackgroundImageLoader();

    //            bg.Load(_imageUrl);
    //            bg.Loaded += (s, e) =>
    //            {
    //                plateImage = bg.Result;
    //                if (!(plateImage is Image))
    //                    plateImage = ResourceImageHelper.CreateImageFromResources("DevExpress.XtraEditors.Images.Error.png", typeof(BackgroundImageLoader).Assembly);

    //                Control control = Control.FromHandle(System.Diagnostics.Process.GetCurrentProcess().MainWindowHandle);

    //                if (control != null && control.InvokeRequired)
    //                {
    //                    control.Invoke((MethodInvoker)delegate
    //                    {
    //                        plateImage = plateImage;
    //                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(plateImage)));
    //                    });
    //                }
    //                else
    //                {
    //                    plateImage = plateImage;
    //                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(plateImage)));
    //                }

    //                //  PropertyChanged(this, new PropertyChangedEventArgs("plateImage"));
    //                bg.Dispose();
    //            };
    //        }
    //        catch (Exception ee)
    //        {
    //            LogFile.UpdateLogFile(string.Format("Error RecentPlatesData class : {0}", ee.Message));
    //        }
    //    }
    //}

    public static class ControlExtensions
    {
        public static void InvokeControl<T>(this T control, Action<T> action) where T : Control
        {
            if (control.IsHandleCreated)
            {
                if (control.InvokeRequired)
                    control.Invoke(new Action(() => action(control)));
                else
                    action(control);
            }
        }
    }
}
