using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.UI_Forms.Manager.User_Control_Form
{
    public partial class searchProduct : UserControl
    {
        public string connectionString = "Data Source=DESKTOP-FGUJCMU\\SQLEXPRESS;Initial Catalog=GSMSDb;Integrated Security=True;TrustServerCertificate=True";
        public searchProduct()
        {
            InitializeComponent();
            loadDatabase();
        }
        public void loadDatabase()
        {
            try
            {
                string inactiveEmployees = "SELECT * FROM Product";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlDataAdapter sda2 = new SqlDataAdapter(inactiveEmployees, connection))
                    {
                        DataTable dt2 = new DataTable();
                        sda2.Fill(dt2);

                        if (productShowData != null)
                            productShowData.DataSource = dt2;
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error: " + ex.Message);
            }

        }
        private void stacklevelbtn2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
