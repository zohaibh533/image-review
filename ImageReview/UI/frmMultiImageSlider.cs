using ImageReview.Logic;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageReview.UI
{
    public partial class frmMultiImageSlider : Form
    {
        public frmMultiImageSlider()
        {
            InitializeComponent();
        }

        List<string> Folders;
        int AccessPointID = 0;
        string EventTime = "", APName = "", LocName = "";

        public void Show(int _accessPointID, string _eventTime, string _aPName, string _locName)
        {
            AccessPointID = _accessPointID;
            EventTime = _eventTime;
            APName = _aPName;
            LocName = _locName;
            this.Show();
        }

        private async void frmMultiImageSlider_Load(object sender, EventArgs e)
        {
            try
            {
                lblLoc.Text = LocName;
                lblAP.Text = APName;
                lblEventTime.Text = EventTime;
                Folders = await MySqlDAL.GetFalseTriggerFolders(AccessPointID, EventTime);
                lbFolders.DataSource = Folders;
                Display();
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error frmMultiImageSlider_Load : {0}", ee.Message));
            }
        }

        private void lbFolders_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lbFolders.SelectedIndex > -1)
                {
                    LoadSliderImages(lbFolders.SelectedItem.ToString());
                }
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error lbFolders_SelectedIndexChanged : {0}", ee.Message));
            }
        }

        private async void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (string folder in Folders)
                    Directory.Delete(string.Format("{0}\\{1}", Utilis.ModificationFolderPath, folder), true);
                await MySqlDAL.UpdateFalseTriggersToSeen(AccessPointID, EventTime);

                if (this.Owner is frmFalseTriggering)
                    await ((frmFalseTriggering)this.Owner).RefreshData();

                this.Close();
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error btnClear_Click : {0}", ee.Message));
            }
        }

        private void LoadSliderImages(string folder)
        {
            try
            {
                string path = Path.Combine(Utilis.ModificationFolderPath, folder);
                if (Directory.Exists(path))
                {
                    List<FileInfo> fPic = (new DirectoryInfo(path)).GetFiles().ToList()
                                .Where(x => x.Extension.ToLower().Contains("jpg")).ToList();

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

                    FileInfo fJson = (new DirectoryInfo(path)).GetFiles().ToList().Where(x => x.Extension.ToLower().Contains("json")).FirstOrDefault();
                    string JsonTxt = fJson != null ? File.ReadAllText(fJson.FullName) : "";
                    SelectedPlateDetail _pd = JsonConvert.DeserializeObject<SelectedPlateDetail>(JsonTxt);
                    //set display data
                    if (_pd != null && _pd.correction != null && _pd.correction.transactionid != "")
                    {
                        lblEventTime.InvokeControl(l => l.Text = _pd.correction.event_datetime);
                    }
                }
                else
                    MessageBox.Show(string.Format("Folder path not found\n{0}", path), "Invalid Folder Path", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error ImageSlider : {0}", ee.Message));
            }
        }

        private void Display()
        {
            imgSlider.Height = this.Height - (lbFolders.Location.Y + lbFolders.Height + 50);
        }

        private void frmMultiImageSlider_Resize(object sender, EventArgs e)
        {
            try
            {
                Display();
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error frmMultiImageSlider_Resize : {0}", ee.Message));
            }
        }
    }
}
