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
            this.cmbAccessPoints = new System.Windows.Forms.ComboBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.chkNoOfTrans = new System.Windows.Forms.CheckBox();
            this.txtNoOfTransactions = new System.Windows.Forms.TextBox();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.lstAccessPointType = new System.Windows.Forms.ListBox();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.lblAvgSpeed = new DevExpress.XtraEditors.LabelControl();
            this.txtAvgSpeedInSec = new System.Windows.Forms.TextBox();
            this.lblTotalAct = new DevExpress.XtraEditors.LabelControl();
            this.txtTotalActCount = new System.Windows.Forms.TextBox();
            this.lblModCount = new DevExpress.XtraEditors.LabelControl();
            this.txtModCount = new System.Windows.Forms.TextBox();
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
            this.dtTo = new System.Windows.Forms.DateTimePicker();
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
            this.gcData.Location = new System.Drawing.Point(0, 530);
            this.gcData.MainView = this.gvData;
            this.gcData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcData.Name = "gcData";
            this.gcData.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.gcData.Size = new System.Drawing.Size(1750, 282);
            this.gcData.TabIndex = 1;
            this.gcData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvData});
            // 
            // gvData
            // 
            this.gvData.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvData.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gvData.Appearance.ColumnFilterButtonActive.Font = new System.Drawing.Font("Calibri", 12F);
            this.gvData.Appearance.ColumnFilterButtonActive.Options.UseFont = true;
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
            this.grpFilters.Controls.Add(this.cmbAccessPoints);
            this.grpFilters.Controls.Add(this.labelControl6);
            this.grpFilters.Controls.Add(this.labelControl12);
            this.grpFilters.Controls.Add(this.chkNoOfTrans);
            this.grpFilters.Controls.Add(this.txtNoOfTransactions);
            this.grpFilters.Controls.Add(this.labelControl11);
            this.grpFilters.Controls.Add(this.lstAccessPointType);
            this.grpFilters.Controls.Add(this.labelControl10);
            this.grpFilters.Controls.Add(this.lblAvgSpeed);
            this.grpFilters.Controls.Add(this.txtAvgSpeedInSec);
            this.grpFilters.Controls.Add(this.lblTotalAct);
            this.grpFilters.Controls.Add(this.txtTotalActCount);
            this.grpFilters.Controls.Add(this.lblModCount);
            this.grpFilters.Controls.Add(this.txtModCount);
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
            this.grpFilters.Controls.Add(this.dtTo);
            this.grpFilters.Controls.Add(this.dtFrom);
            this.grpFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpFilters.Font = new System.Drawing.Font("Tahoma", 12F);
            this.grpFilters.Location = new System.Drawing.Point(0, 0);
            this.grpFilters.Name = "grpFilters";
            this.grpFilters.Size = new System.Drawing.Size(1750, 322);
            this.grpFilters.TabIndex = 0;
            this.grpFilters.TabStop = false;
            this.grpFilters.Text = "Search Criteria";
            // 
            // cmbAccessPoints
            // 
            this.cmbAccessPoints.AccessibleName = "";
            this.cmbAccessPoints.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAccessPoints.FormattingEnabled = true;
            this.cmbAccessPoints.Location = new System.Drawing.Point(533, 187);
            this.cmbAccessPoints.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbAccessPoints.Name = "cmbAccessPoints";
            this.cmbAccessPoints.Size = new System.Drawing.Size(248, 36);
            this.cmbAccessPoints.TabIndex = 12;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            this.labelControl6.Location = new System.Drawing.Point(408, 191);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(116, 28);
            this.labelControl6.TabIndex = 154;
            this.labelControl6.Text = "Access Points";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            this.labelControl12.Location = new System.Drawing.Point(408, 42);
            this.labelControl12.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(69, 28);
            this.labelControl12.TabIndex = 152;
            this.labelControl12.Text = "To Time";
            // 
            // chkNoOfTrans
            // 
            this.chkNoOfTrans.AutoSize = true;
            this.chkNoOfTrans.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.chkNoOfTrans.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            this.chkNoOfTrans.Location = new System.Drawing.Point(408, 273);
            this.chkNoOfTrans.Name = "chkNoOfTrans";
            this.chkNoOfTrans.Size = new System.Drawing.Size(199, 32);
            this.chkNoOfTrans.TabIndex = 15;
            this.chkNoOfTrans.Text = "No. of Transactions";
            this.chkNoOfTrans.UseVisualStyleBackColor = true;
            this.chkNoOfTrans.CheckedChanged += new System.EventHandler(this.chkNoOfTrans_CheckedChanged);
            // 
            // txtNoOfTransactions
            // 
            this.txtNoOfTransactions.Enabled = false;
            this.txtNoOfTransactions.Location = new System.Drawing.Point(626, 273);
            this.txtNoOfTransactions.Name = "txtNoOfTransactions";
            this.txtNoOfTransactions.Size = new System.Drawing.Size(155, 32);
            this.txtNoOfTransactions.TabIndex = 16;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            this.labelControl11.Location = new System.Drawing.Point(32, 42);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(93, 28);
            this.labelControl11.TabIndex = 148;
            this.labelControl11.Text = "From Time";
            // 
            // lstAccessPointType
            // 
            this.lstAccessPointType.FormattingEnabled = true;
            this.lstAccessPointType.ItemHeight = 24;
            this.lstAccessPointType.Location = new System.Drawing.Point(915, 186);
            this.lstAccessPointType.Name = "lstAccessPointType";
            this.lstAccessPointType.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstAccessPointType.Size = new System.Drawing.Size(248, 76);
            this.lstAccessPointType.TabIndex = 13;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            this.labelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl10.Location = new System.Drawing.Point(796, 199);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(106, 56);
            this.labelControl10.TabIndex = 146;
            this.labelControl10.Text = "Access Point Type";
            // 
            // lblAvgSpeed
            // 
            this.lblAvgSpeed.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgSpeed.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            this.lblAvgSpeed.Location = new System.Drawing.Point(32, 232);
            this.lblAvgSpeed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblAvgSpeed.Name = "lblAvgSpeed";
            this.lblAvgSpeed.Size = new System.Drawing.Size(155, 28);
            this.lblAvgSpeed.TabIndex = 144;
            this.lblAvgSpeed.Text = "Avg. Speed in Sec";
            // 
            // txtAvgSpeedInSec
            // 
            this.txtAvgSpeedInSec.Location = new System.Drawing.Point(226, 230);
            this.txtAvgSpeedInSec.Name = "txtAvgSpeedInSec";
            this.txtAvgSpeedInSec.Size = new System.Drawing.Size(168, 32);
            this.txtAvgSpeedInSec.TabIndex = 14;
            this.txtAvgSpeedInSec.Text = "7";
            // 
            // lblTotalAct
            // 
            this.lblTotalAct.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAct.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            this.lblTotalAct.Location = new System.Drawing.Point(408, 232);
            this.lblTotalAct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblTotalAct.Name = "lblTotalAct";
            this.lblTotalAct.Size = new System.Drawing.Size(164, 28);
            this.lblTotalAct.TabIndex = 142;
            this.lblTotalAct.Text = "Total Action Count";
            // 
            // txtTotalActCount
            // 
            this.txtTotalActCount.Location = new System.Drawing.Point(605, 230);
            this.txtTotalActCount.Name = "txtTotalActCount";
            this.txtTotalActCount.Size = new System.Drawing.Size(176, 32);
            this.txtTotalActCount.TabIndex = 15;
            this.txtTotalActCount.Text = "35000";
            // 
            // lblModCount
            // 
            this.lblModCount.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModCount.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            this.lblModCount.Location = new System.Drawing.Point(32, 191);
            this.lblModCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblModCount.Name = "lblModCount";
            this.lblModCount.Size = new System.Drawing.Size(170, 28);
            this.lblModCount.TabIndex = 140;
            this.lblModCount.Text = "Modification Count";
            // 
            // txtModCount
            // 
            this.txtModCount.Location = new System.Drawing.Point(226, 189);
            this.txtModCount.Name = "txtModCount";
            this.txtModCount.Size = new System.Drawing.Size(168, 32);
            this.txtModCount.TabIndex = 11;
            this.txtModCount.Text = "10000";
            // 
            // cmbEntryExit
            // 
            this.cmbEntryExit.AccessibleName = "";
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
            this.cmbLocation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLocation.FormattingEnabled = true;
            this.cmbLocation.Location = new System.Drawing.Point(533, 143);
            this.cmbLocation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(248, 36);
            this.cmbLocation.TabIndex = 9;
            this.cmbLocation.SelectedIndexChanged += new System.EventHandler(this.cmbLocation_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            this.labelControl1.Location = new System.Drawing.Point(408, 147);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(75, 28);
            this.labelControl1.TabIndex = 136;
            this.labelControl1.Text = "Location";
            // 
            // chkExcludeForward
            // 
            this.chkExcludeForward.AutoSize = true;
            this.chkExcludeForward.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.chkExcludeForward.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            this.chkExcludeForward.Location = new System.Drawing.Point(146, 147);
            this.chkExcludeForward.Name = "chkExcludeForward";
            this.chkExcludeForward.Size = new System.Drawing.Size(199, 32);
            this.chkExcludeForward.TabIndex = 8;
            this.chkExcludeForward.Text = "Exclude Forwarded";
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
            this.ppWait.Size = new System.Drawing.Size(178, 70);
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
            this.labelControl4.Location = new System.Drawing.Point(408, 97);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(104, 28);
            this.labelControl4.TabIndex = 18;
            this.labelControl4.Text = "Action Type";
            // 
            // cmbUser
            // 
            this.cmbUser.AccessibleName = "";
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
        private System.Windows.Forms.DateTimePicker dtTo;
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
        private DevExpress.XtraEditors.LabelControl lblAvgSpeed;
        private System.Windows.Forms.TextBox txtAvgSpeedInSec;
        private DevExpress.XtraEditors.LabelControl lblTotalAct;
        private System.Windows.Forms.TextBox txtTotalActCount;
        private DevExpress.XtraEditors.LabelControl lblModCount;
        private System.Windows.Forms.TextBox txtModCount;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private System.Windows.Forms.ListBox lstAccessPointType;
        private System.Windows.Forms.TextBox txtNoOfTransactions;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private System.Windows.Forms.CheckBox chkNoOfTrans;
        private System.Windows.Forms.ComboBox cmbAccessPoints;
        private DevExpress.XtraEditors.LabelControl labelControl6;
    }
}