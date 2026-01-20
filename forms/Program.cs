namespace WinFormsApp1
{
    internal static class Program
    {
        public static string NextAction = "LOGIN";
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // This loop keeps the app running until we explicitly set NextAction to "EXIT"
            while (NextAction != "EXIT")
            {
                if (NextAction == "LOGIN")
                {
                    login_form a = new login_form();
                    Application.Run(a);
                }
                else if (NextAction == "DASHBOARD")
                {
                    staff_dashboard dash = new staff_dashboard();
                    Application.Run(dash);
                }
                else
                {
                    break;
                }
            }
        }
    }
}