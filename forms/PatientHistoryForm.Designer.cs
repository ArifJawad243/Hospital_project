namespace HospitalManagementSystem
{
    partial class PatientHistoryForm
    {
        private System.ComponentModel.IContainer components = null;
        private Panel headerPanel;
        private Label lblTitle;
        private DataGridView dgvHistory;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            headerPanel = new Panel();
            lblTitle = new Label();
            dgvHistory = new DataGridView();

            headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            SuspendLayout();

            // Header Panel
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Height = 60;
            headerPanel.BackColor = Color.FromArgb(63, 81, 181);
            headerPanel.Controls.Add(lblTitle);

            // Title
            lblTitle.Text = "Patient Medical History";
            lblTitle.ForeColor = Color.White;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(20, 15);
            lblTitle.AutoSize = true;

            // DataGridView
            dgvHistory.Dock = DockStyle.Fill;
            dgvHistory.BackgroundColor = Color.FromArgb(30, 30, 30);
            dgvHistory.ForeColor = Color.White;
            dgvHistory.EnableHeadersVisualStyles = false;
            dgvHistory.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(18, 18, 18);
            dgvHistory.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvHistory.RowHeadersVisible = false;

            // Form
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(900, 400);
            Controls.Add(dgvHistory);
            Controls.Add(headerPanel);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Patient History";

            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            ResumeLayout(false);
        }
    }
}
