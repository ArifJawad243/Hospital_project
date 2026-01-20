namespace HospitalApp.forms
{
    partial class admin_patients
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
            dgv_patients = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_patients).BeginInit();
            SuspendLayout();
            // 
            // dgv_patients
            // 
            dgv_patients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_patients.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dgv_patients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_patients.Location = new Point(258, 182);
            dgv_patients.Name = "dgv_patients";
            dgv_patients.Size = new Size(1029, 390);
            dgv_patients.TabIndex = 0;
            // 
            // admin_patients
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1299, 584);
            Controls.Add(dgv_patients);
            FormBorderStyle = FormBorderStyle.None;
            Name = "admin_patients";
            Text = "admin_patients";
            Load += admin_patients_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_patients).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_patients;
    }
}