using ImageReview.Logic;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;


namespace ImageReview.UI
{
    public partial class frmPlayVideo : DevExpress.XtraEditors.XtraForm
    {
        public frmPlayVideo()
        {
            InitializeComponent();
        }

        string _VideoUrl;
        public void Show(string VideoUrl)
        {
            _VideoUrl = VideoUrl;
            this.ShowDialog();
        }

        private void frmLiveExitImage_Load(object sender, EventArgs e)
        {
            try
            {
                wmpVideo.URL = _VideoUrl;
                wmpVideo.Ctlcontrols.play();
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error frmLiveExitImage_Load : {0}", ee.Message));
            }
        }

        private void frmLiveExitImage_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                    this.Close();
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error frmLiveExitImage_KeyDown : {0}", ee.Message));
            }
        }

        private void frmPlayVideo_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                wmpVideo.URL = "";
                wmpVideo.Dispose();
                wmpVideo = null;
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error frmPlayVideo_FormClosed : {0}", ee.Message));
            }
        }
    }
}
