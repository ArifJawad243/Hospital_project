using System;
using System.Windows.Forms;
using System;
using System.Windows.Forms;
using HospitalManagementSystem;

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

            Application.Run(new AppContext());
        }
    }
}