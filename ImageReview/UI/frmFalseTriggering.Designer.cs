namespace ImageReview.UI
{
    partial class frmFalseTriggering
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.chkSelectUnselectAll = new System.Windows.Forms.CheckBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.pnlWait = new System.Windows.Forms.Panel();
            this.ppMainWait = new DevExpress.XtraWaitForm.ProgressPanel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tvFT = new System.Windows.Forms.TreeView();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtAvgSpeedInSec = new System.Windows.Forms.TextBox();
            this.cmbEntryExit = new System.Windows.Forms.ComboBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cmbLocation = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.pnlWait.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClearAll
            // 
            this.btnClearAll.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.Location = new System.Drawing.Point(846, 66);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(234, 55);
            this.btnClearAll.TabIndex = 6;
            this.btnClearAll.Text = "Clear Selected Triggers";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // chkSelectUnselectAll
            // 
            this.chkSelectUnselectAll.AutoSize = true;
            this.chkSelectUnselectAll.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSelectUnselectAll.Location = new System.Drawing.Point(757, 160);
            this.chkSelectUnselectAll.Name = "chkSelectUnselectAll";
            this.chkSelectUnselectAll.Size = new System.Drawing.Size(108, 28);
            this.chkSelectUnselectAll.TabIndex = 1;
            this.chkSelectUnselectAll.Text = "Select All";
            this.chkSelectUnselectAll.UseVisualStyleBackColor = true;
            this.chkSelectUnselectAll.CheckedChanged += new System.EventHandler(this.chkSelectUnselectAll_CheckedChanged);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AllowUserToOrderColumns = true;
            this.dgvData.BackgroundColor = System.Drawing.Color.White;
            this.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(757, 194);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 14F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvData.RowHeadersWidth = 25;
            this.dgvData.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.ShowCellErrors = false;
            this.dgvData.ShowCellToolTips = false;
            this.dgvData.ShowEditingIcon = false;
            this.dgvData.ShowRowErrors = false;
            this.dgvData.Size = new System.Drawing.Size(598, 390);
            this.dgvData.TabIndex = 3;
            this.dgvData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellDoubleClick);
            // 
            // pnlWait
            // 
            this.pnlWait.Controls.Add(this.ppMainWait);
            this.pnlWait.Location = new System.Drawing.Point(1208, 16);
            this.pnlWait.Name = "pnlWait";
            this.pnlWait.Size = new System.Drawing.Size(182, 76);
            this.pnlWait.TabIndex = 86;
            this.pnlWait.Visible = false;
            // 
            // ppMainWait
            // 
            this.ppMainWait.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.ppMainWait.Appearance.Options.UseBackColor = true;
            this.ppMainWait.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.ppMainWait.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ppMainWait.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.ppMainWait.Location = new System.Drawing.Point(0, 0);
            this.ppMainWait.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ppMainWait.Name = "ppMainWait";
            this.ppMainWait.Size = new System.Drawing.Size(182, 76);
            this.ppMainWait.TabIndex = 53;
            this.ppMainWait.ToolTip = "Data is loading";
            this.ppMainWait.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.ppMainWait.ToolTipTitle = "Please Wait";
            this.ppMainWait.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Ring;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(846, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(234, 55);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Search";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // tvFT
            // 
            this.tvFT.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvFT.Location = new System.Drawing.Point(12, 194);
            this.tvFT.Name = "tvFT";
            this.tvFT.Size = new System.Drawing.Size(739, 390);
            this.tvFT.TabIndex = 2;
            this.tvFT.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvFT_NodeMouseDoubleClick);
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            this.labelControl9.Location = new System.Drawing.Point(11, 91);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(235, 28);
            this.labelControl9.TabIndex = 146;
            this.labelControl9.Text = "No. of triggers in one mint.";
            // 
            // txtAvgSpeedInSec
            // 
            this.txtAvgSpeedInSec.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtAvgSpeedInSec.Location = new System.Drawing.Point(271, 89);
            this.txtAvgSpeedInSec.Name = "txtAvgSpeedInSec";
            this.txtAvgSpeedInSec.Size = new System.Drawing.Size(135, 32);
            this.txtAvgSpeedInSec.TabIndex = 4;
            this.txtAvgSpeedInSec.Text = "3";
            // 
            // cmbEntryExit
            // 
            this.cmbEntryExit.AccessibleName = "";
            this.cmbEntryExit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEntryExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEntryExit.FormattingEnabled = true;
            this.cmbEntryExit.Items.AddRange(new object[] {
            "Both Entry/Exit",
            "Only Entry",
            "Only Exit"});
            this.cmbEntryExit.Location = new System.Drawing.Point(537, 46);
            this.cmbEntryExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbEntryExit.Name = "cmbEntryExit";
            this.cmbEntryExit.Size = new System.Drawing.Size(277, 36);
            this.cmbEntryExit.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            this.labelControl3.Location = new System.Drawing.Point(436, 50);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(84, 28);
            this.labelControl3.TabIndex = 150;
            this.labelControl3.Text = "Entry/Exit";
            // 
            // cmbLocation
            // 
            this.cmbLocation.AccessibleName = "";
            this.cmbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLocation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLocation.FormattingEnabled = true;
            this.cmbLocation.Location = new System.Drawing.Point(129, 46);
            this.cmbLocation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(277, 36);
            this.cmbLocation.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            this.labelControl1.Location = new System.Drawing.Point(11, 50);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(75, 28);
            this.labelControl1.TabIndex = 149;
            this.labelControl1.Text = "Location";
            // 
            // dtTo
            // 
            this.dtTo.CustomFormat = "dd-MMM-yyyy HH:mm:ss";
            this.dtTo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTo.Location = new System.Drawing.Point(537, 4);
            this.dtTo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(277, 34);
            this.dtTo.TabIndex = 1;
            // 
            // dtFrom
            // 
            this.dtFrom.CustomFormat = "dd-MMM-yyyy HH:mm:ss";
            this.dtFrom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFrom.Location = new System.Drawing.Point(129, 4);
            this.dtFrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(277, 34);
            this.dtFrom.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            this.labelControl2.Location = new System.Drawing.Point(11, 7);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(93, 28);
            this.labelControl2.TabIndex = 155;
            this.labelControl2.Text = "From Time";
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.labelControl4);
            this.pnlHeader.Controls.Add(this.dtFrom);
            this.pnlHeader.Controls.Add(this.labelControl2);
            this.pnlHeader.Controls.Add(this.btnClearAll);
            this.pnlHeader.Controls.Add(this.btnRefresh);
            this.pnlHeader.Controls.Add(this.dtTo);
            this.pnlHeader.Controls.Add(this.txtAvgSpeedInSec);
            this.pnlHeader.Controls.Add(this.labelControl9);
            this.pnlHeader.Controls.Add(this.cmbEntryExit);
            this.pnlHeader.Controls.Add(this.labelControl1);
            this.pnlHeader.Controls.Add(this.labelControl3);
            this.pnlHeader.Controls.Add(this.cmbLocation);
            this.pnlHeader.Location = new System.Drawing.Point(112, 12);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1090, 128);
            this.pnlHeader.TabIndex = 0;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            this.labelControl4.Location = new System.Drawing.Point(436, 7);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(69, 28);
            this.labelControl4.TabIndex = 156;
            this.labelControl4.Text = "To Time";
            // 
            // frmFalseTriggering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1383, 606);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.tvFT);
            this.Controls.Add(this.pnlWait);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.chkSelectUnselectAll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "frmFalseTriggering";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "False Triggering Data";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmFalseTriggering_Load);
            this.Resize += new System.EventHandler(this.frmFalseTriggering_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.pnlWait.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.CheckBox chkSelectUnselectAll;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Panel pnlWait;
        public DevExpress.XtraWaitForm.ProgressPanel ppMainWait;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TreeView tvFT;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.TextBox txtAvgSpeedInSec;
        private System.Windows.Forms.ComboBox cmbEntryExit;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.ComboBox cmbLocation;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.Panel pnlHeader;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}