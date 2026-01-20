using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1;
using WinFormsApp1.utility;

namespace HospitalApp.forms
{
    public partial class admin_dash : Form
    {
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
        public admin_dash()
        {
            InitializeComponent();
        }

        private void admin_dash_FormClosed(object sender, FormClosedEventArgs e)
        {
            AppSession.Logout();
        }
    }
}
