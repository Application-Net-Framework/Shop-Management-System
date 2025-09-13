using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace App
{
    public partial class Manager_Home : Form
    {
        // Constants for window dragging
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        // Import necessary Windows API functions
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        public Manager_Home()
        {
            InitializeComponent();
            
            // Set up window control buttons
            crossbtn.Text = "X";
            crossbtn.ForeColor = Color.Red;
            crossbtn.FlatStyle = FlatStyle.Flat;
            crossbtn.FlatAppearance.BorderSize = 0;
            crossbtn.Click += crossbtn_Click;
            
            minimizebtn.Text = "_";
            minimizebtn.ForeColor = Color.Black;
            minimizebtn.FlatStyle = FlatStyle.Flat;
            minimizebtn.FlatAppearance.BorderSize = 0;
            minimizebtn.Click += minimizebtn_Click;
            
            fullscreenbtn.Text = "□";
            fullscreenbtn.ForeColor = Color.Black;
            fullscreenbtn.FlatStyle = FlatStyle.Flat;
            fullscreenbtn.FlatAppearance.BorderSize = 0;
            fullscreenbtn.Click += fullscreenbtn_Click;
        }

        private void Manager_Home_Load(object sender, EventArgs e)
        {

        }
        bool dashboardExpnd = false;
        bool settingsExpnd = false;
        bool memberExpnd = false;
        bool productExpnd = false;

        private void dashboardtimer_Tick(object sender, EventArgs e)
        {
            if(dashboardExpnd == false)
            {
                dashboardContainer.Height += 10;
                if(dashboardContainer.Height >= 140)
                {
                    dashboardExpnd = true;
                    dashboardtimer.Stop();
                }
            }
            else
            {
                dashboardContainer.Height -= 10;
                if(dashboardContainer.Height <= 49)
                {
                    dashboardExpnd = false;
                    dashboardtimer.Stop();
                }
            }
        }
        private void settingstime_Tick(object sender, EventArgs e)
        {
            if (settingsExpnd == false)
            {
                settingsContainer.Height += 10;
                if (settingsContainer.Height >= 140)
                {
                    settingsExpnd = true;
                    settingstime.Stop();
                }
            }
            else
            {
                settingsContainer.Height -= 10;
                if (settingsContainer.Height <= 40)
                {
                    settingsExpnd = false;
                    settingstime.Stop();
                }
            }
        }
        private void membertimer_Tick(object sender, EventArgs e)
        {
            if (memberExpnd == false)
            {
                membersContainer.Height += 10;
                if (membersContainer.Height >= 170)
                {
                    memberExpnd = true;
                    membertimer.Stop();
                }
            }
            else
            {
                membersContainer.Height -= 10;
                if (membersContainer.Height <= 40)
                {
                    memberExpnd = false;
                    membertimer.Stop();
                }
            }
        }
        private void producttimer_Tick(object sender, EventArgs e)
        {
            if (productExpnd == false)
            {
                productContainer.Height += 10;
                if (productContainer.Height >= 140)
                {
                    productExpnd = true;
                    producttimer.Stop();
                }
            }
            else
            {
                productContainer.Height -= 10;
                if (productContainer.Height <= 40)
                {
                    productExpnd = false;
                    producttimer.Stop();
                }
            }
        }


        private void dashbtn_Click(object sender, EventArgs e)
        {
            dashboardtimer.Start();
        }
        private void memberbtn_Click(object sender, EventArgs e)
        {
            membertimer.Start();
        }

        private void probtn_Click(object sender, EventArgs e)
        {
            producttimer.Start();
        }

        private void settingsbtn_Click(object sender, EventArgs e)
        {
            settingstime.Start();
        }

        private void settingsContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void aboutbtn_Click(object sender, EventArgs e)
        {

        }

        // Add the MouseDown event handler for the top panel
        private void toppnl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        // Window control button handlers
        private void crossbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizebtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void fullscreenbtn_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                fullscreenbtn.Text = "□";
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                fullscreenbtn.Text = "❐";
            }
        }






        // Add the settings timer event handler

    }
}
