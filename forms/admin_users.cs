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
    public partial class admin_users : Form
    {
        public admin_users()
        {
            InitializeComponent();
        }

        private void admin_users_Load(object sender, EventArgs e)
        {
            try { 
            using (SqlConnection conn = dbhelper.GetConnection())
            {
                string query = "select u.UserID, u.Username, u.FullName, u.Email, u.Role from Users u;";
                conn.Open();
                SqlDataAdapter adpt = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                dgvusers.DataSource = dt;
            }
            }
            catch (SqlException ex)
            { 
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
