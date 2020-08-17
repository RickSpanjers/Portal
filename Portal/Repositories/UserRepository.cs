using DataconPortal.Classes;
using DataconPortal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataconPortal.Repositories
{
    class UserRepository
    {
        private IUser UserInterface;

        public UserRepository(IUser Context)
        {
            UserInterface = Context;
        }

        public bool FindLoginData(User u)
        {
            return UserInterface.FindLoginData(u);
        }
        public void AddUser(User u)
        {
            UserInterface.AddUser(u);
        }

        public List<User> LoadUsers()
        {
            return UserInterface.LoadUsers();
        }

        public void DeleteUser(string Email)
        {
            UserInterface.DeleteUser(Email);
        }
        public bool AddRoleToUser(int UserID, int RoleID)
        {
            return UserInterface.AddRoleToUser(UserID, RoleID);
        }

        public User GetSingleUser(User u)
        {
            return UserInterface.GetSingleUser(u);
        }

        public string GetRoleName(User u)
        {
            return UserInterface.GetRoleName(u);
        }

        public int GetRoleID(User u)
        {
            return UserInterface.GetRoleID(u);
        }

        public bool UpdateUserWithPass(User u)
        {
            return UserInterface.UpdateUserWithPass(u);
        }

        public bool UpdateUserWithNoPass(User u)
        {
            return UserInterface.UpdateUserWithNoPass(u);
        }

        public bool VerifyHash(string password, string hashValue)
        {
            return UserInterface.VerifyHash(password, hashValue);
        }

        public string ComputeHash(string password, byte[] saltBytes)
        {
            return UserInterface.ComputeHash(password, saltBytes);
        }
    }
}
