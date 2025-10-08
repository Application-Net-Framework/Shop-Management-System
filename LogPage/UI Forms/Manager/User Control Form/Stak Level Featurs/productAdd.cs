using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.UI_Forms.Manager.User_Control_Form
{
    public partial class productAdd : UserControl
    {
        public int counter = 0;
        public productAdd()
        {
            InitializeComponent();

            plusbtn.Text = "+";
            plusbtn.ForeColor = Color.Red;

            minusbtn.Text = "-";
            minusbtn.ForeColor = Color.Red;

            string converter = counter.ToString();
            quantitytxt.Text = converter;
            
            // Add the KeyPress event handler
            quantitytxt.KeyPress += new KeyPressEventHandler(quantitytxt_KeyPress);
        }

        private void stacklevelbtn1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void plusbtn_Click(object sender, EventArgs e)
        {
            counter++;
            string converter = counter.ToString();
            quantitytxt.Text = converter;
        }

        private void minusbtn_Click(object sender, EventArgs e)
        {
            counter--;
            if (counter < 0)
            {
                counter = 0;
            }
            string converter = counter.ToString();
            quantitytxt.Text = converter;
        }

        private void quantitytxt_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void quantitytxt_TextChanged(object sender, EventArgs e)
        {
            if (quantitytxt.Text != "")
            {
                counter = Convert.ToInt32(quantitytxt.Text);
            }
            else
            {
                counter = 0;
                quantitytxt.Text = "";
            }
        }
    }
}
