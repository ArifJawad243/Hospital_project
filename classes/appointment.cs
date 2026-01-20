using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using WinFormsApp1.utility;

namespace HospitalApp.classes
{
    internal class appointment
    {
        public int appointmentID { get; set; }
        public int patientID { get; set; }
        public int doctorID { get; set; }
        public int staffID { get; set; }
        public DateTime date {  get; set; }
        public string? Status { get; set; }
        public string? Diagnosis { get; set; }

        public bool SaveToDatabase()
        {

            string query = "INSERT INTO Appointments (PatientID, DoctorID, ScheduledByStaffID, AppointmentDate) VALUES (@pid, @did, @sid, GETDATE())";

            using (SqlConnection conn = dbhelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@pid", this.patientID);
                cmd.Parameters.AddWithValue("@did", this.doctorID);
                cmd.Parameters.AddWithValue("@sid", this.staffID);

                try
                {
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }
    }
}
