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
    public partial class RoleOverview : Form
    {
		private string email;

		public RoleOverview()
        {
            InitializeComponent();
            LoadRoles();
        }

        public RoleOverview(string email)
        {
            this.email = email;
            InitializeComponent();
            LoadRoles();
        }

        private string rolestring;

        /// <summary>
        /// Get all roles from database and insert into listbox
        /// </summary>
        public void LoadRoles()
        {
            RoleLogic Logic = new RoleLogic();
            List<Role> Roles = Logic.RetrieveAllRoles();

            foreach (Role role in Roles)
            {
                lbxRoles.Items.Add(role.RetrieveRoleName());
            }
        }


        private void btnEditRole_Click(object sender, EventArgs e)
        {
            UserLogic userLogic = new UserLogic();
            RoleLogic roleLogic = new RoleLogic();
            PortalLogin Login = new PortalLogin();
            SingleUser singleUser = new SingleUser();
            var AllRoles = roleLogic.RetrieveAllRoles();

            User U = new User(email);
            userLogic.GetSingleUser(U);

            if(U.RoleName =="Admin")
            {
				if(lbxRoles.SelectedIndex > -1)
				{
					foreach (var OneRole in AllRoles)
					{
						if (OneRole.RetrieveRoleName() == lbxRoles.SelectedItem.ToString())
						{
							rolestring = Convert.ToString(lbxRoles.SelectedItem);
							this.Hide();
							SingleRole SingleRole = new SingleRole(OneRole.RetrieveRoleID(), rolestring, email);
							SingleRole.Show();
						}
					}
				}              
            }
            else
            {
                MessageBox.Show("U heeft hier de permissies niet voor!");
            }
        }


        private void btnDeleteRole_Click(object sender, EventArgs e) ///Delete selected role
        {
            DeleteRole();
        }

        public void DeleteRole()
        {
            RoleLogic Logic = new RoleLogic();

            string rolename = Convert.ToString(lbxRoles.SelectedItem);

            if (Logic.DeleteRole(rolename) == true)
            {
                lbxRoles.Items.Clear();
                List<Role> users = Logic.RetrieveAllRoles();
                foreach (Role user in users)
                {
                    lbxRoles.Items.Add(user.RetrieveRoleName());
                }
            }
            else
            {
                MessageBox.Show("Rol kon niet worden verwijderd");
            }
        }

        private void btnAddRole_Click(object sender, EventArgs e) ///Opens a new screen to add a new role into the database
        {
            this.Hide();
            var AddRole = new AddRole(email);
            AddRole.Show();
        }

        private void btndashboard_Click(object sender, EventArgs e) ///Back to dashboard
        {
            Dashboard board = new Dashboard(email);
            board.Show();
            this.Hide();
        }

        private void RoleOverview_Load(object sender, EventArgs e)
        {
            lbxRoles.Items.Clear();
            LoadRoles();
        }
    }
}
