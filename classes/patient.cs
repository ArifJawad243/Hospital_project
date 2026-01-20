using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.utility;

namespace WinFormsApp1.classes
{
    internal class patient
    {
        public int patientID { get; set; }
        public string patientName { get; set; }
        public DateTime dateOfBirth { get; set; }
        public int contactNumber { get; set; }
        public string gender { get; set; }

        public bool SaveToDatabase()
        {
            string checkQuery = "SELECT COUNT(1) FROM Patients WHERE FullName = @pname AND DateOfBirth = @pdate AND ContactNumber = @pcontact";
            
            string insertQuery = "INSERT INTO Patients (FullName, ContactNumber, DateOfBirth, Gender) OUTPUT INSERTED.PatientID VALUES (@pname, @pcontact, @pdate, @pgender)";

            using (SqlConnection conn = dbhelper.GetConnection())
            {
                try
                {
                    conn.Open();

                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@pname", this.patientName);
                        checkCmd.Parameters.AddWithValue("@pcontact", this.contactNumber);
                        checkCmd.Parameters.AddWithValue("@pdate", this.dateOfBirth);

                        int existing = Convert.ToInt32(checkCmd.ExecuteScalar());
                        if (existing > 0)
                        {
                            return false;
                        }
                    }

                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@pname", this.patientName);
                        insertCmd.Parameters.AddWithValue("@pcontact", this.contactNumber);
                        insertCmd.Parameters.AddWithValue("@pdate", this.dateOfBirth);
                        insertCmd.Parameters.AddWithValue("@pgender", this.gender);

                        object result = insertCmd.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int newId))
                        {
                            this.patientID = newId;
                            return true;
                        }
                        return false;
                    }
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

    }
}
