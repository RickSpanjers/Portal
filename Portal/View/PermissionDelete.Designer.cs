namespace DataconPortal.Forms
{
    partial class PermissionDelete
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
            this.lbxpermissions = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxpermissions
            // 
            this.lbxpermissions.FormattingEnabled = true;
            this.lbxpermissions.Location = new System.Drawing.Point(12, 61);
            this.lbxpermissions.Name = "lbxpermissions";
            this.lbxpermissions.Size = new System.Drawing.Size(221, 251);
            this.lbxpermissions.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Permissies";
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(252, 289);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 2;
            this.btndelete.Text = "Verwijderen";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Dashboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PermissionDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 453);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxpermissions);
            this.Name = "PermissionDelete";
            this.Text = "PermissionDelete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxpermissions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button button1;
    }
}