using ImageReview.Logic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ImageReview.UI
{
    public partial class frmSalikLocations : Form
    {
        public frmSalikLocations()
        {
            InitializeComponent();
        }

        private void frmSalikLocations_Load(object sender, EventArgs e)
        {
            try
            {
                FillPendingLocations();
                FillSalikLocations();
                FillAIDataButSalikPendingocations();
                FillSalikNotInAI();
            }
            catch (Exception ee)
            {
                MessageBox.Show("Error : " + ee.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillAIDataButSalikPendingocations()
        {
            try
            {
                List<Location> lstPenLoc = frmDashboard.lstLocations
                    .Where(l => frmDashboard.lstLocalVerification.Contains(l.id)
                    && !frmDashboard.lstSalikLocations.Contains(l.id))
                    .OrderBy(l => l.name).ToList();

                lstNotListedInSalikLocations.Items.Clear();
                lstNotListedInSalikLocations.DataSource = null;

                lstNotListedInSalikLocations.DataSource = lstPenLoc;
                lstNotListedInSalikLocations.DisplayMember = "name";
                lstNotListedInSalikLocations.ValueMember = "id";
                lstNotListedInSalikLocations.SelectedIndex = -1;

                lblNotListed.Text = $"Missing in Salik Locations ({ lstPenLoc.Count})";
            }
            catch (Exception ee)
            {
                MessageBox.Show("Error : " + ee.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillSalikNotInAI()
        {
            try
            {
                List<Location> lstPenLoc = frmDashboard.lstLocations
                    .Where(l => !frmDashboard.lstLocalVerification.Contains(l.id)
                    && frmDashboard.lstSalikLocations.Contains(l.id))
                    .OrderBy(l => l.name).ToList();

                lstSalikLocNotInAI.Items.Clear();
                lstSalikLocNotInAI.DataSource = null;

                lstSalikLocNotInAI.DataSource = lstPenLoc;
                lstSalikLocNotInAI.DisplayMember = "name";
                lstSalikLocNotInAI.ValueMember = "id";
                lstSalikLocNotInAI.SelectedIndex = -1;

                lblSalikLocNotInAI.Text = $"Missing in JLT Server 1.19 ({ lstPenLoc.Count})";
            }
            catch (Exception ee)
            {
                MessageBox.Show("Error : " + ee.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillSalikLocations()
        {
            try
            {
                List<Location> lstPenLoc = frmDashboard.lstLocations
                    .Where(l => frmDashboard.lstSalikLocations.Contains(l.id))
                    .OrderBy(l => l.name).ToList();

                lstSelectedLocations.Items.Clear();
                lstSelectedLocations.DataSource = null;

                lstSelectedLocations.DataSource = lstPenLoc;
                lstSelectedLocations.DisplayMember = "name";
                lstSelectedLocations.ValueMember = "id";
                lstSelectedLocations.SelectedIndex = -1;

                lblSalikLoc.Text = $"Salik Locations ({lstPenLoc.Count})";
            }
            catch (Exception ee)
            {
                MessageBox.Show("Error : " + ee.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillPendingLocations()
        {
            try
            {
                List<Location> lstPenLoc = frmDashboard.lstLocations
                    .Where(l => !frmDashboard.lstSalikLocations.Contains(l.id))
                    .OrderBy(l => l.name).ToList();

                lstPendingLocations.Items.Clear();
                lstPendingLocations.DataSource = null;

                lstPendingLocations.DataSource = lstPenLoc;
                lstPendingLocations.DisplayMember = "name";
                lstPendingLocations.ValueMember = "id";
                lstPendingLocations.SelectedIndex = -1;

                lblPenLoc.Text = $"Pending Locations ({lstPenLoc.Count})";
            }
            catch (Exception ee)
            {
                MessageBox.Show("Error : " + ee.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnMove_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstPendingLocations.SelectedIndex > -1)
                {
                    int locId = Convert.ToInt32(lstPendingLocations.SelectedValue);
                    int rec = await MySqlDAL.AddSalikLocation(locId);
                    if (rec > 0)
                    {
                        frmDashboard.lstSalikLocations.Add(locId);
                        FillPendingLocations();
                        FillSalikLocations();
                        FillAIDataButSalikPendingocations();
                        FillSalikNotInAI();
                    }
                }
                else
                {
                    MessageBox.Show("Kindly select a location from pending list", "Invalid Location", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show("Error : " + ee.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
