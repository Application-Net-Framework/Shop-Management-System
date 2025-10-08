using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.UI_Forms.Manager
{
    public partial class stackLevelform : UserControl
    {
        public stackLevelform()
        {
            InitializeComponent();
            StackLevelchartpnl.Visible = true;
            searchProductManager.Visible = false;
            productAddManager.Visible = false;

        }

        private void addproductpnlbtn_Click(object sender, EventArgs e)
        {
            productAddManager.Visible = true;
        }

        private void serchpnlbtn_Click(object sender, EventArgs e)
        {
            searchProductManager.Visible = true;
        }

        private void refreashbtn_Click(object sender, EventArgs e)
        {
            //loaddatabase();
        }
        public void loadDatabase()
        {

        }

        private void stacklevelbtn1_Click(object sender, EventArgs e)
        {
            StackLevelchartpnl.Visible = true;
           
        }

        private void stacklevelbtn2_Click(object sender, EventArgs e)
        {
            StackLevelchartpnl.Visible = true;
       
        }

        private void addproductpnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void employeChart_Click(object sender, EventArgs e)
        {

        }

        private void searchProductManager_Load(object sender, EventArgs e)
        {
           
        }
    }
}
