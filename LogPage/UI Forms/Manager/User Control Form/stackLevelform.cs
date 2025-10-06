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
            addproductpnl.Visible = false;
            searchPnl.Visible = false;
            StackLevelchartpnl.Visible = true;
        }

        private void addproductpnlbtn_Click(object sender, EventArgs e)
        {
            addproductpnl.Visible = true;
            StackLevelchartpnl.Visible = false;
            searchPnl.Visible = false;
        }

        private void serchpnlbtn_Click(object sender, EventArgs e)
        {
            addproductpnl.Visible = false;
            StackLevelchartpnl.Visible = false;
            searchPnl.Visible = true;
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
            addproductpnl.Visible = false;
            searchPnl.Visible = false;
        }

        private void stacklevelbtn2_Click(object sender, EventArgs e)
        {
            StackLevelchartpnl.Visible = true;
            addproductpnl.Visible = false;
            searchPnl.Visible = false;
        }

        private void addproductpnl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
