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
    public partial class reg_form : Form
    {
        mainform parent;
        public reg_form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void reg_form_Load(object sender, EventArgs e)
        {
            parent = this.ParentForm as mainform;
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            if (parent != null)
            {
                parent.loadform(new login_form());
            }
        }
    }
}
