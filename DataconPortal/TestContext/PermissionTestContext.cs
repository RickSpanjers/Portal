using DataconPortal.Classes;
using DataconPortal.Interfaces;
using System;
using System.Collections.Generic;

namespace DataconPortal.TestContext
{
    class PermissionTestContext : IPermission
    {

        private List<Permission> permissions = new List<Permission>();

        public PermissionTestContext()
        {
            string name = "Testpermission.*";
            Permission p = new Permission(name);
            { p.PermissionDescription = "Dit is een test permissie."; }
            permissions.Add(p);
            string name1 = "Testpermission2.*";
            Permission pe = new Permission(name1);
            permissions.Add(pe);
        }

        public void AddPermission(Permission p)
        {
            if (!string.IsNullOrEmpty(p.RetrievePermissionName()) || !string.IsNullOrEmpty(p.PermissionDescription))
            {
                permissions.Add(p);
            }
        }

        public bool CheckDatabaseForPermissions(Permission p)
        {
            throw new NotImplementedException();
        }

        public void DeletePermission(string permission)
        {
            if (!string.IsNullOrEmpty(permission))
            {
                foreach (Permission p in permissions)
                {
                    if (p.PermissionName == permission)
                    {
                        permissions.Remove(p);
                    }
                }
            }
        }

        public List<Permission> GetAllPermissions()
        {
            List<Permission> permissionlist = new List<Permission>();

            foreach (Permission pe in permissions)
            {
                permissionlist.Add(pe);
            }

            return permissionlist;
        }

        public int getPermissionID(Permission p)
        {
            int id = -1;
            int count = 0;
            foreach (Permission pe in permissions)
            {
                if (pe.PermissionName == p.PermissionName)
                {
                    id = count;
                }
                count++;
            }

            return id;
        }

        public bool CheckPermissionsFromRole(int roleID, int permissionID)
        {
            throw new NotImplementedException();
        }

        public void AddPermissionToRole(int roleID, int permissionID)
        {
            throw new NotImplementedException();
        }

        public void DeleteRolePermission(int roleID, int permissionID)
        {
            throw new NotImplementedException();
        }

        public List<string> GetAllRolePermissions(string role)
        {
            throw new NotImplementedException();
        }
    }
}
