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
            ArrangeDisplay();
            dtTo.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59);
            DateTime YesDay = DateTime.Now.AddDays(-1);
            dtFrom.Value = new DateTime(YesDay.Year, YesDay.Month, YesDay.Day, 0, 0, 0);
            cmbEntryExit.SelectedIndex = 0;

            FillLocations();
            GetData();
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

        private void ArrangeDisplay()
        {
            try
            {
                pnlWait.Location = new Point(((this.Width / 2) - (pnlWait.Width / 2)),
                    ((this.Height / 2) - (pnlWait.Height / 2)));

                pnlHeader.Location = new Point(((this.Width / 2) - (pnlHeader.Width / 2)), pnlHeader.Location.Y);

                tvFT.Width = this.Width / 100 * 40;
                dgvData.Width = this.Width / 100 * 60;
                int locY = chkSelectUnselectAll.Location.Y + chkSelectUnselectAll.Height + 6;

                tvFT.Location = new Point(12, locY);
                dgvData.Location = new Point(tvFT.Width + 18, locY);
                dgvData.Height = tvFT.Height = this.Height - locY - 50;
                chkSelectUnselectAll.Location = new Point(dgvData.Location.X + 25, chkSelectUnselectAll.Location.Y);
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error ArrangeDisplay : {0}", ee.Message));
            }
        }

        List<FalseTrigger> lstData = new List<FalseTrigger>();
        private async Task<int> GetData()
        {
            try
            {
                if (frmDashboard.lstAccessPointsData == null || frmDashboard.lstAccessPointsData.Count <= 0)
                {
                    MessageBox.Show("Locations data is not loaded yet.\nKindly re-try after couple of seconds.", "Locations Data is Loaded Yet", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return 0;
                }

                //filters
                int NoOfRec = 0, LocID = 0, IsExit = 0;
                List<int> apIDs = new List<int>();
                txtAvgSpeedInSec.InvokeControl(l => int.TryParse(l.Text, out NoOfRec));
                DateTime From = new DateTime(), To = new DateTime();
                dtFrom.InvokeControl(l => From = l.Value);
                dtTo.InvokeControl(l => To = l.Value);
                cmbLocation.InvokeControl(l => LocID = l.SelectedIndex > 0 ? Convert.ToInt32(l.SelectedValue) : 0);
                cmbEntryExit.InvokeControl(l => IsExit = l.SelectedIndex);

                //get location ap
                if (LocID > 0)
                {
                    List<AccessPoint> lstAP = frmDashboard.lstAccessPointsData.Where(l => l.locationID == LocID).ToList();
                    if (IsExit > 0)
                        lstAP = lstAP.Where(l => l.is_exit == (IsExit == 2 ? 1 : 0)).ToList();
                    apIDs.AddRange(lstAP.Select(l => l.id).ToList());
                }
                else if (IsExit > 0)
                {
                    apIDs.AddRange(frmDashboard.lstAccessPointsData
                        .Where(l => l.is_exit == (IsExit == 2 ? 1 : 0))
                        .ToList()
                        .Select(l => l.id)
                        .ToList());
                }

                //query
                lstData = await MySqlDAL.GetFalseTriggeringData(From, To, apIDs, NoOfRec);
                var apDict = frmDashboard.lstAccessPointsData.ToDictionary(a => a.id);
                AccessPoint ap;
                foreach (FalseTrigger ft in lstData)
                {
                    if (apDict.TryGetValue(ft.AccessPointID, out ap))
                    {
                        ft.LocationName = ap.locationName;
                        ft.AccessPointName = ap.AccessPointIDName;
                        ft.LocationID = ap.locationID;
                    }
                }

                BindTreeView(lstData);
                BindDataGridView(lstData);

                return lstData.Count;
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error BindGrid : {0}", ee.Message));
                return 0;
            }
        }

        private void BindTreeView(List<FalseTrigger> lstFT)
        {
            try
            {
                tvFT.Nodes.Clear();

                var lstLocs = lstFT.GroupBy(ft => new { ft.LocationID, ft.LocationName }).Select(g => new
                {
                    LocationID = g.Key.LocationID,
                    LocationName = g.Key.LocationName,
                    Count = g.Count()
                }).OrderByDescending(o => o.Count).ToList();

                foreach (var parent in lstLocs)
                {
                    TreeNode parentNode = new TreeNode(string.Format("{0} - - - - - - {1}", parent.LocationName, parent.Count));
                    parentNode.Tag = "loc_" + parent.LocationID;
                    parentNode.NodeFont = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);

                    var lstaps = lstFT.Where(w => w.LocationID == parent.LocationID)
                        .GroupBy(ft => new { ft.AccessPointName, ft.AccessPointID })
                        .Select(g => new
                        {
                            AccessPointID = g.Key.AccessPointID,
                            AccessPointName = g.Key.AccessPointName,
                            Count = g.Count()
                        }).OrderByDescending(o => o.Count).ToList();

                    foreach (var child in lstaps)
                    {
                        TreeNode childNode = new TreeNode(string.Format("{0} - - - {1}", child.AccessPointName, child.Count));
                        childNode.Tag = "ap_" + child.AccessPointID;
                        childNode.NodeFont = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);

                        parentNode.Nodes.Add(childNode);
                    }

                    tvFT.Nodes.Add(parentNode);
                }

                tvFT.ExpandAll();
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error BindTreeView : {0}", ee.Message));
            }
        }

        private void tvFT_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                if (e.Node.Tag.ToString().Contains("loc_"))
                {
                    int LocID = Convert.ToInt32(e.Node.Tag.ToString().Replace("loc_", ""));
                    List<FalseTrigger> lstFT = lstData.Where(w => w.LocationID == LocID).ToList();

                    BindDataGridView(lstFT);
                }
                else if (e.Node.Tag.ToString().Contains("ap_"))
                {
                    int apID = Convert.ToInt32(e.Node.Tag.ToString().Replace("ap_", ""));
                    List<FalseTrigger> lstFT = lstData.Where(w => w.AccessPointID == apID).ToList();

                    BindDataGridView(lstFT);
                }
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error tvFT_NodeMouseDoubleClick : {0}", ee.Message));
            }
        }

        private void BindDataGridView(List<FalseTrigger> lstFT)
        {
            try
            {
                dgvData.Columns.Clear();
                SortableBindingList<FalseTrigger> sortableList = new SortableBindingList<FalseTrigger>(lstFT);
                dgvData.DataSource = sortableList;
                DataGridViewCheckBoxColumn col = new DataGridViewCheckBoxColumn();
                col.Name = "chkChoose";
                dgvData.Columns.Add(col);

                dgvData.Columns["AccessPointID"].Visible = false;
                dgvData.Columns["FolderName"].Visible = false;
                dgvData.Columns["LocationID"].Visible = false;
                dgvData.Columns["ids"].Visible = false;

                foreach (DataGridViewColumn column in dgvData.Columns)
                    column.SortMode = DataGridViewColumnSortMode.Automatic;
                ResizeGridColumns();

                dgvData.Columns["LocationName"].HeaderText = "Location";
                dgvData.Columns["AccessPointName"].HeaderText = "Access Point";
                dgvData.Columns["EventDate"].HeaderText = "Time";
                dgvData.Columns["NoOfTrigger"].HeaderText = "Triggers";
                dgvData.Columns["chkChoose"].HeaderText = "Choose";

                dgvData.Columns["chkChoose"].DisplayIndex = 0;
                dgvData.Columns["LocationName"].DisplayIndex = 1;
                dgvData.Columns["AccessPointName"].DisplayIndex = 2;
                dgvData.Columns["EventDate"].DisplayIndex = 3;
                dgvData.Columns["NoOfTrigger"].DisplayIndex = 4;

                dgvData.Columns["LocationName"].ReadOnly = dgvData.Columns["AccessPointName"].ReadOnly =
                dgvData.Columns["EventDate"].ReadOnly = dgvData.Columns["NoOfTrigger"].ReadOnly = true;
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error BindDataGridView : {0}", ee.Message));
            }
        }

        private void ResizeGridColumns()
        {
            if (dgvData.Columns.Count > 0)
            {
                int siz = dgvData.Width / 100; // 690
                dgvData.Columns["LocationName"].Width = siz * 29;
                dgvData.Columns["AccessPointName"].Width = siz * 24;
                dgvData.Columns["EventDate"].Width = siz * 19;
                dgvData.Columns["NoOfTrigger"].Width = siz * 11;
                dgvData.Columns["chkChoose"].Width = siz * 12;
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
                pnlWait.Visible = true;
                string ids = "";

                await Task.Run(() =>
                {
                    foreach (DataGridViewRow dr in dgvData.Rows)
                    {
                        DataGridViewCheckBoxCell chkCell = dr.Cells["chkChoose"] as DataGridViewCheckBoxCell;
                        if (chkCell.Value != null && (bool)chkCell.Value)
                            ids = string.Format(@"{0},{1}", ids, dr.Cells["ids"].Value.ToString());
                    }
                });

                if (ids.Length > 0)
                {
                    if (MessageBox.Show("Are you sure you want to clear all selected triggers?", "Confirmation Required", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        ids = ids.Substring(1);
                        await MySqlDAL.UpdateFalseTriggersToSeen(ids);
                        await RefreshData();
                    }
                }
                else
                    MessageBox.Show("Please select the triggers you want to clear.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error btnClearAll_Click : {0}", ee.Message));
            }
            pnlWait.Visible = false;
        }

        public async Task RefreshData()
        {
            try
            {
                int rec = await GetData();
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

        private void frmFalseTriggering_Resize(object sender, EventArgs e)
        {
            ArrangeDisplay();
            ResizeGridColumns();
        }


    }
}
