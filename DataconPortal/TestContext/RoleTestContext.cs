using DataconPortal.Classes;
using DataconPortal.Interfaces;
using System;
using System.Collections.Generic;

namespace DataconPortal.TestContext
{
    public class RoleTestContext : IRole
    {
        private List<Role> rolelist = new List<Role>();

        public List<Role> RetrieveAllRoles()
        {
            throw new NotImplementedException();
        }

        public void AddRole(Role r)
        {
            if (!string.IsNullOrEmpty(r.RetrieveRoleName()))
            {
                rolelist.Add(r);
            }
        }

        public void DeleteRole(string name)
        {
            foreach (Role r in rolelist)
            {
                if (r.RetrieveRoleName() == name)
                {
                    rolelist.Remove(r);
                }
            }
        }

        public int GetRoleID(Role r)
        {
            throw new NotImplementedException();
        }

        public bool UpdateRole(Role r)
        {
            bool isUpdated = false;
            foreach (Role ro in rolelist)
            {
                if (ro.RetrieveRoleName() == r.RetrieveRoleName())
                {
                    ro.RoleName = r.RoleName;
                    ro.RoleID = r.RoleID;
                    isUpdated = true;
                }
            }
            return isUpdated;
        }
    }
}
