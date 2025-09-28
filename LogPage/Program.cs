using System;
using System.Windows.Forms;

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
            
            // Start with the login page
            
            // Application.Run(new App.UI_Forms.Admin.Admin_Main_Home());
            // Application.Run(new mainCashier());
          //  Application.Run(new Manager_Home());
            // Application.Run(new Registration_Admin());
            // Application.Run(new Login_Admin());
             Application.Run(new Salesman());
            // Application.Run(new App.LogPage());
        }
    }
}
