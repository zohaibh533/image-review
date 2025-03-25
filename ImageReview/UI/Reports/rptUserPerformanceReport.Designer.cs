using DevExpress.DataAccess.Sql;
using DevExpress.XtraReports.UI;

namespace ImageReview.Reports
{
    partial class rptUserPerformanceReport
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
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptUserPerformanceReport));
            DevExpress.XtraReports.UI.XRSummary xrSummary6 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary5 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary4 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary3 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.formattingRule2 = new DevExpress.XtraReports.UI.FormattingRule();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.xrLabel59 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPageInfo4 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrPageInfo3 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.pmSelectionTimeTo = new DevExpress.XtraReports.Parameters.Parameter();
            this.pmSelectionTimeFrom = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.FieldCaption = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DataField = new DevExpress.XtraReports.UI.XRControlStyle();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrLabel47 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel52 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel53 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel54 = new DevExpress.XtraReports.UI.XRLabel();
            this.formattingRule1 = new DevExpress.XtraReports.UI.FormattingRule();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrPanel1 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel65 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPanel3 = new DevExpress.XtraReports.UI.XRPanel();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel22 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel23 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel24 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel25 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel26 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel27 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel28 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel29 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel30 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel31 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel32 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel33 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel34 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel35 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel36 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel37 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel38 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel39 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel40 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel34,
            this.xrLabel35,
            this.xrLabel32,
            this.xrLabel33,
            this.xrLabel30,
            this.xrLabel31,
            this.xrLabel28,
            this.xrLabel29,
            this.xrLabel27,
            this.xrLabel26,
            this.xrLabel25,
            this.xrLabel24,
            this.xrLabel3,
            this.xrLine2,
            this.xrLabel1});
            this.Detail.HeightF = 45.375F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.SortFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("SourceName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel3
            // 
            this.xrLabel3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.username")});
            this.xrLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(49.39899F, 10F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(136.4962F, 23F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "xrLabel3";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLine2
            // 
            this.xrLine2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.xrLine2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 37.99998F);
            this.xrLine2.Name = "xrLine2";
            this.xrLine2.SizeF = new System.Drawing.SizeF(1050F, 7.375004F);
            this.xrLine2.StylePriority.UseBorderColor = false;
            this.xrLine2.StylePriority.UseForeColor = false;
            // 
            // xrLabel1
            // 
            this.xrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.SourceName")});
            this.xrLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(10.00008F, 10F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(39.39892F, 23F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            xrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.RecordNumber;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrLabel1.Summary = xrSummary1;
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
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
            this.xrPageInfo4.LocationFloat = new DevExpress.Utils.PointFloat(918.5965F, 27.12501F);
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
            this.xrPageInfo3.LocationFloat = new DevExpress.Utils.PointFloat(918.5966F, 11.65341F);
            this.xrPageInfo3.Name = "xrPageInfo3";
            this.xrPageInfo3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo3.SizeF = new System.Drawing.SizeF(141.4034F, 15.4716F);
            this.xrPageInfo3.StyleName = "PageInfo";
            this.xrPageInfo3.StylePriority.UseFont = false;
            this.xrPageInfo3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
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
            // xrLabel20
            // 
            this.xrLabel20.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.xrLabel20.LocationFloat = new DevExpress.Utils.PointFloat(257.89F, 2.554932F);
            this.xrLabel20.Name = "xrLabel20";
            this.xrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel20.SizeF = new System.Drawing.SizeF(802.11F, 27.9716F);
            this.xrLabel20.StylePriority.UseBorderColor = false;
            this.xrLabel20.StylePriority.UseFont = false;
            this.xrLabel20.StylePriority.UseForeColor = false;
            this.xrLabel20.StylePriority.UseTextAlignment = false;
            this.xrLabel20.Text = "IMAGE REVIEW SYSTEM";
            this.xrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel21
            // 
            this.xrLabel21.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel21.LocationFloat = new DevExpress.Utils.PointFloat(257.89F, 30.52653F);
            this.xrLabel21.Name = "xrLabel21";
            this.xrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel21.SizeF = new System.Drawing.SizeF(802.11F, 33.01514F);
            this.xrLabel21.StylePriority.UseFont = false;
            this.xrLabel21.StylePriority.UseTextAlignment = false;
            this.xrLabel21.Text = "User Performance Report";
            this.xrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel14
            // 
            this.xrLabel14.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel14.BorderWidth = 1F;
            this.xrLabel14.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(39.39901F, 66.16666F);
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel14.SizeF = new System.Drawing.SizeF(136.4962F, 26.33334F);
            this.xrLabel14.StyleName = "FieldCaption";
            this.xrLabel14.StylePriority.UseBorders = false;
            this.xrLabel14.StylePriority.UseBorderWidth = false;
            this.xrLabel14.StylePriority.UseFont = false;
            this.xrLabel14.StylePriority.UseForeColor = false;
            this.xrLabel14.StylePriority.UseTextAlignment = false;
            this.xrLabel14.Text = "User";
            this.xrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 7.999979F;
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
            this.FieldCaption.Font = new System.Drawing.Font("Arial", 10F);
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
            this.xrLabel20,
            this.xrLabel21,
            this.xrPictureBox1,
            this.xrLabel52,
            this.xrLabel47,
            this.xrLabel53,
            this.xrLabel54});
            this.ReportHeader.HeightF = 108.75F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrLabel47
            // 
            this.xrLabel47.BorderWidth = 0F;
            this.xrLabel47.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.pmSelectionTimeFrom, "Text", "")});
            this.xrLabel47.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            this.xrLabel47.LocationFloat = new DevExpress.Utils.PointFloat(328.991F, 75.18748F);
            this.xrLabel47.Name = "xrLabel47";
            this.xrLabel47.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel47.SizeF = new System.Drawing.SizeF(148.3334F, 18F);
            this.xrLabel47.StylePriority.UseBorderWidth = false;
            this.xrLabel47.StylePriority.UseFont = false;
            this.xrLabel47.StylePriority.UseTextAlignment = false;
            this.xrLabel47.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel52
            // 
            this.xrLabel52.BorderWidth = 0F;
            this.xrLabel52.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel52.LocationFloat = new DevExpress.Utils.PointFloat(257.89F, 75.18748F);
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
            this.xrLabel53.LocationFloat = new DevExpress.Utils.PointFloat(541.728F, 75.18748F);
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
            this.xrLabel54.LocationFloat = new DevExpress.Utils.PointFloat(477.3244F, 75.18748F);
            this.xrLabel54.Name = "xrLabel54";
            this.xrLabel54.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel54.SizeF = new System.Drawing.SizeF(59.22552F, 18F);
            this.xrLabel54.StylePriority.UseBorderWidth = false;
            this.xrLabel54.StylePriority.UseFont = false;
            this.xrLabel54.StylePriority.UseTextAlignment = false;
            this.xrLabel54.Text = "To Time:";
            this.xrLabel54.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
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
            this.PageHeader.HeightF = 102.5F;
            this.PageHeader.Name = "PageHeader";
            // 
            // xrPanel1
            // 
            this.xrPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.xrPanel1.BorderWidth = 0F;
            this.xrPanel1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel23,
            this.xrLabel12,
            this.xrLabel15,
            this.xrLabel19,
            this.xrLabel17,
            this.xrLabel18,
            this.xrLabel22,
            this.xrLabel11,
            this.xrLabel13,
            this.xrLabel16,
            this.xrLabel7,
            this.xrLabel9,
            this.xrLabel10,
            this.xrLabel4,
            this.xrLabel8,
            this.xrLabel6,
            this.xrLabel5,
            this.xrLabel14,
            this.xrLabel65});
            this.xrPanel1.LocationFloat = new DevExpress.Utils.PointFloat(9.999988F, 0F);
            this.xrPanel1.Name = "xrPanel1";
            this.xrPanel1.SizeF = new System.Drawing.SizeF(1050F, 102.5F);
            this.xrPanel1.StylePriority.UseBackColor = false;
            this.xrPanel1.StylePriority.UseBorderWidth = false;
            // 
            // xrLabel8
            // 
            this.xrLabel8.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel8.BorderWidth = 1F;
            this.xrLabel8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(341.6501F, 66.16666F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(56.70161F, 26.33335F);
            this.xrLabel8.StyleName = "FieldCaption";
            this.xrLabel8.StylePriority.UseBorders = false;
            this.xrLabel8.StylePriority.UseBorderWidth = false;
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.StylePriority.UseForeColor = false;
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            this.xrLabel8.Text = "Count";
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel6
            // 
            this.xrLabel6.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel6.BorderWidth = 1F;
            this.xrLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(398.3517F, 66.16666F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(84.20163F, 26.33334F);
            this.xrLabel6.StyleName = "FieldCaption";
            this.xrLabel6.StylePriority.UseBorders = false;
            this.xrLabel6.StylePriority.UseBorderWidth = false;
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UseForeColor = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = "Avg Time";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel5
            // 
            this.xrLabel5.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel5.BorderWidth = 1F;
            this.xrLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(175.8952F, 66.16666F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(60.51579F, 26.33334F);
            this.xrLabel5.StyleName = "FieldCaption";
            this.xrLabel5.StylePriority.UseBorders = false;
            this.xrLabel5.StylePriority.UseBorderWidth = false;
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UseForeColor = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "Type";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel65
            // 
            this.xrLabel65.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel65.BorderWidth = 1F;
            this.xrLabel65.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel65.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.xrLabel65.LocationFloat = new DevExpress.Utils.PointFloat(8.900961E-05F, 66.16666F);
            this.xrLabel65.Name = "xrLabel65";
            this.xrLabel65.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel65.SizeF = new System.Drawing.SizeF(39.39892F, 26.33332F);
            this.xrLabel65.StyleName = "FieldCaption";
            this.xrLabel65.StylePriority.UseBorders = false;
            this.xrLabel65.StylePriority.UseBorderWidth = false;
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
            this.xrLabel2.SizeF = new System.Drawing.SizeF(128.9023F, 26.33334F);
            this.xrLabel2.StyleName = "FieldCaption";
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseForeColor = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "Total :";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrPanel3
            // 
            this.xrPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.xrPanel3.BorderWidth = 0F;
            this.xrPanel3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel40,
            this.xrLabel39,
            this.xrLabel38,
            this.xrLabel37,
            this.xrLabel36,
            this.xrLabel2});
            this.xrPanel3.LocationFloat = new DevExpress.Utils.PointFloat(10.00008F, 10F);
            this.xrPanel3.Name = "xrPanel3";
            this.xrPanel3.SizeF = new System.Drawing.SizeF(1050F, 47.91666F);
            this.xrPanel3.StylePriority.UseBackColor = false;
            this.xrPanel3.StylePriority.UseBorderWidth = false;
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
            this.ReportFooter.HeightF = 57.91666F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "192.168.1.18_db_imagereview_Connection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery1.Name = "Query";
            customSqlQuery1.Sql = resources.GetString("customSqlQuery1.Sql");
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("xrPictureBox1.Image")));
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(10.00005F, 2.554932F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(236.4109F, 90.63256F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage;
            // 
            // xrLabel4
            // 
            this.xrLabel4.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel4.BorderWidth = 1F;
            this.xrLabel4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(341.6501F, 14.49999F);
            this.xrLabel4.Multiline = true;
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(140.9033F, 51.66667F);
            this.xrLabel4.StyleName = "FieldCaption";
            this.xrLabel4.StylePriority.UseBorders = false;
            this.xrLabel4.StylePriority.UseBorderWidth = false;
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseForeColor = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "Verified Without\r\nModification";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel7
            // 
            this.xrLabel7.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel7.BorderWidth = 1F;
            this.xrLabel7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(482.5533F, 14.49999F);
            this.xrLabel7.Multiline = true;
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(140.9033F, 51.66667F);
            this.xrLabel7.StyleName = "FieldCaption";
            this.xrLabel7.StylePriority.UseBorders = false;
            this.xrLabel7.StylePriority.UseBorderWidth = false;
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UseForeColor = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.Text = "Verified With\r\nModification";
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel9
            // 
            this.xrLabel9.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel9.BorderWidth = 1F;
            this.xrLabel9.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(482.5533F, 66.16666F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(56.70161F, 26.33335F);
            this.xrLabel9.StyleName = "FieldCaption";
            this.xrLabel9.StylePriority.UseBorders = false;
            this.xrLabel9.StylePriority.UseBorderWidth = false;
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.StylePriority.UseForeColor = false;
            this.xrLabel9.StylePriority.UseTextAlignment = false;
            this.xrLabel9.Text = "Count";
            this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel10
            // 
            this.xrLabel10.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel10.BorderWidth = 1F;
            this.xrLabel10.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(539.2549F, 66.16666F);
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(84.20163F, 26.33334F);
            this.xrLabel10.StyleName = "FieldCaption";
            this.xrLabel10.StylePriority.UseBorders = false;
            this.xrLabel10.StylePriority.UseBorderWidth = false;
            this.xrLabel10.StylePriority.UseFont = false;
            this.xrLabel10.StylePriority.UseForeColor = false;
            this.xrLabel10.StylePriority.UseTextAlignment = false;
            this.xrLabel10.Text = "Avg Time";
            this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel11
            // 
            this.xrLabel11.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel11.BorderWidth = 1F;
            this.xrLabel11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(623.4566F, 14.49999F);
            this.xrLabel11.Multiline = true;
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(140.9033F, 51.66667F);
            this.xrLabel11.StyleName = "FieldCaption";
            this.xrLabel11.StylePriority.UseBorders = false;
            this.xrLabel11.StylePriority.UseBorderWidth = false;
            this.xrLabel11.StylePriority.UseFont = false;
            this.xrLabel11.StylePriority.UseForeColor = false;
            this.xrLabel11.StylePriority.UseTextAlignment = false;
            this.xrLabel11.Text = "Ignored";
            this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel13
            // 
            this.xrLabel13.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel13.BorderWidth = 1F;
            this.xrLabel13.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(623.4566F, 66.16666F);
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel13.SizeF = new System.Drawing.SizeF(56.70161F, 26.33335F);
            this.xrLabel13.StyleName = "FieldCaption";
            this.xrLabel13.StylePriority.UseBorders = false;
            this.xrLabel13.StylePriority.UseBorderWidth = false;
            this.xrLabel13.StylePriority.UseFont = false;
            this.xrLabel13.StylePriority.UseForeColor = false;
            this.xrLabel13.StylePriority.UseTextAlignment = false;
            this.xrLabel13.Text = "Count";
            this.xrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel16
            // 
            this.xrLabel16.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel16.BorderWidth = 1F;
            this.xrLabel16.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(680.1583F, 66.16666F);
            this.xrLabel16.Name = "xrLabel16";
            this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel16.SizeF = new System.Drawing.SizeF(84.20163F, 26.33334F);
            this.xrLabel16.StyleName = "FieldCaption";
            this.xrLabel16.StylePriority.UseBorders = false;
            this.xrLabel16.StylePriority.UseBorderWidth = false;
            this.xrLabel16.StylePriority.UseFont = false;
            this.xrLabel16.StylePriority.UseForeColor = false;
            this.xrLabel16.StylePriority.UseTextAlignment = false;
            this.xrLabel16.Text = "Avg Time";
            this.xrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel17
            // 
            this.xrLabel17.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel17.BorderWidth = 1F;
            this.xrLabel17.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(764.3599F, 14.49999F);
            this.xrLabel17.Multiline = true;
            this.xrLabel17.Name = "xrLabel17";
            this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel17.SizeF = new System.Drawing.SizeF(140.9033F, 51.66667F);
            this.xrLabel17.StyleName = "FieldCaption";
            this.xrLabel17.StylePriority.UseBorders = false;
            this.xrLabel17.StylePriority.UseBorderWidth = false;
            this.xrLabel17.StylePriority.UseFont = false;
            this.xrLabel17.StylePriority.UseForeColor = false;
            this.xrLabel17.StylePriority.UseTextAlignment = false;
            this.xrLabel17.Text = "Forwarded";
            this.xrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel18
            // 
            this.xrLabel18.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel18.BorderWidth = 1F;
            this.xrLabel18.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.xrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(764.3599F, 66.16666F);
            this.xrLabel18.Name = "xrLabel18";
            this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel18.SizeF = new System.Drawing.SizeF(56.70161F, 26.33335F);
            this.xrLabel18.StyleName = "FieldCaption";
            this.xrLabel18.StylePriority.UseBorders = false;
            this.xrLabel18.StylePriority.UseBorderWidth = false;
            this.xrLabel18.StylePriority.UseFont = false;
            this.xrLabel18.StylePriority.UseForeColor = false;
            this.xrLabel18.StylePriority.UseTextAlignment = false;
            this.xrLabel18.Text = "Count";
            this.xrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel22
            // 
            this.xrLabel22.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel22.BorderWidth = 1F;
            this.xrLabel22.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.xrLabel22.LocationFloat = new DevExpress.Utils.PointFloat(821.0615F, 66.16666F);
            this.xrLabel22.Name = "xrLabel22";
            this.xrLabel22.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel22.SizeF = new System.Drawing.SizeF(84.20163F, 26.33334F);
            this.xrLabel22.StyleName = "FieldCaption";
            this.xrLabel22.StylePriority.UseBorders = false;
            this.xrLabel22.StylePriority.UseBorderWidth = false;
            this.xrLabel22.StylePriority.UseFont = false;
            this.xrLabel22.StylePriority.UseForeColor = false;
            this.xrLabel22.StylePriority.UseTextAlignment = false;
            this.xrLabel22.Text = "Avg Time";
            this.xrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel12
            // 
            this.xrLabel12.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel12.BorderWidth = 1F;
            this.xrLabel12.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(905.2632F, 14.49999F);
            this.xrLabel12.Multiline = true;
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(140.9033F, 51.66667F);
            this.xrLabel12.StyleName = "FieldCaption";
            this.xrLabel12.StylePriority.UseBorders = false;
            this.xrLabel12.StylePriority.UseBorderWidth = false;
            this.xrLabel12.StylePriority.UseFont = false;
            this.xrLabel12.StylePriority.UseForeColor = false;
            this.xrLabel12.StylePriority.UseTextAlignment = false;
            this.xrLabel12.Text = "Grand Total";
            this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel15
            // 
            this.xrLabel15.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel15.BorderWidth = 1F;
            this.xrLabel15.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(905.2632F, 66.16666F);
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel15.SizeF = new System.Drawing.SizeF(56.70161F, 26.33335F);
            this.xrLabel15.StyleName = "FieldCaption";
            this.xrLabel15.StylePriority.UseBorders = false;
            this.xrLabel15.StylePriority.UseBorderWidth = false;
            this.xrLabel15.StylePriority.UseFont = false;
            this.xrLabel15.StylePriority.UseForeColor = false;
            this.xrLabel15.StylePriority.UseTextAlignment = false;
            this.xrLabel15.Text = "Count";
            this.xrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel19
            // 
            this.xrLabel19.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel19.BorderWidth = 1F;
            this.xrLabel19.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(961.9647F, 66.16666F);
            this.xrLabel19.Name = "xrLabel19";
            this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel19.SizeF = new System.Drawing.SizeF(84.20163F, 26.33334F);
            this.xrLabel19.StyleName = "FieldCaption";
            this.xrLabel19.StylePriority.UseBorders = false;
            this.xrLabel19.StylePriority.UseBorderWidth = false;
            this.xrLabel19.StylePriority.UseFont = false;
            this.xrLabel19.StylePriority.UseForeColor = false;
            this.xrLabel19.StylePriority.UseTextAlignment = false;
            this.xrLabel19.Text = "Avg Time";
            this.xrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel23
            // 
            this.xrLabel23.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel23.BorderWidth = 1F;
            this.xrLabel23.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.xrLabel23.LocationFloat = new DevExpress.Utils.PointFloat(236.411F, 66.16666F);
            this.xrLabel23.Name = "xrLabel23";
            this.xrLabel23.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel23.SizeF = new System.Drawing.SizeF(105.2391F, 26.33334F);
            this.xrLabel23.StyleName = "FieldCaption";
            this.xrLabel23.StylePriority.UseBorders = false;
            this.xrLabel23.StylePriority.UseBorderWidth = false;
            this.xrLabel23.StylePriority.UseFont = false;
            this.xrLabel23.StylePriority.UseForeColor = false;
            this.xrLabel23.StylePriority.UseTextAlignment = false;
            this.xrLabel23.Text = "Login Time";
            this.xrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel24
            // 
            this.xrLabel24.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.usertype")});
            this.xrLabel24.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.xrLabel24.LocationFloat = new DevExpress.Utils.PointFloat(185.8952F, 10F);
            this.xrLabel24.Name = "xrLabel24";
            this.xrLabel24.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel24.SizeF = new System.Drawing.SizeF(60.51579F, 23F);
            this.xrLabel24.StylePriority.UseFont = false;
            this.xrLabel24.StylePriority.UseTextAlignment = false;
            this.xrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel25
            // 
            this.xrLabel25.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.TotalLoginTime")});
            this.xrLabel25.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.xrLabel25.LocationFloat = new DevExpress.Utils.PointFloat(246.4109F, 10F);
            this.xrLabel25.Name = "xrLabel25";
            this.xrLabel25.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel25.SizeF = new System.Drawing.SizeF(105.2391F, 23F);
            this.xrLabel25.StylePriority.UseFont = false;
            this.xrLabel25.StylePriority.UseTextAlignment = false;
            this.xrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel26
            // 
            this.xrLabel26.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.TotalVerifiedWithoutCorrectionAvgTime")});
            this.xrLabel26.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.xrLabel26.LocationFloat = new DevExpress.Utils.PointFloat(408.3517F, 10F);
            this.xrLabel26.Name = "xrLabel26";
            this.xrLabel26.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel26.SizeF = new System.Drawing.SizeF(84.20163F, 23F);
            this.xrLabel26.StylePriority.UseFont = false;
            this.xrLabel26.StylePriority.UseTextAlignment = false;
            this.xrLabel26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel27
            // 
            this.xrLabel27.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.TotalVerifiedWithoutCorrection")});
            this.xrLabel27.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.xrLabel27.LocationFloat = new DevExpress.Utils.PointFloat(351.6501F, 10F);
            this.xrLabel27.Name = "xrLabel27";
            this.xrLabel27.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel27.SizeF = new System.Drawing.SizeF(56.70161F, 23F);
            this.xrLabel27.StylePriority.UseFont = false;
            this.xrLabel27.StylePriority.UseTextAlignment = false;
            this.xrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel28
            // 
            this.xrLabel28.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.TotalVerifiedWithCorrectionAvgTime")});
            this.xrLabel28.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.xrLabel28.LocationFloat = new DevExpress.Utils.PointFloat(549.255F, 10F);
            this.xrLabel28.Name = "xrLabel28";
            this.xrLabel28.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel28.SizeF = new System.Drawing.SizeF(84.20163F, 23F);
            this.xrLabel28.StylePriority.UseFont = false;
            this.xrLabel28.StylePriority.UseTextAlignment = false;
            this.xrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel29
            // 
            this.xrLabel29.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.TotalVerifiedWithCorrection")});
            this.xrLabel29.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.xrLabel29.LocationFloat = new DevExpress.Utils.PointFloat(492.5533F, 10F);
            this.xrLabel29.Name = "xrLabel29";
            this.xrLabel29.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel29.SizeF = new System.Drawing.SizeF(56.70161F, 23F);
            this.xrLabel29.StylePriority.UseFont = false;
            this.xrLabel29.StylePriority.UseTextAlignment = false;
            this.xrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel30
            // 
            this.xrLabel30.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.TotalIgnoredAvgTime")});
            this.xrLabel30.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.xrLabel30.LocationFloat = new DevExpress.Utils.PointFloat(690.1583F, 10F);
            this.xrLabel30.Name = "xrLabel30";
            this.xrLabel30.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel30.SizeF = new System.Drawing.SizeF(84.20163F, 23F);
            this.xrLabel30.StylePriority.UseFont = false;
            this.xrLabel30.StylePriority.UseTextAlignment = false;
            this.xrLabel30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel31
            // 
            this.xrLabel31.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.TotalIgnored")});
            this.xrLabel31.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.xrLabel31.LocationFloat = new DevExpress.Utils.PointFloat(633.4566F, 10F);
            this.xrLabel31.Name = "xrLabel31";
            this.xrLabel31.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel31.SizeF = new System.Drawing.SizeF(56.70161F, 23F);
            this.xrLabel31.StylePriority.UseFont = false;
            this.xrLabel31.StylePriority.UseTextAlignment = false;
            this.xrLabel31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel32
            // 
            this.xrLabel32.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.TotalForwardedAvgTime")});
            this.xrLabel32.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.xrLabel32.LocationFloat = new DevExpress.Utils.PointFloat(831.0616F, 10F);
            this.xrLabel32.Name = "xrLabel32";
            this.xrLabel32.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel32.SizeF = new System.Drawing.SizeF(84.20163F, 23F);
            this.xrLabel32.StylePriority.UseFont = false;
            this.xrLabel32.StylePriority.UseTextAlignment = false;
            this.xrLabel32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel33
            // 
            this.xrLabel33.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.TotalForwarded")});
            this.xrLabel33.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.xrLabel33.LocationFloat = new DevExpress.Utils.PointFloat(774.3599F, 10F);
            this.xrLabel33.Name = "xrLabel33";
            this.xrLabel33.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel33.SizeF = new System.Drawing.SizeF(56.70161F, 23F);
            this.xrLabel33.StylePriority.UseFont = false;
            this.xrLabel33.StylePriority.UseTextAlignment = false;
            this.xrLabel33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel34
            // 
            this.xrLabel34.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.TotalActionAvgTime")});
            this.xrLabel34.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.xrLabel34.LocationFloat = new DevExpress.Utils.PointFloat(971.9647F, 10F);
            this.xrLabel34.Name = "xrLabel34";
            this.xrLabel34.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel34.SizeF = new System.Drawing.SizeF(84.20163F, 23F);
            this.xrLabel34.StylePriority.UseFont = false;
            this.xrLabel34.StylePriority.UseTextAlignment = false;
            this.xrLabel34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel35
            // 
            this.xrLabel35.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.TotalActions")});
            this.xrLabel35.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.xrLabel35.LocationFloat = new DevExpress.Utils.PointFloat(915.2631F, 10F);
            this.xrLabel35.Name = "xrLabel35";
            this.xrLabel35.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel35.SizeF = new System.Drawing.SizeF(56.70161F, 23F);
            this.xrLabel35.StylePriority.UseFont = false;
            this.xrLabel35.StylePriority.UseTextAlignment = false;
            this.xrLabel35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel36
            // 
            this.xrLabel36.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.TotalVerifiedWithoutCorrection")});
            this.xrLabel36.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.xrLabel36.LocationFloat = new DevExpress.Utils.PointFloat(341.65F, 11.58335F);
            this.xrLabel36.Name = "xrLabel36";
            this.xrLabel36.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel36.SizeF = new System.Drawing.SizeF(140.9033F, 26.33334F);
            this.xrLabel36.StyleName = "FieldCaption";
            this.xrLabel36.StylePriority.UseFont = false;
            this.xrLabel36.StylePriority.UseForeColor = false;
            this.xrLabel36.StylePriority.UseTextAlignment = false;
            xrSummary6.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrLabel36.Summary = xrSummary6;
            this.xrLabel36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel37
            // 
            this.xrLabel37.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.TotalVerifiedWithCorrection")});
            this.xrLabel37.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel37.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.xrLabel37.LocationFloat = new DevExpress.Utils.PointFloat(482.5533F, 11.58335F);
            this.xrLabel37.Name = "xrLabel37";
            this.xrLabel37.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel37.SizeF = new System.Drawing.SizeF(140.9033F, 26.33334F);
            this.xrLabel37.StyleName = "FieldCaption";
            this.xrLabel37.StylePriority.UseFont = false;
            this.xrLabel37.StylePriority.UseForeColor = false;
            this.xrLabel37.StylePriority.UseTextAlignment = false;
            xrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrLabel37.Summary = xrSummary5;
            this.xrLabel37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel38
            // 
            this.xrLabel38.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.TotalIgnored")});
            this.xrLabel38.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel38.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.xrLabel38.LocationFloat = new DevExpress.Utils.PointFloat(623.4566F, 11.58335F);
            this.xrLabel38.Name = "xrLabel38";
            this.xrLabel38.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel38.SizeF = new System.Drawing.SizeF(140.9033F, 26.33334F);
            this.xrLabel38.StyleName = "FieldCaption";
            this.xrLabel38.StylePriority.UseFont = false;
            this.xrLabel38.StylePriority.UseForeColor = false;
            this.xrLabel38.StylePriority.UseTextAlignment = false;
            xrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrLabel38.Summary = xrSummary4;
            this.xrLabel38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel39
            // 
            this.xrLabel39.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.TotalForwarded")});
            this.xrLabel39.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel39.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.xrLabel39.LocationFloat = new DevExpress.Utils.PointFloat(764.3599F, 11.58335F);
            this.xrLabel39.Name = "xrLabel39";
            this.xrLabel39.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel39.SizeF = new System.Drawing.SizeF(140.9033F, 26.33334F);
            this.xrLabel39.StyleName = "FieldCaption";
            this.xrLabel39.StylePriority.UseFont = false;
            this.xrLabel39.StylePriority.UseForeColor = false;
            this.xrLabel39.StylePriority.UseTextAlignment = false;
            xrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrLabel39.Summary = xrSummary3;
            this.xrLabel39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel40
            // 
            this.xrLabel40.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.TotalActions")});
            this.xrLabel40.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel40.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.xrLabel40.LocationFloat = new DevExpress.Utils.PointFloat(905.2629F, 11.58335F);
            this.xrLabel40.Name = "xrLabel40";
            this.xrLabel40.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel40.SizeF = new System.Drawing.SizeF(140.9033F, 26.33334F);
            this.xrLabel40.StyleName = "FieldCaption";
            this.xrLabel40.StylePriority.UseFont = false;
            this.xrLabel40.StylePriority.UseForeColor = false;
            this.xrLabel40.StylePriority.UseTextAlignment = false;
            xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrLabel40.Summary = xrSummary2;
            this.xrLabel40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // rptUserPerformanceReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.PageHeader,
            this.PageFooter,
            this.ReportFooter});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.DataMember = "Query";
            this.DataSource = this.sqlDataSource1;
            this.FormattingRuleSheet.AddRange(new DevExpress.XtraReports.UI.FormattingRule[] {
            this.formattingRule1,
            this.formattingRule2});
            this.Landscape = true;
            this.Margins = new System.Drawing.Printing.Margins(48, 51, 47, 8);
            this.PageHeight = 827;
            this.PageWidth = 1169;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.pmSelectionTimeFrom,
            this.pmSelectionTimeTo});
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
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel20;
        private DevExpress.XtraReports.UI.XRLabel xrLabel21;
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
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRPanel xrPanel1;
        private DevExpress.XtraReports.UI.XRPanel xrPanel3;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.Parameters.Parameter pmSelectionTimeTo;
        private DevExpress.XtraReports.Parameters.Parameter pmSelectionTimeFrom;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private SqlDataSource sqlDataSource1;
        private XRLabel xrLabel3;
        private XRLabel xrLabel47;
        private XRLabel xrLabel52;
        private XRLabel xrLabel53;
        private XRLabel xrLabel54;
        private XRLabel xrLabel8;
        private XRLabel xrLabel23;
        private XRLabel xrLabel12;
        private XRLabel xrLabel15;
        private XRLabel xrLabel19;
        private XRLabel xrLabel17;
        private XRLabel xrLabel18;
        private XRLabel xrLabel22;
        private XRLabel xrLabel11;
        private XRLabel xrLabel13;
        private XRLabel xrLabel16;
        private XRLabel xrLabel7;
        private XRLabel xrLabel9;
        private XRLabel xrLabel10;
        private XRLabel xrLabel4;
        private XRLabel xrLabel25;
        private XRLabel xrLabel24;
        private XRLabel xrLabel34;
        private XRLabel xrLabel35;
        private XRLabel xrLabel32;
        private XRLabel xrLabel33;
        private XRLabel xrLabel30;
        private XRLabel xrLabel31;
        private XRLabel xrLabel28;
        private XRLabel xrLabel29;
        private XRLabel xrLabel27;
        private XRLabel xrLabel26;
        private XRLabel xrLabel40;
        private XRLabel xrLabel39;
        private XRLabel xrLabel38;
        private XRLabel xrLabel37;
        private XRLabel xrLabel36;
    }
}
