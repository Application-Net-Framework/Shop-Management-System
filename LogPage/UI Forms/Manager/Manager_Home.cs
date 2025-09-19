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
using App.UI_Forms.Manager;

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
        
        About about;
        DailyActivity dailyActivity;
        Report report;
        StackLevel stackLevel;
        StaffInformation staffInformation;
        TarminationEmployee tarminated;


        // UI panel expansion states
        bool dashboardExpnd = false;
        bool settingsExpnd = false;
        bool memberExpnd = false;
        bool productExpnd = false;
        bool featureExpnd = false;

        public Manager_Home()
        {
            InitializeComponent();
            
            // Set up window control buttons
            SetupWindowControls();

            // Center the welcome message
            CenterWelcomeMessage();
        }

        private void SetupWindowControls()
        {
            // Set up cross button
            crossbtn.Text = "X";
            crossbtn.ForeColor = Color.Red;
            crossbtn.FlatStyle = FlatStyle.Flat;
            crossbtn.FlatAppearance.BorderSize = 0;
            crossbtn.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            crossbtn.Click += crossbtn_Click;
            
            // Set up minimize button
            minimizebtn.Text = "_";
            minimizebtn.ForeColor = Color.Black;
            minimizebtn.FlatStyle = FlatStyle.Flat;
            minimizebtn.FlatAppearance.BorderSize = 0;
            minimizebtn.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            minimizebtn.Click += minimizebtn_Click;
            
            // Set up fullscreen button
            fullscreenbtn.Text = "□";
            fullscreenbtn.ForeColor = Color.Black;
            fullscreenbtn.FlatStyle = FlatStyle.Flat;
            fullscreenbtn.FlatAppearance.BorderSize = 0;
            fullscreenbtn.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            fullscreenbtn.Click += fullscreenbtn_Click;
        }

        private void Manager_Home_Load(object sender, EventArgs e)
        {
            // Initialize the UI when the manager home form loads
            IsMdiContainer = true;  // Ensure this form can host MDI child forms
            
            // Center the welcome message on form load
            CenterWelcomeMessage();
        }

        // Method to center the welcome message in the top panel
        private void CenterWelcomeMessage()
        {
            // Calculate the center point of the top panel
            int centerX = (pnltop.Width - welcomemsg.Width) / 2;
            
            // Set the welcome message location
            welcomemsg.Location = new Point(centerX, welcomemsg.Location.Y);
        }

        // Override the resize event to keep welcome message centered
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            CenterWelcomeMessage();
        }

        private void dashboardtimer_Tick(object sender, EventArgs e)
        {
            if(dashboardExpnd == false)
            {
                dashboardContainer.Height += 5;
                if(dashboardContainer.Height >= 145)
                {
                    dashboardExpnd = true;
                    dashboardtimer.Stop();
                }
            }
            else
            {
                dashboardContainer.Height -= 5;
                if(dashboardContainer.Height <= 45)
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
                settingsContainer.Height += 5;
                if (settingsContainer.Height >= 145)
                {
                    settingsExpnd = true;
                    settingstime.Stop();
                }
            }
            else
            {
                settingsContainer.Height -= 5;
                if (settingsContainer.Height <= 50)
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
                if (membersContainer.Height >= 190)
                {
                    memberExpnd = true;
                    membertimer.Stop();
                }
            }
            else
            {
                membersContainer.Height -= 10;
                if (membersContainer.Height <= 50)
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
                productContainer.Height += 5;
                if (productContainer.Height >= 145)
                {
                    productExpnd = true;
                    producttimer.Stop();
                }
            }
            else
            {
                productContainer.Height -= 10;
                if (productContainer.Height <= 50)
                {
                    productExpnd = false;
                    producttimer.Stop();
                }
            }
        }
        
        private void featureContainertimer_Tick(object sender, EventArgs e)
        {
            if (featureExpnd == false)
            {
                featureContainer.Width += 5;
                if (featureContainer.Width >= 165)
                {
                    featureExpnd = true;
                    featureContainertimer.Stop();
                    
                    // Re-center welcome message after the feature container expands
                    CenterWelcomeMessage();
                }
            }
            else
            {
                featureContainer.Width -= 5;
                if (featureContainer.Width <= 60)
                {
                    featureExpnd = false;
                    featureContainertimer.Stop();
                    
                    // When menu is collapsed, close all other panels
                    CloseAllPanels();
                    
                    // Re-center welcome message after the feature container collapses
                    CenterWelcomeMessage();
                }
            }
        }
        
        private void menubtn_Click(object sender, EventArgs e)
        {
            featureContainertimer.Start();
        }
        
        private void featureContainer_Paint(object sender, PaintEventArgs e)
        {
            // Custom painting for the feature container if needed
        }

        private void settingsContainer_Paint(object sender, PaintEventArgs e)
        {
            // Custom painting for the settings container if needed
        }

        // For Designer compatibility
        private void featureload_Paint(object sender, PaintEventArgs e)
        {
            // This empty handler is required by the Designer
        }

        // Helper method to close all panels
        private void CloseAllPanels()
        {
            // Close dashboard if it's open
            if (dashboardExpnd)
            {
                dashboardContainer.Height = 49;
                dashboardExpnd = false;
                dashboardtimer.Stop();
            }
            
            // Close settings if it's open
            if (settingsExpnd)
            {
                settingsContainer.Height = 40;
                settingsExpnd = false;
                settingstime.Stop();
            }
            
            // Close members if it's open
            if (memberExpnd)
            {
                membersContainer.Height = 40;
                memberExpnd = false;
                membertimer.Stop();
            }
            
            // Close products if it's open
            if (productExpnd)
            {
                productContainer.Height = 40;
                productExpnd = false;
                producttimer.Stop();
            }
        }

        // Helper method to expand the menu if it's collapsed
        private void EnsureMenuExpanded()
        {
            if (!featureExpnd)
            {
                // Expand the menu first
                featureContainer.Width = 165;
                featureExpnd = true;
                
                // Re-center welcome message after the feature container expands
                CenterWelcomeMessage();
            }
        }

        private void dashbtn_Click(object sender, EventArgs e)
        {
            // First ensure the menu is expanded
            EnsureMenuExpanded();
            
            // If dashboard is already open, just close it
            if (dashboardExpnd)
            {
                dashboardtimer.Start();
                return;
            }
            
            // Close all panels first
            CloseAllPanels();
            
            // Now open dashboard
            dashboardtimer.Start();
        }
        
        private void memberbtn_Click(object sender, EventArgs e)
        {
            // First ensure the menu is expanded
            EnsureMenuExpanded();
            
            // If members is already open, just close it
            if (memberExpnd)
            {
                membertimer.Start();
                return;
            }
            
            // Close all panels first
            CloseAllPanels();
            
            // Now open members
            membertimer.Start();
        }

        private void probtn_Click(object sender, EventArgs e)
        {
            // First ensure the menu is expanded
            EnsureMenuExpanded();
            
            // If products is already open, just close it
            if (productExpnd)
            {
                producttimer.Start();
                return;
            }
            
            // Close all panels first
            CloseAllPanels();
            
            // Now open products
            producttimer.Start();
        }

        private void settingsbtn_Click(object sender, EventArgs e)
        {
            // First ensure the menu is expanded
            EnsureMenuExpanded();
            
            // If settings is already open, just close it
            if (settingsExpnd)
            {
                settingstime.Start();
                return;
            }
            
            // Close all panels first
            CloseAllPanels();
            
            // Now open settings
            settingstime.Start();
        }

        private void reportbtn_Click(object sender, EventArgs e)
        {
            if(report == null)
            {
                report = new Report();
                report.FormClosed += Report_FormClosed;
                report.MdiParent = this;
                report.Dock = DockStyle.Fill;
                report.Show();
            }
            else
            {
                report.Activate();
            }
        }
        
        private void Report_FormClosed(object sender, FormClosedEventArgs e)
        {
            report = null;
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
           
        }
      

        private void discountbtn_Click(object sender, EventArgs e)
        {
            // If you have a Discount form, implement it like this:
            // if(discount == null)
            // {
            //     discount = new Discount();
            //     discount.FormClosed += Discount_FormClosed;
            //     discount.MdiParent = this;
            //     discount.Show();
            // }
            // else
            // {
            //     discount.Activate();
            // }
            
            // For now, show a message since the form might not exist yet
            MessageBox.Show("Discount functionality will be implemented in the future.", "Coming Soon", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void productbtn_Click(object sender, EventArgs e)
        {
            
        }

        private void staffbtn_Click(object sender, EventArgs e)
        {
            if(staffInformation == null)
            {
                staffInformation = new StaffInformation();
                staffInformation.FormClosed += StaffInformation_FormClosed;
                staffInformation.MdiParent = this;
                staffInformation.Dock = DockStyle.Fill;
                staffInformation.Show();
            }
            else
            {
                staffInformation.Activate();
            }
        }
        
        private void StaffInformation_FormClosed(object sender, FormClosedEventArgs e)
        {
            staffInformation = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(tarminated == null)
            {
                tarminated = new TarminationEmployee();
                tarminated.FormClosed += TarminationEmployee_FormClosed;
                tarminated.MdiParent = this;
                tarminated.Dock = DockStyle.Fill;
                tarminated.Show();
            }
            else
            {
                tarminated.Activate();
            }
        }
        
        public void TarminationEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {
            tarminated = null;
        }
        private void About_FormClosed(object sender, FormClosedEventArgs e)
        {
            about = null;
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            if(stackLevel == null)
            {
                stackLevel = new StackLevel();
                stackLevel.FormClosed += StackLevel_FormClosed;
                stackLevel.MdiParent = this;
                stackLevel.Dock = DockStyle.Fill;
                stackLevel.Show();
            }
            else
            {
                stackLevel.Activate();
            }
        }
        
        private void StackLevel_FormClosed(object sender, FormClosedEventArgs e)
        {
            stackLevel = null;
        }

        private void aboutbtn_Click(object sender, EventArgs e)
        {
            if(about == null)
            {
                about = new About();
                about.FormClosed += About_FormClosed;
                about.MdiParent = this;
                about.Dock = DockStyle.Fill;
                about.Show();
            }
            else
            {
                about.Activate();
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
            
            // Re-center welcome message after changing window state
            CenterWelcomeMessage();
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

        private void activitybtn_Click(object sender, EventArgs e)
        {
            if(dailyActivity == null)
            {
                dailyActivity = new DailyActivity();
                dailyActivity.FormClosed += DailyActivity_FormClosed;
                dailyActivity.MdiParent = this;
                dailyActivity.Dock = DockStyle.Fill;
                dailyActivity.Show();
            }
            else
            {
                dailyActivity.Activate();
            }
        }

        private void DailyActivity_FormClosed(object sender, FormClosedEventArgs e)
        {
            dailyActivity = null;
        }

        private void minimizebtn_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void fullscreenbtn_Click_1(object sender, EventArgs e)
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
            
            // Re-center welcome message after changing window state
            CenterWelcomeMessage();
        }

        private void crossbtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            featureContainertimer.Start();
        }

        private void toppnl_Paint(object sender, PaintEventArgs e)
        {
            // Nothing to do here
        }

        private void welcomemsg_Click(object sender, EventArgs e)
        {
            // Nothing to do here
        }

        private void pnltop_Paint(object sender, PaintEventArgs e)
        {
            // Nothing to do here
        }
        
        // Add the MouseDown event handler for the top panel to allow dragging
        private void pnltop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        
        // Override the SizeChanged event to recenter welcome message when form size changes
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            
            // Recenter welcome message
            CenterWelcomeMessage();
        }
    }
}
