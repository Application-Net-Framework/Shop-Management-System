using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.UI_Forms.SalesMan
{
    public partial class CustomerManagement : Form
    {
        public CustomerManagement()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.Dpi;   // or AutoScaleMode.Font
            this.AutoSize = true;
        }

        private void CustomerManagement_Load(object sender, EventArgs e)
        {
           
            
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            Salesman S = new Salesman();
            S.StartPosition = FormStartPosition.Manual;
            S.Location = this.Location;
            S.Size = this.Size;
            S.Show();
            this.Hide();
        }

        private void feedbackBtn_Click(object sender, EventArgs e)
        {
            Feedback f = new Feedback();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = this.Location;
            f.Size = this.Size;
            f.Show();
            this.Hide();
        }

        private void pQueryBtn_Click(object sender, EventArgs e)
        {
            ProductQuery PQ = new ProductQuery();
            PQ.StartPosition = FormStartPosition.Manual;
            PQ.Location = this.Location;
            PQ.Size = this.Size;
            PQ.Show();
            this.Hide();
        }
    }
}
