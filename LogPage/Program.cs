using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.UI_Forms.Admin;
using App.UI_Forms.Application_Starting_Logo;

namespace App
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           // Application.Run(new Admin_Main_Home());
            // Start with the login page
            Application.Run(new App.LogPage());

            // Other forms are commented out - uncomment only one if you want to change the startup form
            // Application.Run(new App.UI_Forms.Admin.Admin_Main_Home());
            // Application.Run(new mainCashier());
            // Application.Run(new Manager_Home());
            // Application.Run(new Registration_Admin());
            // Application.Run(new Login_Admin());
            // Application.Run(new Salesman());
        }
    }
}
