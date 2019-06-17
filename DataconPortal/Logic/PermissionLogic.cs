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
    class PermissionLogic
    {
		PermissionRepository PermissionRepo = new PermissionRepository(new PermissionContext());

		public List<Permission> RetrieveAllPermissions()
        {
            return PermissionRepo.GetAllPermissions();
        }

        public void AddPermission(string selectedRole, string selectedPermission)
        {
            RoleLogic RLogic = new RoleLogic();
            Permission p = new Permission(selectedPermission);
            Role r = new Role(selectedRole);

            int roleID = RLogic.GetRoleID(r);
            int permissionID = PermissionRepo.getPermissionID(p);

            bool hasPermission = PermissionRepo.CheckPermissionsFromRole(roleID, permissionID);

            if (roleID != -1 || permissionID != -1)
            {
                if (hasPermission == false)
                {
                    PermissionRepo.AddPermissionToRole(roleID, permissionID);
                }
            }
            PermissionRepo.AddPermission(p);
        }

        public bool DeletePermission(string permission)
        {
            if (string.IsNullOrEmpty(permission)){

                return false;
            }
            else
            {           
                PermissionRepo.DeletePermission(permission);
                return true;
            }
            
        }


        public List<string> GetAllRolePermissions(string rol)
        {
            return PermissionRepo.GetAllRolePermissions(rol);
        }

        public void DeleteRolePermission(int RoleID, int PermissionID)
        {
            PermissionRepo.DeleteRolePermission(RoleID, PermissionID);
        }
    }
}
