namespace WinFormsApp1
{
    partial class mainform
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mainpanel = new Panel();
            panel2 = new Panel();
            title = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // mainpanel
            // 
            mainpanel.BackColor = SystemColors.ControlDarkDark;
            mainpanel.Dock = DockStyle.Bottom;
            mainpanel.Location = new Point(0, 75);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(1170, 568);
            mainpanel.TabIndex = 0;
            mainpanel.Paint += mainpanel_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(title);
            panel2.Dock = DockStyle.Top;
            panel2.ForeColor = Color.Black;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1170, 76);
            panel2.TabIndex = 3;
            // 
            // title
            // 
            title.Anchor = AnchorStyles.None;
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 25F);
            title.ForeColor = SystemColors.Highlight;
            title.Location = new Point(537, 9);
            title.Name = "title";
            title.Size = new Size(98, 46);
            title.TabIndex = 0;
            title.Text = "TITLE";
            title.Click += title_Click;
            // 
            // mainform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1170, 643);
            Controls.Add(panel2);
            Controls.Add(mainpanel);
            Name = "mainform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosing += mainform_FormClosing;
            Load += mainform_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainpanel;
        private Panel panel2;
        private Label title;
    }
}
