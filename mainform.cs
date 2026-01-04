namespace WinFormsApp1
{
    public partial class mainform : Form
    {
        public mainform()
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



        private void title_Click(object sender, EventArgs e)
        {

        }

        

        private void mainform_Load(object sender, EventArgs e)
        {
            loadform(new login_form());
        }
    }
}
