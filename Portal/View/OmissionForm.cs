using DataconPortal.Classes;
using DataconPortal.Context;
using DataconPortal.Data;
using DataconPortal.Forms;
using DataconPortal.Logic;
using DataconPortal.Repositories;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DataconPortal.View
{
    public partial class OmissionForm : Form
    {
        public OmissionForm()
        {
            InitializeComponent();
        }

        private string email;

        public OmissionForm(string email)
        {
            this.email = email;
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard(email);
            this.Hide();
            dash.Show();
        }

        private void btnAddOmission_Click(object sender, EventArgs e)
        {
            this.Hide();
            OmissionAdd oa = new OmissionAdd(email);
            oa.ShowDialog();
        }

        private void Verzuim_Load(object sender, EventArgs e)
        {
            OmissionLogic logic = new OmissionLogic();
            List<Omission> omissions = logic.GetAllOmissions();

            User u = new User(email);
            UserLogic uLogic = new UserLogic();
            User SingleUser = uLogic.GetSingleUser(u);
            int RoleId = SingleUser.RetrieveRoleID();
            int Id = SingleUser.RetrieveUserID();
            PermissionRepository pRepo = new PermissionRepository((new PermissionContext()));

            int OmissionPermission = 29;
            bool haOmissionPermission = pRepo.CheckPermissionsFromRole(u.RetrieveRoleID(), OmissionPermission);

            if (haOmissionPermission == true)
            {
                string allowed = "";

                lbxOmission.Items.Clear();

                foreach (Omission o in omissions)
                {
                    if (o.Code == 0)
                    {
                        allowed = "Niet toegekend";
                    }
                    else if (o.Code == 1)
                    {
                        allowed = "Toegestaan";
                    }
                    else if (o.Code == 2)
                    {
                        allowed = "Geweigerd";
                    }
                    else if (o.Code == 3)
                    {
                        allowed = "Verlopen";
                    }
                    lbxOmission.Items.Add(o.Id + "," + logic.GetUsername(o.UserID) + "-" + o.BeginDate.ToShortDateString() + "-" + o.EndDate.ToShortDateString() + "," + o.Type + "-" + allowed);
                }
            }
            else
            {
                string allowed = "";
                Omission om = new Omission(Id);
                OmissionLogic oLogic = new OmissionLogic();
                List<Omission> SingleUserOmissionList = oLogic.GetSingleUserOmission(om);
                foreach (Omission o in SingleUserOmissionList)
                {
                    if (o.Code == 0)
                    {
                        allowed = "Niet toegekend";
                    }
                    else if (o.Code == 1)
                    {
                        allowed = "Toegestaan";
                    }
                    else if (o.Code == 2)
                    {
                        allowed = "Geweigerd";
                    }
                    else if (o.Code == 3)
                    {
                        allowed = "Verlopen";
                    }
                    lbxOmission.Items.Add(o.Id + "," + logic.GetUsername(o.UserID) + "-" + o.BeginDate.ToShortDateString() + "-" + o.EndDate.ToShortDateString() + "," + o.Type + "-" + allowed);
                }
            }

            PermissionRepository PermissionRepo = new PermissionRepository((new PermissionContext()));
            UserLogic userLogic = new UserLogic();
            User user;
            user = new User(email);
            userLogic.GetSingleUser(user);

            int pagePermission = 20;
            bool hasPagePermission = PermissionRepo.CheckPermissionsFromRole(user.RetrieveRoleID(), pagePermission);

            if (hasPagePermission == true)
            {
                btnAllow.Visible = true;
                btnRefuse.Visible = true;
            }
            else
            {
                btnAllow.Visible = false;
                btnRefuse.Visible = false;
            }
        }

        private void btnAllow_Click(object sender, EventArgs e)
        {
            OmissionLogic logic = new OmissionLogic();
            if (lbxOmission.SelectedItem != null)
            {
                string omission = lbxOmission.SelectedItem.ToString();
                int omissionType = omission.IndexOf(",");
                string selectedOmission = omission.Substring(omissionType + 2);

                int omissionTypeID = omission.IndexOf(",");
                string selectedId = omission.Substring(0, omissionTypeID);
                int id = Convert.ToInt32(selectedId);

                int codeID = omission.IndexOf("Verlopen");

                if (codeID == -1)
                {
                    Omission om = new Omission(selectedOmission);
                    om.Id = id;
                    logic.IsOmissionAllowed(om, 1);
                }
                else
                {
                    MessageBox.Show("Het geselecteerde verzuim is verlopen en kan niet meer worden toegestaan.");
                }
            }
            else
            {
                MessageBox.Show("Je moet een verzuim item selecteren.");
            }

            List<Omission> omissions = logic.GetAllOmissions();
            string allowed = "";

            lbxOmission.Items.Clear();

            foreach (Omission o in omissions)
            {
                if (o.Code == 0)
                {
                    allowed = "Niet toegekend";
                }
                else if (o.Code == 1)
                {
                    allowed = "Toegestaan";
                }
                else if (o.Code == 2)
                {
                    allowed = "Geweigerd";
                }
                else if (o.Code == 3)
                {
                    allowed = "Verlopen";
                }
                lbxOmission.Items.Add(o.Id + "," + logic.GetUsername(o.UserID) + "-" + o.BeginDate.ToShortDateString() + "-" + o.EndDate.ToShortDateString() + "," + o.Type + "-" + allowed);
            }
        }

        private void btnRefuse_Click(object sender, EventArgs e)
        {
            OmissionLogic logic = new OmissionLogic();
            if (lbxOmission.SelectedItem != null)
            {
                string omission = lbxOmission.SelectedItem.ToString();
                int omissionType = omission.IndexOf(",");
                string selectedOmission = omission.Substring(omissionType + 2);

                int omissionTypeID = omission.IndexOf(",");
                string selectedId = omission.Substring(0, omissionTypeID);
                int id = Convert.ToInt32(selectedId);

                int codeID = omission.IndexOf("Verlopen");

                if (codeID == -1)
                {
                    Omission om = new Omission(selectedOmission);
                    om.Id = id;
                    logic.IsOmissionAllowed(om, 2);
                }
                else
                {
                    MessageBox.Show("Het geselecteerde verzuim is verlopen en kan niet meer worden geweigerd.");
                }
            }
            else
            {
                MessageBox.Show("Je moet een verzuim item selecteren.");
            }

            List<Omission> omissions = logic.GetAllOmissions();

            string allowed = "";

            lbxOmission.Items.Clear();

            foreach (Omission o in omissions)
            {
                if (o.Code == 0)
                {
                    allowed = "Niet toegekend";
                }
                else if (o.Code == 1)
                {
                    allowed = "Toegestaan";
                }
                else if (o.Code == 2)
                {
                    allowed = "Geweigerd";
                }
                else if (o.Code == 3)
                {
                    allowed = "Verlopen";
                }
                lbxOmission.Items.Add(o.Id + "," + logic.GetUsername(o.UserID) + "-" + o.BeginDate.ToShortDateString() + "-" + o.EndDate.ToShortDateString() + "," + o.Type + "-" + allowed);
            }
        }
    }
}
