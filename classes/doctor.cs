using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.utility;

namespace WinFormsApp1.classes
{
    internal class doctor
    {
        public int doctorID { get; set; }
        public int userID { get; set; }
        public string qualifications { get; set; }
        public string department { get; set; }

       

    }
}
