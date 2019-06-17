namespace DataconPortal.View
{
    partial class OmissionAdd
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
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpBegin = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.gbxOmission = new System.Windows.Forms.GroupBox();
            this.cmbxType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.lblBeschrijving = new System.Windows.Forms.Label();
            this.gbxOmission.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(339, 52);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(187, 20);
            this.dtpEnd.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Begin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Eind";
            // 
            // dtpBegin
            // 
            this.dtpBegin.Location = new System.Drawing.Point(25, 51);
            this.dtpBegin.Name = "dtpBegin";
            this.dtpBegin.Size = new System.Drawing.Size(187, 20);
            this.dtpBegin.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "tot";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(88, 370);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(95, 35);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Terug";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Location = new System.Drawing.Point(260, 370);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(152, 35);
            this.btnToevoegen.TabIndex = 7;
            this.btnToevoegen.Text = "Toevoegen";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // gbxOmission
            // 
            this.gbxOmission.Controls.Add(this.dtpEnd);
            this.gbxOmission.Controls.Add(this.label1);
            this.gbxOmission.Controls.Add(this.label3);
            this.gbxOmission.Controls.Add(this.label2);
            this.gbxOmission.Controls.Add(this.dtpBegin);
            this.gbxOmission.Location = new System.Drawing.Point(12, 45);
            this.gbxOmission.Name = "gbxOmission";
            this.gbxOmission.Size = new System.Drawing.Size(562, 133);
            this.gbxOmission.TabIndex = 8;
            this.gbxOmission.TabStop = false;
            this.gbxOmission.Text = "Verzuim";
            // 
            // cmbxType
            // 
            this.cmbxType.FormattingEnabled = true;
            this.cmbxType.Location = new System.Drawing.Point(89, 199);
            this.cmbxType.Name = "cmbxType";
            this.cmbxType.Size = new System.Drawing.Size(177, 21);
            this.cmbxType.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Reden verzuim";
            // 
            // tbxDescription
            // 
            this.tbxDescription.Location = new System.Drawing.Point(88, 245);
            this.tbxDescription.Multiline = true;
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.Size = new System.Drawing.Size(368, 102);
            this.tbxDescription.TabIndex = 11;
            this.tbxDescription.Text = "Optioneel";
            // 
            // lblBeschrijving
            // 
            this.lblBeschrijving.AutoSize = true;
            this.lblBeschrijving.Location = new System.Drawing.Point(86, 229);
            this.lblBeschrijving.Name = "lblBeschrijving";
            this.lblBeschrijving.Size = new System.Drawing.Size(64, 13);
            this.lblBeschrijving.TabIndex = 12;
            this.lblBeschrijving.Text = "Beschrijving";
            // 
            // OmissionAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 449);
            this.Controls.Add(this.lblBeschrijving);
            this.Controls.Add(this.tbxDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbxType);
            this.Controls.Add(this.gbxOmission);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.btnBack);
            this.Name = "OmissionAdd";
            this.Text = "OmissionToevoegenForm";
            this.Load += new System.EventHandler(this.OmissionToevoegen_Load);
            this.gbxOmission.ResumeLayout(false);
            this.gbxOmission.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpBegin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.GroupBox gbxOmission;
        private System.Windows.Forms.ComboBox cmbxType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxDescription;
        private System.Windows.Forms.Label lblBeschrijving;
    }
}