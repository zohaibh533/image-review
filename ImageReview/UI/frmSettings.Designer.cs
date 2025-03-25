namespace ImageReview.UI
{
    partial class frmSettings
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
            this.txtDataFolderPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdminReviewPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtModificationPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtReviewPath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtDataFolderPath
            // 
            this.txtDataFolderPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDataFolderPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtDataFolderPath.Location = new System.Drawing.Point(259, 43);
            this.txtDataFolderPath.Name = "txtDataFolderPath";
            this.txtDataFolderPath.Size = new System.Drawing.Size(204, 34);
            this.txtDataFolderPath.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data Folder Path";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(59, 266);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(404, 63);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Admin Review Path";
            // 
            // txtAdminReviewPath
            // 
            this.txtAdminReviewPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdminReviewPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtAdminReviewPath.Location = new System.Drawing.Point(259, 91);
            this.txtAdminReviewPath.Name = "txtAdminReviewPath";
            this.txtAdminReviewPath.Size = new System.Drawing.Size(204, 34);
            this.txtAdminReviewPath.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Modification Path";
            // 
            // txtModificationPath
            // 
            this.txtModificationPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtModificationPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtModificationPath.Location = new System.Drawing.Point(259, 139);
            this.txtModificationPath.Name = "txtModificationPath";
            this.txtModificationPath.Size = new System.Drawing.Size(204, 34);
            this.txtModificationPath.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Review Path";
            // 
            // txtReviewPath
            // 
            this.txtReviewPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReviewPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtReviewPath.Location = new System.Drawing.Point(259, 189);
            this.txtReviewPath.Name = "txtReviewPath";
            this.txtReviewPath.Size = new System.Drawing.Size(204, 34);
            this.txtReviewPath.TabIndex = 3;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(522, 353);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtReviewPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtModificationPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAdminReviewPath);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDataFolderPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSettings";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtDataFolderPath;
        public System.Windows.Forms.TextBox txtAdminReviewPath;
        public System.Windows.Forms.TextBox txtModificationPath;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtReviewPath;
    }
}