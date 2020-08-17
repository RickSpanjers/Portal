using DataconPortal.Classes;
using DataconPortal.Context;
using DataconPortal.Logic;
using DataconPortal.Repositories;
using System;
using System.Windows.Forms;

namespace DataconPortal.Forms
{
    public partial class SingleUser : Form
    {
        private string email;
        private string password;
        private string firstname;
        private string lastname;
        private string address;
        private string zipcode;
        private string place;
        private string role;
        private int id;
        private bool isModified;
        private string userEmail;

        public SingleUser(string email)
        {
            InitializeComponent();
            FillUserRoles();
            this.userEmail = email;
        }
        public SingleUser()
        {
            InitializeComponent();
            FillUserRoles();
        }

        public SingleUser(int id, string email)
        {
            InitializeComponent();
            FillUserRoles();
            this.id = id;
            this.userEmail = email;
        }

        /// <summary>
        /// Add a new user to the database
        /// </summary>

        private void btnAdd_Click(object sender, EventArgs e)
        {
            UserLogic Logic = new UserLogic();
            UserRepository repo = new UserRepository(new UserContext());

            if (string.IsNullOrEmpty(tbxEmail.Text) || string.IsNullOrEmpty(tbxPassword.Text) || string.IsNullOrEmpty(tbxRepeat.Text) ||
                string.IsNullOrEmpty(tbxFirstname.Text) || string.IsNullOrEmpty(tbxLastname.Text) || string.IsNullOrEmpty(tbxAddress.Text) || 
                string.IsNullOrEmpty(tbxZipcode.Text) || string.IsNullOrEmpty(tbxPlace.Text))
            {
                lblMessage.Text = "Je mag geen velden leeg laten!";
            }
            else
            {
                if (tbxEmail.Text.IndexOf("@") == -1 || tbxEmail.Text.IndexOf(".") == -1)
                {
                    lblMessage.Text = "E-mailadres is ongeldig";
                }
                else
                {
                    if (tbxPassword.Text == tbxRepeat.Text)
                    {
                        string password = repo.ComputeHash(tbxPassword.Text, null);
                        User u = new User(tbxEmail.Text, password);
                        u.Firstname = tbxFirstname.Text;
                        u.Lastname = tbxLastname.Text;
                        u.Address = tbxAddress.Text;
                        u.Zipcode = tbxZipcode.Text;
                        u.Place = tbxPlace.Text;

                        Logic.AddUserToSystem(u);
                        AddRoleToUser(u);

                        UserOverview overview = new UserOverview(userEmail);
                        overview.Show();
                        this.Hide();
                    }
                    else
                    {
                        lblMessage.Text = "Wachtwoorden zijn niet gelijk aan elkaar.";
                    }
                }
            }
        }

        /// <summary>
        /// Cancel to add a new user and return to the UserOverviewForm
        /// </summary>

        private void btnCancel_Click(object sender, EventArgs e)
        {
            UserOverview overview = new UserOverview(userEmail);
            overview.Show();
            this.Hide();
        }

        /// <summary>
        /// Fill the listbox with all the roles that are in the database
        /// </summary>

        public void FillUserRoles()
        {
            RoleLogic Logic = new RoleLogic();

            var AllRoles = Logic.RetrieveAllRoles();

            foreach (var SingleRole in AllRoles)
            {
                CB_Roles.Items.Add(SingleRole.RetrieveRoleName());
            }
        }

        /// <summary>
        /// Add a role to a user 
        /// </summary>

        public void AddRoleToUser(User U)
        {
            if (CB_Roles.SelectedIndex > -1)
            {
                UserLogic Logic = new UserLogic();
                if (Logic.AddRoleToUser(U, CB_Roles.SelectedItem.ToString()) == true)
                {
                    MessageBox.Show("Success");
                }
                else
                {
                    MessageBox.Show("Failed to add the role to the user");
                }
            }
        }

        private void SingleUser_Load(object sender, EventArgs e)
        {
			tbxEmail.Text = userEmail;
            tbxFirstname.Text = firstname;
            tbxLastname.Text = lastname;
            tbxAddress.Text = address;
            tbxZipcode.Text = zipcode;
            tbxPlace.Text = place;

            if (isModified == true)
            {
                btnAdd.Visible = false;
                btnModify.Visible = true;
            }
            else
            {
                btnAdd.Visible = true;
                btnModify.Visible = false;
            }
        }

        public void getUserInfo(User u, bool isModified)
        {
            email = u.RetrieveEmail();
            firstname = u.Firstname;
            lastname = u.Lastname;
            address = u.Address;
            zipcode = u.Zipcode;
            place = u.Place;
            CB_Roles.SelectedItem = u.RoleName;
            this.isModified = isModified;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            UserLogic logic = new UserLogic();
            bool isUpdated = false;
            if (string.IsNullOrEmpty(tbxEmail.Text) || string.IsNullOrEmpty(tbxFirstname.Text) ||
                string.IsNullOrEmpty(tbxLastname.Text) || string.IsNullOrEmpty(tbxAddress.Text) || 
                string.IsNullOrEmpty(tbxZipcode.Text) || string.IsNullOrEmpty(tbxPlace.Text))
            {
                lblMessage.Text = "Je mag de persoonsgegevens niet leeglaten.";
                isUpdated = false;
            }
            else
            {
                if (tbxEmail.Text.IndexOf("@") == -1 || tbxEmail.Text.IndexOf(".") == -1)
                {
                    lblMessage.Text = "E-mailadres is ongeldig";
                    isUpdated = false;
                }
                else
                {
                    if (string.IsNullOrEmpty(tbxPassword.Text) && string.IsNullOrEmpty(tbxRepeat.Text))
                    {
                        User u = new User(tbxEmail.Text);
                        u.SetUserID = id;
                        u.Firstname = tbxFirstname.Text;
                        u.Lastname = tbxLastname.Text;
                        u.Address = tbxAddress.Text;
                        u.Zipcode = tbxZipcode.Text;
                        u.Place = tbxPlace.Text;
                        logic.AddRoleToUser(u, CB_Roles.SelectedItem.ToString());
                        isUpdated = logic.UpdateUserWithNoPass(u);
                    }
                    else
                    {
                        User u = new User(tbxEmail.Text, tbxPassword.Text);
                        u.SetUserID = id;
                        u.Firstname = tbxFirstname.Text;
                        u.Lastname = tbxLastname.Text;
                        u.Address = tbxAddress.Text;
                        u.Zipcode = tbxZipcode.Text;
                        u.Place = tbxPlace.Text;
                        logic.AddRoleToUser(u, CB_Roles.SelectedItem.ToString());
                        isUpdated = logic.UpdateUserWithPass(u);
                    }
                }
            }

            if (isUpdated == true)
            {
                MessageBox.Show("Gegevens upgedate.");
                UserOverview overview = new UserOverview(userEmail);
                this.Hide();
                overview.Show();
            }
        }
    }
}
