using DataconPortal.Classes;
using DataconPortal.Interfaces;
using System;
using System.Collections.Generic;

namespace DataconPortal.TestContext
{
    public class UserTestContext : IUser
    {
        private List<User> users = new List<User>();
        private List<Role> roles = new List<Role>();

        public UserTestContext()
        {
            int id = 1;
            string email = "test@test.nl";
            string password = "test123";
            User u = new User(id, email, password);
            { u.Firstname = "Test"; u.Lastname = "Testing"; u.Address = "Teststraat 12"; u.Zipcode = "8645LD"; u.Place = "Testwijk"; u.SetRoleID = 0; }
            users.Add(u);
            string email1 = "jan@piet.nl";
            string password1 = "janpieterman";
            User us = new User(email1, password1);
            { us.Firstname = "Jan"; us.Lastname = "Piet"; us.Address = "Janstraat 3"; us.Zipcode = "9764GF"; us.Place = "PietPlaats"; u.SetRoleID = 1; }
            users.Add(us);
            string name = "User";
            Role r = new Role(name);
            r.RoleID = 0;
            roles.Add(r);
            string name1 = "Admin";
            Role r1 = new Role(name1);
            r.RoleID = 1;
            roles.Add(r1);
        }

        public bool FindLoginData(User u)
        {
            bool hasData = false;
            foreach (User us in users)
            {
                if (us.RetrieveEmail() == u.RetrieveEmail())
                {
                    if (us.RetrievePassword() == u.RetrievePassword())
                    {
                        hasData = true;
                    }
                }
            }
            return hasData;
        }

        public void AddUser(User u)
        {
            if (string.IsNullOrEmpty(u.Firstname) || string.IsNullOrEmpty(u.Lastname) || string.IsNullOrEmpty(u.Address) ||
                string.IsNullOrEmpty(u.Zipcode) || string.IsNullOrEmpty(u.Place))
            {
                return;
            }
            else
            {
                users.Add(u);
            }
        }

        public List<User> LoadUsers()
        {
            List<User> usersTest = new List<User>();

            foreach (User u in users)
            {
                usersTest.Add(u);
            }

            return usersTest;
        }

        public void DeleteUser(string email)
        {
            int id = -1;
            int count = 0;
            foreach (User u in users)
            {
                if (u.RetrieveEmail() == email)
                {
                    id = count;
                }
                count++;
            }

            if (id != -1)
            {
                users.RemoveAt(id);
            }
            else
            {
                return;
            }
        }

        public bool AddRoleToUser(int userID, int roleID)
        {
            bool isRoleAdded = false;
            foreach (User u in users)
            {
                if (u.RetrieveRoleID() == roleID)
                {
                    if (u.RetrieveUserID() == userID)
                    {
                        u.SetRoleID = roleID;
                        isRoleAdded = true;
                    }
                }
            }
            return isRoleAdded;
        }

        public User GetSingleUser(User u)
        {
            foreach (User us in users)
            {
                if (us.RetrieveEmail() == u.RetrieveEmail())
                {
                    u.Firstname = us.Firstname;
                    u.Lastname = us.Lastname;
                    u.Address = us.Address;
                    u.Place = us.Place;
                    u.Zipcode = us.Zipcode;
                    u.SetUserID = us.RetrieveUserID();
                }
            }
            return u;
        }

        public string GetRoleName(User u)
        {
            string roleName = "";
            foreach (Role r in roles)
            {
                if (u.RetrieveRoleID() == r.RetrieveRoleID())
                {
                    roleName = "Test";
                }
            }
            return roleName;
        }

        public int GetRoleID(User u)
        {
            int id = -1;
            string email = "";

            foreach (User us in users)
            {
                if (u.RetrieveEmail() == us.RetrieveEmail())
                {
                    email = u.RetrieveEmail();
                }
            }

            foreach (Role r in roles)
            {
                if (u.RetrieveRoleID() == r.RetrieveRoleID())
                {
                    if (!string.IsNullOrEmpty(email))
                    {
                        id = r.RetrieveRoleID();
                    }
                }
            }
            return id;
        }

        public bool UpdateUserWithPass(User u)
        {
            bool isUpdated = false;

            if (string.IsNullOrEmpty(u.Firstname) || string.IsNullOrEmpty(u.Lastname) ||
                string.IsNullOrEmpty(u.Address) || string.IsNullOrEmpty(u.Zipcode) ||
                string.IsNullOrEmpty(u.Place) || string.IsNullOrEmpty(u.RetrievePassword()) ||
                string.IsNullOrEmpty(u.RetrieveEmail()))
            {
                isUpdated = false;
            }
            else
            {
                foreach (User us in users)
                {
                    if (us.RetrieveEmail() == u.RetrieveEmail())
                    {
                        us.Firstname = u.Firstname;
                        us.Lastname = u.Lastname;
                        us.SetEmail = u.RetrieveEmail();
                        us.SetPassword = u.RetrievePassword();
                        us.Address = u.Address;
                        us.Zipcode = u.Zipcode;
                        us.Place = u.Place;
                        isUpdated = true;
                    }
                }
            }
            return isUpdated;
        }

    public bool UpdateUserWithNoPass(User u)
    {
        bool isUpdated = false;
        foreach (User us in users)
        {
            if (us.RetrieveEmail() == u.RetrieveEmail())
            {
                us.Firstname = u.Firstname;
                us.Lastname = u.Lastname;
                us.SetEmail = u.RetrieveEmail();
                us.Address = u.Address;
                us.Zipcode = u.Zipcode;
                us.Place = u.Place;
                isUpdated = true;
            }
        }
        return isUpdated;
    }



    public bool VerifyHash(string password, string hashValue)
    {
        throw new NotImplementedException();
    }

    public string ComputeHash(string password, byte[] saltBytes)
    {
        throw new NotImplementedException();
    }
}
}
