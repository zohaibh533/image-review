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

namespace ImageReview.UI
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
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
                Utilis.CorrectionFolderPath = ConfigurationManager.AppSettings["CorrectionPath"];

                Design();



                this.Size = new System.Drawing.Size(700, 496);
                //picClose.Location = new System.Drawing.Point(this.Width - picClose.Width-10, 5);
                //picLogo.Size = new System.Drawing.Size(296, 214);
                //this.txtPassword.Location = new System.Drawing.Point(325, 313);
                //this.txtPassword.Size = new System.Drawing.Size(258, 42);
                //this.lblLogin.Location = new System.Drawing.Point(327, 58);
                //this.lblLogin.Size = new System.Drawing.Size(301, 43);
                //this.lblDesc.Location = new System.Drawing.Point(329, 117);
                //this.lblDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                //this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                //this.lblDesc.Size = new System.Drawing.Size(299, 68);

                pnlWait.Location = new Point(((this.Width / 2) - (pnlWait.Width / 2)),
               ((this.Height / 2) - (pnlWait.Height / 2)));

                txtUserName.Focus();
                txtUserName.Select(txtUserName.Text.Length, 0);
                //  pictureBox2.Size = new System.Drawing.Size(372, 496);
                
                //  picLogo.Location = new System.Drawing.Point((this.Width / 4 * 3) - (picLogo.Width / 2), 10);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Design()
        {
            this.chkMemberMe.AutoSize = true;
            this.chkMemberMe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkMemberMe.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkMemberMe.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMemberMe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.chkMemberMe.Location = new System.Drawing.Point(325, 351);
            this.chkMemberMe.Name = "chkMemberMe";
            this.chkMemberMe.Size = new System.Drawing.Size(171, 33);
            this.chkMemberMe.TabIndex = 2;
            this.chkMemberMe.Text = "Remember Me";
            this.chkMemberMe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkMemberMe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.chkMemberMe.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.EditValue = "";
            this.txtPassword.EnterMoveNextControl = true;
            this.txtPassword.Location = new System.Drawing.Point(325, 293);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.txtPassword.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Properties.Appearance.Options.UseBorderColor = true;
            this.txtPassword.Properties.Appearance.Options.UseFont = true;
            this.txtPassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtPassword.Properties.ContextImageAlignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.txtPassword.Properties.UseSystemPasswordChar = true;
            this.txtPassword.Size = new System.Drawing.Size(258, 42);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserName_KeyDown);
            // 
            // txtUserName
            // 
            this.txtUserName.EditValue = "";
            this.txtUserName.EnterMoveNextControl = true;
            this.txtUserName.Location = new System.Drawing.Point(325, 240);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.txtUserName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Properties.Appearance.Options.UseBorderColor = true;
            this.txtUserName.Properties.Appearance.Options.UseFont = true;
            this.txtUserName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtUserName.Properties.ContextImageAlignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.txtUserName.Size = new System.Drawing.Size(258, 42);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserName_KeyDown);
            // 
            // ppWait
            // 
            this.ppWait.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.ppWait.Appearance.Options.UseBackColor = true;
            this.ppWait.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.ppWait.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ppWait.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.ppWait.Location = new System.Drawing.Point(0, 0);
            this.ppWait.Name = "ppWait";
            this.ppWait.Size = new System.Drawing.Size(190, 70);
            this.ppWait.TabIndex = 50;
            this.ppWait.ToolTip = "Data is loading";
            this.ppWait.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.ppWait.ToolTipTitle = "Please Wait";
            this.ppWait.Visible = false;
            this.ppWait.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Ring;
            // 
            // lblLogin
            // 
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblLogin.Location = new System.Drawing.Point(327, 58);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(301, 43);
            this.lblLogin.TabIndex = 8;
            this.lblLogin.Text = "SIGN IN";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDesc
            // 
            this.lblDesc.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.ForeColor = System.Drawing.Color.DimGray;
            this.lblDesc.Location = new System.Drawing.Point(329, 117);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(299, 68);
            this.lblDesc.TabIndex = 9;
            this.lblDesc.Text = "Welcome to the License Plate \r\nReview Application!";
            this.lblDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblUsername.Location = new System.Drawing.Point(192, 247);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(104, 28);
            this.lblUsername.TabIndex = 10;
            this.lblUsername.Text = "Username";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblPassword.Location = new System.Drawing.Point(192, 300);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(97, 28);
            this.lblPassword.TabIndex = 11;
            this.lblPassword.Text = "Password";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlWait
            // 
            this.pnlWait.Controls.Add(this.ppWait);
            this.pnlWait.Location = new System.Drawing.Point(603, 204);
            this.pnlWait.Name = "pnlWait";
            this.pnlWait.Size = new System.Drawing.Size(190, 70);
            this.pnlWait.TabIndex = 51;
            this.pnlWait.Visible = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnLogin.Appearance.Options.UseFont = true;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnLogin.Location = new System.Drawing.Point(197, 406);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(386, 58);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "  LOGIN";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // picClose
            // 
            this.picClose.BackgroundImage = global::ImageReview.Properties.Resources.CloseButton;
            this.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Location = new System.Drawing.Point(711, 0);
            this.picClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(64, 51);
            this.picClose.TabIndex = 7;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // picLogo
            // 
            this.picLogo.BackgroundImage = global::ImageReview.Properties.Resources.Logo;
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picLogo.Location = new System.Drawing.Point(12, 11);
            this.picLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(296, 214);
            this.picLogo.TabIndex = 2;
            this.picLogo.TabStop = false;
            // 
            // frmLogin
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 502);
            this.Size = new System.Drawing.Size(781, 502);
        }
        private static void GrantAccess()
        {
            try
            {
                string file = Application.StartupPath;
                bool exists = System.IO.Directory.Exists(file);
                //if (!exists)
                //{
                //    DirectoryInfo di = System.IO.Directory.CreateDirectory(file);
                //  //  Console.WriteLine("The Folder is created Sucessfully");
                //}
                //else
                //{
                //    //Console.WriteLine("The Folder already exists");
                //}
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

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            //  Exit();
        }

        private void Exit()
        {
            Application.Exit();
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

        private void picClose_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin_Click(sender, e);
        }
    }
}