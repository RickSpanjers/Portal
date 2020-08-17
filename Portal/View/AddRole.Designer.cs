namespace DataconPortal.Forms
{
    partial class AddRole
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
            this.txtbxrolename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnconfirm = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbxrolename
            // 
            this.txtbxrolename.Location = new System.Drawing.Point(35, 94);
            this.txtbxrolename.Name = "txtbxrolename";
            this.txtbxrolename.Size = new System.Drawing.Size(157, 20);
            this.txtbxrolename.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Naam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nieuwe rol aanmaken";
            // 
            // btnconfirm
            // 
            this.btnconfirm.Location = new System.Drawing.Point(467, 398);
            this.btnconfirm.Name = "btnconfirm";
            this.btnconfirm.Size = new System.Drawing.Size(84, 39);
            this.btnconfirm.TabIndex = 6;
            this.btnconfirm.Text = "Verzenden";
            this.btnconfirm.UseVisualStyleBackColor = true;
            this.btnconfirm.Click += new System.EventHandler(this.btnconfirm_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(35, 398);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(100, 39);
            this.btncancel.TabIndex = 7;
            this.btncancel.Text = "Annuleren";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // AddRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 449);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnconfirm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbxrolename);
            this.Name = "AddRole";
            this.Text = "AddRole";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxrolename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnconfirm;
        private System.Windows.Forms.Button btncancel;
    }
}