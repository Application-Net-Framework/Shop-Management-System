using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Manager_Home : Form
    {
        public Manager_Home()
        {
            InitializeComponent();
        }

        private void Manager_Home_Load(object sender, EventArgs e)
        {

        }
        bool dashboardExpnd = false;
        
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

        private void dashbtn_Click(object sender, EventArgs e)
        {
            dashboardtimer.Start();
        }

        private void settingsContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
