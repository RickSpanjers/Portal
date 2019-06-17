namespace DataconPortal
{
    partial class PortalLogin
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
            this.TB_Username = new System.Windows.Forms.TextBox();
            this.TB_Password = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TB_Username
            // 
            this.TB_Username.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Username.Location = new System.Drawing.Point(71, 192);
            this.TB_Username.Margin = new System.Windows.Forms.Padding(2);
            this.TB_Username.Name = "TB_Username";
            this.TB_Username.Size = new System.Drawing.Size(445, 27);
            this.TB_Username.TabIndex = 0;
            this.TB_Username.Text = "E-mailadres";
            // 
            // TB_Password
            // 
            this.TB_Password.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Password.Location = new System.Drawing.Point(71, 236);
            this.TB_Password.Margin = new System.Windows.Forms.Padding(2);
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.PasswordChar = '*';
            this.TB_Password.Size = new System.Drawing.Size(445, 27);
            this.TB_Password.TabIndex = 1;
            this.TB_Password.Text = "Wachtwoord";
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(71, 286);
            this.btn_login.Margin = new System.Windows.Forms.Padding(2);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(444, 50);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "Inloggen";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 30F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(128, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 48);
            this.label1.TabIndex = 3;
            this.label1.Text = "Datacon Portal";
            // 
            // PortalLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 449);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.TB_Password);
            this.Controls.Add(this.TB_Username);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PortalLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datacon Portal Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Username;
        private System.Windows.Forms.TextBox TB_Password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label label1;
    }
}