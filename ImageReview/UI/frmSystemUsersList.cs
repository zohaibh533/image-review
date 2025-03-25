using ImageReview.Logic;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageReview.UI
{
    public partial class frmSystemUsersList : DevExpress.XtraEditors.XtraForm
    {
        bool _isLoaded;
        int _userID = 0;

        public frmSystemUsersList()
        {
            InitializeComponent();
        }

        private void frmSystemUsersAndSettings_Load(object sender, EventArgs e)
        {
            ppSystemUsers.Visible = true;
            FillUsersList();
            ppSystemUsers.Visible = false;
        }

        private async Task FillUsersList()
        {
            try
            {
                _isLoaded = false;
                List<SystemUser> cashier = await MySqlDAL.GetCashiersList();
                lstSystemUsers.DisplayMember = "UserName";
                lstSystemUsers.DataSource = cashier;
                lstSystemUsers.SelectedIndex = -1;
                _isLoaded = true;
            }
            catch (Exception ee)
            {
                MessageBox.Show(string.Format("Error : {0}", ee.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnSaveCashier_Click(object sender, EventArgs e)
        {
            try
            {
                ppSystemUsers.Visible = true;

                if (chkResetPassword.Checked)
                {
                    // IRestResponse resp = await APIs_DAL.ResetPassword(txtUserName.Text, txtPassword.Text);
                    int rec = await MySqlDAL.AddUpdateSystemUser(new SystemUser()
                    {
                        ID = _userID,
                        UserName = txtUserName.Text,
                        Password = txtPassword.Text,
                        UserType = cmbUserType.Text
                    });

                    // if (resp.IsSuccessful && resp.StatusCode == System.Net.HttpStatusCode.OK && resp.Content.ToLower().Contains("success"))
                    if (rec >= 0)
                    {
                        await FillUsersList();
                        Reset();
                    }
                    else
                    {
                        MessageBox.Show(string.Format("Server is not accessible"), "Out of Reach", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (_userID == 0 && await ValidateForm())
                {
                    //string Salt = "";//, HashPassword = "";
                    //if (_userID == 0 || (_userID > 0 && chkResetPassword.Checked))
                    //{
                    // //   Salt = new Random().Next(1000, 9999).ToString();
                    //    //  HashPassword = Utilis.Utilis.GetHashString(string.Format("{0}{1}", txtPassword.Text, Salt));
                    //}

                    // IRestResponse resp = await APIs_DAL.CreateUser(txtUserName.Text, txtPassword.Text, Salt);
                    // if (resp.IsSuccessful && resp.StatusCode == System.Net.HttpStatusCode.OK)
                    int rec = await MySqlDAL.AddUpdateSystemUser(new SystemUser()
                    {
                        ID = 0,
                        UserName = txtUserName.Text,
                        Password = txtPassword.Text,
                        UserType = cmbUserType.Text
                    });

                    if (rec >= 0)
                    {
                        await FillUsersList();
                        Reset();
                    }
                    else
                    {
                        MessageBox.Show(string.Format("Server is not accessible"), "Out of Reach", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(string.Format("Error : {0}", ee.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ppSystemUsers.Visible = false;
        }

        private async Task<bool> ValidateForm()
        {
            if (txtUserName.Text.Trim() == "")
            {
                MessageBox.Show("Username is required", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Focus();
                return false;
            }
            else if (!(await MySqlDAL.IsValidCashierName(_userID, txtUserName.Text.Trim())))
            {
                MessageBox.Show("Username already exist.", "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Focus();
                return false;
            }
            else if (cmbUserType.SelectedIndex == -1)
            {
                MessageBox.Show("User Type is required", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbUserType.Focus();
                return false;
            }
            else if (txtPassword.Text == "" || txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Passwords should be same.", "Invalid Passwords", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return false;
            }
            return true;
        }

        private void btnResetCashier_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            _isLoaded = false;
            lstSystemUsers.SelectedIndex = -1;
            chkResetPassword.Visible = false;
            chkResetPassword.Checked = false;

            txtUserName.Text = txtPassword.Text = txtConfirmPassword.Text = "";
            cmbUserType.SelectedIndex = -1;
            cmbUserType.Text = "";
            lblUserCaption.Text = "CREATE NEW USER";
            _userID = 0;
            txtPassword.ReadOnly = txtConfirmPassword.ReadOnly = txtUserName.ReadOnly = false;
            txtUserName.Focus();
            _isLoaded = true;
        }

        //private async void btnDeleteCashier_Click(object sender, EventArgs e)
        //{
        //    if (lstSystemUsers.SelectedIndex > -1)
        //    {
        //        try
        //        {
        //            if (DialogResult.Yes == MessageBox.Show("Do you want to delete?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
        //            {
        //                ppSystemUsers.Visible = true;
        //                Cashier cash = lstSystemUsers.SelectedItem as Cashier;
        //                int rec = await DAL.MySqlDAL.DeleteCashier(cash.ID);
        //                if (rec > 0)
        //                    FillUsersList();
        //            }
        //        }
        //        catch (Exception ee)
        //        {
        //            MessageBox.Show(string.Format("Error : {0}", ee.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //        ppSystemUsers.Visible = false;
        //    }
        //}

        private void lstSystemUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (_isLoaded && lstSystemUsers.SelectedIndex > -1)
                {
                    SystemUser cash = lstSystemUsers.SelectedItem as SystemUser;
                    _userID = cash.ID;
                    txtUserName.Text = cash.UserName;
                    cmbUserType.EditValue = cash.UserType.ToUpper();
                    txtPassword.Text = "***";
                    txtConfirmPassword.Text = "***";
                    lblUserCaption.Text = "MODIFY EXISTING USER";

                    txtPassword.ReadOnly = txtConfirmPassword.ReadOnly = txtUserName.ReadOnly = true;
                    chkResetPassword.Visible = true;
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(string.Format("Error : {0}", ee.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkResetPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.ReadOnly = txtConfirmPassword.ReadOnly = !chkResetPassword.Checked;
            txtPassword.Text = txtConfirmPassword.Text = chkResetPassword.Checked ? "" : "***";
            txtPassword.Focus();
        }
    }
}