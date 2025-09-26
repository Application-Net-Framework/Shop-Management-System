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
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        // THis part auto generate
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();


        // This part is for expand and collapse features
        bool dashboardExpnd = false;
        bool settingsExpnd = false;
        bool memberExpnd = false;
        bool productExpnd = false;
        bool featureExpnd = false;

        // main  code start from here
        public Manager_Home()
        {
            InitializeComponent();
            
            // This part is for size 
            this.Size = new Size(1200, 700);
            this.ClientSize = new Size(1200, 700);

            // Lock the form in center position
            this.StartPosition = FormStartPosition.CenterScreen;
            
            // Disable form resizing and maximize/minimize buttons
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            
            // Set up window control buttons
            SetupWindowControls();

            // Center the welcome message
            CenterWelcomeMessage();

        }
        private void welcomemsg_Click(object sender, EventArgs e)
        {
            // Nothing to do here
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
            
            // Disable minimize button
            minimizebtn.Visible = false;
            minimizebtn.Enabled = false;
            
            // Disable fullscreen button
            fullscreenbtn.Visible = false;
            fullscreenbtn.Enabled = false;
        }

        private void Manager_Home_Load(object sender, EventArgs e)
        {
           
            IsMdiContainer = true;  
            
            this.CenterToScreen();
            
            
            this.ControlBox = false; 
            
            // this part is for center the welcome message
            CenterWelcomeMessage();
            
            if (featureExpnd)
            {
                featureContainer.Width = 165;
            }
            else
            {
                featureContainer.Width = 60;
            }
            
            this.Update();
        }

        private void CenterWelcomeMessage()
        {
            
            int centerX = (pnltop.Width - welcomemsg.Width) / 2;
            
            if (centerX < 0) centerX = 0;
            
            welcomemsg.Location = new Point(centerX, welcomemsg.Location.Y);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            
            // Apply after base resize to ensure accurate measurements
            if (IsHandleCreated) // Prevent issues during initialization
            {
                // Use BeginInvoke to ensure UI is ready for measurement
                this.BeginInvoke(new Action(() => 
                {
                    CenterWelcomeMessage();
                }));
            }
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            
           if (IsHandleCreated) 
            {
                this.BeginInvoke(new Action(() => 
                {
                    CenterWelcomeMessage();
                }));
            }
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
        private void settingsbtn_Click(object sender, EventArgs e)
        {
           
            EnsureMenuExpanded();

            if (settingsExpnd)
            {
                settingstime.Start();
                return;
            }

            CloseAllPanels();

            settingstime.Start();
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
                    
                    this.BeginInvoke(new Action(() => 
                    {
                        CenterWelcomeMessage();
                    }));
                }
            }
            else
            {
                featureContainer.Width -= 5;
                if (featureContainer.Width <= 60)
                {
                    featureExpnd = false;
                    featureContainertimer.Stop();
                    
                    CloseAllPanels();
                    
                    this.BeginInvoke(new Action(() => 
                    {
                        CenterWelcomeMessage();
                    }));
                }
            }
            
            CenterWelcomeMessage();
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
        private void crossbtn_Click(object sender, EventArgs e)
        {
            this.Close();
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

    

        private void reportbtn_Click(object sender, EventArgs e)
        {
            about1.Visible = false;
            activity1.Visible = false;
            dailyactivityform1.Visible = false;
            discountform1.Visible = false;
            stackLevelform1.Visible = false;

            report1.Visible = true;
        }
        

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      

        private void discountbtn_Click(object sender, EventArgs e)
        {

            about1.Visible = false;
            activity1.Visible = false;
            dailyactivityform1.Visible = false;

            discountform1.Visible = true;
            
            stackLevelform1.Visible = false;
            report1.Visible = false ;
        }

        private void productbtn_Click(object sender, EventArgs e)
        {
            about1.Visible = false;
            activity1.Visible = false;
            dailyactivityform1.Visible = false;
            discountform1.Visible = false;
            stackLevelform1.Visible = false;
            report1.Visible = true;
        }

        private void staffbtn_Click(object sender, EventArgs e)
        {
      
        }
  

        private void button2_Click(object sender, EventArgs e)
        {

        }
        

        private void registerbtn_Click(object sender, EventArgs e)
        {

        }
        
 
        //ABOUT BUTTON
        private void aboutbtn_Click(object sender, EventArgs e)
        {
           
        }
        private void minimizebtn_Click(object sender, EventArgs e)
        {
            // Disabled to prevent form from being minimized
            // this.WindowState = FormWindowState.Minimized;
        }


        private void activitybtn_Click(object sender, EventArgs e)
        {
            about1.Visible = false;

            activity1.Visible = true;
            
            dailyactivityform1.Visible = false;
            discountform1.Visible = false;
            stackLevelform1.Visible = false;
            report1.Visible = false;
        }


        private void minimizebtn_Click_1(object sender, EventArgs e)
        {
            // Disabled to prevent form from being minimized
            // this.WindowState = FormWindowState.Minimized;
        }

        private void crossbtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            featureContainertimer.Start();
        }




        private void pnltop_Paint(object sender, PaintEventArgs e)
        {
            // Nothing to do here
        }
        
        // Add the MouseDown event handler for the top panel to allow dragging
        private void pnltop_MouseDown(object sender, MouseEventArgs e)
        {
            // Disabled to prevent form movement
            // if (e.Button == MouseButtons.Left)
            // {
            //     ReleaseCapture();
            //     SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            // }
        }

       


    }
}
