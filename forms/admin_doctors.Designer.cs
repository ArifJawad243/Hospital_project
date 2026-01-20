namespace HospitalApp.forms
{
    partial class admin_doctors
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
            dgv_doctorlist = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_doctorlist).BeginInit();
            SuspendLayout();
            // 
            // dgv_doctorlist
            // 
            dgv_doctorlist.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_doctorlist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_doctorlist.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dgv_doctorlist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_doctorlist.Location = new Point(329, 175);
            dgv_doctorlist.Name = "dgv_doctorlist";
            dgv_doctorlist.Size = new Size(866, 346);
            dgv_doctorlist.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(673, 116);
            label1.Name = "label1";
            label1.Size = new Size(156, 37);
            label1.TabIndex = 2;
            label1.Text = "Doctors List";
            // 
            // admin_doctors
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1299, 584);
            Controls.Add(dgv_doctorlist);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "admin_doctors";
            Text = "admin_doctors";
            Load += admin_doctors_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_doctorlist).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_doctorlist;
        private Label label1;
    }
}