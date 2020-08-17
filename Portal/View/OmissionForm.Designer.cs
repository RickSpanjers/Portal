namespace DataconPortal.View
{
    partial class OmissionForm
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
            this.lbxOmission = new System.Windows.Forms.ListBox();
            this.btnAddOmission = new System.Windows.Forms.Button();
            this.btnAllow = new System.Windows.Forms.Button();
            this.btnRefuse = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxOmission
            // 
            this.lbxOmission.FormattingEnabled = true;
            this.lbxOmission.Location = new System.Drawing.Point(12, 12);
            this.lbxOmission.Name = "lbxOmission";
            this.lbxOmission.Size = new System.Drawing.Size(383, 381);
            this.lbxOmission.TabIndex = 0;
            // 
            // btnAddOmission
            // 
            this.btnAddOmission.Location = new System.Drawing.Point(401, 12);
            this.btnAddOmission.Name = "btnAddOmission";
            this.btnAddOmission.Size = new System.Drawing.Size(82, 39);
            this.btnAddOmission.TabIndex = 2;
            this.btnAddOmission.Text = "Verzuim aanvragen";
            this.btnAddOmission.UseVisualStyleBackColor = true;
            this.btnAddOmission.Click += new System.EventHandler(this.btnAddOmission_Click);
            // 
            // btnAllow
            // 
            this.btnAllow.Location = new System.Drawing.Point(401, 76);
            this.btnAllow.Name = "btnAllow";
            this.btnAllow.Size = new System.Drawing.Size(82, 45);
            this.btnAllow.TabIndex = 12;
            this.btnAllow.Text = "Verzuim toestaan";
            this.btnAllow.UseVisualStyleBackColor = true;
            this.btnAllow.Click += new System.EventHandler(this.btnAllow_Click);
            // 
            // btnRefuse
            // 
            this.btnRefuse.Location = new System.Drawing.Point(401, 147);
            this.btnRefuse.Name = "btnRefuse";
            this.btnRefuse.Size = new System.Drawing.Size(82, 45);
            this.btnRefuse.TabIndex = 13;
            this.btnRefuse.Text = "Verzuim weigeren";
            this.btnRefuse.UseVisualStyleBackColor = true;
            this.btnRefuse.Click += new System.EventHandler(this.btnRefuse_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(401, 213);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(82, 45);
            this.btnDashboard.TabIndex = 14;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // OmissionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 414);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.btnRefuse);
            this.Controls.Add(this.btnAllow);
            this.Controls.Add(this.btnAddOmission);
            this.Controls.Add(this.lbxOmission);
            this.Name = "OmissionForm";
            this.Text = "Verzuim";
            this.Load += new System.EventHandler(this.Verzuim_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxOmission;
        private System.Windows.Forms.Button btnAddOmission;
        private System.Windows.Forms.Button btnAllow;
        private System.Windows.Forms.Button btnRefuse;
        private System.Windows.Forms.Button btnDashboard;
    }
}