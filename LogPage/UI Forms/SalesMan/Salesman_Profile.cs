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
    public partial class Salesman_Profile : Form
    {
        public Salesman_Profile()
        {
            InitializeComponent();
        }

       

        private void backBtn_Click_1(object sender, EventArgs e)
        {
            Salesman_Home p = new Salesman_Home();
            p.StartPosition = FormStartPosition.Manual;
            p.Location = this.Location;
            p.Size = this.Size;
            p.Show();
            this.Hide();
        }

        private void Profile_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
