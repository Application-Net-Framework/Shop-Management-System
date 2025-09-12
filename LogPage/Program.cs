using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

            // Run Main Form
            Application.Run(new LogPage());
            //Application.Run(new LogPage());
            //Application.Run(new SalesMan_Home());
            Application.Run(new Registration_Admin());
            //Application.Run(new Login_Admin());
            Application.Run(new Manager_Home());
        }
    }
}
