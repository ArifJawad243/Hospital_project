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
        
    }
}
