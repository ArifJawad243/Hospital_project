namespace HospitalManagementSystem
{
    partial class DoctorDashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel headerPanel;
        private PictureBox picDoctor;
        private Label lblTitle;

        private Label lblSearch;
        private TextBox txtSearch;
        private ComboBox cmbFilter;

        private DataGridView dgvAppointments;

        private ComboBox cmbStatus;
        private Button btnUpdateStatus;

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
            mainpanel = new Panel();
            txtDiagnosis = new TextBox();
            label1 = new Label();
            label2 = new Label();
            headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picDoctor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).BeginInit();
            mainpanel.SuspendLayout();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.Anchor = AnchorStyles.None;
            headerPanel.Controls.Add(picDoctor);
            headerPanel.Controls.Add(lblTitle);
            headerPanel.Location = new Point(285, 82);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(900, 70);
            headerPanel.TabIndex = 0;
            // 
            // picDoctor
            // 
            picDoctor.Anchor = AnchorStyles.None;
            picDoctor.BackColor = Color.Transparent;
            picDoctor.Location = new Point(20, 10);
            picDoctor.Name = "picDoctor";
            picDoctor.Size = new Size(48, 48);
            picDoctor.SizeMode = PictureBoxSizeMode.StretchImage;
            picDoctor.TabIndex = 0;
            picDoctor.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(80, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(300, 40);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Doctor Dashboard";
            // 
            // lblSearch
            // 
            lblSearch.Anchor = AnchorStyles.None;
            lblSearch.ForeColor = Color.White;
            lblSearch.Location = new Point(305, 270);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(100, 23);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Search Patient:";
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.None;
            txtSearch.Location = new Point(411, 267);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(200, 23);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // cmbFilter
            // 
            cmbFilter.Anchor = AnchorStyles.None;
            cmbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilter.Items.AddRange(new object[] { "ALL", "PENDING", "FINISHED", "CANCELLED" });
            cmbFilter.Location = new Point(735, 267);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(121, 23);
            cmbFilter.TabIndex = 3;
            cmbFilter.SelectedIndexChanged += cmbFilter_SelectedIndexChanged;
            // 
            // dgvAppointments
            // 
            dgvAppointments.Anchor = AnchorStyles.None;
            dgvAppointments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAppointments.Location = new Point(305, 315);
            dgvAppointments.Name = "dgvAppointments";
            dgvAppointments.ReadOnly = true;
            dgvAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAppointments.Size = new Size(830, 260);
            dgvAppointments.TabIndex = 4;
            dgvAppointments.RowHeaderMouseClick += dgvAppointments_RowHeaderMouseClick;
            // 
            // cmbStatus
            // 
            cmbStatus.Anchor = AnchorStyles.None;
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Items.AddRange(new object[] { "PENDING", "FINISHED", "CANCELLED" });
            cmbStatus.Location = new Point(275, 625);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(162, 23);
            cmbStatus.TabIndex = 5;
            // 
            // btnUpdateStatus
            // 
            btnUpdateStatus.Anchor = AnchorStyles.None;
            btnUpdateStatus.BackColor = Color.FromArgb(63, 81, 181);
            btnUpdateStatus.FlatStyle = FlatStyle.Flat;
            btnUpdateStatus.ForeColor = Color.White;
            btnUpdateStatus.Location = new Point(742, 623);
            btnUpdateStatus.Name = "btnUpdateStatus";
            btnUpdateStatus.Size = new Size(75, 25);
            btnUpdateStatus.TabIndex = 6;
            btnUpdateStatus.Text = "Update Status";
            btnUpdateStatus.UseVisualStyleBackColor = false;
            btnUpdateStatus.Click += btnUpdateStatus_Click;
            // 
            // mainpanel
            // 
            mainpanel.Anchor = AnchorStyles.None;
            mainpanel.Controls.Add(txtSearch);
            mainpanel.Controls.Add(lblSearch);
            mainpanel.Controls.Add(headerPanel);
            mainpanel.Controls.Add(txtDiagnosis);
            mainpanel.Controls.Add(cmbFilter);
            mainpanel.Controls.Add(label1);
            mainpanel.Controls.Add(label2);
            mainpanel.Controls.Add(btnUpdateStatus);
            mainpanel.Controls.Add(cmbStatus);
            mainpanel.Controls.Add(dgvAppointments);
            mainpanel.Location = new Point(0, 0);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(1481, 778);
            mainpanel.TabIndex = 8;
            // 
            // txtDiagnosis
            // 
            txtDiagnosis.Anchor = AnchorStyles.None;
            txtDiagnosis.Location = new Point(469, 625);
            txtDiagnosis.Name = "txtDiagnosis";
            txtDiagnosis.Size = new Size(214, 23);
            txtDiagnosis.TabIndex = 8;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(275, 592);
            label1.Name = "label1";
            label1.Size = new Size(162, 24);
            label1.TabIndex = 2;
            label1.Text = "Appointment Status";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(469, 592);
            label2.Name = "label2";
            label2.Size = new Size(162, 24);
            label2.TabIndex = 7;
            label2.Text = "Diagnosis";
            // 
            // DoctorDashboardForm
            // 
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(1481, 778);
            Controls.Add(mainpanel);
            Name = "DoctorDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Doctor Dashboard";
            FormClosed += DoctorDashboardForm_FormClosed;
            headerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picDoctor).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).EndInit();
            mainpanel.ResumeLayout(false);
            mainpanel.PerformLayout();
            ResumeLayout(false);
        }

        private Panel mainpanel;
        private Label label1;
        private TextBox txtDiagnosis;
        private Label label2;
    }
}