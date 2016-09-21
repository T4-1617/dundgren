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
            pnlCustomerEdit.Visible = false;
            pnlEdit.Visible = false;
            pnlEmployeeEdit.Visible = false;
            pnlSupplierEdit.Visible = false;


            foreach (var person in Peeplist)
            {
                listBox1.Items.Add(person);
            }

           

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Peeps x = (Peeps)listBox1.SelectedItem;
            txtFirstNameEdit.Text = x.FirstName;
            txtLastNameEdit.Text = x.LastName;
            txtNumberEdit.Text = x.PhoneNumber;


            switch (listBox1.SelectedItem.GetType().Name)
            {
                case "Customer":
                    pnlEdit.Visible = true;
                    pnlCustomerEdit.Visible = true;
                    pnlEmployeeEdit.Visible = false;
                    pnlSupplierEdit.Visible = false;
                    break;

                case "Employee":
                    Employee E = (Employee)listBox1.SelectedItem;
                    pnlEdit.Visible = true;
                    pnlCustomerEdit.Visible = false;
                    pnlEmployeeEdit.Visible = true;
                    pnlSupplierEdit.Visible = false;
                    txtEmployeeTitleEdit.Text = E.Title;
                    txtEmployeeWageEdit.Text = E.Wage;
                    break;

                case "Supplier":
                    Supplier S = (Supplier)listBox1.SelectedItem;
                    pnlSupplierEdit.Visible = true;
                    pnlCustomerEdit.Visible = false;
                    pnlEmployeeEdit.Visible = false;
                    pnlEdit.Visible = true;
                    txtSupplierNameEdit.Text = S.Company;
                    break;


                default:
                    pnlCustomerEdit.Visible = false;
                    pnlEmployeeEdit.Visible = false;
                    pnlEdit.Visible = false;
                    pnlSupplierEdit.Visible = false;
                    break;
            }
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

        private void btnCustomerSave_Click(object sender, EventArgs e)
        {
            Peeps x = (Peeps)listBox1.SelectedItem;
            x.FirstName = txtFirstNameEdit.Text;
            x.LastName = txtLastNameEdit.Text;
            x.PhoneNumber = txtNumberEdit.Text;
            pnlEdit.Visible = false;
            pnlCustomerEdit.Visible = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCustomerEditCancel_Click(object sender, EventArgs e)
        {
            pnlEdit.Visible = false;
            pnlCustomerEdit.Visible = false;
            txtFirstNameEdit.Clear();
            txtLastNameEdit.Clear();
            txtNumberEdit.Clear();

        }

        private void btnEmployeeSave_Click(object sender, EventArgs e)
        {
            Employee E = (Employee)listBox1.SelectedItem;
            E.FirstName = txtFirstNameEdit.Text;
            E.LastName = txtLastNameEdit.Text;
            E.PhoneNumber = txtNumberEdit.Text;
            E.Title = txtEmployeeTitleEdit.Text;
            E.Wage = txtEmployeeWageEdit.Text;
            pnlEdit.Visible = false;
            pnlEmployeeEdit.Visible = false;
        }

        private void btnEmployeeEditCancel_Click(object sender, EventArgs e)
        {
            pnlEdit.Visible = false;
            pnlCustomerEdit.Visible = false;
            txtFirstNameEdit.Clear();
            txtLastNameEdit.Clear();
            txtNumberEdit.Clear();
            txtEmployeeWageEdit.Clear();
            txtEmployeeTitleEdit.Clear();
        }

        public void txtClear() {
            txtFirstNameEdit.Clear();
            txtLastNameEdit.Clear();
            txtNumberEdit.Clear();
            txtEmployeeWageEdit.Clear();
            txtEmployeeTitleEdit.Clear();
            
        }
    }
}
