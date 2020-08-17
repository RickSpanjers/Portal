using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataconPortal.Data;
using DataconPortal.Logic;
using System.Windows.Forms;

namespace DataconPortal.View
{
    public partial class SingleRoom : Form
    {
        private string email;
        RoomOverview overview = new RoomOverview();
        private string roomname;

        public SingleRoom()
        {
            InitializeComponent();
        }

        public SingleRoom(string email)
        {
            InitializeComponent();
            this.email = email;
        }

        private void SingleRoom_Load(object sender, EventArgs e)
        {
            roomname = overview.roomname;
            lbl_edit.Text = "To edit room: " + roomname;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            RoomLogic Logic = new RoomLogic();
            Room r = new Room(roomname);

            Logic.UpdateRoom(r);

            this.Hide();
            overview.Show();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            overview.Show();
        }
    }
}
