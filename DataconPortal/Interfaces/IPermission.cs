using DataconPortal.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataconPortal.Interfaces
{
    public interface IPermission
    {      
        void AddPermission(Permission permission);
        bool CheckDatabaseForPermissions(Permission permission);
        void DeletePermission(string permission);
        List<Permission> GetAllPermissions();
        int getPermissionID(Permission P);
        bool CheckPermissionsFromRole(int roleID, int permissionID);
        void AddPermissionToRole(int roleID, int permissionID);
        void DeleteRolePermission(int RoleID, int PermissionID);
        List<string> GetAllRolePermissions(string rol);
    }
}
