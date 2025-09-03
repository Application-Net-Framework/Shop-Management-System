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
    public partial class Cashier_Home : Form
    {
        public Cashier_Home()
        {
            InitializeComponent();
        }
        public void loadform(object Form)
        {
            if (this.mainPnl.Controls.Count > 0)
            {
                this.mainPnl.Controls.RemoveAt(0);
                Form f = Form as Form;
                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                this.mainPnl.Controls.Add(f);
                this.mainPnl.Tag = f;
                f.Show();
            }

        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            loadform(new Cashier_Home());
        }
    }
}
