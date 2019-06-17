using DataconPortal.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataconPortal.Interfaces
{
    public interface IRole
    {
        List<Role> RetrieveAllRoles();
        void AddRole(Role r);
        void DeleteRole(string name);
        int GetRoleID(Role r);
        bool UpdateRole(Role R);
   
    }
}
