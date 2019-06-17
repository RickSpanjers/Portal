namespace DataconPortal.View
{
    partial class RoomOverview
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
            this.lbx_rooms = new System.Windows.Forms.ListBox();
            this.btn_addroom = new System.Windows.Forms.Button();
            this.btn_updateroom = new System.Windows.Forms.Button();
            this.btn_deleteroom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbx_rooms
            // 
            this.lbx_rooms.FormattingEnabled = true;
            this.lbx_rooms.ItemHeight = 16;
            this.lbx_rooms.Location = new System.Drawing.Point(12, 12);
            this.lbx_rooms.Name = "lbx_rooms";
            this.lbx_rooms.Size = new System.Drawing.Size(434, 420);
            this.lbx_rooms.TabIndex = 0;
            // 
            // btn_addroom
            // 
            this.btn_addroom.Location = new System.Drawing.Point(463, 11);
            this.btn_addroom.Name = "btn_addroom";
            this.btn_addroom.Size = new System.Drawing.Size(96, 44);
            this.btn_addroom.TabIndex = 1;
            this.btn_addroom.Text = "Add Room";
            this.btn_addroom.UseVisualStyleBackColor = true;
            this.btn_addroom.Click += new System.EventHandler(this.btn_addroom_Click);
            // 
            // btn_updateroom
            // 
            this.btn_updateroom.Location = new System.Drawing.Point(463, 80);
            this.btn_updateroom.Name = "btn_updateroom";
            this.btn_updateroom.Size = new System.Drawing.Size(96, 44);
            this.btn_updateroom.TabIndex = 2;
            this.btn_updateroom.Text = "Update Room";
            this.btn_updateroom.UseVisualStyleBackColor = true;
            this.btn_updateroom.Click += new System.EventHandler(this.btn_updateroom_Click);
            // 
            // btn_deleteroom
            // 
            this.btn_deleteroom.Location = new System.Drawing.Point(463, 161);
            this.btn_deleteroom.Name = "btn_deleteroom";
            this.btn_deleteroom.Size = new System.Drawing.Size(96, 44);
            this.btn_deleteroom.TabIndex = 3;
            this.btn_deleteroom.Text = "DeleteRoom";
            this.btn_deleteroom.UseVisualStyleBackColor = true;
            this.btn_deleteroom.Click += new System.EventHandler(this.btn_deleteroom_Click);
            // 
            // RoomOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 450);
            this.Controls.Add(this.btn_deleteroom);
            this.Controls.Add(this.btn_updateroom);
            this.Controls.Add(this.btn_addroom);
            this.Controls.Add(this.lbx_rooms);
            this.Name = "RoomOverview";
            this.Text = "RoomOverview";
            this.Load += new System.EventHandler(this.RoomOverview_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbx_rooms;
        private System.Windows.Forms.Button btn_addroom;
        private System.Windows.Forms.Button btn_updateroom;
        private System.Windows.Forms.Button btn_deleteroom;
    }
}