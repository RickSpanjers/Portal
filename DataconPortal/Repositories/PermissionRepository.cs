using DataconPortal.Classes;
using DataconPortal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataconPortal.Repositories
{
    class PermissionRepository
    {
        private IPermission PermissionInterface;

        public PermissionRepository(IPermission Context)
        {
            PermissionInterface = Context;
        }

        public void AddPermission(Permission permission)
        {
            PermissionInterface.AddPermission(permission);
        }
        public bool CheckDatabaseForPermissions(Permission permission)
        {
            return PermissionInterface.CheckDatabaseForPermissions(permission);
        }
        public void DeletePermission(string permission)
        {
            PermissionInterface.DeletePermission(permission);
        }
        public List<Permission> GetAllPermissions()
        {
            return PermissionInterface.GetAllPermissions();
        }

        public void AddPermissionToRole(int roleID, int permissionID)
        {
            PermissionInterface.AddPermissionToRole(roleID, permissionID);
        }

        public int getPermissionID(Permission P)
        {
            return PermissionInterface.getPermissionID(P);
        }

        public bool CheckPermissionsFromRole(int roleID, int permissionID)
        {
            return PermissionInterface.CheckPermissionsFromRole(roleID, permissionID);
        }

        public void DeleteRolePermission(int RoleID, int PermissionID)
        {
            PermissionInterface.DeleteRolePermission(RoleID, PermissionID);
        }

        public List<string> GetAllRolePermissions(string rol)
        {
            return PermissionInterface.GetAllRolePermissions(rol);
        }
    }
}
