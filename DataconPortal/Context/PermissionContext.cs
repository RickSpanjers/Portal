using DataconPortal.Classes;
using DataconPortal.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataconPortal.Context
{
    class PermissionContext : IPermission
    {
     
        /// <summary>
        /// Add all permissions to the system.
        /// </summary>
        public void AddPermission(Permission permission)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Datacon"].ConnectionString))
            {
                string query = "INSERT INTO Proftaak.[Permission] (Name, Description) VALUES(@Name, @Description)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Name", permission.PermissionName);
                cmd.Parameters.AddWithValue("@Description", permission.PermissionDescription);

                if (CheckDatabaseForPermissions(permission) == false)
                {
                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
        }


        /// <summary>
        /// Check the database all added permissions
        /// </summary>

        public bool CheckDatabaseForPermissions(Permission permission)
        {
            bool hasRows = false;
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Datacon"].ConnectionString))
            {
                string query = "SELECT * FROM Proftaak.[Permission] WHERE Name = @Name";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", permission.PermissionName);

                try
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            hasRows = true;
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.Write(e.Message);
                }
            }
            return hasRows;
        }

        /// <summary>
        /// Delete a permission from the database and the system
        /// </summary>

        public void DeletePermission(string permission)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Datacon"].ConnectionString))
            {
                string query = "DELETE FROM Proftaak.[Permission] WHERE Name = @Name";

                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", permission);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Get all the permissions from the database
        /// </summary>

        public List<Permission> GetAllPermissions()
        {
            List<Permission> ListOfPermissions = new List<Permission>();
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Datacon"].ConnectionString))
            {
                string query = "SELECT * FROM Proftaak.[Permission]";

                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandType = CommandType.Text;

                    try
                    {
                        using (SqlDataReader D = cmd.ExecuteReader())
                        {
                            while (D.Read())
                            {
                                int PermissionID = Convert.ToInt32(D["ID"]);
                                string permissionname = D["Name"].ToString();
                                Permission P = new Permission(PermissionID, permissionname);
                                ListOfPermissions.Add(P);
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }
                return ListOfPermissions;
            }
        }

        public void AddPermissionToRole(int roleID, int permissionID)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Datacon"].ConnectionString))
            {
                string query = "INSERT INTO Proftaak.RolePermission (RoleID, PermissionID) VALUES (@RoleID, @PermissionID)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@RoleID", roleID);
                cmd.Parameters.AddWithValue("@PermissionID", permissionID);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.Write(e.Message);
                }

            }
        }

        public int getPermissionID(Permission p)
        {
            int id = -1;

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Datacon"].ConnectionString))
            {
                string query = "SELECT ID FROM Proftaak.[Permission] WHERE Name = @Name";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", p.RetrievePermissionName());

                try
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            id = (int)reader["ID"];
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.Write(e.Message);
                }

            }
            return id;
        }

        public bool CheckPermissionsFromRole(int roleID, int PermissionID)
        {
            bool hasRows = false;

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Datacon"].ConnectionString))
            {
                string query = "SELECT * FROM Proftaak.RolePermission WHERE RoleID = @RoleID AND PermissionID = @PermissionID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@RoleID", roleID);
                cmd.Parameters.AddWithValue("@PermissionID", PermissionID);

                try
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            hasRows = true;
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                return hasRows;
            }
        }


        public void DeleteRolePermission(int RoleID, int PermissionID)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Datacon"].ConnectionString))
            {
                string query = "DELETE FROM Proftaak.[RolePermission] WHERE RoleID = @RoleID And PermissionID = @PermissionID";
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@RoleID", RoleID);
                    cmd.Parameters.AddWithValue("@PermissionID", PermissionID);
                    cmd.ExecuteScalar();
                }
            }
        }


        public List<string> GetAllRolePermissions(string rol)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Datacon"].ConnectionString))
            {
                List<string> per = new List<string>();
                string query = "Select PP.Name " +
                               "From Proftaak.Permission PP, Proftaak.RolePermission PR, Proftaak.Role PRO " +
                               "WHERE PP.ID = PR.PermissionID " +
                               "AND PR.RoleID = PRO.ID " +
                               "AND PRO.Name = @RoleName";
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@RoleName", rol);
                    using (SqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            string permission = dtr.GetString(0);
                            per.Add(permission);
                        }
                    }
                    return per;
                }
            }
        }
    }
}
