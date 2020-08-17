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
    public partial class PermissionDelete : Form
    {
        private string email;

        public PermissionDelete()
        {
            InitializeComponent();
        }

        public PermissionDelete(string email)
        {
            InitializeComponent();
            this.email = email;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            DeletePermission();
        }

        public void DeletePermission()
        {
            PermissionLogic Logic = new PermissionLogic();
            string permission = (string)lbxpermissions.SelectedItem;
            if (Logic.DeletePermission(permission) == true)
            {
                MessageBox.Show("Perimssion " + permission + " is succesvol verwijderd");
                lbxpermissions.Items.Remove(permission);
            }
            else
            {
                MessageBox.Show("Er ging iets mis tijdens het verwijderen");
            }

        }

        public void LoadPermissions()
        {
            PermissionLogic Logic = new PermissionLogic();
            List<Permission> permissionlist = Logic.RetrieveAllPermissions();
            foreach (Permission p in permissionlist)
            {
                lbxpermissions.Items.Add(p.PermissionName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(email);
            this.Hide();
            dashboard.Show();
        }
    }
}
