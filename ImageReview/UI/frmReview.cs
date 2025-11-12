using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ImageReview.Logic;
using DevExpress.XtraReports.UI;
using ImageReview.Reports;
using DevExpress.XtraCharts;
using DevExpress.XtraGrid.Views.Grid;
using System.IO;
using DevExpress.XtraEditors.Controls;
using DevExpress.Utils;

namespace ImageReview.UI
{
    public partial class frmReview : DevExpress.XtraEditors.XtraForm
    {
        public frmReview()
        {
            InitializeComponent();
        }

        private void frmReview_Load(object sender, EventArgs e)
        {
            try
            {
                gcData.Height = this.Height - grpFilters.Height - 45;
                DateTime YesDay = DateTime.Now;
                dtFrom.Value = new DateTime(YesDay.Year, YesDay.Month, YesDay.Day, 0, 0, 0);
                dtTo.Value = dtFrom.Value.AddMinutes(5);
                ppWait.Size = new Size(179, 65);

                cmbActionType.SelectedIndex = 0;
                cmbEntryExit.SelectedIndex = 0;

                FillLocations();
                FillUsers();
                CorrectMissingLocationsInfo();

                btnSearch_Click(sender, e);
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error frmReview_Load : {0}", ee.Message));
                MessageBox.Show("Error : " + ee.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void CorrectMissingLocationsInfo()
        {
            try
            {
                await Task.Run(async () =>
                {
                    DataTable dt = await MySqlDAL.ExecuteDataTable(@"SELECT id,access_point_id FROM tbl_correction_log 
                    WHERE location_id = 0 AND access_point_id<>0");

                    if (dt != null && dt.Rows.Count > 0)
                    {
                        AccessPoint ap = null;
                        foreach (DataRow dr in dt.Rows)
                        {
                            if (frmDashboard.dicApLocation.TryGetValue(Convert.ToInt32(dr["access_point_id"]), out ap))
                                await MySqlDAL.UpdateMissingLocationInfo(Convert.ToInt32(dr["id"]), ap.locationID);
                        }
                    }
                });
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error CorrectMissingLocationsInfo : {0}", ee.Message));
            }
        }

        private void FillLocations()
        {
            try
            {
                List<Location> lst = frmDashboard.lstLocations.OrderBy(g => g.name).ToList();

                lst.Insert(0, new Location { id = 0, name = "All Locations" });
                cmbLocation.DisplayMember = "name";
                cmbLocation.ValueMember = "id";
                cmbLocation.DataSource = lst;
            }
            catch (Exception ee)
            {
                MessageBox.Show(string.Format("Error : {0}", ee.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void FillUsers()
        {
            try
            {
                List<SystemUser> lst = await MySqlDAL.GetCashiersList();

                lst.Insert(0, new SystemUser() { ID = 0, UserName = "All Users", Password = "", UserType = "user" });
                cmbUser.DisplayMember = "UserName";
                cmbUser.ValueMember = "ID";
                cmbUser.DataSource = lst;
            }
            catch (Exception ee)
            {
                MessageBox.Show(string.Format("Error : {0}", ee.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = string.Format(@"SELECT IFNULL(a.Name,'')UserAction,IFNULL(u.Username,'')Username,
                DATE_FORMAT(l.PlateRead_Time, '%d-%b-%Y %H:%i:%s') ReviewTime,
                DATE_FORMAT(l.Created_At, '%d-%b-%Y %H:%i:%s') CorrectionTime,
                TIME_FORMAT(SEC_TO_TIME(TIMESTAMPDIFF(SECOND, l.PlateRead_Time, l.Created_At)), '%i:%s') as ActionTime,
                CONCAT(l.Captured_Code,' ',l.Captured_PlateNo,' ',l.Captured_City) CapturedPlate,
                CONCAT(l.Corrected_Code,' ',l.Corrected_PlateNo,' ',l.Corrected_City) CorrectedPlate,
                l.Transaction_ID,'' as Location_Name,'' as apname,
                IFNULL(r.name,'')Reason,l.User_Remarks AS Remarks,l.ANPR_Message,l.Location_ID,l.User_ID,l.FolderName,l.access_point_id

                FROM tbl_correction_log l
                LEFT OUTER JOIN tbl_users u ON u.ID=l.User_ID
                LEFT OUTER JOIN tbl_actions_master a ON a.ID=l.Action_Type
                LEFT OUTER JOIN tbl_reasons r ON r.ID=l.Reason_ID

                where l.Created_At between '{0}' and '{1}' ",
                dtFrom.Value.ToString("yyyy-MM-dd HH:mm:ss"), dtTo.Value.ToString("yyyy-MM-dd HH:mm:ss"));

                qry = string.Format("{0} {1}", qry, GetQueryFilters());
                qry = string.Format("{0} order by l.Created_At ", qry);

                ppWait.Visible = true;
                DataTable dt = await MySqlDAL.ExecuteDataTable(qry);

                BindingList<ReviewGridData> lst = new BindingList<ReviewGridData>();
                // update location name and access point
                foreach (DataRow dr in dt.Rows)
                {
                    if (frmDashboard.dicApLocation.TryGetValue(Convert.ToInt32(dr["access_point_id"]), out AccessPoint ap))
                    {
                        dr["Location_Name"] = ap.locationName;
                        dr["apname"] = ap.AccessPointIDName;
                    }

                    var dataItem = new ReviewGridData(Convert.ToInt32(dr["User_ID"]), Convert.ToInt32(dr["Location_ID"]),
                     dr["FolderName"].ToString(), Convert.ToInt32(dr["access_point_id"]), dr["ANPR_Message"].ToString(),
                     dr["Remarks"].ToString(), dr["UserAction"].ToString(), dr["Username"].ToString(),
                     dr["ReviewTime"].ToString(), dr["CorrectionTime"].ToString(), dr["ActionTime"].ToString(),
                     dr["Location_Name"].ToString(), dr["apname"].ToString(), dr["Transaction_ID"].ToString(),
                     dr["CapturedPlate"].ToString(), dr["CorrectedPlate"].ToString(), dr["Reason"].ToString());

                    lst.Add(dataItem);
                    LoadPlateImageAsync(dataItem);
                }

                gvData.Columns.Clear();
                gcData.DataSource = lst;
                FormatGridColumns();

                //   lblRecords.Text = string.Format("Rows : {0}", dt.Rows.Count);
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error btnSearch_Click : {0}", ee.Message));
                MessageBox.Show("Error : " + ee.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ppWait.Visible = false;
        }

        private void FormatGridColumns()
        {
            gvData.Columns["User_ID"].Visible = false;
            gvData.Columns["Location_ID"].Visible = false;
            gvData.Columns["FolderName"].Visible = false;
            gvData.Columns["access_point_id"].Visible = false;
            gvData.Columns["ANPR_Message"].Visible = false;
            gvData.Columns["Remarks"].Visible = false;

            gvData.Columns["UserAction"].Caption = "Action";
            gvData.Columns["Username"].Caption = "User";
            gvData.Columns["ReviewTime"].Caption = "Review Time";
            gvData.Columns["CorrectionTime"].Caption = "Modification Time";
            gvData.Columns["ActionTime"].Caption = "Time Spent";
            gvData.Columns["Location_Name"].Caption = "Location";
            gvData.Columns["apname"].Caption = "Access Point";
            gvData.Columns["Transaction_ID"].Caption = "Transaction ID";
            gvData.Columns["CapturedPlate"].Caption = "Captured Plate";
            gvData.Columns["CorrectedPlate"].Caption = "Modified Plate";
            gvData.Columns["Reason"].Caption = "Reason";

            if (gvData.Columns["PlateImage"] != null)
            {
                gvData.Columns["PlateImage"].Caption = "Image";
                gvData.Columns["PlateImage"].AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
                gvData.Columns["PlateImage"].AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
            }

            gvData.Columns["UserAction"].Width = 80;
            gvData.Columns["Username"].Width = 90;
            gvData.Columns["CorrectionTime"].Width = 180;
            gvData.Columns["ReviewTime"].Width = 180;
            gvData.Columns["ActionTime"].Width = 80;
            gvData.Columns["PlateImage"].Width = 220;
        }

        private void LoadPlateImageAsync(ReviewGridData data)
        {
            try
            {
                BackgroundImageLoader bg = new BackgroundImageLoader();
                //get the image url
                var imageURL = new DirectoryInfo(Path.Combine(Utilis.ModificationFolderPath, data.FolderName))
                .GetFiles("*.jpg") // directly filter for JPG files
                .OrderBy(f => f.Length) // order by file size
                .Select(f => f.FullName)
                .FirstOrDefault();

                bg.Load(imageURL);
                bg.Loaded += (s, e) =>
                {
                    try
                    {
                        Image result = bg.Result ?? ResourceImageHelper.CreateImageFromResources("DevExpress.XtraEditors.Images.Error.png", typeof(BackgroundImageLoader).Assembly);

                        if (gcData.InvokeRequired)
                        {
                            gcData.BeginInvoke(new Action(() => data.PlateImage = (Image)result.Clone()));
                        }
                        else
                        {
                            data.PlateImage = (Image)result.Clone();
                        }
                    }
                    catch (Exception ex)
                    {
                        LogFile.UpdateLogFile($"Image load error: {ex.Message}");
                    }
                    finally
                    {
                        bg.Dispose();
                    }
                };
            }
            catch (Exception ee)
            {
              //  LogFile.UpdateLogFile(string.Format("Error LoadImageAsync : {0}", ee.Message));
            }
        }


        private string GetQueryFilters()
        {
            string qry = "";
            if (cmbActionType.SelectedIndex > 0)
            {
                if (cmbActionType.SelectedIndex == 2 || cmbActionType.SelectedIndex == 3)
                {
                    qry = string.Format(@"{0} and l.Action_Type=1 and
                        CONCAT(l.Corrected_Code,l.Corrected_PlateNo,l.Corrected_City) {1}
                        CONCAT(l.Captured_Code,l.Captured_PlateNo,l.Captured_city)",
                      qry, cmbActionType.SelectedIndex == 3 ? " =" : "<>");
                }

                // qry = string.Format("{0} and l.=1 ", qry);
                else
                {
                    int actID = 0;
                    if (cmbActionType.SelectedIndex == 1)
                        actID = 1;
                    else if (cmbActionType.SelectedIndex == 4)
                        actID = 2;
                    else if (cmbActionType.SelectedIndex == 5)
                        actID = 3;
                    else if (cmbActionType.SelectedIndex == 6)
                        actID = 4;

                    qry = string.Format("{0} and l.Action_Type={1} ", qry, actID);
                }
            }

            if (cmbEntryExit.SelectedIndex > 0)
                qry = string.Format("{0} and l.isexit = {1} ", qry, cmbEntryExit.SelectedIndex == 1 ? 0 : 1);

            if (chkExcludeForward.Checked)
                qry = string.Format("{0} and l.Action_Type <> 3 ", qry);

            if (cmbUser.SelectedIndex > 0)
                qry = string.Format("{0} and l.User_ID={1} ", qry, cmbUser.SelectedValue.ToString());

            if (cmbLocation.SelectedIndex > 0)
                qry = string.Format("{0} and l.location_id ={1} ", qry, cmbLocation.SelectedValue.ToString());

            if (txtPlateNo.Text.Trim() != "")
                qry = string.Format(@"{0} and (CONCAT(l.Captured_Code,' ',l.Captured_PlateNo,' ',l.Captured_city) like '%{1}%'
                    or CONCAT(l.Corrected_Code,' ',l.Corrected_PlateNo,' ',l.Corrected_City) like '%{1}%' 
                    or l.Transaction_ID like '%{1}%') ", qry, txtPlateNo.Text.Trim());

            return qry;
        }

        List<FileInfo> fPic;
        private void gvData_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                GridView view = sender as GridView;
                if (view != null)
                {
                    int rowHandle = view.FocusedRowHandle;
                    if (rowHandle >= 0)
                    {
                        //string CapturedPlate = view.GetRowCellValue(rowHandle, "CapturedPlate").ToString().ToLower();
                        //string UserAction = view.GetRowCellValue(rowHandle, "UserAction").ToString().ToLower();
                        //string CorrectedPlate = view.GetRowCellValue(rowHandle, "CorrectedPlate").ToString().ToLower();

                        //if (!CapturedPlate.Equals(CorrectedPlate))
                        //{
                        string folderName = view.GetRowCellValue(rowHandle, "FolderName").ToString();
                        string path = Path.Combine(Utilis.ModificationFolderPath, folderName);
                        string pathAdmin = Path.Combine(Utilis.ForwardFolderPath, folderName);
                        if (Directory.Exists(path))
                        {
                            ViewImage(path);
                        }
                        else if (Directory.Exists(pathAdmin))
                        {
                            ViewImage(pathAdmin);
                        }
                        else
                        {
                            MessageBox.Show(string.Format("Folder path not found\n{0}", path), "Invalid Folder Path", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        //}
                        //else
                        //{
                        //    string TransID = view.GetRowCellValue(rowHandle, "Transaction_ID").ToString();
                        //    MessageBox.Show(string.Format("No modification found for Transaction ID : {0}", TransID), "Invalid Transaction", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //}
                    }
                }
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error gvData_DoubleClick : {0}", ee.Message));
            }
        }

        private void ViewImage(string path)
        {
            try
            {
                fPic = (new DirectoryInfo(path))
                                .GetFiles()
                                .ToList()
                                .Where(x => x.Extension.ToLower().Contains("jpg"))
                                .ToList();

                if (fPic != null && fPic.Count > 0)
                {
                    if (fPic.Count > 20)
                        fPic = fPic.GetRange(0, 19);

                    frmImageSlider frm = new frmImageSlider();
                    frm.Show(fPic);
                }
                else
                {
                    MessageBox.Show(string.Format("There is no image file present in the folder."), "No Image Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error ViewImage : {0}", ee.Message));
            }
        }

        private void dtFrom_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                dtTo.Value = dtFrom.Value.AddMinutes(5);
            }
            catch (Exception ee)
            {
            }
        }
    }

    public class ReviewGridData : INotifyPropertyChanged
    {
        public int User_ID { get; set; }
        public int Location_ID { get; set; }
        public string FolderName { get; set; }
        public int access_point_id { get; set; }
        public string ANPR_Message { get; set; }
        public string Remarks { get; set; }
        public string UserAction { get; set; }
        public string Username { get; set; }
        public string ReviewTime { get; set; }
        public string CorrectionTime { get; set; }
        public string ActionTime { get; set; }
        public string Location_Name { get; set; }
        public string apname { get; set; }
        public string Transaction_ID { get; set; }
        public string CapturedPlate { get; set; }
        public string CorrectedPlate { get; set; }
        public string Reason { get; set; }
        private Image _plateImage;

        public Image PlateImage
        {
            get { return _plateImage; }
            set
            {
                _plateImage = value;
                OnPropertyChanged(nameof(PlateImage));
            }
        }

        public ReviewGridData(int user_ID, int location_ID, string folderName, int ap_id, string aNPR_Message,
            string remarks, string userAction, string username, string reviewTime, string correctionTime,
            string actionTime, string location_Name, string apName, string transaction_ID, string capturedPlate,
            string correctedPlate, string reason)
        {
            User_ID = user_ID;
            Location_ID = location_ID;
            FolderName = folderName;
            access_point_id = ap_id;
            ANPR_Message = aNPR_Message;
            Remarks = remarks;
            UserAction = userAction;
            Username = username;
            ReviewTime = reviewTime;
            CorrectionTime = correctionTime;
            ActionTime = actionTime;
            Location_Name = location_Name;
            apname = apName;
            Transaction_ID = transaction_ID;
            CapturedPlate = capturedPlate;
            CorrectedPlate = correctedPlate;
            Reason = reason;

            PlateImage = ResourceImageHelper.CreateImageFromResources("DevExpress.XtraEditors.Images.loading.gif", typeof(BackgroundImageLoader).Assembly);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }


}