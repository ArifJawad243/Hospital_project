using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class login_form : Form
    {
        mainform parent;
        public login_form()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            parent = this.ParentForm as mainform;
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            if (parent != null)
            {
                parent.loadform(new reg_form());
            }
        }

        private void login_confirm_button_Click(object sender, EventArgs e)
        {
            parent.loadform(new Dashboard());
        }
    }
}
