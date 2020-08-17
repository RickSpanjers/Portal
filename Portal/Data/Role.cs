using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataconPortal.Classes
{
    public class Role
    {
        int roleID;
        string roleName;
        List<Permission> listOfPermissions = new List<Permission>();

        /// <summary>
        /// Constructos of the class Role
        /// </summary>
      

        public Role(string Name, int ID)
        {
            roleName = Name;
            roleID = ID;
        }

        public Role(string Name)
        {
            roleName = Name;
        }

        /// <summary>
        /// Return the roleID
        /// </summary>

        public int RetrieveRoleID()
        {
            return roleID;
        }

        /// <summary>
        /// Return the role name
        /// </summary>

        public string RetrieveRoleName()
        {
            return roleName;
        }

        public string RoleName
        {
            get { return roleName; }
            set { roleName = value; }
        }

        public int RoleID
        {
            get { return roleID; }
            set { roleID = value;  }
        }
    }
}
