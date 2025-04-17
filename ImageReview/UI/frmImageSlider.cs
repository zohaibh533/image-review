using ImageReview.Logic;
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
    public partial class frmImageSlider : Form
    {
        public frmImageSlider()
        {
            InitializeComponent();
        }

        List<FileInfo> fPic;

        public void Show(List<FileInfo> _fPic)
        {
            fPic = _fPic;
            this.ShowDialog();
        }

        private void frmImageSlider_Load(object sender, EventArgs e)
        {
            LoadSliderImages();
        }

        private void LoadSliderImages()
        {
            try
            {
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
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error ImageSlider : {0}", ee.Message));
            }
        }
    }
}
