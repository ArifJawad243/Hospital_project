using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.utility;

namespace WinFormsApp1.classes
{
    internal class user
    {
        public int userid { get; set; }
        public string username { get; set; }
        public string fullname { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string role { get; set; }

        public bool SaveToDatabase()
        {
            string query = "INSERT INTO Users (Username, Password, FullName, Email, Role) VALUES (@uname, @upass, @fullname, @uemail, @urole)";

            using (SqlConnection conn = dbhelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@uname", this.username);
                cmd.Parameters.AddWithValue("@upass", this.password);
                cmd.Parameters.AddWithValue("@fullname", this.fullname);
                cmd.Parameters.AddWithValue("@uemail", this.email);
                cmd.Parameters.AddWithValue("@urole", this.role);

                try
                {
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// Authenticate a user. On success sets AppSession.UserID, AppSession.Username, AppSession.RoleName.
        /// If the role is DOCTOR (case-insensitive) sets AppSession.DoctorID using dbhelper.getDoctorID(fullName).
        /// Returns the UserID on success, or -1 on failure.
        /// </summary>
        public static int Login(string uname, string upass)
        {
            const string query = "SELECT UserID, FullName, Role FROM Users WHERE Username = @username AND Password = @password;";

            using (SqlConnection conn = dbhelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@username", uname ?? string.Empty);
                cmd.Parameters.AddWithValue("@password", upass ?? string.Empty);

                try
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string fullName = reader.GetString(1);
                            string roleName = reader.GetString(2);

                            // populate session
                            AppSession.UserID = id;
                            AppSession.Username = uname;
                            if (roleName != null)
                            {
                                AppSession.RoleName = roleName;
                            }
                            else
                            {
                                AppSession.RoleName = string.Empty;
                            }

                            // If role is DOCTOR, try to resolve DoctorID from DB
                            if (!string.IsNullOrEmpty(roleName) && string.Equals(roleName, "DOCTOR", StringComparison.OrdinalIgnoreCase))
                            {
                                int docId = dbhelper.getDoctorID(fullName);
                                if (docId > 0)
                                {
                                    AppSession.DoctorID = docId;
                                }
                                else
                                {
                                    AppSession.DoctorID = null;
                                }
                            }
                            else
                            {
                                AppSession.DoctorID = null;
                            }

                            return id;
                        }
                    }
                }
                catch (SqlException)
                {
                    // log if you have logging; return -1 to indicate failure
                    return -1;
                }
            }

            return -1;
        }

        /*public static string getrole()
        {
            if (AppSession.UserID > 0)
            {
                const string queryID = "SELECT Role FROM Users WHERE UserID = @id";
                using (SqlConnection conn = dbhelper.GetConnection())
                using (SqlCommand cmd = new SqlCommand(queryID, conn))
                {
                    cmd.Parameters.AddWithValue("@id", AppSession.UserID);
                    try
                    {
                        conn.Open();
                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            string role = Convert.ToString(result);
                            AppSession.RoleName = role ?? string.Empty;
                            return AppSession.RoleName;
                        }
                    }
                    catch (SqlException)
                    {
                        // ignore and try next fallback
                    }
                }
            }

            // Fallback: try by username
            if (!string.IsNullOrEmpty(AppSession.Username))
            {
                const string queryName = "SELECT Role FROM Users WHERE Username = @username";
                using (SqlConnection conn = dbhelper.GetConnection())
                using (SqlCommand cmd = new SqlCommand(queryName, conn))
                {
                    cmd.Parameters.AddWithValue("@username", AppSession.Username);
                    try
                    {
                        conn.Open();
                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            string role = Convert.ToString(result);
                            AppSession.RoleName = role ?? string.Empty;
                            return AppSession.RoleName;
                        }
                    }
                    catch (SqlException)
                    {
                        // ignore
                    }
                }
            }

            return string.Empty;
        }
        */
    }
}
