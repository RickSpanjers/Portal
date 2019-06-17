using DataconPortal.Logic;
using DataconPortal.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataconPortal.View
{
    public partial class RoomOverview : Form
    {
        private string email;
        public string roomname;
        public RoomOverview()
        {
            InitializeComponent();
        }

        public RoomOverview(string email)
        {
            InitializeComponent();
            this.email = email;
        }

        public void LoadRooms()
        {
            RoomLogic Logic = new RoomLogic();
            List<Room> Rooms = Logic.RetrieveAllRooms();

            foreach (Room room in Rooms)
            {
                lbx_rooms.Items.Add(room.RetrieveRoomName());
            }
        }

        private void RoomOverview_Load(object sender, EventArgs e)
        {
            LoadRooms();
        }

        private void btn_addroom_Click(object sender, EventArgs e)
        {
            AddRoom addRoom = new AddRoom();
            this.Hide();
            addRoom.Show();
        }

        private void btn_updateroom_Click(object sender, EventArgs e)
        {
            roomname = (string)lbx_rooms.SelectedItem;

            this.Hide();
            SingleRoom singleRoom = new SingleRoom();
            singleRoom.Show();
        }

        private void btn_deleteroom_Click(object sender, EventArgs e)
        {
            RoomLogic Logic = new RoomLogic();

            Logic.DeleteRoom((string)lbx_rooms.SelectedItem);
            lbx_rooms.Items.Clear();
            LoadRooms();
        }
    }
}
