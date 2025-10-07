using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.UI_Forms.Manager.User_Control_Form
{
    public partial class searchProduct : UserControl
    {
        public searchProduct()
        {
            InitializeComponent();
        }

        private void stacklevelbtn2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
