namespace ImageReview.UI
{
    partial class frmSystemUsersList
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkResetPassword = new System.Windows.Forms.CheckBox();
            this.lblUserCaption = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ppSystemUsers = new DevExpress.XtraWaitForm.ProgressPanel();
            this.cmbUserType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnResetCashier = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSaveCashier = new System.Windows.Forms.Button();
            this.lstSystemUsers = new DevExpress.XtraEditors.ListBoxControl();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbUserType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstSystemUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkResetPassword);
            this.groupBox1.Controls.Add(this.lblUserCaption);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ppSystemUsers);
            this.groupBox1.Controls.Add(this.cmbUserType);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtConfirmPassword);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnResetCashier);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnSaveCashier);
            this.groupBox1.Controls.Add(this.lstSystemUsers);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(10, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 457);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // chkResetPassword
            // 
            this.chkResetPassword.AutoSize = true;
            this.chkResetPassword.Location = new System.Drawing.Point(583, 225);
            this.chkResetPassword.Name = "chkResetPassword";
            this.chkResetPassword.Size = new System.Drawing.Size(103, 17);
            this.chkResetPassword.TabIndex = 3;
            this.chkResetPassword.Text = "Reset Password";
            this.chkResetPassword.UseVisualStyleBackColor = true;
            this.chkResetPassword.Visible = false;
            this.chkResetPassword.CheckedChanged += new System.EventHandler(this.chkResetPassword_CheckedChanged);
            // 
            // lblUserCaption
            // 
            this.lblUserCaption.AutoSize = true;
            this.lblUserCaption.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(47)))), ((int)(((byte)(73)))));
            this.lblUserCaption.Location = new System.Drawing.Point(406, 17);
            this.lblUserCaption.Name = "lblUserCaption";
            this.lblUserCaption.Size = new System.Drawing.Size(146, 21);
            this.lblUserCaption.TabIndex = 142;
            this.lblUserCaption.Text = "CREATE NEW USER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(47)))), ((int)(((byte)(73)))));
            this.label3.Location = new System.Drawing.Point(19, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 21);
            this.label3.TabIndex = 141;
            this.label3.Text = "USERS LIST";
            // 
            // ppSystemUsers
            // 
            this.ppSystemUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ppSystemUsers.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.ppSystemUsers.Appearance.Options.UseBackColor = true;
            this.ppSystemUsers.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.ppSystemUsers.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.ppSystemUsers.Location = new System.Drawing.Point(240, 140);
            this.ppSystemUsers.Name = "ppSystemUsers";
            this.ppSystemUsers.Size = new System.Drawing.Size(158, 49);
            this.ppSystemUsers.TabIndex = 132;
            this.ppSystemUsers.ToolTip = "Data is loading";
            this.ppSystemUsers.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.ppSystemUsers.ToolTipTitle = "Please Wait";
            this.ppSystemUsers.Visible = false;
            this.ppSystemUsers.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Ring;
            // 
            // cmbUserType
            // 
            this.cmbUserType.EnterMoveNextControl = true;
            this.cmbUserType.Location = new System.Drawing.Point(406, 165);
            this.cmbUserType.Name = "cmbUserType";
            this.cmbUserType.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUserType.Properties.Appearance.Options.UseFont = true;
            this.cmbUserType.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.cmbUserType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbUserType.Properties.Items.AddRange(new object[] {
            "USER",
            "ADMIN"});
            this.cmbUserType.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Simple;
            this.cmbUserType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbUserType.Size = new System.Drawing.Size(280, 32);
            this.cmbUserType.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(406, 248);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(280, 33);
            this.txtPassword.TabIndex = 4;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.Location = new System.Drawing.Point(406, 327);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(280, 33);
            this.txtConfirmPassword.TabIndex = 5;
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(406, 89);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(280, 33);
            this.txtUserName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(406, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 21);
            this.label1.TabIndex = 37;
            this.label1.Text = "Username ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(406, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 21);
            this.label7.TabIndex = 31;
            this.label7.Text = "Password ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(406, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 21);
            this.label6.TabIndex = 30;
            this.label6.Text = "Confirm Password";
            // 
            // btnResetCashier
            // 
            this.btnResetCashier.BackColor = System.Drawing.Color.Transparent;
            this.btnResetCashier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnResetCashier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetCashier.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnResetCashier.FlatAppearance.BorderSize = 0;
            this.btnResetCashier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetCashier.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetCashier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(47)))), ((int)(((byte)(73)))));
            this.btnResetCashier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResetCashier.Location = new System.Drawing.Point(406, 394);
            this.btnResetCashier.Name = "btnResetCashier";
            this.btnResetCashier.Size = new System.Drawing.Size(62, 28);
            this.btnResetCashier.TabIndex = 7;
            this.btnResetCashier.Text = "RESET";
            this.btnResetCashier.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnResetCashier.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnResetCashier.UseVisualStyleBackColor = false;
            this.btnResetCashier.Click += new System.EventHandler(this.btnResetCashier_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(406, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 27;
            this.label2.Text = "User Type";
            // 
            // btnSaveCashier
            // 
            this.btnSaveCashier.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveCashier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSaveCashier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveCashier.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSaveCashier.FlatAppearance.BorderSize = 0;
            this.btnSaveCashier.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSaveCashier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSaveCashier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveCashier.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCashier.ForeColor = System.Drawing.Color.Transparent;
            this.btnSaveCashier.Image = global::ImageReview.Properties.Resources.btnSaveWithIcon;
            this.btnSaveCashier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveCashier.Location = new System.Drawing.Point(501, 376);
            this.btnSaveCashier.Name = "btnSaveCashier";
            this.btnSaveCashier.Size = new System.Drawing.Size(194, 46);
            this.btnSaveCashier.TabIndex = 6;
            this.btnSaveCashier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSaveCashier.UseVisualStyleBackColor = false;
            this.btnSaveCashier.Click += new System.EventHandler(this.btnSaveCashier_Click);
            // 
            // lstSystemUsers
            // 
            this.lstSystemUsers.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSystemUsers.Appearance.Options.UseFont = true;
            this.lstSystemUsers.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lstSystemUsers.Location = new System.Drawing.Point(19, 57);
            this.lstSystemUsers.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.lstSystemUsers.Name = "lstSystemUsers";
            this.lstSystemUsers.Size = new System.Drawing.Size(307, 385);
            this.lstSystemUsers.TabIndex = 0;
            this.lstSystemUsers.SelectedIndexChanged += new System.EventHandler(this.lstSystemUsers_SelectedIndexChanged);
            // 
            // frmSystemUsersList
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 472);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSystemUsersList";
            this.Padding = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SYSTEM USERS";
            this.Load += new System.EventHandler(this.frmSystemUsersAndSettings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbUserType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstSystemUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.ListBoxControl lstSystemUsers;
        public System.Windows.Forms.Button btnResetCashier;
        public DevExpress.XtraWaitForm.ProgressPanel ppSystemUsers;
        public System.Windows.Forms.Button btnSaveCashier;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private DevExpress.XtraEditors.ComboBoxEdit cmbUserType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUserCaption;
        private System.Windows.Forms.CheckBox chkResetPassword;
    }
}