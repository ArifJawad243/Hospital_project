using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.utility;

namespace WinFormsApp1
{
    public partial class staff_dashboard : Form
    {
        public staff_dashboard()
        {
            InitializeComponent();
        }
        public void loadform(object form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.Clear();
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }
        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.NextAction = "EXIT";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            loadform(new DoctorsList());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            loadform(new Appointments_Staff());
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            loadform(new Appointments_Staff());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Program.NextAction = "LOGIN";
            this.Close();
            AppSession.Logout();
        }
    }
}
