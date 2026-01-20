namespace HospitalManagementSystem
{
    partial class PatientHistoryForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.PictureBox picHistory;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvHistory;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.headerPanel = new System.Windows.Forms.Panel();
            this.picHistory = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvHistory = new System.Windows.Forms.DataGridView();

            // Header
            this.headerPanel.BackColor = Color.FromArgb(120, 80, 180);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Height = 60;

            // History icon (loaded at runtime)
            this.picHistory.Size = new System.Drawing.Size(40, 40);
            this.picHistory.Location = new System.Drawing.Point(20, 10);
            this.picHistory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            // Title
            this.lblTitle.Text = "Patient Medical History";
            this.lblTitle.ForeColor = Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(75, 15);

            this.headerPanel.Controls.Add(this.picHistory);
            this.headerPanel.Controls.Add(this.lblTitle);

            // DataGridView
            this.dgvHistory.Location = new System.Drawing.Point(20, 80);
            this.dgvHistory.Size = new System.Drawing.Size(620, 260);
            this.dgvHistory.ReadOnly = true;

            // Form
            this.ClientSize = new System.Drawing.Size(660, 370);
            this.BackColor = Color.FromArgb(245, 247, 250);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.dgvHistory);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Patient History";
        }
    }
}
