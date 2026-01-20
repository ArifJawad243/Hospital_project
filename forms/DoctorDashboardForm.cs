using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using WinFormsApp1;
using WinFormsApp1.utility;

namespace HospitalManagementSystem
{
    public partial class DoctorDashboardForm : Form
    {
        private DataTable dtAppointments = new DataTable();

        public DoctorDashboardForm()
        {
            InitializeComponent();
            LoadAppointments();
        }

        private void DoctorDashboardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AppSession.Logout();
        }

        /// <summary>
        /// Load appointments for the current doctor (AppSession.DoctorID) into a DataTable
        /// and bind it to the dgvAppointments DataGridView.
        /// </summary>
        private void LoadAppointments(string status = "All", string name = "")
        {
            dtAppointments.Clear();

            // Ensure we have a doctor context
            if (!AppSession.DoctorID.HasValue || AppSession.DoctorID.Value < 1)
            {
                // No doctor assigned in session -- clear grid and return
                dgvAppointments.DataSource = null;
                return;
            }

            using (SqlConnection conn = dbhelper.GetConnection())
            {
                // Select useful columns and alias them for the grid
                string query = @"
SELECT
    a.AppointmentID,
    a.AppointmentDate AS AppointmentTime,
    p.FullName AS PatientName,
    p.ContactNumber,
    p.DateOfBirth,
    p.Gender,
    u.FullName AS DoctorName,
    a.Status,
    a.Diagnosis
FROM Appointments a
JOIN Patients p ON a.PatientID = p.PatientID
JOIN Doctors d ON a.DoctorID = d.DoctorID
JOIN Users u ON d.UserID = u.UserID
WHERE a.DoctorID = @DoctorID";

                // Use a case-insensitive check so callers can pass "ALL", "All", "all" etc.
                bool includeStatus = !string.Equals(status, "All", StringComparison.OrdinalIgnoreCase);
                if (includeStatus)
                {
                    query += " AND a.Status = @Status";
                }

                if (!string.IsNullOrWhiteSpace(name))
                {
                    query += " AND p.FullName LIKE @Name";
                }
                query += " ORDER BY a.AppointmentDate DESC;";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@DoctorID", AppSession.DoctorID.Value);
                    if (includeStatus)
                        cmd.Parameters.AddWithValue("@Status", status);

                    if (!string.IsNullOrWhiteSpace(name))
                        cmd.Parameters.AddWithValue("@Name", "%" + name + "%");

                    try
                    {
                        conn.Open();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dtAppointments);
                            dgvAppointments.DataSource = dtAppointments;
                        }
                        // Ensure default selection for filter (optional)
                        if (cmbFilter.Items.Count > 0 && cmbFilter.SelectedIndex == -1)
                            cmbFilter.SelectedIndex = 0; // "All"
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Failed to load appointments: " + ex.Message, "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dgvAppointments.DataSource = null;
                    }
                }
            }
        }

        // Live-search handler: filters the bound DataTable by PatientName as user types in txtSearch
        private void txtSearch_TextChanged(object? sender, EventArgs e)
        {
            LoadAppointments(cmbFilter.Text, txtSearch.Text);
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAppointments(cmbFilter.Text, txtSearch.Text);
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            // Validate selection, status and diagnosis
            if (dgvAppointments.SelectedRows.Count == 0 || cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill out both appointment status and diagnosis.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int appointmentID = Convert.ToInt32(dgvAppointments.SelectedRows[0].Cells["AppointmentID"].Value);
            string newStatus = cmbStatus.Text;
            string diagnosis = txtDiagnosis.Text.Trim();

            using (SqlConnection conn = dbhelper.GetConnection())
            {
                string query = "UPDATE Appointments SET Status = @Status, Diagnosis = @Diagnosis WHERE AppointmentID = @AppointmentID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Status", newStatus);
                    cmd.Parameters.AddWithValue("@Diagnosis", diagnosis);
                    cmd.Parameters.AddWithValue("@AppointmentID", appointmentID);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Appointment status and diagnosis updated.");
                            LoadAppointments(cmbFilter.Text, txtSearch.Text);
                        }
                        else
                        {
                            MessageBox.Show("No appointment updated. Please check the selection.");
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Failed to update status and diagnosis: " + ex.Message, "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dgvAppointments_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowindex = e.RowIndex;
            cmbStatus.Text = dgvAppointments.Rows[rowindex].Cells["Status"].Value.ToString();
        }
    }
}
