using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogPage
{
    public partial class ForgetPass : Form
    {
        public ForgetPass()
        {
            InitializeComponent();
        }

        private void verifyLbl_Click(object sender, EventArgs e)
        {//if verify comlete ,will change this later
            ChangePassConfirm homeForm = new ChangePassConfirm();
            homeForm.Show();
            this.Hide();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
           LogPage  homeForm = new LogPage();
            homeForm.Show();
            this.Hide();
        }
    }
}
