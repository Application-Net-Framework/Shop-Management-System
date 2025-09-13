using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.UI_Forms.Application_Starting_Logo
{
    public partial class SplashForm : Form
    {
        private Timer timer;

        public SplashForm()
        {
            InitializeComponent();
            
            // Center the form in the middle of the screen
            this.StartPosition = FormStartPosition.CenterScreen;
            
            // Create a timer to close the splash form after 3 seconds
            timer = new Timer();
            timer.Interval = 3000; // 3 seconds
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Stop the timer
            timer.Stop();
            timer.Dispose();

            // Close this form
            this.Close();
        }
    }
}
