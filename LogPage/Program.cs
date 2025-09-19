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

            // Choose only ONE form to run
            //Application.Run(new Admin_Main_Home());
            
            // Other forms are commented out - uncomment only one if you want to change the startup form
            // Application.Run(new LogPage());
            // Application.Run(new Cashier());
            // Application.Run(new Cashier_Home());
            // Application.Run(new Manager_Home());
            // Application.Run(new New_Managed());
            // Application.Run(new Registration_Admin());
            // Application.Run(new Login_Admin());

            // Note: Only one Application.Run call can be active at a time
            // as it blocks until the form is closed
        }
    }
}
