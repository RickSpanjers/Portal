using DataconPortal.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataconPortal.Interfaces
{
    public interface IUser
    {
        bool FindLoginData(User u); 
        void AddUser(User u);
        List<User> LoadUsers();
        void DeleteUser(string Email);
        bool AddRoleToUser(int UserID, int RoleID);
        User GetSingleUser(User u);
        string GetRoleName(User u);
        int GetRoleID(User u);
        bool UpdateUserWithPass(User u);
        bool UpdateUserWithNoPass(User u);
        bool VerifyHash(string password, string hashValue);
        string ComputeHash(string password, byte[] saltBytes);

    }
}
