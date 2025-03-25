namespace ImageReview.UI
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.chkMemberMe = new System.Windows.Forms.CheckBox();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.ppWait = new DevExpress.XtraWaitForm.ProgressPanel();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.pnlWait = new System.Windows.Forms.Panel();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            this.pnlWait.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // chkMemberMe
            // 
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
            this.pnlWait.Location = new System.Drawing.Point(22, 278);
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
            this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
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
            this.picClose.Location = new System.Drawing.Point(660, 31);
            this.picClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(64, 51);
            this.picClose.TabIndex = 7;
            this.picClose.TabStop = false;
            this.picClose.Visible = false;
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
            this.ClientSize = new System.Drawing.Size(831, 549);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pnlWait);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.chkMemberMe);
            this.Controls.Add(this.picLogo);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLogin_FormClosed);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            this.pnlWait.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.CheckBox chkMemberMe;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.TextEdit txtUserName;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        public DevExpress.XtraWaitForm.ProgressPanel ppWait;
        private System.Windows.Forms.Panel pnlWait;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
    }
}