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

namespace App
{
    public partial class Registration_Admin : Form
    {
        public void connect()
        {
            try
            {
                string connectionString = @"Data Source=DESKTOP-HRPRSI4\\SQLEXPRESS;Initial Catalog=GSMSDb;Integrated Security=True;";

                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string query = "INSERT INTO Registration(FullName, Email,PhoneNumber) VALUES ('Rafia','rafia@gmail.com',03893)";
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
            }            
            
            catch (Exception )

            {
                //MessageBox.Show("An error occurred: " + ex.Message);
            }
           
        }
        public Registration_Admin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            connect();
            // Optionally, show a message on success
            // MessageBox.Show("Registration Successfully");
        }
    }
}
