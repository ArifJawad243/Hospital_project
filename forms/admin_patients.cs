using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.utility;

namespace HospitalApp.forms
{
    public partial class admin_patients : Form
    {
        public admin_patients()
        {
            InitializeComponent();
        }

        private void admin_patients_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = dbhelper.GetConnection())
            {
                string query = "SELECT a.AppointmentID, p.PatientID, CAST(a.AppointmentDate AS DATE) AS AppointmentTime, p.FullName AS PatientName, p.ContactNumber, p.DateOfBirth, p.Gender, u.FullName AS DoctorName, a.Status FROM Appointments a JOIN patients p ON a.patientid = p.patientid JOIN Doctors d ON a.DoctorID = d.DoctorID JOIN Users u ON d.UserID = u.UserID ORDER BY a.AppointmentDate DESC;";

                conn.Open();
                SqlDataAdapter adpt = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                dgv_patients.DataSource = dt;
            }
        }
    }
}
