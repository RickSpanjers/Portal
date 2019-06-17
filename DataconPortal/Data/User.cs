using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataconPortal.Classes
{
    public class User
    {
        private int userID;
        private string emailaddress;
        private string password;
        private string roleName;
        private int roleID;
        private string firstname;
        private string lastname;
        private string address;
        private string zipcode;
        private string place;

        private Role userRole;

        /// <summary>
        /// Constructors for the class User
        /// </summary>
        public User()
        {
        }

        public User(string Email)
        {
            this.emailaddress = Email;
        }

        public User(int id,string email,string password,int roleID)
        {

        }

        public User(int ID, string Email, string Password)
        {
            userID = ID;
            emailaddress = Email;
            password = Password;
        }

        public User(string Email, string Password)
        {
            this.emailaddress = Email;
            this.password = Password;
        }

        /// <summary>
        /// Return the UserID
        /// </summary>
      

        public int RetrieveUserID()
        {
            return userID;
        }

        /// <summary>
        /// Return the email
        /// </summary>
        

        public string RetrieveEmail()
        {
            return emailaddress;
        }

        public string SetEmail
        {
            set{ emailaddress = value; }
        }

        /// <summary>
        /// Return the password
        /// </summary>
        

        public string RetrievePassword()
        {
            return password;
        }

        public string SetPassword
        {
            set { password = value; }
        }

        public int RetrieveRoleID()
        {
            return roleID;
        }

        /// <summary>
        /// Set the user role
        /// </summary>
      


        public void SetUserRole(Role R)
        {
            userRole = R;
        }


        public string RoleName
        {
            get { return roleName; }
            set { roleName = value; }
        }
        /// <summary>
        /// Get the user role
        /// </summary>
       

        public Role RetrieveUserRole()
        {
            return userRole;
        }

        public int SetUserID
        {
            set { userID = value; }
        }

        public int SetRoleID
        {
            set { roleID = value; }
        }

        /// <summary>
        /// Propertys of the class User
        /// </summary>

        public string Firstname
        {
            get
            {
                return firstname;
            }
            set
            {
                firstname = value;
            }
        }

        public string Lastname
        {
            get
            {
                return lastname;
            }
            set
            {
                lastname = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        public string Zipcode
        {
            get
            {
                return zipcode;
            }
            set
            {
                zipcode = value;
            }
        }

        public string Place
        {
            get
            {
                return place;
            }
            set
            {
                place = value;
            }
        }
    }
}
