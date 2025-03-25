namespace ImageReview.UI
{
    partial class frmChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangePassword));
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNewPassword = new DevExpress.XtraEditors.TextEdit();
            this.txtCurrentPassword = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new DevExpress.XtraEditors.TextEdit();
            this.btnChangePassword = new DevExpress.XtraEditors.SimpleButton();
            this.ppWait = new DevExpress.XtraWaitForm.ProgressPanel();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrentPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfirmPassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.label6.Location = new System.Drawing.Point(168, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Current Password";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.label5.Location = new System.Drawing.Point(168, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "New Password";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.EditValue = "";
            this.txtNewPassword.EnterMoveNextControl = true;
            this.txtNewPassword.Location = new System.Drawing.Point(168, 154);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.txtNewPassword.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.Properties.Appearance.Options.UseBorderColor = true;
            this.txtNewPassword.Properties.Appearance.Options.UseFont = true;
            this.txtNewPassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtNewPassword.Properties.ContextImageAlignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.txtNewPassword.Properties.PasswordChar = '*';
            this.txtNewPassword.Properties.UseSystemPasswordChar = true;
            this.txtNewPassword.Size = new System.Drawing.Size(258, 36);
            this.txtNewPassword.TabIndex = 1;
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.EditValue = "";
            this.txtCurrentPassword.EnterMoveNextControl = true;
            this.txtCurrentPassword.Location = new System.Drawing.Point(168, 76);
            this.txtCurrentPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.txtCurrentPassword.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentPassword.Properties.Appearance.Options.UseBorderColor = true;
            this.txtCurrentPassword.Properties.Appearance.Options.UseFont = true;
            this.txtCurrentPassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtCurrentPassword.Properties.ContextImageAlignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.txtCurrentPassword.Properties.PasswordChar = '*';
            this.txtCurrentPassword.Properties.UseSystemPasswordChar = true;
            this.txtCurrentPassword.Size = new System.Drawing.Size(258, 36);
            this.txtCurrentPassword.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.label1.Location = new System.Drawing.Point(168, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Confirm Password";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.EditValue = "";
            this.txtConfirmPassword.EnterMoveNextControl = true;
            this.txtConfirmPassword.Location = new System.Drawing.Point(168, 232);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.txtConfirmPassword.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.Properties.Appearance.Options.UseBorderColor = true;
            this.txtConfirmPassword.Properties.Appearance.Options.UseFont = true;
            this.txtConfirmPassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtConfirmPassword.Properties.ContextImageAlignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.txtConfirmPassword.Properties.PasswordChar = '*';
            this.txtConfirmPassword.Properties.UseSystemPasswordChar = true;
            this.txtConfirmPassword.Size = new System.Drawing.Size(258, 36);
            this.txtConfirmPassword.TabIndex = 2;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.Appearance.Options.UseFont = true;
            this.btnChangePassword.Image = ((System.Drawing.Image)(resources.GetObject("btnChangePassword.Image")));
            this.btnChangePassword.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnChangePassword.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnChangePassword.Location = new System.Drawing.Point(168, 327);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(258, 58);
            this.btnChangePassword.TabIndex = 3;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // ppWait
            // 
            this.ppWait.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ppWait.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.ppWait.Appearance.Options.UseBackColor = true;
            this.ppWait.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.ppWait.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.ppWait.Location = new System.Drawing.Point(172, 152);
            this.ppWait.Name = "ppWait";
            this.ppWait.Size = new System.Drawing.Size(246, 50);
            this.ppWait.TabIndex = 51;
            this.ppWait.ToolTip = "Data is loading";
            this.ppWait.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.ppWait.ToolTipTitle = "Please Wait";
            this.ppWait.Visible = false;
            this.ppWait.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Ring;
            // 
            // frmChangePassword
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 428);
            this.Controls.Add(this.ppWait);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtCurrentPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChangePassword";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHANGE PASSWORD";
            this.Load += new System.EventHandler(this.frmChangePassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrentPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfirmPassword.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit txtNewPassword;
        private DevExpress.XtraEditors.TextEdit txtCurrentPassword;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtConfirmPassword;
        private DevExpress.XtraEditors.SimpleButton btnChangePassword;
        public DevExpress.XtraWaitForm.ProgressPanel ppWait;
    }
}