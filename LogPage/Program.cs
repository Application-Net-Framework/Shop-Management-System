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

            // You can choose which form to run by uncommenting one of these lines
            // For development, you may want to start with a specific form
            // For production, you'd typically use the splash screen and login flow

            // --- Splash screen and login flow (for production) ---
            // SplashForm splashForm = new SplashForm();
            // splashForm.Show();
            // LogPage loginForm = new LogPage();
            // loginForm.StartPosition = FormStartPosition.CenterScreen;
            // while (splashForm.Visible)
            // {
            //     Application.DoEvents();
            // }
            // Application.Run(loginForm);

            // --- Direct form launching (for development) ---
            // Application.Run(new LogPage());
             Application.Run(new Cashier());
            // Application.Run(new Cashier_Home());
            //Application.Run(new Manager_Home());
            // Application.Run(new New_Managed());
            // Application.Run(new Admin_Main_Home());
            // Application.Run(new Registration_Admin());
            // Application.Run(new Login_Admin());

            // Note: Only one Application.Run call can be active at a time
            // as it blocks until the form is closed
        }
    }
}
