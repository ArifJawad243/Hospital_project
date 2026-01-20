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
    public partial class login_form : Form
    {
        public login_form()
        {
            InitializeComponent();
        }

        private void login_confirm_button_Click(object sender, EventArgs e)
        {
            AppSession.UserID = 5;
            Program.NextAction = "DASHBOARD";
            this.Close();
        }

        private void login_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Program.NextAction != "DASHBOARD")
            {
                Program.NextAction = "EXIT";
            }
        }
    }
}
