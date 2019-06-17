using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataconPortal.Data;
using DataconPortal.Logic;

namespace DataconPortal.View
{
    public partial class AddRoom : Form
    {
        RoomOverview overview = new RoomOverview();

        public AddRoom()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            RoomLogic Logic = new RoomLogic();
            Room r = new Room(tbName.Text);

            Logic.AddRoom(r);

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
