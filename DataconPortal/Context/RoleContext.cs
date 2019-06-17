using DataconPortal.Classes;
using DataconPortal.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataconPortal.Context
{
    class RoleContext : IRole
    {
        /// <summary>
        /// Retrieve all roles from the database and return them
        /// </summary>

        public List<Role> RetrieveAllRoles()
        {
            List<Role> ListOfRoles = new List<Role>();
            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["Datacon"].ConnectionString))
            {
                string query = "SELECT * FROM Proftaak.[Role]";
                SqlCommand command = new SqlCommand(query, cnn);
                command.CommandType = CommandType.Text;

                try
                {
                    cnn.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string RoleName = reader["Name"].ToString();
                            int RoleID = Convert.ToInt32(reader["ID"]);
                            Role R = new Role(RoleName, RoleID);
                            ListOfRoles.Add(R);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return ListOfRoles;
        }

        /// <summary>
        /// Add a role the system and the database
        /// </summary>

        public void AddRole(Role r)
        {
            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["Datacon"].ConnectionString))
            {
                string query = "INSERT INTO Proftaak.[Role] (Name) VALUES (@Name)";
                SqlCommand command = new SqlCommand(query, cnn);
                command.Parameters.AddWithValue("@Name", r.RetrieveRoleName());
                command.CommandType = CommandType.Text;
                try
                {
                    cnn.Open();
                    command.ExecuteNonQuery();

                }
                catch (Exception e)
                {
                    Console.Write(e.Message);
                    Console.ReadLine();
                }
            }
        }

        /// <summary>
        /// Delete the role from the system and the database
        /// </summary>

        public void DeleteRole(string name)
        {
            string query = "DELETE FROM Proftaak.[Role] WHERE Name = @Name";
            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["Datacon"].ConnectionString))
            {
                cnn.Open();
                using (SqlCommand cmdDeleteRole = new SqlCommand(query, cnn))
                {
                    cmdDeleteRole.Parameters.AddWithValue("@Name", name);
                    cmdDeleteRole.ExecuteNonQuery();
                }
            }
        }

        public int GetRoleID(Role r)
        {
            int id = -1;

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Datacon"].ConnectionString))
            {
                string query = "SELECT ID FROM Proftaak.[Role] WHERE Name = @Name";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", r.RetrieveRoleName());
                Console.WriteLine(r.RetrieveRoleName());

                try
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            id = Convert.ToInt32(reader["ID"]);
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


        public bool UpdateRole(Role R)
        {
            bool isUpdated = false;

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Datacon"].ConnectionString))
            {
                string query = "UPDATE Proftaak.[Role] SET Name = @Name WHERE ID = @ID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", R.RetrieveRoleName());
                cmd.Parameters.AddWithValue("@Id", R.RetrieveRoleID());

                try
                {
                    conn.Open();
                    cmd.ExecuteScalar();
                    isUpdated = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    isUpdated = false;
                }

            }
            return isUpdated;
        }

    }
}
