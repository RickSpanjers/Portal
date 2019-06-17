using DataconPortal.Classes;
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
    public partial class OmissionAdd : Form
    {
        public OmissionAdd()
        {
            InitializeComponent();
        }

        public OmissionAdd(string email)
        {
            this.email = email;
            InitializeComponent();
        }

        private string email;

        private void OmissionToevoegen_Load(object sender, EventArgs e)
        {
            cmbxType.Items.Add("Ziek");
            cmbxType.Items.Add("Verlof");
            cmbxType.Items.Add("Vakantie");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            OmissionForm of = new OmissionForm(email);
            of.ShowDialog();
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            Omission om = new Omission();
            User u = new User(email);

            Logic.UserLogic ul = new Logic.UserLogic();
            ul.GetSingleUser(u);

            int id = u.RetrieveUserID();

            DateTime beginDate = dtpBegin.Value;
            DateTime endDate = dtpEnd.Value;
            string type = Convert.ToString(cmbxType.SelectedItem.ToString());
            string description = tbxDescription.Text;

            om.Id = id;
            om.BeginDate = beginDate;
            om.EndDate = endDate;
            om.Type = type;
            om.Description = description;
            om.Code = 0;

            Logic.OmissionLogic ol = new Logic.OmissionLogic();
            ol.AddOmission(om);
        }

        public void GetEmail(string email)
        {
            this.email = email;
        }
    }
}
