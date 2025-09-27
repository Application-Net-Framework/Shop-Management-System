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
    public partial class ChangePassConfirm : Form
    {
        public ChangePassConfirm()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            ForgetPass homeForm = new ForgetPass();
            homeForm.Show();
            this.Hide();
        }
    }
}
