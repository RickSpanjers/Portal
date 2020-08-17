using DataconPortal.Classes;
using DataconPortal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataconPortal.Repositories
{
    class RoleRepository
    {
        private IRole RoleInterface;

        public RoleRepository(IRole Context)
        {
            RoleInterface = Context;
        }
        public List<Role> RetrieveAllRoles()
        {
            return RoleInterface.RetrieveAllRoles();
        }
        public void AddRole(Role r)
        {
            RoleInterface.AddRole(r);
        }

        public void DeleteRole(string name)
        {
            RoleInterface.DeleteRole(name);
        }

        public int GetRoleID(Role r)
        {
            return RoleInterface.GetRoleID(r);
        }
        public bool UpdateRole(Role R)
        {
            return RoleInterface.UpdateRole(R);
        }
    }
}
