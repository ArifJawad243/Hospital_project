using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class PatientHistoryForm : Form
    {
        int patientId;

        string connectionString =
            @"Data Source=.\SQLEXPRESS;Initial Catalog=HospitalDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public PatientHistoryForm(int patientId)
        {
            InitializeComponent();
            this.patientId = patientId;
            LoadHistory();
        }

        private void LoadHistory()
        {
            using SqlConnection con = new SqlConnection(connectionString);

            string query = @"
                SELECT Diagnosis, Treatment, RecordDate
                FROM MedicalHistory
                WHERE PatientId=@Id";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Id", patientId);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvHistory.DataSource = dt;
        }
    }
}
