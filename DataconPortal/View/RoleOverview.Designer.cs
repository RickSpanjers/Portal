namespace DataconPortal.Forms
{
    partial class RoleOverview
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
            this.lbxRoles = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditRole = new System.Windows.Forms.Button();
            this.btnDeleteRole = new System.Windows.Forms.Button();
            this.btnAddRole = new System.Windows.Forms.Button();
            this.btndashboard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxRoles
            // 
            this.lbxRoles.FormattingEnabled = true;
            this.lbxRoles.Location = new System.Drawing.Point(10, 41);
            this.lbxRoles.Name = "lbxRoles";
            this.lbxRoles.Size = new System.Drawing.Size(393, 303);
            this.lbxRoles.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rollen";
            // 
            // btnEditRole
            // 
            this.btnEditRole.Location = new System.Drawing.Point(456, 42);
            this.btnEditRole.Name = "btnEditRole";
            this.btnEditRole.Size = new System.Drawing.Size(90, 32);
            this.btnEditRole.TabIndex = 2;
            this.btnEditRole.Text = "Rol wijzigen";
            this.btnEditRole.UseVisualStyleBackColor = true;
            this.btnEditRole.Click += new System.EventHandler(this.btnEditRole_Click);
            // 
            // btnDeleteRole
            // 
            this.btnDeleteRole.Location = new System.Drawing.Point(456, 80);
            this.btnDeleteRole.Name = "btnDeleteRole";
            this.btnDeleteRole.Size = new System.Drawing.Size(90, 32);
            this.btnDeleteRole.TabIndex = 3;
            this.btnDeleteRole.Text = "Rol verwijderen";
            this.btnDeleteRole.UseVisualStyleBackColor = true;
            this.btnDeleteRole.Click += new System.EventHandler(this.btnDeleteRole_Click);
            // 
            // btnAddRole
            // 
            this.btnAddRole.Location = new System.Drawing.Point(456, 118);
            this.btnAddRole.Name = "btnAddRole";
            this.btnAddRole.Size = new System.Drawing.Size(90, 32);
            this.btnAddRole.TabIndex = 4;
            this.btnAddRole.Text = "Rol toevoegen";
            this.btnAddRole.UseVisualStyleBackColor = true;
            this.btnAddRole.Click += new System.EventHandler(this.btnAddRole_Click);
            // 
            // btndashboard
            // 
            this.btndashboard.Location = new System.Drawing.Point(12, 405);
            this.btndashboard.Name = "btndashboard";
            this.btndashboard.Size = new System.Drawing.Size(90, 32);
            this.btndashboard.TabIndex = 5;
            this.btndashboard.Text = "Dashboard";
            this.btndashboard.UseVisualStyleBackColor = true;
            this.btndashboard.Click += new System.EventHandler(this.btndashboard_Click);
            // 
            // RoleOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 449);
            this.Controls.Add(this.btndashboard);
            this.Controls.Add(this.btnAddRole);
            this.Controls.Add(this.btnDeleteRole);
            this.Controls.Add(this.btnEditRole);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxRoles);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RoleOverview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoleOverview";
            this.Load += new System.EventHandler(this.RoleOverview_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxRoles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditRole;
        private System.Windows.Forms.Button btnDeleteRole;
        private System.Windows.Forms.Button btnAddRole;
        private System.Windows.Forms.Button btndashboard;
    }
}