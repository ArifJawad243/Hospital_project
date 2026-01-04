namespace WinFormsApp1
{
    partial class reg_form
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
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label6 = new Label();
            textBox5 = new TextBox();
            reg_confirm_button = new Button();
            back_button = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F);
            label1.Location = new Point(435, 78);
            label1.Name = "label1";
            label1.Size = new Size(346, 46);
            label1.TabIndex = 0;
            label1.Text = "REGISTRATION FORM";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(445, 259);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 8;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(442, 195);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 7;
            label2.Text = "Name";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Location = new Point(503, 256);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(278, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.BackColor = SystemColors.Window;
            textBox1.Location = new Point(503, 192);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(278, 23);
            textBox1.TabIndex = 5;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(429, 389);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 12;
            label4.Text = "Pasword";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(440, 325);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 11;
            label5.Text = "Phone";
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.Location = new Point(503, 386);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(278, 23);
            textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.None;
            textBox4.BackColor = SystemColors.Window;
            textBox4.Location = new Point(503, 322);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(278, 23);
            textBox4.TabIndex = 9;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(382, 456);
            label6.Name = "label6";
            label6.Size = new Size(99, 15);
            label6.TabIndex = 14;
            label6.Text = "Confirm Pasword";
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.None;
            textBox5.Location = new Point(503, 453);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(278, 23);
            textBox5.TabIndex = 13;
            // 
            // reg_confirm_button
            // 
            reg_confirm_button.Anchor = AnchorStyles.None;
            reg_confirm_button.Location = new Point(706, 539);
            reg_confirm_button.Name = "reg_confirm_button";
            reg_confirm_button.Size = new Size(75, 23);
            reg_confirm_button.TabIndex = 15;
            reg_confirm_button.Text = "Confirm";
            reg_confirm_button.UseVisualStyleBackColor = true;
            // 
            // back_button
            // 
            back_button.Anchor = AnchorStyles.None;
            back_button.Location = new Point(445, 539);
            back_button.Name = "back_button";
            back_button.Size = new Size(75, 23);
            back_button.TabIndex = 16;
            back_button.Text = "Go Back";
            back_button.UseVisualStyleBackColor = true;
            back_button.Click += back_button_Click;
            // 
            // reg_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1202, 615);
            Controls.Add(back_button);
            Controls.Add(reg_confirm_button);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "reg_form";
            Text = "Form3";
            Load += reg_form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label5;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label6;
        private TextBox textBox5;
        private Button reg_confirm_button;
        private Button back_button;
    }
}