using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace ImageReview.UI
{
    public partial class frmZoomInImage : DevExpress.XtraEditors.XtraForm
    {
        Bitmap bitmap;
        private const float ZoomIncrement = 0.1f;
        private float currentZoom = 1.0f;
        private int _xPos;
        private int _yPos;
        private bool _dragging;
        Image _img;
        Rectangle _imgRect;

        public frmZoomInImage()
        {
            InitializeComponent();
        }

        public void Show(Image img)
        {
            try
            {
                _img = img;
                picMain.Image = img;
                bitmap = (Bitmap)img;
                this.Show();
            }
            catch (Exception ee)
            { }
        }

        public void UpdateImage(Image img)
        {
            try
            {
                _img = img;
                picMain.Image = img;
                bitmap = (Bitmap)img;
            }
            catch (Exception ee)
            { }
        }

        private void frmLiveExitImage_Load(object sender, EventArgs e)
        {
            try
            {
                // picMain.Cursor = new Cursor(Properties.Resources.ZoomOut.GetHicon());
                picMain.Cursor = Cursors.Hand;
                SetFormControls();

                picMain.MouseWheel += pictureBox1_MouseWheel;
                picMain.MouseDown += PictureBox1_MouseDown;
                picMain.MouseMove += PictureBox1_MouseMove;
                picMain.MouseUp += PictureBox1_MouseUp;
                picMain.Paint += pictureBox1_Paint;

                picMain.SizeMode = PictureBoxSizeMode.AutoSize;

                panel1.AutoScroll = true;
                txtFocus.Focus();
            }
            catch (Exception ee)
            { }
        }

        private void SetFormControls()
        {
            panel1.Height = this.Height - tbSlider.Height - 5;
        }

        private void tbSlider_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                picMain.Image = ChangeBrightness(bitmap, (float)(tbSlider.Value / 100.0));
            }
            catch (Exception ee)
            { }
        }

        ImageAttributes attributes;
        ColorMatrix cm;
        Bitmap bm;
        private Bitmap ChangeBrightness(Image image, float brightness)
        {
            try
            {
                bm = new Bitmap(image.Width, image.Height);

                if (tbSlider.Value != 100)
                {
                    // Make the ColorMatrix.
                    float b = brightness;
                    cm = new ColorMatrix(new float[][]
                       {
                    new float[] {b, 0, 0, 0, 0},
                    new float[] {0, b, 0, 0, 0},
                    new float[] {0, 0, b, 0, 0},
                    new float[] {0, 0, 0, 1, 0},
                    new float[] {0, 0, 0, 0, 1},
                       });
                    attributes = new ImageAttributes();
                    attributes.SetColorMatrix(cm);

                    // Draw the image onto the new bitmap while applying the new ColorMatrix.
                    Point[] points = { new Point(0, 0), new Point(image.Width, 0), new Point(0, image.Height) };
                    rect = new Rectangle(0, 0, image.Width, image.Height);

                    // Make the result bitmap.
                    using (Graphics gr = Graphics.FromImage(bm))
                    {
                        gr.DrawImage(image, points, rect, GraphicsUnit.Pixel, attributes);
                    }
                }

                // Return the result.
                return bm;
            }
            catch (Exception ee)
            {
                MessageBox.Show("Error : " + ee.Message);
                return (Bitmap)image;
            }
        }
        Rectangle rect;
        private void pictureBox1_MouseWheel(object sender, MouseEventArgs e)
        {
            try
            {
                if (ModifierKeys.HasFlag(Keys.Control))
                {
                    if (e.Delta > 0)
                        currentZoom += ZoomIncrement;
                    else if (e.Delta < 0 && currentZoom > ZoomIncrement)
                        currentZoom -= ZoomIncrement;

                    RedrawImageWithZoom();
                }
            }
            catch (Exception ee)
            { }
        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (ModifierKeys.HasFlag(Keys.Control))
                {
                    _img = picMain.Image;
                    _dragging = true;
                    _xPos = e.X;
                    _yPos = e.Y;
                }
            }
            catch (Exception ee)
            { }
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (ModifierKeys.HasFlag(Keys.Control) && e.Button == MouseButtons.Left)
                {

                    if (!_dragging || _img == null) return;

                    if (e.Button == MouseButtons.Left)
                    {
                        _imgRect = new Rectangle(-(_xPos - e.X), -(_yPos - e.Y), _img.Width, _img.Height);
                        picMain.Invalidate();
                    }
                }
            }
            catch (Exception ee)
            { }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                if (_img != null)
                {
                    e.Graphics.DrawImage(_img, _imgRect);
                }
                else e.Graphics.Dispose();
            }
            catch (Exception ee)
            { }
        }

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                var c = sender as PictureBox;
                if (null == c) return;
                _dragging = false;
                //  _imgRect = new Rectangle(1, 1, 1, 1);
                //  picMain.Invalidate();
            }
            catch (Exception ee)
            { }
        }

        Image originalImage;
        Bitmap newImage;
        private void RedrawImageWithZoom()
        {
            try
            {
                originalImage = bitmap;

                int newWidth = (int)(originalImage.Width * currentZoom);
                int newHeight = (int)(originalImage.Height * currentZoom);

                int maxInt = 7000;
                newWidth = newWidth > maxInt ? maxInt : newWidth;
                newHeight = newHeight > maxInt ? maxInt : newHeight;

                if (newWidth != 0 && newHeight != 0)
                {
                    newImage = new Bitmap(newWidth, newHeight);

                    using (Graphics graphics = Graphics.FromImage(newImage))
                    {
                        graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                        graphics.DrawImage(originalImage, new Rectangle(0, 0, newWidth, newHeight));
                    }

                    if (tbSlider.Value != 100)
                        newImage = ChangeBrightness(newImage, (float)(tbSlider.Value / 100.0));

                    picMain.Image = newImage;
                }
            }
            catch (Exception ee)
            {
            }
        }

        private void picMain_DoubleClick(object sender, EventArgs e)
        {
            CloseForm();
        }

        private void CloseForm()
        {
            this.Close();
        }

        private void txtFocus_Leave(object sender, EventArgs e)
        {
            txtFocus.Focus();
        }

        private void txtFocus_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space || e.KeyCode == Keys.Escape)
                {
                    CloseForm();
                }
            }
            catch (Exception ee)
            { }
        }

        private void frmZoomInImage_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                (this.Tag as frmDashboard).DisposeFrmZoom();
                e.Cancel = false;
            }
            catch (Exception ee)
            { }
        }

        private void frmZoomInImage_Resize(object sender, EventArgs e)
        {
            try
            {
                SetFormControls();
            }
            catch (Exception ee)
            { }
        }
    }
}
