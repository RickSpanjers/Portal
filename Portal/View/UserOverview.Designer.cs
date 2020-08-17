namespace DataconPortal.Forms
{
    partial class UserOverview
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
            this.lbxUsers = new System.Windows.Forms.ListBox();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxUsers
            // 
            this.lbxUsers.FormattingEnabled = true;
            this.lbxUsers.ItemHeight = 16;
            this.lbxUsers.Location = new System.Drawing.Point(13, 14);
            this.lbxUsers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbxUsers.Name = "lbxUsers";
            this.lbxUsers.Size = new System.Drawing.Size(355, 516);
            this.lbxUsers.TabIndex = 0;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(376, 68);
            this.btnModify.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(136, 43);
            this.btnModify.TabIndex = 1;
            this.btnModify.Text = "Wijzigen";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(376, 14);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(136, 47);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Toevoegen";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(376, 119);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(136, 43);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Verwijderen";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(376, 170);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(136, 44);
            this.btnDashboard.TabIndex = 4;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // UserOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 553);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.lbxUsers);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserOverview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserOverview";
            this.Load += new System.EventHandler(this.UserOverview_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxUsers;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnDashboard;
    }
}