namespace WinFormsApp1
{
    partial class login_form
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            back_button = new Button();
            label4 = new Label();
            login_confirm_button = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F);
            label1.Location = new Point(419, 83);
            label1.Name = "label1";
            label1.Size = new Size(196, 41);
            label1.TabIndex = 0;
            label1.Text = "LOGIN FORM";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.BackColor = SystemColors.Window;
            textBox1.Location = new Point(397, 182);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(278, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Location = new Point(397, 246);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(278, 23);
            textBox2.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(334, 185);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 3;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(318, 249);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 4;
            label3.Text = "Pasword";
            // 
            // back_button
            // 
            back_button.Anchor = AnchorStyles.None;
            back_button.Location = new Point(540, 405);
            back_button.Name = "back_button";
            back_button.Size = new Size(75, 23);
            back_button.TabIndex = 5;
            back_button.Text = "Register";
            back_button.UseVisualStyleBackColor = true;
            back_button.Click += back_button_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(403, 409);
            label4.Name = "label4";
            label4.Size = new Size(131, 15);
            label4.TabIndex = 6;
            label4.Text = "Don't have an account?";
            // 
            // login_confirm_button
            // 
            login_confirm_button.Anchor = AnchorStyles.None;
            login_confirm_button.Location = new Point(487, 306);
            login_confirm_button.Name = "login_confirm_button";
            login_confirm_button.Size = new Size(75, 23);
            login_confirm_button.TabIndex = 7;
            login_confirm_button.Text = "Login";
            login_confirm_button.UseVisualStyleBackColor = true;
            login_confirm_button.Click += login_confirm_button_Click;
            // 
            // login_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 539);
            Controls.Add(login_confirm_button);
            Controls.Add(label4);
            Controls.Add(back_button);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "login_form";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private Button back_button;
        private Label label4;
        private Button login_confirm_button;
    }
}