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
    public partial class admin_doctors : Form
    {
        public admin_doctors()
        {
            InitializeComponent();
        }

        private void admin_doctors_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = dbhelper.GetConnection())
            {
                string query = "select d.DoctorID, u.FullName as DoctorName, u.Email, d.Department, d.Qualifications from Doctors d join Users u on d.UserID = u.UserID;";
                conn.Open();
                SqlDataAdapter adpt = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                dgv_doctorlist.DataSource = dt;
            }
        }
    }
}
