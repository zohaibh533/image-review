using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ImageReview.Logic;
using DevExpress.XtraReports.UI;
using ImageReview.Reports;
using DevExpress.XtraCharts;
using DevExpress.XtraGrid.Views.Grid;
using System.IO;
using DevExpress.XtraEditors.Controls;

namespace ImageReview.UI
{
    public partial class frmReports : DevExpress.XtraEditors.XtraForm
    {
        public frmReports()
        {
            InitializeComponent();
        }

        private void frmReports_Load(object sender, EventArgs e)
        {
            try
            {
                gcData.Height = this.Height - grpFilters.Height - 45;
                dtTo.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59);
                dtFrom.Value = DateTime.Now.AddDays(-1);
                ppWait.Size = new Size(178, 49);

                cmbActionType.SelectedIndex = 0;
                cmbPrintReport.SelectedIndex = 0;
                cmbEntryExit.SelectedIndex = 0;

                FillLocations();
                FillUsers();
                //if (Utilis.UserType != "admin")
                //{

                //}

                CorrectMissingLocationsInfo();
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error frmReports_Load : {0}", ee.Message));
                MessageBox.Show("Error : " + ee.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void CorrectMissingLocationsInfo()
        {
            try
            {
                await Task.Run(async () =>
                {
                    DataTable dt = await MySqlDAL.ExecuteDataTable(@"SELECT id,access_point_id FROM tbl_correction_log 
                    WHERE location_id = 0 AND access_point_id<>0");

                    if (dt != null && dt.Rows.Count > 0)
                    {
                        AccessPoint ap = null;
                        foreach (DataRow dr in dt.Rows)
                        {
                            if (frmDashboard.dicApLocation.TryGetValue(Convert.ToInt32(dr["access_point_id"]), out ap))
                                await MySqlDAL.UpdateMissingLocationInfo(Convert.ToInt32(dr["id"]), ap.locationID);
                        }
                    }
                });
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error CorrectMissingLocationsInfo : {0}", ee.Message));
            }
        }

        private void FillLocations()
        {
            try
            {
                List<Location> lst = frmDashboard.lstLocations.OrderBy(g => g.name).ToList();

                lst.Insert(0, new Location { id = 0, name = "All Locations" });
                cmbLocation.DisplayMember = "name";
                cmbLocation.ValueMember = "id";
                cmbLocation.DataSource = lst;
            }
            catch (Exception ee)
            {
                MessageBox.Show(string.Format("Error : {0}", ee.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void FillUsers()
        {
            try
            {
                List<SystemUser> lst = await MySqlDAL.GetCashiersList();

                lst.Insert(0, new SystemUser() { ID = 0, UserName = "All Users", Password = "", UserType = "user" });
                cmbUser.DisplayMember = "UserName";
                cmbUser.ValueMember = "ID";
                cmbUser.DataSource = lst;

                if (Utilis.UserType == "admin")
                    cmbUser.SelectedIndex = 0;
                else
                    cmbUser.SelectedValue = Utilis.UserID;

                btnSearch_Click(this, new EventArgs());
            }
            catch (Exception ee)
            {
                MessageBox.Show(string.Format("Error : {0}", ee.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = string.Format(@"SELECT IFNULL(a.Name,'')UserAction,IFNULL(u.Username,'')Username,
                DATE_FORMAT(l.PlateRead_Time, '%d-%b-%Y %H:%i:%s') ReviewTime,
                DATE_FORMAT(l.Created_At, '%d-%b-%Y %H:%i:%s') CorrectionTime,
                TIME_FORMAT(SEC_TO_TIME(TIMESTAMPDIFF(SECOND, l.PlateRead_Time, l.Created_At)), '%i:%s') as ActionTime,
                CONCAT(l.Captured_Code,' ',l.Captured_PlateNo,' ',l.Captured_City) CapturedPlate,
                CONCAT(l.Corrected_Code,' ',l.Corrected_PlateNo,' ',l.Corrected_City) CorrectedPlate,
                l.Transaction_ID,'' as Location_Name,'' as apname,
                IFNULL(r.name,'')Reason,l.User_Remarks AS Remarks,l.ANPR_Message,l.Location_ID,l.User_ID,l.FolderName,
l.access_point_id

                FROM tbl_correction_log l
                LEFT OUTER JOIN tbl_users u ON u.ID=l.User_ID
                LEFT OUTER JOIN tbl_actions_master a ON a.ID=l.Action_Type
                LEFT OUTER JOIN tbl_reasons r ON r.ID=l.Reason_ID

                where l.Created_At between '{0}' and '{1}' ",
                dtFrom.Value.ToString("yyyy-MM-dd HH:mm:ss"), dtTo.Value.ToString("yyyy-MM-dd HH:mm:ss"));

                qry = string.Format("{0} {1}", qry, GetQueryFilters());
                qry = string.Format("{0} order by l.Created_At ", qry);

                ppWait.Visible = true;
                DataTable dt = await MySqlDAL.ExecuteDataTable(qry);

                AccessPoint ap;
                // update location name and access point
                foreach (DataRow dr in dt.Rows)
                {
                    if (frmDashboard.dicApLocation.TryGetValue(Convert.ToInt32(dr["access_point_id"]), out ap))
                    {
                        dr["Location_Name"] = ap.locationName;
                        dr["apname"] = ap.AccessPointIDName;
                    }
                }

                gcData.DataSource = dt;
                FormatGridColumns();

                lblRecords.Text = string.Format("Rows : {0}", dt.Rows.Count);
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error btnSearch_Click : {0}", ee.Message));
                MessageBox.Show("Error : " + ee.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ppWait.Visible = false;
        }

        private void FormatGridColumns()
        {
            gvData.Columns["User_ID"].Visible = false;
            gvData.Columns["Location_ID"].Visible = false;
            gvData.Columns["FolderName"].Visible = false;
            gvData.Columns["access_point_id"].Visible = false;

            gvData.Columns["UserAction"].Caption = "Action";
            gvData.Columns["Username"].Caption = "User";
            gvData.Columns["ReviewTime"].Caption = "Review Time";
            gvData.Columns["CorrectionTime"].Caption = "Modification Time";
            gvData.Columns["ActionTime"].Caption = "Time Spent";
            gvData.Columns["Location_Name"].Caption = "Location";
            gvData.Columns["apname"].Caption = "Access Point";
            gvData.Columns["Transaction_ID"].Caption = "Transaction ID";
            gvData.Columns["CapturedPlate"].Caption = "Captured Plate";
            gvData.Columns["CorrectedPlate"].Caption = "Modified Plate";
            gvData.Columns["Remarks"].Caption = "Remarks";
            gvData.Columns["ANPR_Message"].Caption = "OCR Output";
            gvData.Columns["Reason"].Caption = "Reason";

            gvData.Columns["UserAction"].Width = 80;
            gvData.Columns["Username"].Width = 60;
            gvData.Columns["CorrectionTime"].Width = 160;
            gvData.Columns["ReviewTime"].Width = 160;
            gvData.Columns["ActionTime"].Width = 100;
        }

        #region Print Reports

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbPrintReport.SelectedIndex == 0) // Correction Summary Report
                {
                    LoadCorrectionSummaryReport();
                }
                else if (cmbPrintReport.SelectedIndex == 1) // User Wise Summary
                {
                    LoadUserWiseSummaryReport();
                }
                else if (cmbPrintReport.SelectedIndex == 2) // Hourly Summary
                {
                    LoadHourlySummaryReport();
                }
                else if (cmbPrintReport.SelectedIndex == 3) // User performance
                {
                    LoadUserPerformanceReport();
                }
                else if (cmbPrintReport.SelectedIndex == 4) // Location Summary
                {
                    LoadLocationWiseSummaryReport();
                }
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error btnPrint_Click : {0}", ee.Message));
                MessageBox.Show("Error : " + ee.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async void LoadUserPerformanceReport()
        {
            try
            {
                ppWait.Visible = true;
                rptUserPerformanceReport report = new rptUserPerformanceReport();

                //Report Parameters
                report.Parameters["pmSelectionTimeFrom"].Value = dtFrom.Value.ToString("yyyy-MM-dd HH:mm:ss");
                report.Parameters["pmSelectionTimeTo"].Value = dtTo.Value.ToString("yyyy-MM-dd HH:mm:ss");
                //report.Parameters["pmActionType"].Value = cmbActionType.Text;
                //report.Parameters["pmUser"].Value = cmbUser.Text;
                //report.Parameters["pmPlateNo"].Value = string.IsNullOrEmpty(txtPlateNo.Text.Trim()) ? "N/A" : txtPlateNo.Text.Trim();

                //Report Datasource
                DataTable dt = await MySqlDAL.ExecuteDataTable(UserPerformanceQry());
                report.DataSource = dt;
                report.DataMember = dt.TableName;

                ReportPrintTool tool = new ReportPrintTool(report);
                this.TopMost = false;
                tool.ShowRibbonPreviewDialog();
            }
            catch (Exception ee)
            {
                MessageBox.Show(string.Format("Error : {0}", ee.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ppWait.Visible = false;
        }

        private string UserPerformanceQry()
        {
            string qry = string.Format(@"
WITH CorrectionStats AS (
    SELECT 
        cl.User_ID,
        COUNT(cl.ID) AS TotalActions,
        SUM(cl.Action_Type = 1 AND CONCAT(cl.Captured_Code, cl.Captured_PlateNo, cl.Captured_city) = 
            CONCAT(cl.Corrected_Code, cl.Corrected_PlateNo, cl.Corrected_City)) AS TotalVerifiedWithoutCorrection,
        SUM(cl.Action_Type = 1 AND CONCAT(cl.Captured_Code, cl.Captured_PlateNo, cl.Captured_city) <> 
            CONCAT(cl.Corrected_Code, cl.Corrected_PlateNo, cl.Corrected_City)) AS TotalVerifiedWithCorrection,
        SUM(cl.Action_Type = 2) AS TotalIgnored,
        SUM(cl.Action_Type = 3) AS TotalForwarded,
        AVG(CASE WHEN cl.Action_Type = 1 AND CONCAT(cl.Captured_Code, cl.Captured_PlateNo, cl.Captured_city) = 
                 CONCAT(cl.Corrected_Code, cl.Corrected_PlateNo, cl.Corrected_City) 
                 THEN TIMESTAMPDIFF(SECOND, cl.PlateRead_Time, cl.Created_At) END) AS TotalVerifiedWithoutCorrectionAvgTime,
        AVG(CASE WHEN cl.Action_Type = 1 AND CONCAT(cl.Captured_Code, cl.Captured_PlateNo, cl.Captured_city) <> 
                 CONCAT(cl.Corrected_Code, cl.Corrected_PlateNo, cl.Corrected_City) 
                 THEN TIMESTAMPDIFF(SECOND, cl.PlateRead_Time, cl.Created_At) END) AS TotalVerifiedWithCorrectionAvgTime,
        AVG(CASE WHEN cl.Action_Type = 2 
                 THEN TIMESTAMPDIFF(SECOND, cl.PlateRead_Time, cl.Created_At) END) AS TotalIgnoredAvgTime,
        AVG(CASE WHEN cl.Action_Type = 3 
                 THEN TIMESTAMPDIFF(SECOND, cl.PlateRead_Time, cl.Created_At) END) AS TotalForwardedAvgTime,
        AVG(TIMESTAMPDIFF(SECOND, cl.PlateRead_Time, cl.Created_At)) AS TotalActionAvgTime
    FROM tbl_correction_log cl
    WHERE cl.Created_At BETWEEN '{0}' and '{1}'
    GROUP BY cl.User_ID
)

    SELECT 
    la.user_id,
    la.username,
    la.usertype,
    COUNT(la.user_id) AS NoOfSessions,
    SEC_TO_TIME(SUM(TIMESTAMPDIFF(SECOND, la.Login_Time, la.Logout_Time))) AS TotalLoginTime,
    IFNULL(cs.TotalVerifiedWithoutCorrection, 0) AS TotalVerifiedWithoutCorrection,
    IFNULL(TIME_FORMAT(SEC_TO_TIME(cs.TotalVerifiedWithoutCorrectionAvgTime), '%H:%i:%s'), '') AS TotalVerifiedWithoutCorrectionAvgTime,
    IFNULL(cs.TotalVerifiedWithCorrection, 0) AS TotalVerifiedWithCorrection,
    IFNULL(TIME_FORMAT(SEC_TO_TIME(cs.TotalVerifiedWithCorrectionAvgTime), '%H:%i:%s'), '') AS TotalVerifiedWithCorrectionAvgTime,
    IFNULL(cs.TotalIgnored, 0) AS TotalIgnored,
    IFNULL(TIME_FORMAT(SEC_TO_TIME(cs.TotalIgnoredAvgTime), '%H:%i:%s'), '') AS TotalIgnoredAvgTime,
    IFNULL(cs.TotalForwarded, 0) AS TotalForwarded,
    IFNULL(TIME_FORMAT(SEC_TO_TIME(cs.TotalForwardedAvgTime), '%H:%i:%s'), '') AS TotalForwardedAvgTime,
    IFNULL(cs.TotalActions, 0) AS TotalActions,
    IFNULL(TIME_FORMAT(SEC_TO_TIME(cs.TotalActionAvgTime), '%H:%i:%s'), '') AS TotalActionAvgTime
    
    FROM vw_login_activity la
    LEFT JOIN CorrectionStats cs ON la.user_id = cs.User_ID
    WHERE la.Login_Time BETWEEN '{0}' and '{1}'
    AND la.Logout_Time IS NOT NULL 
    GROUP BY la.user_id, la.username, la.usertype
    ORDER BY la.username; ",
               dtFrom.Value.ToString("yyyy-MM-dd HH:mm:ss"), dtTo.Value.ToString("yyyy-MM-dd HH:mm:ss"));

            return qry;
        }

        public async void LoadHourlySummaryReport()
        {
            try
            {
                ppWait.Visible = true;
                rptHourlyCorrectionSummary report = new rptHourlyCorrectionSummary();

                //Report Parameters
                report.Parameters["pmSelectionTimeFrom"].Value = dtFrom.Value.ToString("yyyy-MM-dd HH:mm:ss");
                report.Parameters["pmSelectionTimeTo"].Value = dtTo.Value.ToString("yyyy-MM-dd HH:mm:ss");
                report.Parameters["pmActionType"].Value = cmbActionType.Text;
                report.Parameters["pmUser"].Value = cmbUser.Text;
                report.Parameters["pmPlateNo"].Value = string.IsNullOrEmpty(txtPlateNo.Text.Trim()) ? "N/A" : txtPlateNo.Text.Trim();

                //Report Datasource
                DataTable dt = await MySqlDAL.ExecuteDataTable(HourlyWiseSummaryQry());
                report.DataSource = dt;
                report.DataMember = dt.TableName;

                //Chart DataSource
                XRChart chart = report.FindControl("xrChart1", true) as XRChart;
                chart.Series[0].DataSource = dt;
                chart.Series[0].ArgumentScaleType = ScaleType.Qualitative;
                chart.Series[0].ArgumentDataMember = "HourlyTime";
                chart.Series[0].ValueScaleType = ScaleType.Numerical;
                chart.Series[0].ValueDataMembers.AddRange(new string[] { "TotalCount" });

                //show report
                ReportPrintTool tool = new ReportPrintTool(report);
                this.TopMost = false;
                tool.ShowRibbonPreviewDialog();
            }
            catch (Exception ee)
            {
                MessageBox.Show(string.Format("Error : {0}", ee.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ppWait.Visible = false;
        }

        private string HourlyWiseSummaryQry()
        {
            string qry = string.Format(@"WITH HourlyData AS (SELECT DATE_FORMAT(l.Created_At, '%d-%b (%H)') AS HourlyTime,
                SUM(CASE WHEN l.Action_Type = 1 THEN 1 ELSE 0 END) AS Correction,
                SUM(CASE WHEN l.Action_Type = 2 THEN 1 ELSE 0 END) AS Ignored,
                SUM(CASE WHEN l.Action_Type = 3 THEN 1 ELSE 0 END) AS Forwarded,
                COUNT(l.id) AS TotalCount,
                TIME_FORMAT(SEC_TO_TIME(AVG(TIMESTAMPDIFF(SECOND, l.PlateRead_Time, l.Created_At))),
                '%i:%s') AS ActionTime
    
                FROM tbl_correction_log l
                LEFT OUTER JOIN tbl_users u ON u.ID = l.User_ID
                LEFT OUTER JOIN tbl_actions_master a ON a.ID = l.Action_Type
                
                where l.Created_At between '{0}' and '{1}' and l.Action_Type<>4 ",
               dtFrom.Value.ToString("yyyy-MM-dd HH:mm:ss"), dtTo.Value.ToString("yyyy-MM-dd HH:mm:ss"));

            qry = string.Format(@"{0} {1}  GROUP BY HourlyTime) SELECT
                HourlyTime, Correction, Ignored, Forwarded, TotalCount, 
                ROUND((TotalCount * 100.0) / SUM(TotalCount) OVER(), 2) AS PercentageOfTotal,
                ActionTime FROM HourlyData ORDER BY HourlyTime DESC; ", qry, GetQueryFilters());

            return qry;
        }

        private string GetQueryFilters()
        {
            string qry = "";
            if (cmbActionType.SelectedIndex > 0)
            {
                if (cmbActionType.SelectedIndex == 2 || cmbActionType.SelectedIndex == 3)
                {
                    qry = string.Format(@"{0} and l.Action_Type=1 and
                        CONCAT(l.Corrected_Code,l.Corrected_PlateNo,l.Corrected_City) {1}
                        CONCAT(l.Captured_Code,l.Captured_PlateNo,l.Captured_city)",
                      qry, cmbActionType.SelectedIndex == 3 ? " =" : "<>");
                }

                // qry = string.Format("{0} and l.=1 ", qry);
                else
                {
                    int actID = 0;
                    if (cmbActionType.SelectedIndex == 1)
                        actID = 1;
                    else if (cmbActionType.SelectedIndex == 4)
                        actID = 2;
                    else if (cmbActionType.SelectedIndex == 5)
                        actID = 3;
                    else if (cmbActionType.SelectedIndex == 6)
                        actID = 4;

                    qry = string.Format("{0} and l.Action_Type={1} ", qry, actID);
                }
            }

            if (cmbEntryExit.SelectedIndex > 0)
                qry = string.Format("{0} and l.isexit = {1} ", qry, cmbEntryExit.SelectedIndex == 1 ? 0 : 1);

            if (chkExcludeForward.Checked)
                qry = string.Format("{0} and l.Action_Type <> 3 ", qry);

            if (cmbUser.SelectedIndex > 0)
                qry = string.Format("{0} and l.User_ID={1} ", qry, cmbUser.SelectedValue.ToString());

            if (cmbLocation.SelectedIndex > 0)
                qry = string.Format("{0} and l.location_id ={1} ", qry, cmbLocation.SelectedValue.ToString());

            if (txtPlateNo.Text.Trim() != "")
                qry = string.Format(@"{0} and (CONCAT(l.Captured_Code,' ',l.Captured_PlateNo,' ',l.Captured_city) like '%{1}%'
                    or CONCAT(l.Corrected_Code,' ',l.Corrected_PlateNo,' ',l.Corrected_City) like '%{1}%' 
                    or l.Transaction_ID like '%{1}%') ", qry, txtPlateNo.Text.Trim());

            return qry;
        }

        public async void LoadLocationWiseSummaryReport()
        {
            try
            {
                ppWait.Visible = true;
                rptLocationWiseSummaryReport report = new rptLocationWiseSummaryReport();

                //Report Parameters
                report.Parameters["pmSelectionTimeFrom"].Value = dtFrom.Value.ToString("yyyy-MM-dd HH:mm:ss");
                report.Parameters["pmSelectionTimeTo"].Value = dtTo.Value.ToString("yyyy-MM-dd HH:mm:ss");
                report.Parameters["pmActionType"].Value = cmbActionType.Text;
                report.Parameters["pmUser"].Value = cmbUser.Text;
                report.Parameters["pmPlateNo"].Value = string.IsNullOrEmpty(txtPlateNo.Text.Trim()) ? "N/A" : txtPlateNo.Text.Trim();

                //Report Datasource
                DataTable dt = await MySqlDAL.ExecuteDataTable(LocationWiseSummaryQry());

                Location loc;
                // update location name and access point
                foreach (DataRow dr in dt.Rows)
                {
                    loc = frmDashboard.lstLocations.Where(l => l.id == Convert.ToInt32(dr["LocationID"])).FirstOrDefault();

                    if (loc != null)
                        dr["LocationName"] = loc.name;
                }

                report.DataSource = dt;
                report.DataMember = dt.TableName;

                ReportPrintTool tool = new ReportPrintTool(report);
                this.TopMost = false;
                tool.ShowRibbonPreviewDialog();
            }
            catch (Exception ee)
            {
                MessageBox.Show(string.Format("Error : {0}", ee.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ppWait.Visible = false;
        }

        private string LocationWiseSummaryQry()
        {
            string qry = string.Format(@"SELECT '' as LocationName,l.Location_id as LocationID,
sum(case when l.Action_Type=1 then 1 else 0 end) as Correction,
sum(case when l.Action_Type=2 then 1 else 0 end) as Ignored,
sum(case when l.Action_Type=3 then 1 else 0 end) as Forwarded,
count(l.id) AS total,avg(TIMESTAMPDIFF(SECOND, l.PlateRead_Time, l.Created_At)) AS TimeDiffSec

                FROM tbl_correction_log l
                LEFT OUTER JOIN tbl_actions_master a ON a.ID=l.Action_Type
                
                where l.Created_At between '{0}' and '{1}' and l.Action_Type<>4 ",
               dtFrom.Value.ToString("yyyy-MM-dd HH:mm:ss"), dtTo.Value.ToString("yyyy-MM-dd HH:mm:ss"));

            qry = string.Format("{0} {1} group by l.Location_ID  order BY total desc", qry, GetQueryFilters());
            return qry;
        }


        public async void LoadUserWiseSummaryReport()
        {
            try
            {
                ppWait.Visible = true;
                rptUserWiseSummaryReport report = new rptUserWiseSummaryReport();

                //Report Parameters
                report.Parameters["pmSelectionTimeFrom"].Value = dtFrom.Value.ToString("yyyy-MM-dd HH:mm:ss");
                report.Parameters["pmSelectionTimeTo"].Value = dtTo.Value.ToString("yyyy-MM-dd HH:mm:ss");
                report.Parameters["pmActionType"].Value = cmbActionType.Text;
                report.Parameters["pmUser"].Value = cmbUser.Text;
                report.Parameters["pmPlateNo"].Value = string.IsNullOrEmpty(txtPlateNo.Text.Trim()) ? "N/A" : txtPlateNo.Text.Trim();

                //Report Datasource
                DataTable dt = await MySqlDAL.ExecuteDataTable(UserWiseSummaryQry());
                report.DataSource = dt;
                report.DataMember = dt.TableName;

                ReportPrintTool tool = new ReportPrintTool(report);
                this.TopMost = false;
                tool.ShowRibbonPreviewDialog();
            }
            catch (Exception ee)
            {
                MessageBox.Show(string.Format("Error : {0}", ee.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ppWait.Visible = false;
        }

        private string UserWiseSummaryQry()
        {
            string qry = string.Format(@"SELECT IFNULL(u.Username,'')Username,l.User_ID as UserID,
sum(case when l.Action_Type=1 then 1 else 0 end) as Correction,
sum(case when l.Action_Type=2 then 1 else 0 end) as Ignored,
sum(case when l.Action_Type=3 then 1 else 0 end) as Forwarded,
count(l.id) AS total,avg(TIMESTAMPDIFF(SECOND, l.PlateRead_Time, l.Created_At)) AS TimeDiffSec

                FROM tbl_correction_log l
                LEFT OUTER JOIN tbl_users u ON u.ID=l.User_ID
                LEFT OUTER JOIN tbl_actions_master a ON a.ID=l.Action_Type
                
                where l.Created_At between '{0}' and '{1}' and l.Action_Type<>4 ",
               dtFrom.Value.ToString("yyyy-MM-dd HH:mm:ss"), dtTo.Value.ToString("yyyy-MM-dd HH:mm:ss"));

            qry = string.Format("{0} {1} group by u.Username,l.User_ID  order BY total desc", qry, GetQueryFilters());
            return qry;
        }

        public async void LoadCorrectionSummaryReport()
        {
            try
            {
                ppWait.Visible = true;
                rptCorrectionSummaryReport report = new rptCorrectionSummaryReport();

                //Report Parameters
                report.Parameters["pmSelectionTimeFrom"].Value = dtFrom.Value.ToString("yyyy-MM-dd HH:mm:ss");
                report.Parameters["pmSelectionTimeTo"].Value = dtTo.Value.ToString("yyyy-MM-dd HH:mm:ss");
                report.Parameters["pmActionType"].Value = cmbActionType.Text;
                report.Parameters["pmUser"].Value = cmbUser.Text;
                report.Parameters["pmPlateNo"].Value = string.IsNullOrEmpty(txtPlateNo.Text.Trim()) ? "N/A" : txtPlateNo.Text.Trim();

                //Report Datasource
                DataTable dt = await MySqlDAL.ExecuteDataTable(CorrectionWiseSummaryQry());
                report.DataSource = dt;
                report.DataMember = dt.TableName;

                ReportPrintTool tool = new ReportPrintTool(report);
                this.TopMost = false;
                tool.ShowRibbonPreviewDialog();
            }
            catch (Exception ee)
            {
                MessageBox.Show(string.Format("Error : {0}", ee.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ppWait.Visible = false;
        }

        private string CorrectionWiseSummaryQry()
        {
            string qry = string.Format(@"SELECT ifnull(sum(case when l.Action_Type=1 then 1 else 0 END),0) as TotalVerifications,
            ifnull(sum(case when l.Action_Type=1 then TIMESTAMPDIFF(SECOND, l.PlateRead_Time, l.Created_At) else 0 END),0) TotalVerificationsSec,

            ifnull(sum(case when l.Action_Type=1 AND CONCAT(l.Corrected_Code,l.Corrected_PlateNo,l.Corrected_City)
            <> CONCAT(l.Captured_Code,l.Captured_PlateNo,l.Captured_city) then 1 else 0 end),0) as TotalVeriWithCorr,

            ifnull(sum(case when l.Action_Type=1 AND CONCAT(l.Corrected_Code,l.Corrected_PlateNo,l.Corrected_City)
            <> CONCAT(l.Captured_Code,l.Captured_PlateNo,l.Captured_city) then TIMESTAMPDIFF(SECOND, l.PlateRead_Time, l.Created_At) else 0 end),0) as TotalVeriWithCorrSec,

            ifnull(sum(case when l.Action_Type=1 AND CONCAT(l.Corrected_Code,l.Corrected_PlateNo,l.Corrected_City)
            = CONCAT(l.Captured_Code,l.Captured_PlateNo,l.Captured_city) then 1 else 0 end),0) as TotalVeriWithoutCorr,

            ifnull(sum(case when l.Action_Type=1 AND CONCAT(l.Corrected_Code,l.Corrected_PlateNo,l.Corrected_City)
            = CONCAT(l.Captured_Code,l.Captured_PlateNo,l.Captured_city) then TIMESTAMPDIFF(SECOND, l.PlateRead_Time, l.Created_At) else 0 end),0) as TotalVeriWithoutCorrSec,

            ifnull(sum(case when l.Action_Type=2 then 1 else 0 end),0) as TotalIgnored,

            ifnull(sum(case when l.Action_Type=2 then TIMESTAMPDIFF(SECOND, l.PlateRead_Time, l.Created_At) else 0 END),0) TotalIgnoredSec,

            ifnull(sum(case when l.Action_Type=3 then 1 else 0 end),0) as TotalForwarded,

            ifnull(sum(case when l.Action_Type=3 then TIMESTAMPDIFF(SECOND, l.PlateRead_Time, l.Created_At) else 0 END),0) TotalForwardedSec,

            count(l.id) AS GrandTotal,ifnull(avg(TIMESTAMPDIFF(SECOND, l.PlateRead_Time, l.Created_At)),0) AS GrandTotalAvgSec

            FROM tbl_correction_log l
                
            where l.Created_At between '{0}' and '{1}' and l.Action_Type<>4 ",
            dtFrom.Value.ToString("yyyy-MM-dd HH:mm:ss"), dtTo.Value.ToString("yyyy-MM-dd HH:mm:ss"));

            qry = string.Format("{0} {1}", qry, GetQueryFilters());
            return qry;
        }

        #endregion

        List<FileInfo> fPic;
        private void gvData_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                GridView view = sender as GridView;
                if (view != null)
                {
                    int rowHandle = view.FocusedRowHandle;
                    if (rowHandle >= 0)
                    {
                        //string CapturedPlate = view.GetRowCellValue(rowHandle, "CapturedPlate").ToString().ToLower();
                        //string UserAction = view.GetRowCellValue(rowHandle, "UserAction").ToString().ToLower();
                        //string CorrectedPlate = view.GetRowCellValue(rowHandle, "CorrectedPlate").ToString().ToLower();

                        //if (!CapturedPlate.Equals(CorrectedPlate))
                        //{
                        string folderName = view.GetRowCellValue(rowHandle, "FolderName").ToString();
                        string path = Path.Combine(Utilis.ModificationFolderPath, folderName);
                        if (Directory.Exists(path))
                        {
                            fPic = (new DirectoryInfo(path))
                                .GetFiles()
                                .ToList()
                                .Where(x => x.Extension.ToLower().Contains("jpg"))
                                .ToList();

                            if (fPic != null && fPic.Count > 0)
                            {
                                if (fPic.Count > 20)
                                    fPic = fPic.GetRange(0, 19);

                                frmImageSlider frm = new frmImageSlider();
                                frm.Show(fPic);
                            }
                            else
                            {
                                MessageBox.Show(string.Format("There is no image file present in the folder."), "No Image Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show(string.Format("Folder path not found\n{0}", path), "Invalid Folder Path", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        //}
                        //else
                        //{
                        //    string TransID = view.GetRowCellValue(rowHandle, "Transaction_ID").ToString();
                        //    MessageBox.Show(string.Format("No modification found for Transaction ID : {0}", TransID), "Invalid Transaction", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //}
                    }
                }
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error gvData_DoubleClick : {0}", ee.Message));
            }
        }
    }
}