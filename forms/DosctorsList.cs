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
using WinFormsApp1.utility;

namespace WinFormsApp1
{
    public partial class DoctorsList : Form
    {
        public DoctorsList()
        {
            InitializeComponent();
        }

        private void DoctorsList_Load(object sender, EventArgs e)
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
