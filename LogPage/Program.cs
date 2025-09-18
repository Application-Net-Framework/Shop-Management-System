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

            // Choose ONE of these as your starting form
            // Application.Run(new LogPage());
            //Application.Run(new Cashier());
            // Application.Run(new Manager_Home());
            Application.Run(new Admin_Main_Home());
            
            // Note: Only one Application.Run call can be active at a time
            // as it blocks until the form is closed
        }
    }
}
