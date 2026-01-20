
namespace WinFormsApp1
{
    partial class staff_dashboard
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
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            close_button = new Button();
            mainpanel = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 694);
            panel1.TabIndex = 0;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.BackColor = Color.Red;
            button4.BackgroundImageLayout = ImageLayout.None;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Microsoft Sans Serif", 12F);
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.Location = new Point(12, 539);
            button4.Name = "button4";
            button4.Size = new Size(182, 55);
            button4.TabIndex = 3;
            button4.Text = "Logout";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.DarkSlateGray;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 12F);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(12, 120);
            button2.Name = "button2";
            button2.Size = new Size(182, 55);
            button2.TabIndex = 1;
            button2.Text = "Doctors List";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.DarkSlateGray;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 12F);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(12, 39);
            button1.Name = "button1";
            button1.Size = new Size(182, 55);
            button1.TabIndex = 0;
            button1.Text = "Appointments";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGreen;
            panel2.Controls.Add(close_button);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1493, 44);
            panel2.TabIndex = 1;
            // 
            // close_button
            // 
            close_button.Anchor = AnchorStyles.None;
            close_button.BackColor = Color.Transparent;
            close_button.BackgroundImageLayout = ImageLayout.None;
            close_button.FlatAppearance.BorderSize = 0;
            close_button.FlatStyle = FlatStyle.Flat;
            close_button.ForeColor = SystemColors.ActiveCaptionText;
            close_button.Location = new Point(1450, 4);
            close_button.Name = "close_button";
            close_button.Size = new Size(40, 37);
            close_button.TabIndex = 3;
            close_button.Text = "X";
            close_button.UseVisualStyleBackColor = false;
            close_button.Click += close_button_Click;
            // 
            // mainpanel
            // 
            mainpanel.BackColor = Color.LightGray;
            mainpanel.Dock = DockStyle.Fill;
            mainpanel.Location = new Point(220, 44);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(1273, 694);
            mainpanel.TabIndex = 2;
            // 
            // staff_dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1493, 738);
            Controls.Add(mainpanel);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "staff_dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Homepage";
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }


        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel mainpanel;
        private Button button2;
        private Button button1;
        private Button close_button;
        private Button button4;
    }
}