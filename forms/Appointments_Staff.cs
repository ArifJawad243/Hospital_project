using HospitalApp.classes;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.classes;
using WinFormsApp1.utility;

namespace WinFormsApp1
{
    public partial class Appointments_Staff : Form
    {
        DataTable dt = new DataTable();
        public Appointments_Staff()
        {
            InitializeComponent();
        }

        private void Appointments_Doc_Load(object sender, EventArgs e)
        {
            LoadAppointments();
        }

        private void LoadAppointments()
        {
            dt.Clear();
            using (SqlConnection conn = dbhelper.GetConnection())
            {
                string query = "SELECT CAST(a.AppointmentDate AS DATE) AS AppointmentTime, p.FullName AS PatientName, p.ContactNumber, DATEDIFF(YEAR, p.DateOfBirth, GETDATE()) AS Age, p.Gender, u.FullName AS DoctorName, a.Status FROM Appointments a JOIN patients p ON a.patientid = p.patientid JOIN Doctors d ON a.DoctorID = d.DoctorID JOIN Users u ON d.UserID = u.UserID ORDER BY a.AppointmentDate DESC;";
                conn.Open();
                SqlDataAdapter adpt = new SqlDataAdapter(query, conn);
                adpt.Fill(dt);
                dgv_appointments.DataSource = dt;
            }
        }

        private void dgv_appointments_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowindex = e.RowIndex;
            txtboxName.Text = dgv_appointments.Rows[rowindex].Cells["PatientName"].Value.ToString();
            txtboxContact.Text = dgv_appointments.Rows[rowindex].Cells["ContactNumber"].Value.ToString();
            dtbDOB.Text = dgv_appointments.Rows[rowindex].Cells["DateOfBirth"].Value.ToString();
            cmbGender.Text = dgv_appointments.Rows[rowindex].Cells["Gender"].Value.ToString();
            txtboxDoctor.Text = dgv_appointments.Rows[rowindex].Cells["DoctorName"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            patient p = new patient();
            DialogResult result = MessageBox.Show("Are you sure you want to create this appointment?", "Confirm Appointment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                p.patientName = txtboxName.Text;
                p.contactNumber = int.Parse(txtboxContact.Text);
                p.dateOfBirth = DateTime.Parse(dtbDOB.Text);
                p.gender = cmbGender.Text;

                if (!p.SaveToDatabase())
                {
                    MessageBox.Show("Failed to save patient information.");
                    p = null;
                    return;
                }
                appointment a = new appointment();
                a.patientID = p.patientID;
                int docId = dbhelper.getDoctorID(txtboxDoctor.Text);
                if (docId < 1)
                {
                    MessageBox.Show("Invalid Doctor Name.");
                    return;
                }
                a.doctorID = docId;
                a.staffID = AppSession.UserID;
                if (!a.SaveToDatabase())
                {
                    MessageBox.Show("Failed to save patient information.");
                    a = null;
                    return;
                }
                else
                {
                    MessageBox.Show("Appointment created successfully.");
                    LoadAppointments();
                    p = null;
                    a = null;
                }

            }
            else
            {
                return;
            }
        }
    }
}
