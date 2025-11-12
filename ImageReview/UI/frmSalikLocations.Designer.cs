namespace ImageReview.UI
{
    partial class frmSalikLocations
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
            this.lstPendingLocations = new DevExpress.XtraEditors.ListBoxControl();
            this.lstSelectedLocations = new DevExpress.XtraEditors.ListBoxControl();
            this.btnMove = new System.Windows.Forms.Button();
            this.lblPenLoc = new System.Windows.Forms.Label();
            this.lblSalikLoc = new System.Windows.Forms.Label();
            this.lblNotListed = new System.Windows.Forms.Label();
            this.lstNotListedInSalikLocations = new DevExpress.XtraEditors.ListBoxControl();
            this.lstSalikLocNotInAI = new DevExpress.XtraEditors.ListBoxControl();
            this.lblSalikLocNotInAI = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lstPendingLocations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstSelectedLocations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstNotListedInSalikLocations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstSalikLocNotInAI)).BeginInit();
            this.SuspendLayout();
            // 
            // lstPendingLocations
            // 
            this.lstPendingLocations.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPendingLocations.Appearance.Options.UseFont = true;
            this.lstPendingLocations.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lstPendingLocations.Location = new System.Drawing.Point(12, 49);
            this.lstPendingLocations.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.lstPendingLocations.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstPendingLocations.Name = "lstPendingLocations";
            this.lstPendingLocations.Size = new System.Drawing.Size(358, 379);
            this.lstPendingLocations.TabIndex = 0;
            // 
            // lstSelectedLocations
            // 
            this.lstSelectedLocations.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSelectedLocations.Appearance.Options.UseFont = true;
            this.lstSelectedLocations.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lstSelectedLocations.Location = new System.Drawing.Point(511, 49);
            this.lstSelectedLocations.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.lstSelectedLocations.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstSelectedLocations.Name = "lstSelectedLocations";
            this.lstSelectedLocations.Size = new System.Drawing.Size(358, 379);
            this.lstSelectedLocations.TabIndex = 2;
            // 
            // btnMove
            // 
            this.btnMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMove.Location = new System.Drawing.Point(382, 207);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(117, 63);
            this.btnMove.TabIndex = 1;
            this.btnMove.Text = ">";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // lblPenLoc
            // 
            this.lblPenLoc.AutoSize = true;
            this.lblPenLoc.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPenLoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(47)))), ((int)(((byte)(73)))));
            this.lblPenLoc.Location = new System.Drawing.Point(102, 13);
            this.lblPenLoc.Name = "lblPenLoc";
            this.lblPenLoc.Size = new System.Drawing.Size(179, 28);
            this.lblPenLoc.TabIndex = 142;
            this.lblPenLoc.Text = "Pending Locations";
            // 
            // lblSalikLoc
            // 
            this.lblSalikLoc.AutoSize = true;
            this.lblSalikLoc.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalikLoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(47)))), ((int)(((byte)(73)))));
            this.lblSalikLoc.Location = new System.Drawing.Point(617, 13);
            this.lblSalikLoc.Name = "lblSalikLoc";
            this.lblSalikLoc.Size = new System.Drawing.Size(146, 28);
            this.lblSalikLoc.TabIndex = 143;
            this.lblSalikLoc.Text = "Salik Locations";
            // 
            // lblNotListed
            // 
            this.lblNotListed.AutoSize = true;
            this.lblNotListed.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotListed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(47)))), ((int)(((byte)(73)))));
            this.lblNotListed.Location = new System.Drawing.Point(12, 443);
            this.lblNotListed.Name = "lblNotListed";
            this.lblNotListed.Size = new System.Drawing.Size(245, 28);
            this.lblNotListed.TabIndex = 144;
            this.lblNotListed.Text = "Missing in Salik Locations";
            // 
            // lstNotListedInSalikLocations
            // 
            this.lstNotListedInSalikLocations.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstNotListedInSalikLocations.Appearance.Options.UseFont = true;
            this.lstNotListedInSalikLocations.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lstNotListedInSalikLocations.Location = new System.Drawing.Point(12, 475);
            this.lstNotListedInSalikLocations.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.lstNotListedInSalikLocations.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstNotListedInSalikLocations.Name = "lstNotListedInSalikLocations";
            this.lstNotListedInSalikLocations.Size = new System.Drawing.Size(358, 154);
            this.lstNotListedInSalikLocations.TabIndex = 3;
            // 
            // lstSalikLocNotInAI
            // 
            this.lstSalikLocNotInAI.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSalikLocNotInAI.Appearance.Options.UseFont = true;
            this.lstSalikLocNotInAI.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lstSalikLocNotInAI.Location = new System.Drawing.Point(511, 475);
            this.lstSalikLocNotInAI.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.lstSalikLocNotInAI.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstSalikLocNotInAI.Name = "lstSalikLocNotInAI";
            this.lstSalikLocNotInAI.Size = new System.Drawing.Size(358, 154);
            this.lstSalikLocNotInAI.TabIndex = 145;
            // 
            // lblSalikLocNotInAI
            // 
            this.lblSalikLocNotInAI.AutoSize = true;
            this.lblSalikLocNotInAI.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalikLocNotInAI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(47)))), ((int)(((byte)(73)))));
            this.lblSalikLocNotInAI.Location = new System.Drawing.Point(511, 443);
            this.lblSalikLocNotInAI.Name = "lblSalikLocNotInAI";
            this.lblSalikLocNotInAI.Size = new System.Drawing.Size(241, 28);
            this.lblSalikLocNotInAI.TabIndex = 146;
            this.lblSalikLocNotInAI.Text = "Missing in JLT Server 1.19";
            // 
            // frmSalikLocations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 642);
            this.Controls.Add(this.lstSalikLocNotInAI);
            this.Controls.Add(this.lblSalikLocNotInAI);
            this.Controls.Add(this.lstNotListedInSalikLocations);
            this.Controls.Add(this.lblNotListed);
            this.Controls.Add(this.lblSalikLoc);
            this.Controls.Add(this.lblPenLoc);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.lstSelectedLocations);
            this.Controls.Add(this.lstPendingLocations);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSalikLocations";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Salik Locations";
            this.Load += new System.EventHandler(this.frmSalikLocations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lstPendingLocations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstSelectedLocations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstNotListedInSalikLocations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstSalikLocNotInAI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ListBoxControl lstPendingLocations;
        private DevExpress.XtraEditors.ListBoxControl lstSelectedLocations;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Label lblPenLoc;
        private System.Windows.Forms.Label lblSalikLoc;
        private System.Windows.Forms.Label lblNotListed;
        private DevExpress.XtraEditors.ListBoxControl lstNotListedInSalikLocations;
        private DevExpress.XtraEditors.ListBoxControl lstSalikLocNotInAI;
        private System.Windows.Forms.Label lblSalikLocNotInAI;
    }
}