using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.utility
{
    public static class AppSession
    {
        public static int UserID { get; set; }
        public static string Username { get; set; }
        public static string RoleName { get; set; }

        public static int? DoctorID { get; set; }

        public static void Logout()
        {
            UserID = 0;
            Username = string.Empty;
            RoleName = string.Empty;
            DoctorID = null;
        }

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
    }
}
