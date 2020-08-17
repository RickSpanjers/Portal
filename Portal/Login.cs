using DataconPortal.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataconPortal.Forms;
using DataconPortal.Repositories;
using DataconPortal.Context;
using DataconPortal.Logic;
using DataconPortal.View;
using DataconPortal.Data;

namespace DataconPortal
{
    public partial class PortalLogin : Form
    {
        public PortalLogin()
        {
            InitializeComponent();

            //Enter key function as login button
            this.AcceptButton = btn_login;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            LoginUser();
        }


        public void LoginUser()
        {
            LoginLogic Logic = new LoginLogic();

            if (Logic.Log_In_User(TB_Username.Text, TB_Password.Text) == true)
            {
                string email = TB_Username.Text;
                
                //Hide the current form
                this.Hide();
                //Make instance of new form
                var Dashboard = new Dashboard(email);

                Dashboard.Closed += (s, args) => this.Close();

                //Open new form
                Dashboard.Show();

            }
            else
            {
                MessageBox.Show("Gebruikersnaam of wachtwoord was niet correct");
            }
        }

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}
