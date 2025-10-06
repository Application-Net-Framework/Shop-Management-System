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
    public partial class staffinformation : UserControl
    {
        public string username;
        public string phonenum;
        public string email;
        public string qulification;
        public string address;
        public string title;
        public string gender;
        public string Address;

        public int userId;
        public DateTime dob;
        public int age;

        public string ConnectionString;
        public staffinformation()
        {
            InitializeComponent();

            invalidUsernamelb.Visible = false;
            invalidphonelb.Visible = false;
            invemaillb.Visible = false;
            invalidDatelb.Visible = false;
            invalidaddresslb.Visible = false;

            SaleManPicturebox.Visible = false;
            cashierpicturebox.Visible = false;
            
            //this when no employee search
            demopicturebox.Visible = true;
            //loadDatabase;
            
            genderLb.Text = gender;
            QulifiShow.Text = qulification;
            usrIdlbl.Text = userId.ToString();
            titleShow.Text = title;

            // data grid view  informationEmployee

        }
        public void loadDatabase()
        {

        }

        private void staffinformationPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            
        }

        private void tarminationbtn_Click(object sender, EventArgs e)
        {

        }

        private void aboutTxtboxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void aboutPhoneTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void aboutAddressTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
