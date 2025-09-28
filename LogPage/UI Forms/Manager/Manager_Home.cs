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
using App.UI_Forms.Manager.User_Control_Form;

namespace App
{
    public partial class Manager_Home : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();
        
        private activity homeManagerControl;
        private about aboutControl;
        private report reportControl;
        private discountform discountControl;
        private productform productControl;
        private stackLevelform stackLevelControl;
        private dailyactivityform dailyActivityControl;

        bool dashboardExpnd = false;
        bool settingsExpnd = false;
        bool memberExpnd = false;
        bool productExpnd = false;
        bool featureExpnd = false;

        public Manager_Home()
        {
            InitializeComponent();
            
            // Set form size
            this.Size = new Size(1200, 600);
            this.ClientSize = new Size(1200, 600);

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

            // Initialize user controls
            homeManagerControl = new activity();
            aboutControl = new about();

            // Add controls to the feature panel
            featurePanel.Controls.Add(homeManagerControl);
            featurePanel.Controls.Add(aboutControl);

            // Set initial visibility
            homeManagerControl.Visible = true;
            aboutControl.Visible = false;
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
            // Initialize the UI when the manager home form loads
            IsMdiContainer = true;  // Ensure this form can host MDI child forms
            
            // Force the form to be centered on screen
            this.CenterToScreen();
            
            // Prevent the form from being moved after loading
            this.ControlBox = false; // Hide the control box completely
            
            // Center the welcome message on form load
            CenterWelcomeMessage();
            
            // Make sure feature container has correct initial state
            if (featureExpnd)
            {
                featureContainer.Width = 165;
            }
            else
            {
                featureContainer.Width = 60;
            }
            
            // Apply all visual settings after load
            this.Update();
        }

        // Method to center the welcome message in the top panel
        private void CenterWelcomeMessage()
        {
            // Calculate the center point of the top panel
            int centerX = (pnltop.Width - welcomemsg.Width) / 2;
            
            // Ensure we don't position it off-screen
            if (centerX < 0) centerX = 0;
            
            // Set the welcome message location
            welcomemsg.Location = new Point(centerX, welcomemsg.Location.Y);
        }

        // Override the resize event to keep welcome message centered
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

        // Override the SizeChanged event to recenter welcome message when form size changes
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            
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
            
            // Re-center during animation to keep it smooth
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

            // Show the product control
            HideAllControls();
            if (productControl == null)
            {
                productControl = new productform();
                featurePanel.Controls.Add(productControl);
                productControl.Dock = DockStyle.Fill;
            }
            productControl.Visible = true;
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
            HideAllControls();
            report1.Visible = true;
        }
        
        // Helper method to hide all controls in the feature panel
        private void HideAllControls()
        {
            foreach (Control control in featurePanel.Controls)
            {
                control.Visible = false;
            }
        }

        private void discountbtn_Click(object sender, EventArgs e)
        {
            HideAllControls();
            discountform1.Visible = true;
        }

        private void productbtn_Click(object sender, EventArgs e)
        {
            HideAllControls();
            stackLevelform1.Visible = false;
        }

        private void staffbtn_Click(object sender, EventArgs e)
        {
            
        }

        // Tarmination Button
        private void button2_Click(object sender, EventArgs e)
        {
            HideAllControls();
            managerTarmination.Visible = true;

        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            
        }

        //ABOUT BUTTON
        private void aboutbtn_Click(object sender, EventArgs e)
        {
            HideAllControls();
            aboutControl.Visible = true;
        }
        
        private void minimizebtn_Click(object sender, EventArgs e)
        {
            // Disabled to prevent form from being minimized
            // this.WindowState = FormWindowState.Minimized;
        }

        private void activitybtn_Click(object sender, EventArgs e)
        {
            HideAllControls();
            activity1.Visible = true;
        }

        private void minimizebtn_Click_1(object sender, EventArgs e)
        {
           //nothing
        }

        private void crossbtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            featureContainertimer.Start();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            // Log out implementation
            this.Close();
            DialogResult result = MessageBox.Show("Are you sure you want to Logout?",
                                                      "Confirm",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();

            }
        }

        // Empty method implementations to fix designer references
        private void pnltop_Paint(object sender, PaintEventArgs e)
        {
            // Empty implementation to satisfy designer reference
        }
        
        private void pnltop_MouseDown(object sender, MouseEventArgs e)
        {
            // Empty implementation to satisfy designer reference
        }
    }
}
