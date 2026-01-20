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
            string username = txtuname.Text;
            string password = txtpass.Text;
            if (AppSession.Login(username, password) > 0)
            {
                this.Close();
            }
            else
            {
                // Failed login
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            this.Close();
        }

        private void txtuname_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
