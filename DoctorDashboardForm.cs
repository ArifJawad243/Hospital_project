using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace HospitalManagementSystem
{
    public partial class DoctorDashboardForm : Form
    {
        int loggedInDoctorId = 1;

        string connectionString =
            @"Data Source=.\SQLEXPRESS;Initial Catalog=HospitalDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public DoctorDashboardForm()
        {
            InitializeComponent();

            LoadIcons();
            LoadAppointments();
        }

        private void LoadIcons()
        {
            try
            {
                string imgPath = Path.Combine(Application.StartupPath, "Images");

                picDoctor.Image = Image.FromFile(Path.Combine(imgPath, "doctor.png"));
                btnViewHistory.Image = Image.FromFile(Path.Combine(imgPath, "history.png"));
            }
            catch
            {
                // If images are missing, app still runs
            }
        }

        private void LoadAppointments(string status = "All", string name = "")
        {
            using SqlConnection con = new SqlConnection(connectionString);

            string query = @"
                SELECT 
                    A.AppointmentId,
                    P.PatientId,
                    P.Name AS PatientName,
                    A.AppointmentDate,
                    A.Status
                FROM Appointments A
                JOIN Patients P ON A.PatientId = P.PatientId
                WHERE A.DoctorId = @DoctorId";

            if (status != "All")
                query += " AND A.Status = @Status";

            if (!string.IsNullOrWhiteSpace(name))
                query += " AND P.Name LIKE @Name";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@DoctorId", loggedInDoctorId);

            if (status != "All")
                cmd.Parameters.AddWithValue("@Status", status);

            if (!string.IsNullOrWhiteSpace(name))
                cmd.Parameters.AddWithValue("@Name", "%" + name + "%");

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvAppointments.DataSource = dt;
        }

        private void dgvAppointments_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvAppointments.Rows)
            {
                if (row.Cells["Status"].Value == null) continue;

                string status = row.Cells["Status"].Value.ToString();

                if (status == "Cancelled")
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 215, 215);
                else if (status == "Finished")
                    row.DefaultCellStyle.BackColor = Color.FromArgb(215, 255, 215);
                else
                    row.DefaultCellStyle.BackColor = Color.FromArgb(235, 240, 255);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadAppointments(cmbFilter.Text, txtSearch.Text);
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAppointments(cmbFilter.Text, txtSearch.Text);
        }

        private void btnViewHistory_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an appointment.");
                return;
            }

            int patientId = Convert.ToInt32(
                dgvAppointments.SelectedRows[0].Cells["PatientId"].Value);

            new PatientHistoryForm(patientId).ShowDialog();
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.SelectedRows.Count == 0 || cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Select appointment and status.");
                return;
            }

            int appointmentId = Convert.ToInt32(
                dgvAppointments.SelectedRows[0].Cells["AppointmentId"].Value);

            using SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(
                "UPDATE Appointments SET Status=@Status WHERE AppointmentId=@Id", con);

            cmd.Parameters.AddWithValue("@Status", cmbStatus.Text);
            cmd.Parameters.AddWithValue("@Id", appointmentId);

            con.Open();
            cmd.ExecuteNonQuery();

            LoadAppointments(cmbFilter.Text, txtSearch.Text);
        }

        // Gradient Header
        private void headerPanel_Paint(object sender, PaintEventArgs e)
        {
            using LinearGradientBrush brush = new LinearGradientBrush(
                headerPanel.ClientRectangle,
                Color.FromArgb(50, 80, 200),
                Color.FromArgb(120, 90, 220),
                0f);

            e.Graphics.FillRectangle(brush, headerPanel.ClientRectangle);
        }

        // Button hover effects
        private void ButtonHover(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.FromArgb(80, 130, 255);
        }

        private void ButtonLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.FromArgb(60, 100, 220);
        }
    }
}
