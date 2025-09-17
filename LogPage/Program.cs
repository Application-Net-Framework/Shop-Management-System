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

            // Create and show splash screen
            //SplashForm splashForm = new SplashForm();
            //splashForm.Show();

            // Create the main login form but don't show it yet
            LogPage loginForm = new LogPage();
            // Center the login form as well
            loginForm.StartPosition = FormStartPosition.CenterScreen;

            // Process messages while splash screen is shown
            //while (splashForm.Visible)
            //{
            //    Application.DoEvents();
            //}

            // Run the login form after splash screen closes
            //Application.Run(loginForm);

            // These will never be executed because Application.Run() is blocking
            // Until the form is closed
            // Application.Run(new Cashier_Home());
            Application.Run(new SalesMan_Home());
            //Application.Run(new Registration_Admin());
            //Application.Run(new Login_Admin());
            //Application.Run(new Manager_Home());
            //Application.Run(new New_Managed());
            //Application.Run(new Admin_Main_Home());
        }
    }
}
