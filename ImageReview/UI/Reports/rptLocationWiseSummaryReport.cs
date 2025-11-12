namespace ImageReview.Reports
{
    public partial class rptLocationWiseSummaryReport : DevExpress.XtraReports.UI.XtraReport
    {
        public rptLocationWiseSummaryReport()
        {
            InitializeComponent();
        }

        int mainGroupCounter = 0;
        int subGroupCounter = 0;

        private void GroupHeader2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            subGroupCounter = 0;
            mainGroupCounter++;
            lblMainSr.Text = mainGroupCounter.ToString();
        }

        private void GroupHeader1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            subGroupCounter++;
            lblSubSr.Text = subGroupCounter.ToString();
        }
    }
}
