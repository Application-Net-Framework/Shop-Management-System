using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.UI_Forms.Admin
{
    public partial class Admin_Main_Home : Form
    {
        public Admin_Main_Home()
        {
            InitializeComponent();
            panelSide.Height = btnHome.Height;
            home1.BringToFront();

        }

        private void Admin_Main_Home_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            panelSide.Height = btnHome.Height;
            panelSide.Top = btnHome.Top;
            home1.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panelSide.Height = btnEmployee.Height;
            panelSide.Top = btnEmployee.Top;
            employees1.BringToFront();

        }

        private void btnProduct_Click(object sender, EventArgs e)
        {

        }

        private void btnsales_Click(object sender, EventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {

        }

        private void btnSetting_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {

        }

        private void btnMail_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelSide_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
