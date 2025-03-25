namespace ImageReview.UI
{
    partial class frmZoomInImage
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
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel1 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel2 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel3 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            this.tbSlider = new DevExpress.XtraEditors.TrackBarControl();
            this.picMain = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFocus = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSlider.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbSlider
            // 
            this.tbSlider.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbSlider.EditValue = 100;
            this.tbSlider.Location = new System.Drawing.Point(6, 0);
            this.tbSlider.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbSlider.Name = "tbSlider";
            this.tbSlider.Properties.LabelAppearance.Options.UseTextOptions = true;
            this.tbSlider.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            trackBarLabel1.Label = "Original";
            trackBarLabel1.Value = 100;
            trackBarLabel2.Label = "Max Brightness";
            trackBarLabel2.Value = 1000;
            trackBarLabel3.Label = "Min Brightness";
            trackBarLabel3.Value = -50;
            this.tbSlider.Properties.Labels.AddRange(new DevExpress.XtraEditors.Repository.TrackBarLabel[] {
            trackBarLabel1,
            trackBarLabel2,
            trackBarLabel3});
            this.tbSlider.Properties.Maximum = 1000;
            this.tbSlider.Properties.Minimum = -50;
            this.tbSlider.Properties.ShowLabels = true;
            this.tbSlider.Size = new System.Drawing.Size(1342, 86);
            this.tbSlider.TabIndex = 4;
            this.tbSlider.Value = 100;
            this.tbSlider.EditValueChanged += new System.EventHandler(this.tbSlider_EditValueChanged);
            // 
            // picMain
            // 
            this.picMain.BackColor = System.Drawing.Color.White;
            this.picMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picMain.Location = new System.Drawing.Point(0, 0);
            this.picMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picMain.Name = "picMain";
            this.picMain.Size = new System.Drawing.Size(1342, 515);
            this.picMain.TabIndex = 0;
            this.picMain.TabStop = false;
            this.picMain.DoubleClick += new System.EventHandler(this.picMain_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picMain);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(6, 349);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1342, 515);
            this.panel1.TabIndex = 5;
            // 
            // txtFocus
            // 
            this.txtFocus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFocus.Location = new System.Drawing.Point(-200, 187);
            this.txtFocus.Name = "txtFocus";
            this.txtFocus.Size = new System.Drawing.Size(100, 16);
            this.txtFocus.TabIndex = 6;
            this.txtFocus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFocus_KeyDown);
            this.txtFocus.Leave += new System.EventHandler(this.txtFocus_Leave);
            // 
            // frmZoomInImage
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 870);
            this.Controls.Add(this.txtFocus);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbSlider);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimizeBox = false;
            this.Name = "frmZoomInImage";
            this.Padding = new System.Windows.Forms.Padding(6, 0, 6, 6);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmZoomInImage_FormClosing);
            this.Load += new System.EventHandler(this.frmLiveExitImage_Load);
            this.Resize += new System.EventHandler(this.frmZoomInImage_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.tbSlider.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picMain;
        private DevExpress.XtraEditors.TrackBarControl tbSlider;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtFocus;
    }
}