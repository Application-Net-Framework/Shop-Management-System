using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.UI_Forms.Manager
{
    // Changed from internal to public to match method parameter accessibility
    public class database
    {
        string connectionString = "";
        public string name { get; set; }
        public string mail { get; set; }   
        public int id { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string position { get; set; }
        public string salary { get; set; }
        public static List<database> list = new List<database>();
        
        public void search(string key)
        {
            // Your search implementation
        }
    }
}
