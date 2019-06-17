using DataconPortal.Classes;
using DataconPortal.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataconPortal.Forms
{
    public partial class AddRole : Form
    {

        private string email;

        public AddRole()
        {
            InitializeComponent();
        }

        public AddRole(string email)
        {
            InitializeComponent();
            this.email = email;
        }

        private void btnconfirm_Click(object sender, EventArgs e) ///Add role into database
        {
            RoleLogic Logic = new RoleLogic();
            string rolename = txtbxrolename.Text;
            Role r = new Role(rolename, 1);

            if(txtbxrolename.TextLength > 0)
            {
                MessageBox.Show("Rol '" + r.RetrieveRoleName() + "' aangemaakt");
                if(Logic.AddRole(r) == true)
                {
                    var overview = new RoleOverview(email);
                    this.Hide();
                    overview.Show();
                }
                else
                {
                    MessageBox.Show("Er ging iets mis tijdens het toevoegen van de rol");
                }
            }
            if(txtbxrolename.TextLength == 0) ///Checks if rolename is not null
            {
                MessageBox.Show("Rolnaam kan niet leeg zijn!");
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            var roleoverview = new RoleOverview(email);
            roleoverview.Show();
        }
    }
}
