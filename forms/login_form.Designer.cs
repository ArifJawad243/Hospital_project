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
            txtuname = new TextBox();
            txtpass = new TextBox();
            label2 = new Label();
            label3 = new Label();
            login_confirm_button = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F);
            label1.Location = new Point(390, 65);
            label1.Name = "label1";
            label1.Size = new Size(105, 41);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtuname
            // 
            txtuname.Anchor = AnchorStyles.None;
            txtuname.BackColor = SystemColors.Window;
            txtuname.Location = new Point(313, 138);
            txtuname.Name = "txtuname";
            txtuname.Size = new Size(278, 23);
            txtuname.TabIndex = 1;
            txtuname.KeyDown += txtuname_KeyDown;
            // 
            // txtpass
            // 
            txtpass.Anchor = AnchorStyles.None;
            txtpass.Location = new Point(313, 202);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(278, 23);
            txtpass.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(234, 141);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 3;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(234, 205);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 4;
            label3.Text = "Pasword";
            // 
            // login_confirm_button
            // 
            login_confirm_button.Anchor = AnchorStyles.None;
            login_confirm_button.Location = new Point(403, 262);
            login_confirm_button.Name = "login_confirm_button";
            login_confirm_button.Size = new Size(75, 23);
            login_confirm_button.TabIndex = 7;
            login_confirm_button.Text = "Login";
            login_confirm_button.UseVisualStyleBackColor = true;
            login_confirm_button.Click += login_confirm_button_Click;
            // 
            // login_form
            // 
            AcceptButton = login_confirm_button;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 450);
            Controls.Add(login_confirm_button);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtpass);
            Controls.Add(txtuname);
            Controls.Add(label1);
            Name = "login_form";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtuname;
        private TextBox txtpass;
        private Label label2;
        private Label label3;
        private Button login_confirm_button;
    }
}