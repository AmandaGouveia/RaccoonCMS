// RacconCMS
// This is a basic customer management system.
// It reads customer data from a CSV and displays the data, allowing 
// the user to add, edit, and delete customers from the database.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaccoonCMS
{
    public partial class Form1 : Form
    {
        private List<Customer> customers = new List<Customer>();
        private readonly string FILE_NAME = "customers.csv";

        private void LoadCustomerFile()
        {
            
        }
        public Form1()
        {
            InitializeComponent();
            LoadCustomerFile();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Exit the Program
            this.Close();

            // To Do - add confirmation
        }
    }
}
