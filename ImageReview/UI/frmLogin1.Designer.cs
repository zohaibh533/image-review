namespace ImageReview.UI
{
    partial class frmLogin1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin1));
            this.pnlWait = new System.Windows.Forms.Panel();
            this.ppWait = new DevExpress.XtraWaitForm.ProgressPanel();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.chkMemberMe = new System.Windows.Forms.CheckBox();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlWait.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlWait
            // 
            this.pnlWait.Controls.Add(this.ppWait);
            this.pnlWait.Location = new System.Drawing.Point(22, 278);
            this.pnlWait.Name = "pnlWait";
            this.pnlWait.Size = new System.Drawing.Size(190, 70);
            this.pnlWait.TabIndex = 62;
            this.pnlWait.Visible = false;
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
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblPassword.Location = new System.Drawing.Point(156, 300);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(97, 28);
            this.lblPassword.TabIndex = 61;
            this.lblPassword.Text = "Password";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblUsername.Location = new System.Drawing.Point(156, 247);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(104, 28);
            this.lblUsername.TabIndex = 60;
            this.lblUsername.Text = "Username";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDesc
            // 
            this.lblDesc.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.ForeColor = System.Drawing.Color.DimGray;
            this.lblDesc.Location = new System.Drawing.Point(256, 85);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(435, 68);
            this.lblDesc.TabIndex = 59;
            this.lblDesc.Text = "Welcome to the License Plate \r\nReview Application!";
            this.lblDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLogin
            // 
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblLogin.Location = new System.Drawing.Point(361, 26);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(225, 43);
            this.lblLogin.TabIndex = 58;
            this.lblLogin.Text = "SIGN IN";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUserName
            // 
            this.txtUserName.EditValue = "";
            this.txtUserName.EnterMoveNextControl = true;
            this.txtUserName.Location = new System.Drawing.Point(289, 240);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.txtUserName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Properties.Appearance.Options.UseBorderColor = true;
            this.txtUserName.Properties.Appearance.Options.UseFont = true;
            this.txtUserName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtUserName.Properties.ContextImageAlignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.txtUserName.Size = new System.Drawing.Size(258, 42);
            this.txtUserName.TabIndex = 52;
            this.txtUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserName_KeyDown);
            // 
            // txtPassword
            // 
            this.txtPassword.EditValue = "";
            this.txtPassword.EnterMoveNextControl = true;
            this.txtPassword.Location = new System.Drawing.Point(289, 293);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.txtPassword.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Properties.Appearance.Options.UseBorderColor = true;
            this.txtPassword.Properties.Appearance.Options.UseFont = true;
            this.txtPassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtPassword.Properties.ContextImageAlignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.txtPassword.Properties.UseSystemPasswordChar = true;
            this.txtPassword.Size = new System.Drawing.Size(258, 42);
            this.txtPassword.TabIndex = 53;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserName_KeyDown);
            // 
            // chkMemberMe
            // 
            this.chkMemberMe.AutoSize = true;
            this.chkMemberMe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkMemberMe.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkMemberMe.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMemberMe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.chkMemberMe.Location = new System.Drawing.Point(289, 351);
            this.chkMemberMe.Name = "chkMemberMe";
            this.chkMemberMe.Size = new System.Drawing.Size(171, 33);
            this.chkMemberMe.TabIndex = 54;
            this.chkMemberMe.Text = "Remember Me";
            this.chkMemberMe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkMemberMe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.chkMemberMe.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnLogin.Appearance.Options.UseFont = true;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
            this.btnLogin.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnLogin.Location = new System.Drawing.Point(161, 401);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(386, 58);
            this.btnLogin.TabIndex = 56;
            this.btnLogin.Text = "  LOGIN";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // picLogo
            // 
            this.picLogo.BackgroundImage = global::ImageReview.Properties.Resources.Logo;
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picLogo.Location = new System.Drawing.Point(12, 11);
            this.picLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(238, 178);
            this.picLogo.TabIndex = 55;
            this.picLogo.TabStop = false;
            // 
            // frmLogin1
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 504);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pnlWait);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.chkMemberMe);
            this.Controls.Add(this.picLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.frmLogin1_HelpButtonClicked);
            this.Load += new System.EventHandler(this.frmLogin1_Load);
            this.pnlWait.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private System.Windows.Forms.Panel pnlWait;
        public DevExpress.XtraWaitForm.ProgressPanel ppWait;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblLogin;
        private DevExpress.XtraEditors.TextEdit txtUserName;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private System.Windows.Forms.CheckBox chkMemberMe;
        private System.Windows.Forms.PictureBox picLogo;
    }
}