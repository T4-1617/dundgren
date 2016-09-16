using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employees
{
    public partial class Form1 : Form
    {
        System.Collections.ArrayList CustomersAndEmployees;

        public Form1()
        {
            InitializeComponent();

            CustomersAndEmployees = new System.Collections.ArrayList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CustomersAndEmployees.Add(new Customer() { FirstName = txtFirstName.Text, LastName = txtLastName.Text });

            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;

            txtFirstName.Focus();

            DisplayCustomersAndEmployees();

        }

        private void DisplayCustomersAndEmployees() {

            listBox1.Items.Clear();

            foreach (var x in CustomersAndEmployees)
            {

                switch (x.GetType().Name) {

                    case "Customer":
                        listBox1.Items.Add("Customer:" + x);
                        break;

                    case "Employee":
                        listBox1.Items.Add("Employee" + x);
                        break;

                    default:
                        break;


                }

            }

        }
    }
}
