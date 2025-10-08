using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.UI_Forms.Manager.User_Control_Form
{
    public partial class discountform : UserControl
    {
        public string connectionString = "Data Source=DESKTOP-FGUJCMU\\SQLEXPRESS;Initial Catalog=GSMSDb;Integrated Security=True;TrustServerCertificate=True";
        
        public discountform()
        {
            InitializeComponent();
            LoadDatabase();
        }
        
        private void addbtn_Click(object sender, EventArgs e)
        {

        }

        private void activebtn_Click(object sender, EventArgs e)
        {

        }

        private void deletebtn_Click(object sender, EventArgs e)
        {

        }

        private void deactivebtn_Click(object sender, EventArgs e)
        {

        }
        public void LoadDatabase()
        {
            try
            {
                string inactiveEmployees = "SELECT * FROM Discounts";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlDataAdapter sda2 = new SqlDataAdapter(inactiveEmployees, connection))
                    {
                        DataTable dt2 = new DataTable();
                        sda2.Fill(dt2);

                        if (discountDataTable != null)
                            discountDataTable.DataSource = dt2;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void discountDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
