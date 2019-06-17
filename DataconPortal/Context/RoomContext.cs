using DataconPortal.Interfaces;
using DataconPortal.Classes;
using DataconPortal.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace DataconPortal.Context
{
    class RoomContext : IRoom
    {
        public void AddRoom(Room r)
        {
            ///Add the room to the database
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Datacon"].ConnectionString))
            {
                string query = "INSERT INTO Proftaak.[Room] (Name) VALUES(@name)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", r.RetrieveRoomName());

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

        public List<Room> LoadRooms()
        {
            List<Room> AllRooms = new List<Room>();
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Datacon"].ConnectionString))
            {
                string query = "SELECT * FROM Proftaak.[Room]";

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
                            string Name = reader["Name"].ToString();
                            
                            Room R = new Room(ID, Name);

                            R.RoomName = reader["Name"].ToString();

                            AllRooms.Add(R);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.Write(e.Message);
                }
            }
            return AllRooms;
        }

        public void DeleteRoom(string Name)
        {
            string query = "Delete FROM Proftaak.[Room] Where Name = @Name";
            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["Datacon"].ConnectionString))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateRoom(Room r)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Datacon"].ConnectionString))
            {
                string query = "UPDATE Proftaak.[Room] SET Name = @Name WHERE ID = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", r.RetrieveRoomName());
                cmd.Parameters.AddWithValue("@Id", r.RetrieveRoomID());

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
}
