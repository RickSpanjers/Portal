namespace DataconPortal.Forms
{
    partial class SingleRole
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
            this.label1 = new System.Windows.Forms.Label();
            this.Testlabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbRoleName = new System.Windows.Forms.TextBox();
            this.btCancel = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rol wijzigen";
            // 
            // Testlabel
            // 
            this.Testlabel.AutoSize = true;
            this.Testlabel.Location = new System.Drawing.Point(17, 88);
            this.Testlabel.Name = "Testlabel";
            this.Testlabel.Size = new System.Drawing.Size(40, 17);
            this.Testlabel.TabIndex = 1;
            this.Testlabel.Text = "Test:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nieuwe rolnaam:";
            // 
            // tbRoleName
            // 
            this.tbRoleName.Location = new System.Drawing.Point(20, 155);
            this.tbRoleName.Name = "tbRoleName";
            this.tbRoleName.Size = new System.Drawing.Size(196, 22);
            this.tbRoleName.TabIndex = 3;
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(20, 198);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(95, 49);
            this.btCancel.TabIndex = 4;
            this.btCancel.Text = "Annuleren";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(121, 198);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(95, 49);
            this.btEdit.TabIndex = 5;
            this.btEdit.Text = "Wijzigingen opslaan";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // SingleRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 261);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.tbRoleName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Testlabel);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SingleRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SingleRole";
            this.Load += new System.EventHandler(this.SingleRole_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Testlabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbRoleName;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btEdit;
    }
}