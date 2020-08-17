using DataconPortal.Data;
using DataconPortal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace DataconPortal.Context
{
    class OmissionContext : IOmission
    {
        public List<Omission> GetAllOmissions()
        {
            List<Omission> om = new List<Omission>();

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Datacon"].ConnectionString))
            {
                string query = "SELECT * FROM Proftaak.Omission";
                SqlCommand cmd = new SqlCommand(query, conn);

                try
                {
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string type = reader["Type"].ToString();
                            Omission o = new Omission(type);

                            o.Id = (int)reader["Id"];
                            o.BeginDate = (DateTime)reader["StartDate"];
                            o.EndDate = (DateTime)reader["EndDate"];
                            o.Description = reader["Description"].ToString();
                            o.UserID = (int)reader["UserID"];
                            o.Code = (int)reader["Code"];

                            if ((DateTime.Now.Day - o.EndDate.Day) < 3)
                            {
                                if ((DateTime.Now.Day - o.EndDate.Day) > 0)
                                {
                                    o.Code = 3;
                                }
                                om.Add(o);
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return om;
        }

        public string GetUsername(int id)
        {
            string name = "";

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Datacon"].ConnectionString))
            {
                string query = "SELECT Firstname, Lastname FROM Proftaak.[User] WHERE Id = @ID";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@ID", id);

                try
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            name = reader["Firstname"] + " " + reader["Lastname"];
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

        public bool isOmissionAllowed(Omission o, int code)
        {
            bool isAllowed = false;

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Datacon"].ConnectionString))
            {
                string query = "UPDATE Proftaak.Omission SET Code = @Code WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Code", code);
                cmd.Parameters.AddWithValue("@Id", o.Id);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    isAllowed = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    isAllowed = false;
                }
            }
            return isAllowed;
        }

        public void AddOmission(Omission om)
        {

            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Datacon"].ConnectionString))
                {
                    string query = "INSERT INTO Proftaak.Omission(UserID, StartDate, EndDate, Type, Description, Code) " +
                                   "Values(@UserID, @StartDate, @EndDate, @Type, @Description, @Code)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        cmd.Parameters.AddWithValue("@UserID", om.Id);
                        cmd.Parameters.AddWithValue("@StartDate", om.BeginDate);
                        cmd.Parameters.AddWithValue("@EndDate", om.EndDate);
                        cmd.Parameters.AddWithValue("@Type", om.Type);
                        cmd.Parameters.AddWithValue("@Description", om.Description);
                        cmd.Parameters.AddWithValue("@Code", om.Code);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Verlof aanvragen gelukt!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<Omission> GetSingleUserOmission(Omission om)
        {

            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Datacon"].ConnectionString))
                {
                    List<Omission> OmissionListUser = new List<Omission>();
                    string query = "Select* " +
                                   "From Proftaak.Omission " +
                                   "Where UserID = @UserID";
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", om.UserID);
                        cmd.ExecuteNonQuery();
                        using (SqlDataReader dtr = cmd.ExecuteReader())
                        {
                            while (dtr.Read())
                            {
                                int Id = (int)dtr["Id"];
                                DateTime StartDate = (DateTime)dtr["StartDate"];
                                DateTime EndDate = (DateTime)dtr["EndDate"];
                                string Type = (string)dtr["Type"];
                                string Description = (string)dtr["Description"];
                                int Code = (int)dtr["Code"];
                                OmissionListUser.Add(new Omission(Id, StartDate, EndDate, Type, Description, Code));
                            }
                            return OmissionListUser;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
    }
}
