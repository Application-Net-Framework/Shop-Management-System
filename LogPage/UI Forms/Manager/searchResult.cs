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
    public partial class searchResult : UserControl
    {
        public searchResult()
        {
            InitializeComponent();
        }

        private void searchResult_Load(object sender, EventArgs e)
        {

        }
        
        public void details(database d)
        {
            // Your implementation here
        }
        
        // Renamed method to avoid conflict with class name
        public void performSearch(string key)
        {
            database get = new database();
            get.search(key);
        }
    }
}
