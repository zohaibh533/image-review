namespace ImageReview.UI
{
    partial class frmReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReports));
            this.gcData = new DevExpress.XtraGrid.GridControl();
            this.gvData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grpFilters = new System.Windows.Forms.GroupBox();
            this.cmbEntryExit = new System.Windows.Forms.ComboBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cmbLocation = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.chkExcludeForward = new System.Windows.Forms.CheckBox();
            this.ppWait = new DevExpress.XtraWaitForm.ProgressPanel();
            this.lblRecords = new DevExpress.XtraEditors.LabelControl();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.cmbPrintReport = new System.Windows.Forms.ComboBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtPlateNo = new System.Windows.Forms.TextBox();
            this.cmbActionType = new System.Windows.Forms.ComboBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cmbUser = new System.Windows.Forms.ComboBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.label2 = new System.Windows.Forms.Label();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.gcData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
            this.grpFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcData
            // 
            this.gcData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gcData.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcData.Location = new System.Drawing.Point(0, 264);
            this.gcData.MainView = this.gvData;
            this.gcData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcData.Name = "gcData";
            this.gcData.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.gcData.Size = new System.Drawing.Size(1750, 548);
            this.gcData.TabIndex = 1;
            this.gcData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvData});
            // 
            // gvData
            // 
            this.gvData.Appearance.EvenRow.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gvData.Appearance.EvenRow.Options.UseFont = true;
            this.gvData.Appearance.FilterCloseButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvData.Appearance.FilterCloseButton.Options.UseFont = true;
            this.gvData.Appearance.FilterPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvData.Appearance.FilterPanel.Options.UseFont = true;
            this.gvData.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvData.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvData.Appearance.OddRow.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gvData.Appearance.OddRow.Options.UseFont = true;
            this.gvData.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvData.Appearance.Row.Options.UseFont = true;
            this.gvData.AppearancePrint.OddRow.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvData.AppearancePrint.OddRow.Options.UseFont = true;
            this.gvData.AppearancePrint.Row.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvData.AppearancePrint.Row.Options.UseFont = true;
            this.gvData.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.gvData.DetailHeight = 400;
            this.gvData.GridControl = this.gcData;
            this.gvData.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gvData.Name = "gvData";
            this.gvData.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvData.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvData.OptionsBehavior.Editable = false;
            this.gvData.OptionsBehavior.ReadOnly = true;
            this.gvData.OptionsFind.AlwaysVisible = true;
            this.gvData.OptionsFind.FindDelay = 100;
            this.gvData.OptionsFind.ShowClearButton = false;
            this.gvData.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvData.OptionsView.EnableAppearanceEvenRow = true;
            this.gvData.OptionsView.ShowGroupPanel = false;
            this.gvData.RowHeight = 35;
            this.gvData.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.LiveVertScroll;
            this.gvData.DoubleClick += new System.EventHandler(this.gvData_DoubleClick);
            // 
            // grpFilters
            // 
            this.grpFilters.Controls.Add(this.cmbEntryExit);
            this.grpFilters.Controls.Add(this.labelControl3);
            this.grpFilters.Controls.Add(this.cmbLocation);
            this.grpFilters.Controls.Add(this.labelControl1);
            this.grpFilters.Controls.Add(this.chkExcludeForward);
            this.grpFilters.Controls.Add(this.ppWait);
            this.grpFilters.Controls.Add(this.lblRecords);
            this.grpFilters.Controls.Add(this.btnPrint);
            this.grpFilters.Controls.Add(this.btnSearch);
            this.grpFilters.Controls.Add(this.cmbPrintReport);
            this.grpFilters.Controls.Add(this.labelControl7);
            this.grpFilters.Controls.Add(this.labelControl5);
            this.grpFilters.Controls.Add(this.txtPlateNo);
            this.grpFilters.Controls.Add(this.cmbActionType);
            this.grpFilters.Controls.Add(this.labelControl4);
            this.grpFilters.Controls.Add(this.cmbUser);
            this.grpFilters.Controls.Add(this.labelControl2);
            this.grpFilters.Controls.Add(this.label2);
            this.grpFilters.Controls.Add(this.dtTo);
            this.grpFilters.Controls.Add(this.label1);
            this.grpFilters.Controls.Add(this.dtFrom);
            this.grpFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpFilters.Font = new System.Drawing.Font("Tahoma", 12F);
            this.grpFilters.Location = new System.Drawing.Point(0, 0);
            this.grpFilters.Name = "grpFilters";
            this.grpFilters.Size = new System.Drawing.Size(1750, 196);
            this.grpFilters.TabIndex = 0;
            this.grpFilters.TabStop = false;
            this.grpFilters.Text = "Search Criteria";
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
            this.cmbEntryExit.Location = new System.Drawing.Point(915, 143);
            this.cmbEntryExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbEntryExit.Name = "cmbEntryExit";
            this.cmbEntryExit.Size = new System.Drawing.Size(248, 36);
            this.cmbEntryExit.TabIndex = 10;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            this.labelControl3.Location = new System.Drawing.Point(796, 147);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(84, 28);
            this.labelControl3.TabIndex = 138;
            this.labelControl3.Text = "Entry/Exit";
            // 
            // cmbLocation
            // 
            this.cmbLocation.AccessibleName = "";
            this.cmbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLocation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLocation.FormattingEnabled = true;
            this.cmbLocation.Location = new System.Drawing.Point(533, 143);
            this.cmbLocation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(248, 36);
            this.cmbLocation.TabIndex = 9;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            this.labelControl1.Location = new System.Drawing.Point(421, 147);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(75, 28);
            this.labelControl1.TabIndex = 136;
            this.labelControl1.Text = "Location";
            // 
            // chkExcludeForward
            // 
            this.chkExcludeForward.AutoSize = true;
            this.chkExcludeForward.Location = new System.Drawing.Point(146, 147);
            this.chkExcludeForward.Name = "chkExcludeForward";
            this.chkExcludeForward.Size = new System.Drawing.Size(269, 28);
            this.chkExcludeForward.TabIndex = 8;
            this.chkExcludeForward.Text = "Exclude Forwarded Tickets";
            this.chkExcludeForward.UseVisualStyleBackColor = true;
            // 
            // ppWait
            // 
            this.ppWait.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ppWait.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.ppWait.Appearance.Options.UseBackColor = true;
            this.ppWait.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.ppWait.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.ppWait.Location = new System.Drawing.Point(1383, 57);
            this.ppWait.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ppWait.Name = "ppWait";
            this.ppWait.Size = new System.Drawing.Size(178, 56);
            this.ppWait.TabIndex = 132;
            this.ppWait.ToolTip = "Data is loading";
            this.ppWait.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.ppWait.ToolTipTitle = "Please Wait";
            this.ppWait.Visible = false;
            this.ppWait.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Ring;
            // 
            // lblRecords
            // 
            this.lblRecords.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            this.lblRecords.Location = new System.Drawing.Point(1169, 147);
            this.lblRecords.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(67, 28);
            this.lblRecords.TabIndex = 133;
            this.lblRecords.Text = "Count : ";
            // 
            // btnPrint
            // 
            this.btnPrint.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnPrint.Appearance.Options.UseFont = true;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnPrint.Location = new System.Drawing.Point(1169, 36);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(208, 41);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "  Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnSearch.Appearance.Options.UseFont = true;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSearch.Location = new System.Drawing.Point(1169, 91);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(208, 41);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "  Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbPrintReport
            // 
            this.cmbPrintReport.AccessibleName = "";
            this.cmbPrintReport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrintReport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPrintReport.FormattingEnabled = true;
            this.cmbPrintReport.Items.AddRange(new object[] {
            "Verification Summary",
            "User Wise Summary",
            "Hourly Summary",
            "User Performance",
            "Location Wise Summary"});
            this.cmbPrintReport.Location = new System.Drawing.Point(915, 38);
            this.cmbPrintReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbPrintReport.Name = "cmbPrintReport";
            this.cmbPrintReport.Size = new System.Drawing.Size(248, 36);
            this.cmbPrintReport.TabIndex = 2;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            this.labelControl7.Location = new System.Drawing.Point(796, 42);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(106, 28);
            this.labelControl7.TabIndex = 24;
            this.labelControl7.Text = "Print Report";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl5.Location = new System.Drawing.Point(796, 83);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(113, 56);
            this.labelControl5.TabIndex = 20;
            this.labelControl5.Text = "Plate No && Trans ID";
            // 
            // txtPlateNo
            // 
            this.txtPlateNo.Location = new System.Drawing.Point(915, 95);
            this.txtPlateNo.Name = "txtPlateNo";
            this.txtPlateNo.Size = new System.Drawing.Size(248, 32);
            this.txtPlateNo.TabIndex = 6;
            // 
            // cmbActionType
            // 
            this.cmbActionType.AccessibleName = "";
            this.cmbActionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActionType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbActionType.FormattingEnabled = true;
            this.cmbActionType.Items.AddRange(new object[] {
            "All Actions",
            "Verified",
            "Verified - With Modification",
            "Verified - Without Modification",
            "Ignored",
            "Forwarded",
            "PNF-System"});
            this.cmbActionType.Location = new System.Drawing.Point(533, 93);
            this.cmbActionType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbActionType.Name = "cmbActionType";
            this.cmbActionType.Size = new System.Drawing.Size(248, 36);
            this.cmbActionType.TabIndex = 5;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            this.labelControl4.Location = new System.Drawing.Point(421, 97);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(104, 28);
            this.labelControl4.TabIndex = 18;
            this.labelControl4.Text = "Action Type";
            // 
            // cmbUser
            // 
            this.cmbUser.AccessibleName = "";
            this.cmbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUser.FormattingEnabled = true;
            this.cmbUser.Location = new System.Drawing.Point(146, 93);
            this.cmbUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Size = new System.Drawing.Size(248, 36);
            this.cmbUser.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            this.labelControl2.Location = new System.Drawing.Point(32, 97);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(39, 28);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            this.label2.Location = new System.Drawing.Point(421, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "To Time";
            // 
            // dtTo
            // 
            this.dtTo.CustomFormat = "dd-MMM-yyyy HH:mm:ss";
            this.dtTo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTo.Location = new System.Drawing.Point(533, 39);
            this.dtTo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(248, 34);
            this.dtTo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            this.label1.Location = new System.Drawing.Point(32, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "From Time";
            // 
            // dtFrom
            // 
            this.dtFrom.CustomFormat = "dd-MMM-yyyy HH:mm:ss";
            this.dtFrom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFrom.Location = new System.Drawing.Point(146, 39);
            this.dtFrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(248, 34);
            this.dtFrom.TabIndex = 0;
            // 
            // frmReports
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1750, 812);
            this.Controls.Add(this.grpFilters);
            this.Controls.Add(this.gcData);
            this.MinimizeBox = false;
            this.Name = "frmReports";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Review Reports";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
            this.grpFilters.ResumeLayout(false);
            this.grpFilters.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcData;
        private DevExpress.XtraGrid.Views.Grid.GridView gvData;
        private System.Windows.Forms.GroupBox grpFilters;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.ComboBox cmbUser;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.ComboBox cmbActionType;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.ComboBox cmbPrintReport;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.TextBox txtPlateNo;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        public DevExpress.XtraWaitForm.ProgressPanel ppWait;
        private DevExpress.XtraEditors.LabelControl lblRecords;
        private System.Windows.Forms.CheckBox chkExcludeForward;
        private System.Windows.Forms.ComboBox cmbLocation;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox cmbEntryExit;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}