namespace HospitalApp.forms
{
    partial class admin_dash
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
            panel1 = new Panel();
            button3 = new Button();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            lblTitle = new Label();
            mainpanel = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 100);
            panel1.Name = "panel1";
            panel1.Size = new Size(205, 623);
            panel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.BackColor = Color.Navy;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 12F);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(11, 324);
            button3.Name = "button3";
            button3.Size = new Size(182, 55);
            button3.TabIndex = 5;
            button3.Text = "Users";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.BackColor = Color.Navy;
            button4.BackgroundImageLayout = ImageLayout.None;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Microsoft Sans Serif", 12F);
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.Location = new Point(11, 243);
            button4.Name = "button4";
            button4.Size = new Size(182, 55);
            button4.TabIndex = 4;
            button4.Text = "Patients";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.Navy;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 12F);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(12, 162);
            button2.Name = "button2";
            button2.Size = new Size(182, 55);
            button2.TabIndex = 3;
            button2.Text = "Doctors";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.Navy;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 12F);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(12, 81);
            button1.Name = "button1";
            button1.Size = new Size(182, 55);
            button1.TabIndex = 2;
            button1.Text = "Appointments";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Controls.Add(lblTitle);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1520, 100);
            panel2.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(193, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(246, 40);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Admin Dashboard";
            // 
            // mainpanel
            // 
            mainpanel.BackColor = SystemColors.Control;
            mainpanel.Dock = DockStyle.Fill;
            mainpanel.Location = new Point(205, 100);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(1315, 623);
            mainpanel.TabIndex = 2;
            // 
            // admin_dash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1520, 723);
            Controls.Add(mainpanel);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "admin_dash";
            Text = "admin_dash";
            FormClosed += admin_dash_FormClosed;
            Load += admin_dash_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel mainpanel;
        private Label lblTitle;
        private Button button3;
        private Button button4;
        private Button button2;
        private Button button1;
    }
}