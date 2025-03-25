using Newtonsoft.Json;
using ImageReview.Logic;
using RestSharp;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageReview.UI
{
    public partial class frmChangePassword : DevExpress.XtraEditors.XtraForm
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            txtCurrentPassword.Focus();
        }

        private async void btnChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                ppWait.Visible = true;
                if (await ValidateForm())
                {
                    //string Salt = new Random().Next(1000, 9999).ToString();
                    // string HashPassword = Utilis.GetHashString(string.Format("{0}{1}", txtNewPassword.Text, Salt));

                    int rec = await MySqlDAL.ChangeSystemUserPassword(Utilis.UserName, txtNewPassword.Text);
                    if (rec >= 0)
                    {
                        Utilis.Password = txtNewPassword.Text;
                        Reset();
                        MessageBox.Show(string.Format("Password has been changed successfully"), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            ppWait.Visible = false;
        }

        private void Reset()
        {
            txtConfirmPassword.Text = txtCurrentPassword.Text = txtNewPassword.Text = "";
            txtCurrentPassword.Focus();
        }

        private async Task<bool> ValidateForm()
        {
            //IRestResponse resp = await APIs_DAL.GetAuthenticationResponce(Utilis.UserName,
            //    txtCurrentPassword.Text);
            //if (resp.IsSuccessful && resp.StatusCode == System.Net.HttpStatusCode.OK)
            //{
            //    LoginResponce_Root rest = JsonConvert.DeserializeObject<LoginResponce_Root>(resp.Content);
            // if (rest.Result[0].login.ToLower() != "success")
            if (txtCurrentPassword.Text != Utilis.Password)
            {
                MessageBox.Show("Current password is incorrect.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCurrentPassword.Focus();
                return false;
            }
            //    }

            if (txtNewPassword.Text == "" || txtNewPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Both passwords should be same", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewPassword.Focus();
                return false;
            }
            return true;
        }

    }
}