namespace DataconPortal.Forms
{
    partial class PermissionToRole
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
            this.lbxPermissions = new System.Windows.Forms.ListBox();
            this.btnAddPermission = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.cmbRoles = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbxPermissions
            // 
            this.lbxPermissions.FormattingEnabled = true;
            this.lbxPermissions.ItemHeight = 16;
            this.lbxPermissions.Location = new System.Drawing.Point(16, 30);
            this.lbxPermissions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbxPermissions.Name = "lbxPermissions";
            this.lbxPermissions.Size = new System.Drawing.Size(291, 484);
            this.lbxPermissions.TabIndex = 0;
            // 
            // btnAddPermission
            // 
            this.btnAddPermission.Location = new System.Drawing.Point(321, 86);
            this.btnAddPermission.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddPermission.Name = "btnAddPermission";
            this.btnAddPermission.Size = new System.Drawing.Size(105, 42);
            this.btnAddPermission.TabIndex = 1;
            this.btnAddPermission.Text = "Toekennen";
            this.btnAddPermission.UseVisualStyleBackColor = true;
            this.btnAddPermission.Click += new System.EventHandler(this.btnAddPermission_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(319, 471);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(221, 42);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Terug";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cmbRoles
            // 
            this.cmbRoles.FormattingEnabled = true;
            this.cmbRoles.Location = new System.Drawing.Point(321, 49);
            this.cmbRoles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbRoles.Name = "cmbRoles";
            this.cmbRoles.Size = new System.Drawing.Size(219, 24);
            this.cmbRoles.TabIndex = 3;
            this.cmbRoles.SelectedIndexChanged += new System.EventHandler(this.cmbRoles_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rol:";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(435, 86);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(105, 42);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Verwijderen";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(321, 153);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(219, 308);
            this.listBox1.TabIndex = 6;
            // 
            // PermissionToRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 540);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbRoles);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAddPermission);
            this.Controls.Add(this.lbxPermissions);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PermissionToRole";
            this.Text = "PermissionToRole";
            this.Load += new System.EventHandler(this.PermissionToRole_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxPermissions;
        private System.Windows.Forms.Button btnAddPermission;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cmbRoles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListBox listBox1;
    }
}