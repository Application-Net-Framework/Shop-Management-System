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
    public partial class about : UserControl
    {
        public about()
        {
            InitializeComponent();

            invalidUsernamelb.Visible = false;
            invalidphonelb.Visible = false;
            invemaillb.Visible = false;
            invalidpasswodlb.Visible = false;
            invalidretypelb.Visible = false;
            invalidpreviouspasslb.Visible = false;
            invalidpasswodlb.Visible = false;
            invalidaddresslb.Visible = false;
            dobLb.Visible = false;


        }








        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void aboutTxtboxName_TextChanged(object sender, EventArgs e)
        {
            double input;
            if(double.TryParse(aboutTxtboxName.Text, out input))
            {
                invalidUsernamelb.Visible = true;
            }
            else {
                invalidUsernamelb.Visible = false;
            }

        }

        private void aboutPhoneTxt_TextChanged(object sender, EventArgs e)
        {
            double input;
            if (!double.TryParse(aboutPhoneTxt.Text, out input))
            {
                invalidphonelb.Visible = true;
            }
            else
            {
                invalidphonelb.Visible = false;
            }
        }

        private void aboutEmailTxt_TextChanged(object sender, EventArgs e)
        {
            double input;
            if (double.TryParse(aboutEmailTxt.Text, out input))
            {
                invemaillb.Visible = true;
            }
            else
            {
                invemaillb.Visible = false;
            }
        }

        private void aboutAddressTxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void aboutPrePass_TextChanged(object sender, EventArgs e)
        {
            //Database
        }

        private void aboutNewPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void aboutRePass_TextChanged(object sender, EventArgs e)
        {
            if(aboutNewPass.Text != aboutRePass.Text)
            {
                invalidretypelb.Visible = true;
            }
            else
            {
                invalidretypelb.Visible = false;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dob = dateTimePicker1.Value;
            int age = calculateAge(dob);
            if(age < 18)
            {
                dobLb.Visible = true;
            }
            else
            {
                dobLb.Visible = false;
            }

        }
        private int calculateAge(DateTime birthDate)
        {
            int age = DateTime.Now.Year - birthDate.Year;
            if (DateTime.Now < birthDate.AddYears(age))
            {
                age--;
            }
            return age;
        }

        private void QulifiShow_Click(object sender, EventArgs e)
        {
            //database
        }

        private void genderLb_Click(object sender, EventArgs e)
        {
            //database
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            if (invalidUsernamelb.Visible ||  invalidphonelb.Visible || invemaillb.Visible || invalidpasswodlb.Visible ||  invalidretypelb.Visible ||  invalidpreviouspasslb.Visible ||   invalidaddresslb.Visible ||   dobLb.Visible)
            {
                MessageBox.Show("Please fulfill the requirements.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to change?",
                                                      "Confirm",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Changes applied successfully!",
                                    "Success",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
        }
    }
}
