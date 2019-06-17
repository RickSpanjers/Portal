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
    public partial class UserOverview : Form
    {
        private bool isModified = false;
        private string email;

        public UserOverview()
        {
            InitializeComponent();
            LoadUsersFromDB();
        }

        public UserOverview(string email)
        {
            InitializeComponent();
            this.email = email;
            LoadUsersFromDB();
        }

        /// <summary>
        /// Open form to modify the selected user
        /// </summary>

        private void btnModify_Click(object sender, EventArgs e)
        {
            isModified = true;
            UserLogic logic = new UserLogic();
            int id = -1;

            List<User> users = logic.RetrieveAllUsers();

            if (lbxUsers.SelectedItem != null)
            {
                foreach (User us in users)
                {
                    if (us.RetrieveEmail() == lbxUsers.SelectedItem.ToString())
                    {
                        id = us.RetrieveUserID();
                    }
                }

                string emailSelected = lbxUsers.SelectedItem.ToString();
                User u = new User(emailSelected);
                logic.GetSingleUser(u);

                ///Open form to modify the selected user.
                SingleUser user = new SingleUser(id, email);
                user.getUserInfo(u, isModified);
                this.Hide();
                user.Show();
            }
			else
            {
                MessageBox.Show("Je moet een email selecteren.");
            }
        }

        /// <summary>
        /// Open the register form
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            SingleUser user = new SingleUser(email);
            this.Hide();
            user.Show();
        }

        /// <summary>
        /// Remove the user from the database
        /// </summary>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            UserLogic Logic = new UserLogic();

            if (Logic.RemoveUser((string)lbxUsers.SelectedItem) == true)
            {
                lbxUsers.Items.Clear();
                LoadUsersFromDB();
                MessageBox.Show("Gebruiker verwijderd!");
            }
            else
            {
                MessageBox.Show("Er ging iets mis tijdens het verwijderen");
            }
        }

        /// <summary>
        /// Go back to the dashboard form
        /// </summary>     
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard board = new Dashboard(email);
            board.Show();
            this.Hide();
        }


        /// <summary>
        /// Load all the users into the listbox
        /// </summary>
        private void LoadUsersFromDB()
        {
            UserLogic Logic = new UserLogic();
            var AllUsers = Logic.RetrieveAllUsers();

            foreach (var SingleUser in AllUsers)
            {
                lbxUsers.Items.Add(SingleUser.RetrieveEmail());
            }
        }

        private void UserOverview_Load(object sender, EventArgs e)
        {
            LoadUsersFromDB();
        }
    }
}
