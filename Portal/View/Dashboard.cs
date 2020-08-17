using DataconPortal.Classes;
using DataconPortal.Logic;
using DataconPortal.Context;
using DataconPortal.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataconPortal.View;

namespace DataconPortal.Forms
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private string email;

        public Dashboard(string email)
        {
            this.email = email;
            InitializeComponent();
        }
        
        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            var dashboard = new Dashboard(email);
            dashboard.Closed += (s, args) => this.Close();
            dashboard.Show();
        }

        private void btn_users_Click(object sender, EventArgs e)
        {
            UserLogic userLogic = new UserLogic();
            RoleLogic roleLogic = new RoleLogic();
            SingleUser singleUser = new SingleUser();
            PermissionRepository PermissionRepo = new PermissionRepository(new PermissionContext());

            var AllRoles = roleLogic.RetrieveAllRoles();
            int pagePermission = 20;

            User user;
            user = new User(email);
            userLogic.GetSingleUser(user);

			bool hasPagePermission = PermissionRepo.CheckPermissionsFromRole(user.RetrieveRoleID(), pagePermission);

			if (hasPagePermission == true)
			{
				this.Hide();
                var users = new UserOverview(email);
                users.Closed += (s, args) => this.Close();
                users.Show();
			}

            else
            {
                MessageBox.Show("U heeft hier de rechten niet voor!");
            }
	}

        private void btn_roles_Click(object sender, EventArgs e)
        {
            UserLogic userLogic = new UserLogic();
            RoleLogic roleLogic = new RoleLogic();
            SingleUser singleUser = new SingleUser();
            PermissionRepository PermissionRepo = new PermissionRepository(new PermissionContext());
            var AllRoles = roleLogic.RetrieveAllRoles();
            int pagePermission = 20;

            User user;
            user = new User(email);
            userLogic.GetSingleUser(user);

            bool hasPagePermission = PermissionRepo.CheckPermissionsFromRole(user.RetrieveRoleID(), pagePermission);

			if (hasPagePermission == true)
			{
				this.Hide();
                var roles = new RoleOverview(email);
                roles.Closed += (s, args) => this.Close();
                roles.Show();
			}
            else
            {
               MessageBox.Show("U heeft hier de rechten niet voor!");
            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            var logout = new PortalLogin();
            logout.Closed += (s, args) => this.Close();
            logout.Show();
        }

        private void btnPermissions_Click(object sender, EventArgs e)
        {
            UserLogic userLogic = new UserLogic();
            RoleLogic roleLogic = new RoleLogic();
            SingleUser singleUser = new SingleUser();
            PermissionRepository PermissionRepo = new PermissionRepository(new PermissionContext());
            var AllRoles = roleLogic.RetrieveAllRoles();
            int pagePermission = 20;

            User user;
            user = new User(email);
            userLogic.GetSingleUser(user);

            bool hasPagePermission = PermissionRepo.CheckPermissionsFromRole(user.RetrieveRoleID(), pagePermission);

			if (hasPagePermission == true)
			{
				PermissionToRole role = new PermissionToRole(email);

                role.Show();
                this.Hide();
			}
            else
            {
                MessageBox.Show("U heeft hier de rechten niet voor!");
            }
		}

        private void btnVerzuim_Click(object sender, EventArgs e)
        {
            this.Hide();
            OmissionForm v = new OmissionForm(email);
            v.ShowDialog();
        }

        private void btn_rooms_Click(object sender, EventArgs e)
        {
            UserLogic userLogic = new UserLogic();
            RoleLogic roleLogic = new RoleLogic();
            SingleUser singleUser = new SingleUser();
            PermissionRepository PermissionRepo = new PermissionRepository(new PermissionContext());
            var AllRoles = roleLogic.RetrieveAllRoles();
            int pagePermission = 20;

            User user;
            user = new User(email);
            userLogic.GetSingleUser(user);

            bool hasPagePermission = PermissionRepo.CheckPermissionsFromRole(user.RetrieveRoleID(), pagePermission);

            if (hasPagePermission == true)
            {
                RoomOverview rooms = new RoomOverview(email);

                rooms.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("U heeft hier de rechten niet voor!");
            }
        }
    }
}
