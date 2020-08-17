namespace DataconPortal.View
{
    partial class SingleRoom
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
            this.lbl_edit = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_ = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Room";
            // 
            // lbl_edit
            // 
            this.lbl_edit.AutoSize = true;
            this.lbl_edit.Location = new System.Drawing.Point(134, 78);
            this.lbl_edit.Name = "lbl_edit";
            this.lbl_edit.Size = new System.Drawing.Size(92, 17);
            this.lbl_edit.TabIndex = 1;
            this.lbl_edit.Text = "To edit room:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "New name:";
            // 
            // tbx_
            // 
            this.tbx_.Location = new System.Drawing.Point(219, 119);
            this.tbx_.Name = "tbx_";
            this.tbx_.Size = new System.Drawing.Size(100, 22);
            this.tbx_.TabIndex = 3;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(12, 166);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(362, 166);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 5;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // SingleRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 203);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.tbx_);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_edit);
            this.Controls.Add(this.label1);
            this.Name = "SingleRoom";
            this.Text = "SingleRoom";
            this.Load += new System.EventHandler(this.SingleRoom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_edit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_edit;
    }
}