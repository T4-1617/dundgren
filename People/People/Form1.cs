using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace People
{
    public partial class Form1 : Form
    {
        System.Collections.ArrayList Peeplist;
        
        public Form1()
        {
            InitializeComponent();
            Peeplist = new System.Collections.ArrayList();

            Peeplist.Add(new Customer() { FirstName = "Daniel", LastName = "Lundgren", CustomerId = 1, PhoneNumber = "0702324562" });
            Peeplist.Add(new Customer() { FirstName = "Sebbe", LastName = "Kullander", CustomerId = 2, PhoneNumber = "0762524644" });

            Peeplist.Add(new Employee() { FirstName = "Steven", LastName = "Bergqvist", EmployeeId = 1, PhoneNumber = "0705326247", Title = "CEO", Wage = "40.000kr" });
            Peeplist.Add(new Employee() { FirstName = "Kent", LastName = "Konradsson", EmployeeId = 2, PhoneNumber = "0707217129", Title = "Mekaniker", Wage = "24.392kr" });

            Peeplist.Add(new Supplier() { FirstName = "Snorre", LastName = "Sturesson", Company = "MotorikAB", PhoneNumber = "0762515273" });

            pnlCustomer.Visible = false;
            pnlEmployee.Visible = false;
            pnlSupplier.Visible = false;


            foreach (var person in Peeplist)
            {
                listBox1.Items.Add(person);
            }

           

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ComboPeople_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ComboPeople.Text)
            {

                case "Kund":
                    pnlCustomer.Visible = true;
                    pnlEmployee.Visible = false;
                    pnlSupplier.Visible = false;
                    break;

                case "Anställd":
                    pnlCustomer.Visible = false;
                    pnlEmployee.Visible = true;
                    pnlSupplier.Visible = false;
                    break;

                case "Leverantör":
                    pnlCustomer.Visible = false;
                    pnlEmployee.Visible = false;
                    pnlSupplier.Visible = true;
                    break;

                default:
                    pnlCustomer.Visible = false;
                    pnlEmployee.Visible = false;
                    pnlSupplier.Visible = false;
                    break;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Peeplist.Add(new Customer() { FirstName = txtCustomerFirstName.Text, LastName = txtCustomerLastName.Text, CustomerId = 1, PhoneNumber = txtCustomerPhoneNumber.Text });
            listBox1.Items.Clear();
            foreach (var person in Peeplist)
            {
                listBox1.Items.Add(person);
            }

            txtCustomerFirstName.Clear();
            txtCustomerLastName.Clear();
            txtCustomerPhoneNumber.Clear();

        }

        private void btnEmployeeAdd_Click(object sender, EventArgs e)
        {
            Peeplist.Add(new Employee() { FirstName = txtEmployeeFirstName.Text, LastName = txtEmployeeLastName.Text, EmployeeId = 1, PhoneNumber = txtEmployeePhoneNumber.Text, Title = txtEmployeeTitle.Text, Wage = txtEmployeeWage.Text  });
            listBox1.Items.Clear();
            foreach (var person in Peeplist)
            {
                listBox1.Items.Add(person);
            }

            txtEmployeeFirstName.Clear();
            txtEmployeeLastName.Clear();
            txtEmployeePhoneNumber.Clear();
            txtEmployeeTitle.Clear();
            txtEmployeeWage.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Peeplist.Add(new Supplier() { FirstName = txtSupplierFirstName.Text, LastName = txtSupplierLastName.Text, PhoneNumber = txtSupplierPhoneNumber.Text, Company = txtCompanyName.Text });
            listBox1.Items.Clear();
            foreach (var person in Peeplist)
            {
                listBox1.Items.Add(person);
            }

            txtCompanyName.Clear();
            txtSupplierFirstName.Clear();
            txtSupplierLastName.Clear();
            txtSupplierPhoneNumber.Clear();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlCustomer.Visible = false;
            txtCustomerFirstName.Clear();
            txtCustomerLastName.Clear();
            txtCustomerPhoneNumber.Clear();
        }

        private void btnEmployeeCancel_Click(object sender, EventArgs e)
        {
            pnlEmployee.Visible = false;
            txtEmployeeFirstName.Clear();
            txtEmployeeLastName.Clear();
            txtEmployeePhoneNumber.Clear();
            txtEmployeeTitle.Clear();
            txtEmployeeWage.Clear();
        }

        private void btnSupplierCancel_Click(object sender, EventArgs e)
        {
            pnlSupplier.Visible = false;
            txtCompanyName.Clear();
            txtSupplierFirstName.Clear();
            txtSupplierLastName.Clear();
            txtSupplierPhoneNumber.Clear();
        }
    }
}
