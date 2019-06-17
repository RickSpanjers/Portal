namespace DataconPortal.Forms
{
    partial class Dashboard
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
            this.GB_Menu = new System.Windows.Forms.GroupBox();
            this.btnVerzuim = new System.Windows.Forms.Button();
            this.btnPermissions = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_roles = new System.Windows.Forms.Button();
            this.btn_users = new System.Windows.Forms.Button();
            this.btn_dashboard = new System.Windows.Forms.Button();
            this.btn_rooms = new System.Windows.Forms.Button();
            this.GB_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_Menu
            // 
            this.GB_Menu.Controls.Add(this.btnVerzuim);
            this.GB_Menu.Controls.Add(this.btnPermissions);
            this.GB_Menu.Controls.Add(this.btn_logout);
            this.GB_Menu.Controls.Add(this.btn_roles);
            this.GB_Menu.Controls.Add(this.btn_users);
            this.GB_Menu.Controls.Add(this.btn_dashboard);
            this.GB_Menu.Location = new System.Drawing.Point(12, 11);
            this.GB_Menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GB_Menu.Name = "GB_Menu";
            this.GB_Menu.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GB_Menu.Size = new System.Drawing.Size(757, 76);
            this.GB_Menu.TabIndex = 0;
            this.GB_Menu.TabStop = false;
            // 
            // btnVerzuim
            // 
            this.btnVerzuim.Location = new System.Drawing.Point(467, 21);
            this.btnVerzuim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVerzuim.Name = "btnVerzuim";
            this.btnVerzuim.Size = new System.Drawing.Size(116, 38);
            this.btnVerzuim.TabIndex = 1;
            this.btnVerzuim.Text = "Verzuim";
            this.btnVerzuim.UseVisualStyleBackColor = true;
            this.btnVerzuim.Click += new System.EventHandler(this.btnVerzuim_Click);
            // 
            // btnPermissions
            // 
            this.btnPermissions.Location = new System.Drawing.Point(357, 21);
            this.btnPermissions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPermissions.Name = "btnPermissions";
            this.btnPermissions.Size = new System.Drawing.Size(103, 38);
            this.btnPermissions.TabIndex = 4;
            this.btnPermissions.Text = "Permissies";
            this.btnPermissions.UseVisualStyleBackColor = true;
            this.btnPermissions.Click += new System.EventHandler(this.btnPermissions_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(651, 21);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(101, 38);
            this.btn_logout.TabIndex = 3;
            this.btn_logout.Text = "Uitloggen";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_roles
            // 
            this.btn_roles.Location = new System.Drawing.Point(247, 21);
            this.btn_roles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_roles.Name = "btn_roles";
            this.btn_roles.Size = new System.Drawing.Size(105, 38);
            this.btn_roles.TabIndex = 2;
            this.btn_roles.Text = "Rollen";
            this.btn_roles.UseVisualStyleBackColor = true;
            this.btn_roles.Click += new System.EventHandler(this.btn_roles_Click);
            // 
            // btn_users
            // 
            this.btn_users.Location = new System.Drawing.Point(124, 21);
            this.btn_users.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_users.Name = "btn_users";
            this.btn_users.Size = new System.Drawing.Size(117, 38);
            this.btn_users.TabIndex = 1;
            this.btn_users.Text = "Gebruikers";
            this.btn_users.UseVisualStyleBackColor = true;
            this.btn_users.Click += new System.EventHandler(this.btn_users_Click);
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.Location = new System.Drawing.Point(5, 21);
            this.btn_dashboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Size = new System.Drawing.Size(112, 38);
            this.btn_dashboard.TabIndex = 0;
            this.btn_dashboard.Text = "Dashboard";
            this.btn_dashboard.UseVisualStyleBackColor = true;
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click);
            // 
            // btn_rooms
            // 
            this.btn_rooms.Location = new System.Drawing.Point(17, 92);
            this.btn_rooms.Name = "btn_rooms";
            this.btn_rooms.Size = new System.Drawing.Size(112, 38);
            this.btn_rooms.TabIndex = 1;
            this.btn_rooms.Text = "Rooms";
            this.btn_rooms.UseVisualStyleBackColor = true;
            this.btn_rooms.Click += new System.EventHandler(this.btn_rooms_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 553);
            this.Controls.Add(this.btn_rooms);
            this.Controls.Add(this.GB_Menu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.GB_Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_Menu;
        private System.Windows.Forms.Button btn_roles;
        private System.Windows.Forms.Button btn_users;
        private System.Windows.Forms.Button btn_dashboard;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btnPermissions;
        private System.Windows.Forms.Button btnVerzuim;
        private System.Windows.Forms.Button btn_rooms;
    }
}