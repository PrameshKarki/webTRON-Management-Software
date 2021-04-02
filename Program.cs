using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using webTRON_Management_Software.Views.Accountant;
using webTRON_Management_Software.Views.Doctor;
using webTRON_Management_Software.Views.Admin;
using webTRON_Management_Software.Views.Landing_Window;
using webTRON_Management_Software.Views.Others;
using webTRON_Management_Software.Views.Management;
using webTRON_Management_Software.Views.Utilities;

namespace webTRON_Management_Software
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Run main window here
            //Application.Run(new LandingWindow());
            Application.Run(new CreateNewPatient());

       
          
        }
    }
}
