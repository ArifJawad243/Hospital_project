namespace HospitalManagementSystem
{
    partial class DoctorDashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.PictureBox picDoctor;
        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbFilter;

        private System.Windows.Forms.DataGridView dgvAppointments;

        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnUpdateStatus;
        private System.Windows.Forms.Button btnViewHistory;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            headerPanel = new Panel();
            picDoctor = new PictureBox();
            lblTitle = new Label();
            lblSearch = new Label();
            txtSearch = new TextBox();
            cmbFilter = new ComboBox();
            dgvAppointments = new DataGridView();
            cmbStatus = new ComboBox();
            btnUpdateStatus = new Button();
            btnViewHistory = new Button();
            headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picDoctor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).BeginInit();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.Controls.Add(picDoctor);
            headerPanel.Controls.Add(lblTitle);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(900, 70);
            headerPanel.TabIndex = 0;
            headerPanel.Paint += headerPanel_Paint;
            // 
            // picDoctor
            // 
            picDoctor.Location = new Point(20, 10);
            picDoctor.Name = "picDoctor";
            picDoctor.Size = new Size(48, 48);
            picDoctor.SizeMode = PictureBoxSizeMode.StretchImage;
            picDoctor.TabIndex = 0;
            picDoctor.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(80, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(247, 40);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Doctor Dashboard";
            // 
            // lblSearch
            // 
            lblSearch.Location = new Point(25, 85);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(100, 23);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Search Patient:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(140, 82);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(200, 23);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // cmbFilter
            // 
            cmbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilter.Items.AddRange(new object[] { "All", "Upcoming", "Finished", "Cancelled" });
            cmbFilter.Location = new Point(360, 82);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(121, 23);
            cmbFilter.TabIndex = 3;
            cmbFilter.SelectedIndexChanged += cmbFilter_SelectedIndexChanged;
            // 
            // dgvAppointments
            // 
            dgvAppointments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAppointments.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvAppointments.Location = new Point(25, 120);
            dgvAppointments.Name = "dgvAppointments";
            dgvAppointments.ReadOnly = true;
            dgvAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAppointments.Size = new Size(830, 260);
            dgvAppointments.TabIndex = 4;
            dgvAppointments.DataBindingComplete += dgvAppointments_DataBindingComplete;
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Items.AddRange(new object[] { "Upcoming", "Finished", "Cancelled" });
            cmbStatus.Location = new Point(25, 400);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(121, 23);
            cmbStatus.TabIndex = 5;
            // 
            // btnUpdateStatus
            // 
            btnUpdateStatus.BackColor = Color.FromArgb(60, 100, 220);
            btnUpdateStatus.FlatStyle = FlatStyle.Flat;
            btnUpdateStatus.ForeColor = Color.White;
            btnUpdateStatus.Location = new Point(200, 392);
            btnUpdateStatus.Name = "btnUpdateStatus";
            btnUpdateStatus.Size = new Size(101, 26);
            btnUpdateStatus.TabIndex = 6;
            btnUpdateStatus.Text = "Update Status";
            btnUpdateStatus.UseVisualStyleBackColor = false;
            btnUpdateStatus.Click += btnUpdateStatus_Click;
            btnUpdateStatus.MouseEnter += ButtonHover;
            btnUpdateStatus.MouseLeave += ButtonLeave;
            // 
            // btnViewHistory
            // 
            btnViewHistory.BackColor = Color.FromArgb(60, 100, 220);
            btnViewHistory.FlatStyle = FlatStyle.Flat;
            btnViewHistory.ForeColor = Color.White;
            btnViewHistory.Location = new Point(307, 392);
            btnViewHistory.Name = "btnViewHistory";
            btnViewHistory.Size = new Size(90, 28);
            btnViewHistory.TabIndex = 7;
            btnViewHistory.Text = " View History";
            btnViewHistory.TextImageRelation = TextImageRelation.TextAboveImage;
            btnViewHistory.UseVisualStyleBackColor = false;
            btnViewHistory.Click += btnViewHistory_Click;
            btnViewHistory.MouseEnter += ButtonHover;
            btnViewHistory.MouseLeave += ButtonLeave;
            // 
            // DoctorDashboardForm
            // 
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(900, 470);
            Controls.Add(headerPanel);
            Controls.Add(lblSearch);
            Controls.Add(txtSearch);
            Controls.Add(cmbFilter);
            Controls.Add(dgvAppointments);
            Controls.Add(cmbStatus);
            Controls.Add(btnUpdateStatus);
            Controls.Add(btnViewHistory);
            Name = "DoctorDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Doctor Dashboard";
            headerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picDoctor).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
