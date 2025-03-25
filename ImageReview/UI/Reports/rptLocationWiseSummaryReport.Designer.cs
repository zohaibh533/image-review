using DevExpress.DataAccess.Sql;
using DevExpress.XtraReports.UI;

namespace ImageReview.Reports
{
    partial class rptLocationWiseSummaryReport
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary4 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary5 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptLocationWiseSummaryReport));
            DevExpress.XtraReports.UI.XRSummary xrSummary3 = new DevExpress.XtraReports.UI.XRSummary();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel30 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.formattingRule2 = new DevExpress.XtraReports.UI.FormattingRule();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.xrLabel59 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPageInfo4 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrPageInfo3 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.pmActionType = new DevExpress.XtraReports.Parameters.Parameter();
            this.pmSelectionTimeTo = new DevExpress.XtraReports.Parameters.Parameter();
            this.pmSelectionTimeFrom = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.FieldCaption = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DataField = new DevExpress.XtraReports.UI.XRControlStyle();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.pmUser = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.formattingRule1 = new DevExpress.XtraReports.UI.FormattingRule();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrPanel1 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLabel65 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPanel3 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.cfTotal = new DevExpress.XtraReports.UI.CalculatedField();
            this.cfTimeName = new DevExpress.XtraReports.UI.CalculatedField();
            this.cfPercentageOfTotal = new DevExpress.XtraReports.UI.CalculatedField();
            this.cfActionTimeTxt = new DevExpress.XtraReports.UI.CalculatedField();
            this.cfLocationsCap = new DevExpress.XtraReports.UI.CalculatedField();
            this.cfAPCap = new DevExpress.XtraReports.UI.CalculatedField();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPanel4 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel35 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel38 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel44 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel47 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel49 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel51 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel52 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel53 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel54 = new DevExpress.XtraReports.UI.XRLabel();
            this.pmPlateNo = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel22 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel23 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel22,
            this.xrLabel30,
            this.xrLabel18,
            this.xrLabel17,
            this.xrLabel11,
            this.xrLabel10,
            this.xrLabel3,
            this.xrLine2,
            this.xrLabel1});
            this.Detail.HeightF = 40.375F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.SortFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("SourceName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel30
            // 
            this.xrLabel30.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.cfActionTimeTxt", "{0:}")});
            this.xrLabel30.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.xrLabel30.LocationFloat = new DevExpress.Utils.PointFloat(602.8457F, 5F);
            this.xrLabel30.Name = "xrLabel30";
            this.xrLabel30.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel30.SizeF = new System.Drawing.SizeF(111.3324F, 23F);
            this.xrLabel30.StylePriority.UseFont = false;
            this.xrLabel30.StylePriority.UseTextAlignment = false;
            this.xrLabel30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel18
            // 
            this.xrLabel18.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.cfPercentageOfTotal", "{0:0.00}")});
            this.xrLabel18.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.xrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(522.9799F, 5F);
            this.xrLabel18.Name = "xrLabel18";
            this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel18.SizeF = new System.Drawing.SizeF(79.86575F, 23F);
            this.xrLabel18.StylePriority.UseFont = false;
            this.xrLabel18.StylePriority.UseTextAlignment = false;
            this.xrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel17
            // 
            this.xrLabel17.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.cfTotal")});
            this.xrLabel17.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(442.9449F, 5F);
            this.xrLabel17.Name = "xrLabel17";
            this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel17.SizeF = new System.Drawing.SizeF(80.03497F, 23F);
            this.xrLabel17.StylePriority.UseFont = false;
            this.xrLabel17.StylePriority.UseTextAlignment = false;
            this.xrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel11
            // 
            this.xrLabel11.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Ignored")});
            this.xrLabel11.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(360.7891F, 5F);
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(80.03497F, 23F);
            this.xrLabel11.StylePriority.UseFont = false;
            this.xrLabel11.StylePriority.UseTextAlignment = false;
            this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel10
            // 
            this.xrLabel10.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Correction")});
            this.xrLabel10.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(200.4056F, 5F);
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(80.03497F, 23F);
            this.xrLabel10.StylePriority.UseFont = false;
            this.xrLabel10.StylePriority.UseTextAlignment = false;
            this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel3
            // 
            this.xrLabel3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.LocationName")});
            this.xrLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(59.39891F, 5F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(141.0067F, 23F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLine2
            // 
            this.xrLine2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.xrLine2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(10F, 33F);
            this.xrLine2.Name = "xrLine2";
            this.xrLine2.SizeF = new System.Drawing.SizeF(709F, 7.375004F);
            this.xrLine2.StylePriority.UseBorderColor = false;
            this.xrLine2.StylePriority.UseForeColor = false;
            // 
            // xrLabel1
            // 
            this.xrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.SourceName")});
            this.xrLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(20F, 5F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(39.39892F, 23F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            xrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.RecordNumber;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrLabel1.Summary = xrSummary1;
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // formattingRule2
            // 
            this.formattingRule2.Condition = "[Remarks]=\'\'";
            // 
            // 
            // 
            this.formattingRule2.Formatting.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.formattingRule2.Name = "formattingRule2";
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel59,
            this.xrPageInfo4,
            this.xrPageInfo3});
            this.TopMargin.HeightF = 47F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel59
            // 
            this.xrLabel59.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel59.LocationFloat = new DevExpress.Utils.PointFloat(9.999998F, 20.26323F);
            this.xrLabel59.Name = "xrLabel59";
            this.xrLabel59.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel59.SizeF = new System.Drawing.SizeF(536.4583F, 23F);
            this.xrLabel59.StylePriority.UseFont = false;
            this.xrLabel59.Text = "Image Review System - Reporting";
            // 
            // xrPageInfo4
            // 
            this.xrPageInfo4.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.xrPageInfo4.Format = "{0:dd/MM/yy h:mm tt}";
            this.xrPageInfo4.LocationFloat = new DevExpress.Utils.PointFloat(577.5965F, 27.12501F);
            this.xrPageInfo4.Name = "xrPageInfo4";
            this.xrPageInfo4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo4.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.xrPageInfo4.SizeF = new System.Drawing.SizeF(141.4035F, 19.87499F);
            this.xrPageInfo4.StyleName = "PageInfo";
            this.xrPageInfo4.StylePriority.UseFont = false;
            this.xrPageInfo4.StylePriority.UseTextAlignment = false;
            this.xrPageInfo4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrPageInfo3
            // 
            this.xrPageInfo3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.xrPageInfo3.Format = "Page {0} of {1}";
            this.xrPageInfo3.LocationFloat = new DevExpress.Utils.PointFloat(577.5966F, 11.65341F);
            this.xrPageInfo3.Name = "xrPageInfo3";
            this.xrPageInfo3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo3.SizeF = new System.Drawing.SizeF(141.4034F, 15.4716F);
            this.xrPageInfo3.StyleName = "PageInfo";
            this.xrPageInfo3.StylePriority.UseFont = false;
            this.xrPageInfo3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // pmActionType
            // 
            this.pmActionType.Description = "pmActionType";
            this.pmActionType.Name = "pmActionType";
            this.pmActionType.Visible = false;
            // 
            // pmSelectionTimeTo
            // 
            this.pmSelectionTimeTo.Description = "pmSelectionTimeTo";
            this.pmSelectionTimeTo.Name = "pmSelectionTimeTo";
            this.pmSelectionTimeTo.Visible = false;
            // 
            // pmSelectionTimeFrom
            // 
            this.pmSelectionTimeFrom.Description = "pmSelectionTimeFrom";
            this.pmSelectionTimeFrom.Name = "pmSelectionTimeFrom";
            this.pmSelectionTimeFrom.Visible = false;
            // 
            // xrLabel14
            // 
            this.xrLabel14.BorderWidth = 0F;
            this.xrLabel14.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(49.39892F, 9.99999F);
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel14.SizeF = new System.Drawing.SizeF(141.0067F, 26.33334F);
            this.xrLabel14.StyleName = "FieldCaption";
            this.xrLabel14.StylePriority.UseBorderWidth = false;
            this.xrLabel14.StylePriority.UseFont = false;
            this.xrLabel14.StylePriority.UseForeColor = false;
            this.xrLabel14.StylePriority.UseTextAlignment = false;
            this.xrLabel14.Text = "Location";
            this.xrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 18F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.BorderColor = System.Drawing.Color.Black;
            this.Title.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Title.BorderWidth = 1F;
            this.Title.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.Title.ForeColor = System.Drawing.Color.Maroon;
            this.Title.Name = "Title";
            // 
            // FieldCaption
            // 
            this.FieldCaption.BackColor = System.Drawing.Color.Transparent;
            this.FieldCaption.BorderColor = System.Drawing.Color.Black;
            this.FieldCaption.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.FieldCaption.BorderWidth = 1F;
            this.FieldCaption.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.FieldCaption.ForeColor = System.Drawing.Color.Maroon;
            this.FieldCaption.Name = "FieldCaption";
            // 
            // PageInfo
            // 
            this.PageInfo.BackColor = System.Drawing.Color.Transparent;
            this.PageInfo.BorderColor = System.Drawing.Color.Black;
            this.PageInfo.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.PageInfo.BorderWidth = 1F;
            this.PageInfo.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.PageInfo.ForeColor = System.Drawing.Color.Black;
            this.PageInfo.Name = "PageInfo";
            // 
            // DataField
            // 
            this.DataField.BackColor = System.Drawing.Color.Transparent;
            this.DataField.BorderColor = System.Drawing.Color.Black;
            this.DataField.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.DataField.BorderWidth = 1F;
            this.DataField.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.DataField.ForeColor = System.Drawing.Color.Black;
            this.DataField.Name = "DataField";
            this.DataField.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel4,
            this.xrLabel21,
            this.xrLabel20,
            this.xrPictureBox1,
            this.xrLabel9});
            this.ReportHeader.HeightF = 220.4167F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // pmUser
            // 
            this.pmUser.Description = "pmUser";
            this.pmUser.Name = "pmUser";
            this.pmUser.Visible = false;
            // 
            // xrLabel9
            // 
            this.xrLabel9.BorderWidth = 0F;
            this.xrLabel9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(300F, 103.3333F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(139.345F, 22.16667F);
            this.xrLabel9.StylePriority.UseBorderWidth = false;
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.StylePriority.UseTextAlignment = false;
            this.xrLabel9.Text = "Applied Filters";
            this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // formattingRule1
            // 
            // 
            // 
            // 
            this.formattingRule1.Formatting.Visible = DevExpress.Utils.DefaultBoolean.True;
            this.formattingRule1.Name = "formattingRule1";
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel1});
            this.PageHeader.HeightF = 62.5F;
            this.PageHeader.Name = "PageHeader";
            // 
            // xrPanel1
            // 
            this.xrPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.xrPanel1.BorderWidth = 0F;
            this.xrPanel1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel19,
            this.xrLabel12,
            this.xrLabel15,
            this.xrLabel6,
            this.xrLabel8,
            this.xrLabel5,
            this.xrLabel14,
            this.xrLabel65});
            this.xrPanel1.LocationFloat = new DevExpress.Utils.PointFloat(9.99999F, 10.00001F);
            this.xrPanel1.Name = "xrPanel1";
            this.xrPanel1.SizeF = new System.Drawing.SizeF(709.0001F, 47.91666F);
            this.xrPanel1.StylePriority.UseBackColor = false;
            this.xrPanel1.StylePriority.UseBorderWidth = false;
            // 
            // xrLabel65
            // 
            this.xrLabel65.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel65.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.xrLabel65.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 9.99999F);
            this.xrLabel65.Name = "xrLabel65";
            this.xrLabel65.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel65.SizeF = new System.Drawing.SizeF(39.39892F, 26.33332F);
            this.xrLabel65.StyleName = "FieldCaption";
            this.xrLabel65.StylePriority.UseFont = false;
            this.xrLabel65.StylePriority.UseForeColor = false;
            this.xrLabel65.StylePriority.UseTextAlignment = false;
            this.xrLabel65.Text = "#";
            this.xrLabel65.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel2
            // 
            this.xrLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(9.99993F, 11.58333F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(153.069F, 26.33334F);
            this.xrLabel2.StyleName = "FieldCaption";
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseForeColor = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "Total :";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel4
            // 
            this.xrLabel4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.cfTotal")});
            this.xrLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(432.9449F, 11.58333F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(80.03497F, 26.33333F);
            this.xrLabel4.StyleName = "FieldCaption";
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseForeColor = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrLabel4.Summary = xrSummary2;
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrPanel3
            // 
            this.xrPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.xrPanel3.BorderWidth = 0F;
            this.xrPanel3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel23,
            this.xrLabel16,
            this.xrLabel13,
            this.xrLabel2,
            this.xrLabel4});
            this.xrPanel3.LocationFloat = new DevExpress.Utils.PointFloat(10.00007F, 9.999974F);
            this.xrPanel3.Name = "xrPanel3";
            this.xrPanel3.SizeF = new System.Drawing.SizeF(709.0001F, 47.91666F);
            this.xrPanel3.StylePriority.UseBackColor = false;
            this.xrPanel3.StylePriority.UseBorderWidth = false;
            // 
            // xrLabel16
            // 
            this.xrLabel16.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Correction")});
            this.xrLabel16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(190.4055F, 11.58333F);
            this.xrLabel16.Name = "xrLabel16";
            this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel16.SizeF = new System.Drawing.SizeF(80.03497F, 26.33333F);
            this.xrLabel16.StyleName = "FieldCaption";
            this.xrLabel16.StylePriority.UseFont = false;
            this.xrLabel16.StylePriority.UseForeColor = false;
            this.xrLabel16.StylePriority.UseTextAlignment = false;
            xrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrLabel16.Summary = xrSummary4;
            this.xrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel13
            // 
            this.xrLabel13.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Ignored")});
            this.xrLabel13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(350.7891F, 11.58333F);
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel13.SizeF = new System.Drawing.SizeF(80.03497F, 26.33333F);
            this.xrLabel13.StyleName = "FieldCaption";
            this.xrLabel13.StylePriority.UseFont = false;
            this.xrLabel13.StylePriority.UseForeColor = false;
            this.xrLabel13.StylePriority.UseTextAlignment = false;
            xrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrLabel13.Summary = xrSummary5;
            this.xrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // PageFooter
            // 
            this.PageFooter.HeightF = 0.8333333F;
            this.PageFooter.Name = "PageFooter";
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel3});
            this.ReportFooter.HeightF = 74.79166F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "localhost_Connection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery1.Name = "Query";
            customSqlQuery1.Sql = "SELECT \'\' as LocationName,0 as LocationID,\r\n0 as Correction,\r\n0 as Ignored,\r\n0 as" +
    " Forwarded,\r\n0 AS total,0 AS TimeDiffSec";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // cfTotal
            // 
            this.cfTotal.DataMember = "Query";
            this.cfTotal.Expression = "[Correction]+[Ignored]+[Forwarded]";
            this.cfTotal.Name = "cfTotal";
            // 
            // cfTimeName
            // 
            this.cfTimeName.Expression = "Iif([Parameters.pmIsCorrectionTime]==0, \'Correction Time From:\'  , \'Captured Time" +
    " From:\')";
            this.cfTimeName.Name = "cfTimeName";
            // 
            // cfPercentageOfTotal
            // 
            this.cfPercentageOfTotal.DataMember = "Query";
            this.cfPercentageOfTotal.Expression = "[cfTotal]/ sum([cfTotal])*100.00";
            this.cfPercentageOfTotal.Name = "cfPercentageOfTotal";
            // 
            // cfActionTimeTxt
            // 
            this.cfActionTimeTxt.DataMember = "Query";
            this.cfActionTimeTxt.Expression = "floor([TimeDiffSec]/60)+\':\' + toint([TimeDiffSec]- ( floor([TimeDiffSec]/60) *60 " +
    "))";
            this.cfActionTimeTxt.Name = "cfActionTimeTxt";
            // 
            // cfLocationsCap
            // 
            this.cfLocationsCap.Expression = "iif([Parameters.pmLocationExclude],\'Excluded Locations:\',\'Locations:\')";
            this.cfLocationsCap.Name = "cfLocationsCap";
            // 
            // cfAPCap
            // 
            this.cfAPCap.Expression = "iif([Parameters.pmAccessPointExclude],\'Excluded Access Points:\',\'Access Points:\')" +
    "";
            this.cfAPCap.Name = "cfAPCap";
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("xrPictureBox1.Image")));
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(10.00018F, 10F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(236.4109F, 90.63256F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage;
            // 
            // xrLabel21
            // 
            this.xrLabel21.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel21.LocationFloat = new DevExpress.Utils.PointFloat(257.8902F, 55.18657F);
            this.xrLabel21.Name = "xrLabel21";
            this.xrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel21.SizeF = new System.Drawing.SizeF(461.11F, 33.01514F);
            this.xrLabel21.StylePriority.UseFont = false;
            this.xrLabel21.StylePriority.UseTextAlignment = false;
            this.xrLabel21.Text = "Location Wise Verification Summary";
            this.xrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel20
            // 
            this.xrLabel20.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.xrLabel20.LocationFloat = new DevExpress.Utils.PointFloat(257.8902F, 27.21497F);
            this.xrLabel20.Name = "xrLabel20";
            this.xrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel20.SizeF = new System.Drawing.SizeF(461.11F, 27.9716F);
            this.xrLabel20.StylePriority.UseBorderColor = false;
            this.xrLabel20.StylePriority.UseFont = false;
            this.xrLabel20.StylePriority.UseForeColor = false;
            this.xrLabel20.StylePriority.UseTextAlignment = false;
            this.xrLabel20.Text = "IMAGE REVIEW SYSTEM";
            this.xrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrPanel4
            // 
            this.xrPanel4.BorderColor = System.Drawing.Color.Silver;
            this.xrPanel4.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrPanel4.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel7,
            this.xrLabel35,
            this.xrLabel38,
            this.xrLabel44,
            this.xrLabel47,
            this.xrLabel49,
            this.xrLabel51,
            this.xrLabel52,
            this.xrLabel53,
            this.xrLabel54});
            this.xrPanel4.LocationFloat = new DevExpress.Utils.PointFloat(10.00029F, 137.5F);
            this.xrPanel4.Name = "xrPanel4";
            this.xrPanel4.SizeF = new System.Drawing.SizeF(708.9999F, 75.89586F);
            this.xrPanel4.StylePriority.UseBorderColor = false;
            this.xrPanel4.StylePriority.UseBorders = false;
            // 
            // xrLabel7
            // 
            this.xrLabel7.BorderWidth = 0F;
            this.xrLabel7.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(463.946F, 10F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(72.51218F, 18F);
            this.xrLabel7.StylePriority.UseBorderWidth = false;
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.Text = "Action Type:";
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel35
            // 
            this.xrLabel35.BorderWidth = 0F;
            this.xrLabel35.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.pmPlateNo, "Text", "")});
            this.xrLabel35.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            this.xrLabel35.LocationFloat = new DevExpress.Utils.PointFloat(295.6363F, 41.30566F);
            this.xrLabel35.Name = "xrLabel35";
            this.xrLabel35.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel35.SizeF = new System.Drawing.SizeF(404.0775F, 18.00002F);
            this.xrLabel35.StylePriority.UseBorderWidth = false;
            this.xrLabel35.StylePriority.UseFont = false;
            this.xrLabel35.StylePriority.UseTextAlignment = false;
            this.xrLabel35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel38
            // 
            this.xrLabel38.BorderWidth = 0F;
            this.xrLabel38.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel38.LocationFloat = new DevExpress.Utils.PointFloat(236.4108F, 41.30567F);
            this.xrLabel38.Name = "xrLabel38";
            this.xrLabel38.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel38.SizeF = new System.Drawing.SizeF(58.51166F, 18F);
            this.xrLabel38.StylePriority.UseBorderWidth = false;
            this.xrLabel38.StylePriority.UseFont = false;
            this.xrLabel38.StylePriority.UseTextAlignment = false;
            this.xrLabel38.Text = "Plate No:";
            this.xrLabel38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel44
            // 
            this.xrLabel44.BorderWidth = 0F;
            this.xrLabel44.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.pmUser, "Text", "")});
            this.xrLabel44.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            this.xrLabel44.LocationFloat = new DevExpress.Utils.PointFloat(62.98785F, 41.30563F);
            this.xrLabel44.Name = "xrLabel44";
            this.xrLabel44.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel44.SizeF = new System.Drawing.SizeF(173.4229F, 18F);
            this.xrLabel44.StylePriority.UseBorderWidth = false;
            this.xrLabel44.StylePriority.UseFont = false;
            this.xrLabel44.StylePriority.UseTextAlignment = false;
            this.xrLabel44.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel47
            // 
            this.xrLabel47.BorderWidth = 0F;
            this.xrLabel47.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.pmSelectionTimeFrom, "Text", "")});
            this.xrLabel47.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            this.xrLabel47.LocationFloat = new DevExpress.Utils.PointFloat(88.07737F, 10F);
            this.xrLabel47.Name = "xrLabel47";
            this.xrLabel47.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel47.SizeF = new System.Drawing.SizeF(148.3334F, 18F);
            this.xrLabel47.StylePriority.UseBorderWidth = false;
            this.xrLabel47.StylePriority.UseFont = false;
            this.xrLabel47.StylePriority.UseTextAlignment = false;
            this.xrLabel47.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel49
            // 
            this.xrLabel49.BorderWidth = 0F;
            this.xrLabel49.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel49.LocationFloat = new DevExpress.Utils.PointFloat(16.97639F, 41.30564F);
            this.xrLabel49.Name = "xrLabel49";
            this.xrLabel49.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel49.SizeF = new System.Drawing.SizeF(46.01166F, 17.99998F);
            this.xrLabel49.StylePriority.UseBorderWidth = false;
            this.xrLabel49.StylePriority.UseFont = false;
            this.xrLabel49.StylePriority.UseTextAlignment = false;
            this.xrLabel49.Text = "Users:";
            this.xrLabel49.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel51
            // 
            this.xrLabel51.BorderWidth = 0F;
            this.xrLabel51.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.pmActionType, "Text", "")});
            this.xrLabel51.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            this.xrLabel51.LocationFloat = new DevExpress.Utils.PointFloat(536.4581F, 10.00006F);
            this.xrLabel51.Name = "xrLabel51";
            this.xrLabel51.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel51.SizeF = new System.Drawing.SizeF(167.7197F, 18F);
            this.xrLabel51.StylePriority.UseBorderWidth = false;
            this.xrLabel51.StylePriority.UseFont = false;
            this.xrLabel51.StylePriority.UseTextAlignment = false;
            this.xrLabel51.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel52
            // 
            this.xrLabel52.BorderWidth = 0F;
            this.xrLabel52.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel52.LocationFloat = new DevExpress.Utils.PointFloat(16.97639F, 10F);
            this.xrLabel52.Name = "xrLabel52";
            this.xrLabel52.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel52.SizeF = new System.Drawing.SizeF(70.67444F, 18F);
            this.xrLabel52.StylePriority.UseBorderWidth = false;
            this.xrLabel52.StylePriority.UseFont = false;
            this.xrLabel52.StylePriority.UseTextAlignment = false;
            this.xrLabel52.Text = "From Time:";
            this.xrLabel52.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel53
            // 
            this.xrLabel53.BorderWidth = 0F;
            this.xrLabel53.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.pmSelectionTimeTo, "Text", "")});
            this.xrLabel53.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            this.xrLabel53.LocationFloat = new DevExpress.Utils.PointFloat(300.8143F, 10F);
            this.xrLabel53.Name = "xrLabel53";
            this.xrLabel53.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel53.SizeF = new System.Drawing.SizeF(163.1316F, 18F);
            this.xrLabel53.StylePriority.UseBorderWidth = false;
            this.xrLabel53.StylePriority.UseFont = false;
            this.xrLabel53.StylePriority.UseTextAlignment = false;
            this.xrLabel53.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel54
            // 
            this.xrLabel54.BorderWidth = 0F;
            this.xrLabel54.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel54.LocationFloat = new DevExpress.Utils.PointFloat(236.4108F, 10F);
            this.xrLabel54.Name = "xrLabel54";
            this.xrLabel54.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel54.SizeF = new System.Drawing.SizeF(59.22552F, 18F);
            this.xrLabel54.StylePriority.UseBorderWidth = false;
            this.xrLabel54.StylePriority.UseFont = false;
            this.xrLabel54.StylePriority.UseTextAlignment = false;
            this.xrLabel54.Text = "To Time:";
            this.xrLabel54.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // pmPlateNo
            // 
            this.pmPlateNo.Description = "pmPlateNo";
            this.pmPlateNo.Name = "pmPlateNo";
            this.pmPlateNo.Visible = false;
            // 
            // xrLabel19
            // 
            this.xrLabel19.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(592.8457F, 10F);
            this.xrLabel19.Name = "xrLabel19";
            this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel19.SizeF = new System.Drawing.SizeF(111.3324F, 26.33332F);
            this.xrLabel19.StyleName = "FieldCaption";
            this.xrLabel19.StylePriority.UseFont = false;
            this.xrLabel19.StylePriority.UseForeColor = false;
            this.xrLabel19.StylePriority.UseTextAlignment = false;
            this.xrLabel19.Text = "Avg Time Spent";
            this.xrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel12
            // 
            this.xrLabel12.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(512.9799F, 10F);
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(79.86575F, 26.33332F);
            this.xrLabel12.StyleName = "FieldCaption";
            this.xrLabel12.StylePriority.UseFont = false;
            this.xrLabel12.StylePriority.UseForeColor = false;
            this.xrLabel12.StylePriority.UseTextAlignment = false;
            this.xrLabel12.Text = "% of Total";
            this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel15
            // 
            this.xrLabel15.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(432.9449F, 10F);
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel15.SizeF = new System.Drawing.SizeF(80.03497F, 26.33333F);
            this.xrLabel15.StyleName = "FieldCaption";
            this.xrLabel15.StylePriority.UseFont = false;
            this.xrLabel15.StylePriority.UseForeColor = false;
            this.xrLabel15.StylePriority.UseTextAlignment = false;
            this.xrLabel15.Text = "Total";
            this.xrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel6
            // 
            this.xrLabel6.BorderWidth = 0F;
            this.xrLabel6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(350.7891F, 10F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(80.03497F, 26.33334F);
            this.xrLabel6.StyleName = "FieldCaption";
            this.xrLabel6.StylePriority.UseBorderWidth = false;
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UseForeColor = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = "Ignored";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel8
            // 
            this.xrLabel8.BorderWidth = 0F;
            this.xrLabel8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(270.4406F, 10F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(80.03497F, 26.33335F);
            this.xrLabel8.StyleName = "FieldCaption";
            this.xrLabel8.StylePriority.UseBorderWidth = false;
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.StylePriority.UseForeColor = false;
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            this.xrLabel8.Text = "Forwarded";
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel5
            // 
            this.xrLabel5.BorderWidth = 0F;
            this.xrLabel5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(190.4056F, 10F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(80.03497F, 26.33334F);
            this.xrLabel5.StyleName = "FieldCaption";
            this.xrLabel5.StylePriority.UseBorderWidth = false;
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UseForeColor = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "Verified";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel22
            // 
            this.xrLabel22.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Forwarded")});
            this.xrLabel22.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.xrLabel22.LocationFloat = new DevExpress.Utils.PointFloat(280.4406F, 5F);
            this.xrLabel22.Name = "xrLabel22";
            this.xrLabel22.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel22.SizeF = new System.Drawing.SizeF(80.03497F, 23F);
            this.xrLabel22.StylePriority.UseFont = false;
            this.xrLabel22.StylePriority.UseTextAlignment = false;
            this.xrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel23
            // 
            this.xrLabel23.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Forwarded")});
            this.xrLabel23.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.xrLabel23.LocationFloat = new DevExpress.Utils.PointFloat(270.4406F, 11.58333F);
            this.xrLabel23.Name = "xrLabel23";
            this.xrLabel23.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel23.SizeF = new System.Drawing.SizeF(80.03497F, 26.33333F);
            this.xrLabel23.StyleName = "FieldCaption";
            this.xrLabel23.StylePriority.UseFont = false;
            this.xrLabel23.StylePriority.UseForeColor = false;
            this.xrLabel23.StylePriority.UseTextAlignment = false;
            xrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrLabel23.Summary = xrSummary3;
            this.xrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // rptLocationWiseSummaryReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.PageHeader,
            this.PageFooter,
            this.ReportFooter});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.cfTimeName,
            this.cfTotal,
            this.cfPercentageOfTotal,
            this.cfActionTimeTxt,
            this.cfLocationsCap,
            this.cfAPCap});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.DataMember = "Query";
            this.DataSource = this.sqlDataSource1;
            this.FormattingRuleSheet.AddRange(new DevExpress.XtraReports.UI.FormattingRule[] {
            this.formattingRule1,
            this.formattingRule2});
            this.Margins = new System.Drawing.Printing.Margins(48, 51, 47, 18);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.pmSelectionTimeFrom,
            this.pmSelectionTimeTo,
            this.pmActionType,
            this.pmUser,
            this.pmPlateNo});
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.FieldCaption,
            this.PageInfo,
            this.DataField});
            this.Version = "15.2";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRControlStyle Title;
        private DevExpress.XtraReports.UI.XRControlStyle FieldCaption;
        private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
        private DevExpress.XtraReports.UI.XRControlStyle DataField;
        private DevExpress.XtraReports.UI.XRLabel xrLabel14;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo3;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo4;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel xrLabel59;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.FormattingRule formattingRule2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel65;
        public DevExpress.XtraReports.UI.FormattingRule formattingRule1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLine xrLine2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRPanel xrPanel1;
        private DevExpress.XtraReports.UI.XRPanel xrPanel3;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.Parameters.Parameter pmSelectionTimeTo;
        private DevExpress.XtraReports.Parameters.Parameter pmSelectionTimeFrom;
        private DevExpress.XtraReports.Parameters.Parameter pmActionType;
        private DevExpress.XtraReports.Parameters.Parameter pmUser;
        private DevExpress.XtraReports.UI.XRLabel xrLabel9;
        private SqlDataSource sqlDataSource1;
        private XRLabel xrLabel3;
        private XRLabel xrLabel11;
        private XRLabel xrLabel10;
        private XRLabel xrLabel16;
        private XRLabel xrLabel13;
        private XRLabel xrLabel17;
        private CalculatedField cfTotal;
        private CalculatedField cfTimeName;
        private XRLabel xrLabel18;
        private CalculatedField cfPercentageOfTotal;
        private XRLabel xrLabel30;
        private CalculatedField cfActionTimeTxt;
        private CalculatedField cfLocationsCap;
        private CalculatedField cfAPCap;
        private XRPictureBox xrPictureBox1;
        private XRLabel xrLabel21;
        private XRLabel xrLabel20;
        private XRPanel xrPanel4;
        private XRLabel xrLabel7;
        private XRLabel xrLabel35;
        private XRLabel xrLabel38;
        private XRLabel xrLabel44;
        private XRLabel xrLabel47;
        private XRLabel xrLabel49;
        private XRLabel xrLabel51;
        private XRLabel xrLabel52;
        private XRLabel xrLabel53;
        private XRLabel xrLabel54;
        private DevExpress.XtraReports.Parameters.Parameter pmPlateNo;
        private XRLabel xrLabel19;
        private XRLabel xrLabel12;
        private XRLabel xrLabel15;
        private XRLabel xrLabel6;
        private XRLabel xrLabel8;
        private XRLabel xrLabel5;
        private XRLabel xrLabel22;
        private XRLabel xrLabel23;
    }
}
