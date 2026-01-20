namespace HospitalApp.forms
{
    partial class admin_users
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvusers = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvusers).BeginInit();
            SuspendLayout();
            // 
            // dgvusers
            // 
            dgvusers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvusers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dgvusers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvusers.Location = new Point(382, 170);
            dgvusers.Name = "dgvusers";
            dgvusers.Size = new Size(905, 402);
            dgvusers.TabIndex = 0;
            // 
            // admin_users
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1299, 584);
            Controls.Add(dgvusers);
            FormBorderStyle = FormBorderStyle.None;
            Name = "admin_users";
            Text = "admin_users";
            Load += admin_users_Load;
            ((System.ComponentModel.ISupportInitialize)dgvusers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvusers;
    }
}