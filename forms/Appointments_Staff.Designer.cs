namespace WinFormsApp1
{
    partial class Appointments_Staff
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
            dgv_appointments = new DataGridView();
            txtboxName = new TextBox();
            txtboxContact = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtboxDoctor = new TextBox();
            button1 = new Button();
            dtbDOB = new DateTimePicker();
            cmbGender = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgv_appointments).BeginInit();
            SuspendLayout();
            // 
            // dgv_appointments
            // 
            dgv_appointments.Anchor = AnchorStyles.Right;
            dgv_appointments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_appointments.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_appointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_appointments.Location = new Point(400, 144);
            dgv_appointments.Name = "dgv_appointments";
            dgv_appointments.Size = new Size(827, 341);
            dgv_appointments.TabIndex = 0;
            dgv_appointments.RowHeaderMouseClick += dgv_appointments_RowHeaderMouseClick;
            // 
            // txtboxName
            // 
            txtboxName.Anchor = AnchorStyles.None;
            txtboxName.Location = new Point(164, 141);
            txtboxName.Name = "txtboxName";
            txtboxName.Size = new Size(181, 23);
            txtboxName.TabIndex = 1;
            // 
            // txtboxContact
            // 
            txtboxContact.Anchor = AnchorStyles.None;
            txtboxContact.Location = new Point(164, 190);
            txtboxContact.Name = "txtboxContact";
            txtboxContact.Size = new Size(181, 23);
            txtboxContact.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(79, 144);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 3;
            label1.Text = "Patient Name";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(766, 126);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 4;
            label2.Text = "Appointments";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(79, 193);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 5;
            label3.Text = "Contact No.";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(79, 293);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 9;
            label4.Text = "Gender";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(79, 244);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 8;
            label5.Text = "Date of Birth";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(81, 343);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 11;
            label6.Text = "Doctor";
            // 
            // txtboxDoctor
            // 
            txtboxDoctor.Anchor = AnchorStyles.None;
            txtboxDoctor.Location = new Point(164, 340);
            txtboxDoctor.Name = "txtboxDoctor";
            txtboxDoctor.Size = new Size(181, 23);
            txtboxDoctor.TabIndex = 10;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.Lime;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(275, 444);
            button1.Name = "button1";
            button1.Size = new Size(119, 41);
            button1.TabIndex = 12;
            button1.Text = "Create Appointment";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dtbDOB
            // 
            dtbDOB.Anchor = AnchorStyles.None;
            dtbDOB.Format = DateTimePickerFormat.Short;
            dtbDOB.Location = new Point(164, 238);
            dtbDOB.Name = "dtbDOB";
            dtbDOB.Size = new Size(181, 23);
            dtbDOB.TabIndex = 14;
            dtbDOB.Value = new DateTime(2026, 1, 20, 0, 0, 0, 0);
            // 
            // cmbGender
            // 
            cmbGender.Anchor = AnchorStyles.None;
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(164, 290);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(181, 23);
            cmbGender.TabIndex = 13;
            // 
            // Appointments_Staff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1239, 572);
            Controls.Add(dtbDOB);
            Controls.Add(cmbGender);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(txtboxDoctor);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtboxContact);
            Controls.Add(txtboxName);
            Controls.Add(dgv_appointments);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Appointments_Staff";
            Text = "Form1";
            Load += Appointments_Doc_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_appointments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private DataGridView dgv_appointments;
        private TextBox txtboxName;
        private TextBox txtboxContact;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtboxDoctor;
        private Button button1;
        private DateTimePicker dtbDOB;
        private ComboBox cmbGender;
    }
}