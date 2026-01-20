using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.utility
{
    public static class dbhelper
    {
        private static string conn = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=hospitalapp;Integrated Security=True;Trust Server Certificate=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(conn);
        }

        public static int getDoctorID(string fullName)
        {
            using (SqlConnection conn = dbhelper.GetConnection())
            {
                // Ensure a single result is returned when multiple rows could match
                const string query = "SELECT TOP (1) d.DoctorID FROM Doctors d JOIN Users u ON d.UserID = u.UserID WHERE u.FullName = @FullName;";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FullName", fullName);

                    try
                    {
                        conn.Open();
                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            return Convert.ToInt32(result);
                        }
                    }
                    catch (SqlException)
                    {
                        return -1;
                    }
                }
            }
            return -1;
        }

    }
}
