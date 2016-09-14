using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customersdan
{
    public partial class Form1 : Form
    {
        string status;
        //int för att hålla reda på id
        int i = 100;
        //En lista som ska innehålla kundobjekten
        List<Customer> MyCustomers = new List<Customer>();

        public Form1()
        {

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //skapar ett objekt med hjälp av klassen 
            Customer c = new Customer();
            c.id = i;
            c.firstname = txtFirstname.Text;
            c.lastname = txtLastname.Text;

            if (checkBox1.Checked)
            {
                c.active = true;
            }

            else {
                c.active = false;
            }
            //lägger till kunden i listan
            MyCustomers.Add(c);
            //tömmer listboxen innan nya kunder läggs till
            lbMyCustomers.Items.Clear();
            //går igenom listan och lägger till varje kund
            foreach (Customer item in MyCustomers) {

                lbMyCustomers.Items.Add(item.fullname());

            }


            //ändrar labeln så att de berättar hur många kunder det finns i listan
            label3.Text = string.Format("Du har {0} kunder", MyCustomers.Count);

            //lägger till 1 på int i så att nästa kund får nytt id
            i++;

           



        }


        private void lbMyCustomers_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //kollar var i listan man klickar
            Customer c = MyCustomers[lbMyCustomers.SelectedIndex];

            MessageBox.Show(string.Format("ID: {0}\nFirst name: {1}\nLast name {2}\nStatus: {3}", 
                c.id, c.firstname, c.lastname, c.active));
        }
    }
}
