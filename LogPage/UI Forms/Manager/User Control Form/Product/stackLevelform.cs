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

namespace App.UI_Forms.Manager
{
    public partial class stackLevelform : UserControl
    {
        public string highStack;
        public string lowStack;
        public string connectionString = "Data Source=GSM\\SQLEXPRESS;Initial Catalog=GSM;Integrated Security=True;TrustServerCertificate=True";
        
        public stackLevelform()
        {
            InitializeComponent();
            StackLevelchartpnl.Visible = true;
            searchProductManager.Visible = false;
            productAddManager.Visible = false;
            loadDatabase(); 
        }

        private void addproductpnlbtn_Click(object sender, EventArgs e)
        {
            productAddManager.Visible = true;
            HighStack.Visible = false;
            LowStack.Visible = false;
        }

        private void serchpnlbtn_Click(object sender, EventArgs e)
        {
            searchProductManager.Visible = true;
            HighStack.Visible = false;
            LowStack.Visible = false;
        }

        private void refreashbtn_Click(object sender, EventArgs e)
        {
            loadDatabase();
            HighStack.Visible = true;
            LowStack.Visible = true;
        }
        
        public void loadDatabase()
        {
            try
            {
                
                DataTable highStockTable = new DataTable();
                string highStockQuery = "SELECT ProductID, ProductName, Stock FROM Product WHERE Stock > 100";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(highStockQuery, conn))
                    {
                        adapter.Fill(highStockTable);
                        HighStack.DataSource = highStockTable;
                        highStack = highStockTable.Rows.Count.ToString();
                    }
                }

                DataTable lowStockTable = new DataTable();
                string lowStockQuery = "SELECT ProductID, ProductName, Stock FROM Product WHERE Stock < 50";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(lowStockQuery, conn))
                    {
                        adapter.Fill(lowStockTable);
                        LowStack.DataSource = lowStockTable;
                        lowStack = lowStockTable.Rows.Count.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void stacklevelbtn1_Click(object sender, EventArgs e)
        {
            StackLevelchartpnl.Visible = true;
        }

        private void stacklevelbtn2_Click(object sender, EventArgs e)
        {
            StackLevelchartpnl.Visible = true;
        }

        private void addproductpnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void employeChart_Click(object sender, EventArgs e)
        {

        }

        private void searchProductManager_Load(object sender, EventArgs e)
        {
           
        }

        private void HighStack_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LowStack_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
