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
    public partial class PermissionToRole : Form
    {
        private string email;

        public PermissionToRole()
        {
            InitializeComponent();
            LoadAllPermission();
        }

        public PermissionToRole(string email)
        {
            InitializeComponent();
            this.email = email;
            LoadAllPermission();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(email);
            dashboard.Show();
            this.Hide();
        }

        public void LoadAllPermission()
        {
			lbxPermissions.Items.Clear();
			cmbRoles.Items.Clear();

            PermissionLogic PLogic = new PermissionLogic();
            RoleLogic RLogic = new RoleLogic();

            List<Permission> permissions = PLogic.RetrieveAllPermissions();
            foreach (var permission in permissions)
            {
                lbxPermissions.Items.Add(permission.PermissionName);
            }

            List<Role> Roles = RLogic.RetrieveAllRoles();
            foreach (Role role in Roles)
            {
                cmbRoles.Items.Add(role.RetrieveRoleName());
            }
        }


        private void btnAddPermission_Click(object sender, EventArgs e)
        {
            AddPermission();

            listBox1.Items.Clear();
            PermissionLogic Logic = new PermissionLogic();
            string rol = cmbRoles.SelectedItem.ToString();

            List<string> permissions = Logic.GetAllRolePermissions(rol);
            foreach (string per in permissions)
            {
                listBox1.Items.Add(per);
            }
        }

        public void AddPermission()
        {
            RoleLogic RLogic = new RoleLogic();
            PermissionLogic PLogic = new PermissionLogic();

            string selectedPermission = lbxPermissions.SelectedItem.ToString();
            string selectedRole = cmbRoles.SelectedItem.ToString();

            PLogic.AddPermission(selectedRole, selectedPermission);
        }


        private void cmbRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
                listBox1.Items.Clear();
                PermissionLogic PLogic = new PermissionLogic();
                string rol = cmbRoles.SelectedItem.ToString();

                List<string> permissions = PLogic.GetAllRolePermissions(rol);
                foreach (string per in permissions)
                {
                    listBox1.Items.Add(per);
                }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //Get the rolename and the permissionname
            string RoleName = cmbRoles.SelectedItem.ToString();
            string PermissionName = listBox1.SelectedItem.ToString();

            //New instance of permissionlogic and rolelogic
            PermissionLogic PLogic = new PermissionLogic();
            RoleLogic RLogic = new RoleLogic();

            //New role and new permisson
            Role r = new Role(RoleName, 1);
            Permission p = new Permission(1, PermissionName);

            //Empt roleid and permissionid
            int RoleID = 0;
            int PermissionID = 0;

            //Get permissionid from the database
            var AllPermissions = PLogic.RetrieveAllPermissions();
            foreach(var SinglePermission in AllPermissions)
            {
                if(SinglePermission.PermissionName == p.PermissionName)
                {
                    PermissionID = SinglePermission.RetrievePermissionID();
                }
            }

            //Get roleid from the database
            var AllRoles = RLogic.RetrieveAllRoles();
            foreach(var SingleRole in AllRoles)
            {
                if(SingleRole.RetrieveRoleName() == r.RetrieveRoleName())
                {
                    RoleID = SingleRole.RetrieveRoleID();
                }
            }

            PLogic.DeleteRolePermission(RoleID, PermissionID);

            listBox1.Items.Clear();
            string rol = cmbRoles.SelectedItem.ToString();

            List<string> permissions = PLogic.GetAllRolePermissions(rol);
            foreach (string per in permissions)
            {
                listBox1.Items.Add(per);
            }

        }

        private void PermissionToRole_Load(object sender, EventArgs e)
        {
            LoadAllPermission();
        }
    }
}
