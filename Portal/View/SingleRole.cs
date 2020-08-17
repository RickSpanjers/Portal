using System;
using DataconPortal.Classes;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataconPortal.Logic;

namespace DataconPortal.Forms
{
    public partial class SingleRole : Form
    {
        private string RoleToEditName;
        private int RoleToEditID;
        private string email;

        public SingleRole(int RoleID, string rolestring, string email)
        {
            InitializeComponent();
            RoleToEditID = RoleID;
            this.RoleToEditName = rolestring;
            this.email = email;
        }

        private void SingleRole_Load(object sender, EventArgs e)
        {
            RoleOverview roleOverview = new RoleOverview(email);
            string oldname = this.RoleToEditName;
            Testlabel.Text = "Test: " + oldname;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            RoleOverview roleOverview = new RoleOverview(email);
            roleOverview.Show();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            EditRole();
        }

        private void EditRole()
        {
            RoleOverview roleOverview = new RoleOverview(email);
            RoleLogic Logic = new RoleLogic();

            string oldname = RoleToEditName;

            if (tbRoleName.TextLength > 0)
            {
                Role R = new Role(tbRoleName.Text, RoleToEditID);

                if (Logic.EditRole(R) == true)
                {
                    MessageBox.Show("Rolnaam gewijzigd naar: '" + tbRoleName.Text + "'.");
                    this.Hide();
                    roleOverview.Show();
                }
            }

            if (tbRoleName.TextLength == 0)
            {
                MessageBox.Show("Rolnaam kan niet leeg zijn!");
            }
        }
    }
}
