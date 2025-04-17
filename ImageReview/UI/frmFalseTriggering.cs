using ImageReview.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageReview.UI
{
    public partial class frmFalseTriggering : Form
    {
        public frmFalseTriggering()
        {
            InitializeComponent();
        }

        private void frmFalseTriggering_Load(object sender, EventArgs e)
        {
            pnlWait.Location = new Point(((this.Width / 2) - (pnlWait.Width / 2)),
            ((this.Height / 2) - (pnlWait.Height / 2)));

            BindGrid();
        }

        private async Task<int> BindGrid()
        {
            try
            {
                List<FalseTrigger> lstFT = await MySqlDAL.GetFalseTriggeringData();

                var apDict = frmDashboard.lstAccessPointsData.ToDictionary(a => a.id);
                AccessPoint ap;
                foreach (FalseTrigger ft in lstFT)
                {
                    if (apDict.TryGetValue(ft.AccessPointID, out ap))
                    {
                        ft.LocationName = ap.locationName;
                        ft.AccessPointName = ap.AccessPointIDName;
                    }
                }

                dgvData.Columns.Clear();
                dgvData.DataSource = lstFT;

                DataGridViewCheckBoxColumn col = new DataGridViewCheckBoxColumn();
                col.Name = "chkChoose";
                dgvData.Columns.Add(col);

                dgvData.Columns["AccessPointID"].Visible = false;
                dgvData.Columns["FolderName"].Visible = false;

                dgvData.Columns["LocationName"].Width = 200;
                dgvData.Columns["AccessPointName"].Width = 170;
                dgvData.Columns["EventDate"].Width = 140;
                dgvData.Columns["NoOfTrigger"].Width = 80;
                dgvData.Columns["chkChoose"].Width = 100;

                dgvData.Columns["LocationName"].HeaderText = "Location";
                dgvData.Columns["AccessPointName"].HeaderText = "Access Point";
                dgvData.Columns["EventDate"].HeaderText = "Time";
                dgvData.Columns["NoOfTrigger"].HeaderText = "Triggers";
                dgvData.Columns["chkChoose"].HeaderText = "Choose";

                dgvData.Columns["LocationName"].DisplayIndex = 0;
                dgvData.Columns["AccessPointName"].DisplayIndex = 1;
                dgvData.Columns["EventDate"].DisplayIndex = 2;
                dgvData.Columns["NoOfTrigger"].DisplayIndex = 3;
                dgvData.Columns["chkChoose"].DisplayIndex = 4;

                dgvData.Columns["LocationName"].ReadOnly = dgvData.Columns["AccessPointName"].ReadOnly =
                dgvData.Columns["EventDate"].ReadOnly = dgvData.Columns["NoOfTrigger"].ReadOnly = true;

                return lstFT.Count;
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error BindGrid : {0}", ee.Message));
                return 0;
            }
        }

        private void chkSelectUnselectAll_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                chkSelectUnselectAll.Text = chkSelectUnselectAll.Checked ? "Unselect All" : "Select All";
                foreach (DataGridViewRow dr in dgvData.Rows)
                    (dr.Cells["chkChoose"] as DataGridViewCheckBoxCell).Value = chkSelectUnselectAll.Checked;
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error chkSelectUnselectAll_CheckedChanged : {0}", ee.Message));
            }
        }

        private async void btnClearAll_Click(object sender, EventArgs e)
        {
            try
            {
                List<FalseTrigger> lstFT = new List<FalseTrigger>();
                foreach (DataGridViewRow dr in dgvData.Rows)
                {
                    DataGridViewCheckBoxCell chkCell = dr.Cells["chkChoose"] as DataGridViewCheckBoxCell;
                    if (chkCell.Value != null && (bool)chkCell.Value)
                    {
                        lstFT.Add(new FalseTrigger()
                        {
                            AccessPointID = Convert.ToInt32(dr.Cells["AccessPointID"].Value),
                            EventDate = dr.Cells["EventDate"].Value.ToString()
                        });
                    }
                }

                if (lstFT.Count > 0)
                {
                    if (MessageBox.Show("Are you sure you want to clear all selected triggers?", "Confirmation Required", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        pnlWait.Visible = true;
                        foreach (FalseTrigger ft in lstFT)
                            await DeleteFolderAndMarkItSeen(ft);

                        await RefreshData();
                        pnlWait.Visible = false;
                    }
                }
                else
                    MessageBox.Show("Please select the triggers you want to clear.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error btnClearAll_Click : {0}", ee.Message));
            }
        }

        public async Task DeleteFolderAndMarkItSeen(FalseTrigger ft)
        {
            try
            {
                List<string> folders = await MySqlDAL.GetFalseTriggerFolders(ft.AccessPointID, ft.EventDate);
                foreach (string folder in folders)
                    Directory.Delete(string.Format("{0}\\{1}", Utilis.ModificationFolderPath, folder), true);
                await MySqlDAL.UpdateFalseTriggersToSeen(ft.AccessPointID, ft.EventDate);
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error DeleteFolderAndMarkItSeen : {0}", ee.Message));
            }
        }

        public async Task RefreshData()
        {
            try
            {
                int rec = await BindGrid();
                if (this.Owner is frmDashboard)
                    ((frmDashboard)this.Owner).RefreshFalseTriggeringCount(rec);
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error RefreshFalseTriggeringCount : {0}", ee.Message));
            }
        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvData.Rows[e.RowIndex];

                    frmMultiImageSlider frm = new frmMultiImageSlider();
                    frm.Owner = this;
                    frm.Show(Convert.ToInt32(row.Cells["AccessPointID"].Value),
                        row.Cells["EventDate"].Value.ToString(),
                        row.Cells["AccessPointName"].Value.ToString(),
                        row.Cells["LocationName"].Value.ToString());
                }
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error dgvData_CellDoubleClick : {0}", ee.Message));
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
