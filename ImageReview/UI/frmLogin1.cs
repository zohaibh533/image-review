using Newtonsoft.Json;
using ImageReview.Logic;
using RestSharp;
using System;
using System.Configuration;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;
using System.Xml;

namespace ImageReview.UI
{
    public partial class frmLogin1 : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin1()
        {
            InitializeComponent();
        }

        private void frmLogin1_Load(object sender, EventArgs e)
        {
            try
            {
                GrantAccess();
                if (Properties.Settings.Default.UserName != string.Empty)
                {
                    txtUserName.Text = Properties.Settings.Default.UserName;
                    txtPassword.Text = Properties.Settings.Default.Password;
                    chkMemberMe.Checked = true;
                }

                Utilis.dbServer = ConfigurationManager.AppSettings["dbServer"];
                Utilis.dbUser = ConfigurationManager.AppSettings["dbUser"];
                Utilis.dbPwd = ConfigurationManager.AppSettings["dbPwd"];

                pnlWait.Location = new Point(((this.Width / 2) - (pnlWait.Width / 2)),
               ((this.Height / 2) - (pnlWait.Height / 2)));

                txtUserName.Focus();
                txtUserName.Select(txtUserName.Text.Length, 0);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void GrantAccess()
        {
            try
            {
                string file = Application.StartupPath;
                bool exists = System.IO.Directory.Exists(file);
                DirectoryInfo dInfo = new DirectoryInfo(file);
                DirectorySecurity dSecurity = dInfo.GetAccessControl();
                dSecurity.AddAccessRule(new FileSystemAccessRule(new SecurityIdentifier(WellKnownSidType.WorldSid, null),
                    FileSystemRights.FullControl, InheritanceFlags.ObjectInherit | InheritanceFlags.ContainerInherit, PropagationFlags.NoPropagateInherit, AccessControlType.Allow));
                dInfo.SetAccessControl(dSecurity);
            }
            catch (Exception ee)
            {
                MessageBox.Show(string.Format("Open application using Run as Administrator.\n{0}", ee.Message), "Required Admin Access", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateForm())
                {
                    pnlWait.Visible = ppWait.Visible = true;
                    string userType = await MySqlDAL.AuthenticateSystemUser(txtUserName.Text.Trim(), txtPassword.Text);

                    if (userType != "")
                    {
                        Utilis.UserName = txtUserName.Text.Trim();
                        Utilis.Password = txtPassword.Text;
                        Utilis.UserType = userType.ToLower();

                        await MySqlDAL.AddLoginActivity();

                        Utilis.CorrectionFolderPath = Properties.Settings.Default.CorrectionPath;
                        Utilis.ForwardFolderPath = Properties.Settings.Default.AdminReviewPath;
                        Utilis.ModificationFolderPath = Properties.Settings.Default.ModificationPath;
                        Utilis.ReviewPath = Properties.Settings.Default.ReviewPath;

                        SaveCredentialSettings();
                        this.Hide();
                        frmDashboard frm = new frmDashboard();
                        frm.Show();
                    }
                    else
                    {
                        MessageBox.Show(string.Format("Invalid User Name and Password"), "Invalid Credentials", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtUserName.Focus();
                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(string.Format("Error : {0}", ee.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            pnlWait.Visible = ppWait.Visible = false;
        }

        private bool ValidateForm()
        {
            if (txtUserName.Text.Trim() == "")
            {
                MessageBox.Show("Username is required", "Invalid Credentials", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Focus();
                return false;
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Password is required", "Invalid Credentials", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return false;
            }
            return true;
        }

        private void SaveCredentialSettings()
        {
            Task.Run(() =>
            {
                if (chkMemberMe.Checked)
                {
                    Properties.Settings.Default.UserName = txtUserName.Text;
                    Properties.Settings.Default.Password = txtPassword.Text;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.UserName = "";
                    Properties.Settings.Default.Password = "";
                    Properties.Settings.Default.Save();
                }
            });
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin_Click(sender, e);
        }

        private void frmLogin1_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                Help.ShowHelp(this, "helpfile.chm");
                frmSettings frm = new frmSettings();
                frm.txtDataFolderPath.Text = Properties.Settings.Default.CorrectionPath;
                frm.txtAdminReviewPath.Text = Properties.Settings.Default.AdminReviewPath;
                frm.txtModificationPath.Text = Properties.Settings.Default.ModificationPath;
                frm.txtReviewPath.Text = Properties.Settings.Default.ReviewPath;

                DialogResult res = frm.ShowDialog();
                if (res == DialogResult.OK)
                {
                    Properties.Settings.Default.CorrectionPath = frm.txtDataFolderPath.Text.Trim();
                    Properties.Settings.Default.AdminReviewPath = frm.txtAdminReviewPath.Text.Trim();
                    Properties.Settings.Default.ModificationPath = frm.txtModificationPath.Text.Trim();
                    Properties.Settings.Default.ReviewPath = frm.txtReviewPath.Text.Trim();
                    Properties.Settings.Default.Save();
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(string.Format("Error : {0}", ee.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}