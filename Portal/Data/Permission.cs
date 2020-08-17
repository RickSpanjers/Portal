using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataconPortal.Classes
{
    public class Permission
    {
        int permissionID;
        string permissionName;
        string permissionDescription;

        /// <summary>
        /// Constructors for the class Permission
        /// </summary>

        public Permission(int ID, string Name)
        {
            permissionID = ID;
            permissionName = Name;
        }

        public Permission(string Name, string Description)
        {
            this.permissionName = Name;
            this.permissionDescription = Description;
        }

        public Permission(string Name)
        {
            this.permissionName = Name;
        }

        /// <summary>
        /// Get the name of the permission
        /// </summary>

        public string RetrievePermissionName()
        {
            return permissionName;
        }

        /// <summary>
        /// Get or set the permission name
        /// </summary>

        public string PermissionName
        {
            get { return permissionName; }
            set { permissionName = value; }
        }

        /// <summary>
        /// Get or set the permission description
        /// </summary>
   
        public string PermissionDescription
        {
            get { return permissionDescription; }
            set { permissionDescription = value; }
        }

        public int RetrievePermissionID()
        {
            return permissionID;
        }
    }
}
