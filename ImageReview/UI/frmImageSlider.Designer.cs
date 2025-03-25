namespace ImageReview.UI
{
    partial class frmImageSlider
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.imgSlider = new DevExpress.XtraEditors.Controls.ImageSlider();
            ((System.ComponentModel.ISupportInitialize)(this.imgSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // imgSlider
            // 
            this.imgSlider.AnimationTime = 300;
            this.imgSlider.CurrentImageIndex = -1;
            this.imgSlider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgSlider.LayoutMode = DevExpress.Utils.Drawing.ImageLayoutMode.ZoomInside;
            this.imgSlider.Location = new System.Drawing.Point(0, 0);
            this.imgSlider.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.imgSlider.Name = "imgSlider";
            this.imgSlider.Size = new System.Drawing.Size(1184, 568);
            this.imgSlider.TabIndex = 4;
            this.imgSlider.TabStop = false;
            this.imgSlider.Text = "imageSlider1";
            this.imgSlider.UseDisabledStatePainter = true;
            // 
            // frmImageSlider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 568);
            this.Controls.Add(this.imgSlider);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmImageSlider";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modified Data Review";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmImageSlider_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgSlider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.Controls.ImageSlider imgSlider;
    }
}