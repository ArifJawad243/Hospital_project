using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.utility
{
    public static class AppSession
    {
        public static int UserID { get; set; }
        public static string Username { get; set; }
        public static string RoleName { get; set; }

        public static int? DoctorID { get; set; }

        public static void Logout()
        {
            UserID = 0;
            Username = string.Empty;
            RoleName = string.Empty;
            DoctorID = null;
        }
    }
}
