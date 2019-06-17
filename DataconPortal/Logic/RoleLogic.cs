using DataconPortal.Classes;
using DataconPortal.Context;
using DataconPortal.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataconPortal.Logic
{
    class RoleLogic
    {
		RoleRepository RoleRepo = new RoleRepository(new RoleContext());

		public List<Role> RetrieveAllRoles()
        {
            return RoleRepo.RetrieveAllRoles();
        }

        public bool DeleteRole(string name)
        {          
            if(string.IsNullOrEmpty(name) == true)
            {
                return false;
            }
            else
            {
                RoleRepo.DeleteRole(name);
                return true;
            }
        }

        public int GetRoleID(Role R)
        {
            return RoleRepo.GetRoleID(R);
        }

        public bool AddRole(Role R)
        {
            RoleRepo.AddRole(R);
            return true;
        }

        public bool EditRole(Role R)
        {
            string Rolename = R.RetrieveRoleName();
            int RoleID = 0;

            var AllRoles = RoleRepo.RetrieveAllRoles();
            foreach(var SingleRole in AllRoles)
            {
                if(SingleRole.RetrieveRoleID() == R.RetrieveRoleID())
                {
                    RoleID = SingleRole.RetrieveRoleID();  
                }
            }

            Role UpdatedRole = new Role(Rolename, RoleID);
            return RoleRepo.UpdateRole(R);
        }
    }
}
