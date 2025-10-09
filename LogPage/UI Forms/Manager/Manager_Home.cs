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
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        private activity homeManagerControl;
        private about aboutControl;

        bool dashboardExpnd = false;
        bool settingsExpnd = false;
        bool memberExpnd = false;
        bool productExpnd = false;
        bool featureExpnd = false;

        public Manager_Home()
        {
            InitializeComponent();

            this.Size = new Size(1200, 600);
            this.ClientSize = new Size(1200, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            SetupWindowControls();
            CenterWelcomeMessage();
            HideAllControls();

            homeManagerControl = new activity();
            aboutControl = new about();

            featurePanel.Controls.Add(homeManagerControl);
            featurePanel.Controls.Add(aboutControl);

            homeManagerControl.Visible = true;
            aboutControl.Visible = false;
        }

        private void SetupWindowControls()
        {
            crossbtn.Text = "X";
            crossbtn.ForeColor = Color.Red;
         
            minimizebtn.Visible = false;
            minimizebtn.Enabled = false;

            fullscreenbtn.Visible = false;
            fullscreenbtn.Enabled = false;
        }

        private void crossbtn_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }
        private void HideAllControls()
        {
            foreach (Control control in featurePanel.Controls)
            {
                control.Visible = false;
            }
        }

        private void Manager_Home_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
            this.CenterToScreen();
            this.ControlBox = false;
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
            if (IsHandleCreated)
            {
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
            if (dashboardExpnd == false)
            {
                dashboardContainer.Height += 5;
                if (dashboardContainer.Height >= 145)
                {
                    dashboardExpnd = true;
                    dashboardtimer.Stop();
                }
            }
            else
            {
                dashboardContainer.Height -= 5;
                if (dashboardContainer.Height <= 45)
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
            CenterWelcomeMessage();
        }

      

        private void menubtn_Click(object sender, EventArgs e)
        {
            featureContainertimer.Start();
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            featureContainertimer.Start();
        }

        private void CloseAllPanels()
        {
            if (dashboardExpnd)
            {
                dashboardContainer.Height = 49;
                dashboardExpnd = false;
                dashboardtimer.Stop();
            }

            if (settingsExpnd)
            {
                settingsContainer.Height = 40;
                settingsExpnd = false;
                settingstime.Stop();
            }

            if (memberExpnd)
            {
                membersContainer.Height = 40;
                memberExpnd = false;
                membertimer.Stop();
            }

            if (productExpnd)
            {
                productContainer.Height = 40;
                productExpnd = false;
                producttimer.Stop();
            }
        }

        private void EnsureMenuExpanded()
        {
            if (!featureExpnd)
            {
                featureContainer.Width = 165;
                featureExpnd = true;
                CenterWelcomeMessage();
            }
        }

        private void dashbtn_Click(object sender, EventArgs e)
        {
            EnsureMenuExpanded();
            if (dashboardExpnd)
            {
                dashboardtimer.Start();
                return;
            }
            CloseAllPanels();
            dashboardtimer.Start();
        }

        private void memberbtn_Click(object sender, EventArgs e)
        {
            EnsureMenuExpanded();
            if (memberExpnd)
            {
                membertimer.Start();
                return;
            }
            CloseAllPanels();
            membertimer.Start();
        }

        private void probtn_Click(object sender, EventArgs e)
        {
            EnsureMenuExpanded();
            if (productExpnd)
            {
                producttimer.Start();
                return;
            }
            CloseAllPanels();
            producttimer.Start();
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

        private void reportbtn_Click(object sender, EventArgs e)
        {
            HideAllControls();
            report1.Visible = true;
        }

        private void discountbtn_Click(object sender, EventArgs e)
        {
            HideAllControls();
            discountform1.Visible = true;
        }

        private void productbtn_Click(object sender, EventArgs e)
        {
            HideAllControls();
            stackLevelform1.Visible = true;
        }

        private void staffbtn_Click(object sender, EventArgs e)
        {
            HideAllControls();
            staffinformationManager.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HideAllControls();
            managerTarmination.Visible = true;
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            HideAllControls();
            newRegistrationEmployeesManager.Visible = true;
        }

        private void aboutbtn_Click(object sender, EventArgs e)
        {
            HideAllControls();
            aboutControl.Visible = true;
        }

        private void activitybtn_Click(object sender, EventArgs e)
        {
            HideAllControls();
            activity1.Visible = true;
        }

        private void crossbtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
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

        private void pnltop_Paint(object sender, PaintEventArgs e) { }
        private void pnltop_MouseDown(object sender, MouseEventArgs e) { }
        private void welcomemsg_Click(object sender, EventArgs e) { }
        private void minimizebtn_Click_1(object sender, EventArgs e) { }
        private void minimizebtn_Click(object sender, EventArgs e) { }
        private void featureContainer_Paint(object sender, PaintEventArgs e) { }
        private void settingsContainer_Paint(object sender, PaintEventArgs e) { }
        private void featureload_Paint(object sender, PaintEventArgs e) { }

     
    }
}
