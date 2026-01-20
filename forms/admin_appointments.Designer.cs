namespace HospitalApp.forms
{
    partial class admin_appointments
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
            button2 = new Button();
            label7 = new Label();
            txtboxpid = new TextBox();
            textBox2 = new TextBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_appointments).BeginInit();
            SuspendLayout();
            // 
            // dgv_appointments
            // 
            dgv_appointments.Anchor = AnchorStyles.Right;
            dgv_appointments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_appointments.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_appointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_appointments.Location = new Point(424, 169);
            dgv_appointments.Name = "dgv_appointments";
            dgv_appointments.Size = new Size(879, 341);
            dgv_appointments.TabIndex = 0;
            dgv_appointments.RowHeaderMouseClick += dgv_appointments_RowHeaderMouseClick;
            // 
            // txtboxName
            // 
            txtboxName.Anchor = AnchorStyles.None;
            txtboxName.Location = new Point(153, 205);
            txtboxName.Name = "txtboxName";
            txtboxName.Size = new Size(181, 23);
            txtboxName.TabIndex = 1;
            // 
            // txtboxContact
            // 
            txtboxContact.Anchor = AnchorStyles.None;
            txtboxContact.Location = new Point(153, 254);
            txtboxContact.Name = "txtboxContact";
            txtboxContact.Size = new Size(181, 23);
            txtboxContact.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(68, 208);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 3;
            label1.Text = "Patient Name";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(774, 125);
            label2.Name = "label2";
            label2.Size = new Size(137, 28);
            label2.TabIndex = 4;
            label2.Text = "Appointments";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(68, 257);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 5;
            label3.Text = "Contact No.";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(68, 357);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 9;
            label4.Text = "Gender";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(68, 308);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 8;
            label5.Text = "Date of Birth";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(70, 407);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 11;
            label6.Text = "Doctor";
            // 
            // txtboxDoctor
            // 
            txtboxDoctor.Anchor = AnchorStyles.None;
            txtboxDoctor.Location = new Point(153, 404);
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
            button1.Location = new Point(261, 469);
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
            dtbDOB.Location = new Point(153, 302);
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
            cmbGender.Location = new Point(153, 354);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(181, 23);
            cmbGender.TabIndex = 13;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.Red;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(87, 469);
            button2.Name = "button2";
            button2.Size = new Size(119, 41);
            button2.TabIndex = 15;
            button2.Text = "Delete Appointment";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Location = new Point(83, 151);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 16;
            label7.Text = "Patient ID";
            // 
            // txtboxpid
            // 
            txtboxpid.Anchor = AnchorStyles.None;
            txtboxpid.Location = new Point(153, 148);
            txtboxpid.Name = "txtboxpid";
            txtboxpid.Size = new Size(37, 23);
            txtboxpid.TabIndex = 17;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Location = new Point(296, 148);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(37, 23);
            textBox2.TabIndex = 19;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Location = new Point(196, 151);
            label8.Name = "label8";
            label8.Size = new Size(92, 15);
            label8.TabIndex = 18;
            label8.Text = "Appointment ID";
            // 
            // admin_appointments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1315, 623);
            Controls.Add(textBox2);
            Controls.Add(label8);
            Controls.Add(txtboxpid);
            Controls.Add(label7);
            Controls.Add(button2);
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
            Name = "admin_appointments";
            Text = "Form1";
            Load += Appointments_Doc_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_appointments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtbDOB;
        private ComboBox cmbGender;
        private Button button1;
        private Label label6;
        private TextBox txtboxDoctor;
        private Label label4;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtboxContact;
        private TextBox txtboxName;
        private DataGridView dgv_appointments;
        private Button button2;
        private Label label7;
        private TextBox txtboxpid;
        private TextBox textBox2;
        private Label label8;
    }
}