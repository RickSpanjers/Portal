using DataconPortal.Classes;
using DataconPortal.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace DataconPortal.Context
{
    class UserContext : IUser
    {

        /// <summary>
        /// Search for the login data in the database and return true if account has been found and checked
        /// </summary>
        public bool FindLoginData(User u)
        {
            bool Result = false;

            try
            {
                using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["Datacon"].ConnectionString))
                {
                    string query = "SELECT * FROM Proftaak.[User] WHERE Email = @email AND Password = @password";
                    SqlCommand cmd = new SqlCommand(query, cnn);
                    cmd.Parameters.AddWithValue("@email", u.RetrieveEmail());
                    cmd.Parameters.AddWithValue("@password", u.RetrievePassword());

                    cmd.CommandType = CommandType.Text;
                    cnn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Result = true;
                        }
                    }

                    cnn.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return Result;
        }


        /// <summary>
        /// Add the user to the database
        /// </summary>
        public void AddUser(User u)
        {
            ///Add the user to the database
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Datacon"].ConnectionString))
            {
                string query = "INSERT INTO Proftaak.[User] (Email, Password, Firstname, Lastname, Address, Zipcode, Place) " +
                    "VALUES(@Email, @Password, @Firstname, @Lastname, @Address, @Zipcode, @Place)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", u.RetrieveEmail());
                cmd.Parameters.AddWithValue("@Password", u.RetrievePassword());
                cmd.Parameters.AddWithValue("@Firstname", u.Firstname);
                cmd.Parameters.AddWithValue("@Lastname", u.Lastname);
                cmd.Parameters.AddWithValue("@Address", u.Address);
                cmd.Parameters.AddWithValue("@Zipcode", u.Zipcode);
                cmd.Parameters.AddWithValue("@Place", u.Place);

                cmd.CommandType = CommandType.Text;
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

        /// <summary>
        /// Load all the users from the database and return them
        /// </summary>
        public List<User> LoadUsers()
        {
            List<User> AllUsers = new List<User>();
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Datacon"].ConnectionString))
            {
                string query = "SELECT * FROM Proftaak.[User]";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.Text;

                try
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int ID = Convert.ToInt32(reader["ID"]);
                            string Email = reader["Email"].ToString();
                            string Password = reader["Password"].ToString();

                            User U = new User(ID, Email, Password);

                            U.Firstname = reader["Firstname"].ToString();
                            U.Address = reader["Address"].ToString();
                            U.Lastname = reader["Lastname"].ToString();
                            U.Zipcode = reader["Zipcode"].ToString();
                            U.Place = reader["Place"].ToString();

                            AllUsers.Add(U);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.Write(e.Message);
                }
            }
            return AllUsers;
        }


        /// <summary>
        /// Delete the user from the database
        /// </summary>
        public void DeleteUser(string Email)
        {
            string query = "Delete FROM Proftaak.[User] Where Email = @Email";
            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["Datacon"].ConnectionString))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Add a role to a user
        /// </summary>
        public bool AddRoleToUser(int UserID, int RoleID)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["Datacon"].ConnectionString))
                {
                    string query = "UPDATE Proftaak.[User] SET RoleID=@RoleID WHERE ID = @ID";

                    SqlCommand NewCmd = new SqlCommand(query, cnn);
                    NewCmd.CommandType = CommandType.Text;

                    NewCmd.Parameters.AddWithValue("@ID", UserID);
                    NewCmd.Parameters.AddWithValue("@RoleID", RoleID);

                    cnn.Open();
                    NewCmd.ExecuteNonQuery();
                    return true;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return false;
        }

        public User GetSingleUser(User u)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Datacon"].ConnectionString))
            {
                string query = "SELECT * FROM Proftaak.[User] WHERE Email = @Email";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Email", u.RetrieveEmail());

                try
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            u.Firstname = reader["Firstname"].ToString();
                            u.Address = reader["Address"].ToString();
                            u.Lastname = reader["Lastname"].ToString();
                            u.Zipcode = reader["Zipcode"].ToString();
                            u.Place = reader["Place"].ToString();
                            u.SetUserID = (int)reader["ID"];
                            u.SetRoleID = (int)reader["RoleID"];
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.Write(e.Message);
                }
            }

            u.RoleName = GetRoleName(u);

            return u;
        }

        public string GetRoleName(User u)
        {
            string name = "";
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Datacon"].ConnectionString))
            {
                string query = "SELECT r.Name FROM Proftaak.[Role] r INNER JOIN Proftaak.[User] u ON r.Id = u.RoleID WHERE u.ID = @Id AND r.ID = u.RoleID";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Id", u.RetrieveUserID());

                try
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            name = reader["Name"].ToString();
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return name;
        }

        public int GetRoleID(User u)
        {
            int id = 0;
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Datacon"].ConnectionString))
            {
                string query = "SELECT r.ID FROM Proftaak.[Role] r INNER JOIN Proftaak.[User] u ON r.Id = u.RoleID WHERE u.ID = @Id AND r.ID = u.RoleID";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@ID", u.RetrieveRoleID());

                try
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            id = Convert.ToInt32(reader["ID"].ToString());
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return id;
        }

        public bool UpdateUserWithPass(User u)
        {
            bool isUpdated = false;

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Datacon"].ConnectionString))
            {
                string query = "UPDATE Proftaak.[User] SET Email = @Email, Password = @Password, Firstname = @Firstname," +
                    " Lastname = @Lastname, Address = @Address, Zipcode = @Zipcode, Place = @Place WHERE ID = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", u.RetrieveEmail());
                cmd.Parameters.AddWithValue("@Password", u.RetrievePassword());
                cmd.Parameters.AddWithValue("@Firstname", u.Firstname);
                cmd.Parameters.AddWithValue("@Lastname", u.Lastname);
                cmd.Parameters.AddWithValue("@Address", u.Address);
                cmd.Parameters.AddWithValue("@Zipcode", u.Zipcode);
                cmd.Parameters.AddWithValue("@Place", u.Place);
                cmd.Parameters.AddWithValue("@Id", u.RetrieveUserID());

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
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

        public bool UpdateUserWithNoPass(User u)
        {
            bool isUpdated = false;

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Datacon"].ConnectionString))
            {
                string query = "UPDATE Proftaak.[User] SET Email = @Email, Firstname = @Firstname," +
                    " Lastname = @Lastname, Address = @Address, Zipcode = @Zipcode, Place = @Place WHERE ID = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", u.RetrieveEmail());
                cmd.Parameters.AddWithValue("@Firstname", u.Firstname);
                cmd.Parameters.AddWithValue("@Lastname", u.Lastname);
                cmd.Parameters.AddWithValue("@Address", u.Address);
                cmd.Parameters.AddWithValue("@Zipcode", u.Zipcode);
                cmd.Parameters.AddWithValue("@Place", u.Place);
                cmd.Parameters.AddWithValue("@Id", u.RetrieveUserID());

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

        public string ComputeHash(string password, byte[] saltBytes)
        {
            // If salt is not specified, generate it on the fly.
            if (saltBytes == null)
            {
                // Define min and max salt sizes.
                int minSaltSize = 4;
                int maxSaltSize = 8;

                // Generate a random number for the size of the salt.
                Random random = new Random();
                int saltSize = random.Next(minSaltSize, maxSaltSize);

                // Allocate a byte array, which will hold the salt.
                saltBytes = new byte[saltSize];

                // Initialize a random number generator.
                RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();

                // Fill the salt with cryptographically strong byte values.
                rng.GetNonZeroBytes(saltBytes);
            }

            // Convert plain text into a byte array.
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(password);

            // Allocate array, which will hold plain text and salt.
            byte[] plainTextWithSaltBytes =
                    new byte[plainTextBytes.Length + saltBytes.Length];

            // Copy plain text bytes into resulting array.
            for (int i = 0; i < plainTextBytes.Length; i++)
            {
                plainTextWithSaltBytes[i] = plainTextBytes[i];
            }

            // Append salt bytes to the resulting array.
            for (int i = 0; i < saltBytes.Length; i++)
            {
                plainTextWithSaltBytes[plainTextBytes.Length + i] = saltBytes[i];
            }

            HashAlgorithm hash;

            // Initialize appropriate hashing algorithm class.

            hash = new SHA256Managed();

            // Compute hash value of our plain text with appended salt.
            byte[] hashBytes = hash.ComputeHash(plainTextWithSaltBytes);

            // Create array which will hold hash and original salt bytes.
            byte[] hashWithSaltBytes = new byte[hashBytes.Length +
                                                saltBytes.Length];

            // Copy hash bytes into resulting array.
            for (int i = 0; i < hashBytes.Length; i++)
            {
                hashWithSaltBytes[i] = hashBytes[i];
            }

            // Append salt bytes to the result.
            for (int i = 0; i < saltBytes.Length; i++)
            {
                hashWithSaltBytes[hashBytes.Length + i] = saltBytes[i];
            }

            // Convert result into a base64-encoded string.
            string hashValue = Convert.ToBase64String(hashWithSaltBytes);

            // Return the result.
            return hashValue;
        }

        public bool VerifyHash(string password, string hashValue)
        {
            // Convert base64-encoded hash value into a byte array.
            byte[] hashWithSaltBytes = Convert.FromBase64String(hashValue);

            // We must know size of hash (without salt).
            int hashSizeInBits;
            int hashSizeInBytes;

            hashSizeInBits = 256;

            // Convert size of hash from bits to bytes.
            hashSizeInBytes = hashSizeInBits / 8;

            // Make sure that the specified hash value is long enough.
            if (hashWithSaltBytes.Length < hashSizeInBytes)
            {
                return false;
            }
            // Allocate array to hold original salt bytes retrieved from hash.
            byte[] saltBytes = new byte[hashWithSaltBytes.Length -
                                        hashSizeInBytes];

            // Copy salt from the end of the hash to the new array.
            for (int i = 0; i < saltBytes.Length; i++)
            {
                saltBytes[i] = hashWithSaltBytes[hashSizeInBytes + i];
            }

            // Compute a new hash string.
            string expectedHashString =
                        ComputeHash(password, saltBytes);

            bool isPassword = false;

            // If the computed hash matches the specified hash,
            // the plain text value must be correct.
            if (hashValue == expectedHashString)
            {
                isPassword = true;
            }
            return isPassword;
        }
    }
}
