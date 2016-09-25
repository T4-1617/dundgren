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
        int CustomerCounter;
        int EmployeeCounter;
        int SupplierCounter;

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

            WriteListBox();


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Peeps x = (Peeps)listBox1.SelectedItem;

            //Att göra: kolla att selecteditem TYPE är en peeps, annars avbryt
            if ( x != null)
            {
                txtFirstNameEdit.Text = x.FirstName;
                txtLastNameEdit.Text = x.LastName;
                txtNumberEdit.Text = x.PhoneNumber;


                switch (x.GetType().Name)
                {
                    case "Customer":
                        //Alt
                        Customer C = (Customer)x;

                        pnlEdit.Visible = true;
                        pnlCustomerEdit.Visible = true;
                        pnlEmployeeEdit.Visible = false;
                        pnlSupplierEdit.Visible = false;
                        txtCustomerId.Text = Convert.ToString(C.CustomerId);
                        break;

                    case "Employee":
                        Employee E = (Employee)x;
                        pnlEdit.Visible = true;
                        pnlCustomerEdit.Visible = false;
                        pnlEmployeeEdit.Visible = true;
                        pnlSupplierEdit.Visible = false;
                        txtEmployeeTitleEdit.Text = E.Title;
                        txtEmployeeWageEdit.Text = E.Wage;
                        txtEmployeeId.Text = Convert.ToString(E.EmployeeId);
                        break;

                    case "Supplier":
                        Supplier S = (Supplier)x;
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
        }

        private void ComboPeople_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ComboPeople.Text)
            {

                case "Kund":
                    //Exempel på refactoring
                    UpdatePanels(true, false, false);

                    //pnlCustomer.Visible = true;
                    //pnlEmployee.Visible = false;
                    //pnlSupplier.Visible = false;
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

        private void UpdatePanels(bool ShowCustomerPanel, bool ShowEmployeePanel, bool ShowSupplierPanel)
        {
            pnlCustomer.Visible = ShowCustomerPanel;
            pnlEmployee.Visible = ShowEmployeePanel;
            pnlSupplier.Visible = ShowSupplierPanel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCustomerFirstName.Text == string.Empty || txtCustomerLastName.Text == string.Empty || txtCustomerPhoneNumber.Text == string.Empty)
            {
                MessageBox.Show("Fyll i all information!");
            }
            else
            {
                Peeplist.Add(new Customer() { FirstName = txtCustomerFirstName.Text, LastName = txtCustomerLastName.Text, CustomerId = CustomerCounter, PhoneNumber = txtCustomerPhoneNumber.Text });
                WriteListBox();
                txtClear();
            }

        }

        private void btnEmployeeAdd_Click(object sender, EventArgs e)
        {
            if (txtEmployeeFirstName.Text == string.Empty || txtEmployeeLastName.Text == string.Empty || txtEmployeePhoneNumber.Text == string.Empty || txtEmployeeTitle.Text == string.Empty || txtEmployeeWage.Text == string.Empty)
            {
                MessageBox.Show("Fyll i all information!");
            }
            else
            {
                Peeplist.Add(new Employee() { FirstName = txtEmployeeFirstName.Text, LastName = txtEmployeeLastName.Text, EmployeeId = EmployeeCounter, PhoneNumber = txtEmployeePhoneNumber.Text, Title = txtEmployeeTitle.Text, Wage = txtEmployeeWage.Text });
                WriteListBox();
                txtClear();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtSupplierFirstName.Text == string.Empty || txtSupplierLastName.Text == string.Empty || txtSupplierPhoneNumber.Text == string.Empty || txtCompanyName.Text == string.Empty)
            {
                MessageBox.Show("Fyll i all information!");
            }

            else
            {
                Peeplist.Add(new Supplier() { FirstName = txtSupplierFirstName.Text, LastName = txtSupplierLastName.Text, PhoneNumber = txtSupplierPhoneNumber.Text, Company = txtCompanyName.Text });
                WriteListBox();
                txtClear();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            hidePanels();
            txtClear();
        }

        private void btnEmployeeCancel_Click(object sender, EventArgs e)
        {
            txtClear();
            hidePanels();
        }

        private void btnSupplierCancel_Click(object sender, EventArgs e)
        {
            txtClear();
            hidePanels();
        }

        private void btnCustomerSave_Click(object sender, EventArgs e)
        {
            Peeps x = (Peeps)listBox1.SelectedItem;
            x.FirstName = txtFirstNameEdit.Text;
            x.LastName = txtLastNameEdit.Text;
            x.PhoneNumber = txtNumberEdit.Text;
            hidePanels();
            WriteListBox();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCustomerEditCancel_Click(object sender, EventArgs e)
        {
            hidePanels();
            txtClear();
        }

        private void btnEmployeeSave_Click(object sender, EventArgs e)
        {
            Employee E = (Employee)listBox1.SelectedItem;
            E.FirstName = txtFirstNameEdit.Text;
            E.LastName = txtLastNameEdit.Text;
            E.PhoneNumber = txtNumberEdit.Text;
            E.Title = txtEmployeeTitleEdit.Text;
            E.Wage = txtEmployeeWageEdit.Text;
            hidePanels();
            WriteListBox();
        }

        private void btnEmployeeEditCancel_Click(object sender, EventArgs e)
        {
            hidePanels();
            txtClear();
        }

        public void txtClear()
        {
            txtFirstNameEdit.Clear();
            txtLastNameEdit.Clear();
            txtNumberEdit.Clear();
            txtEmployeeWageEdit.Clear();
            txtEmployeeTitleEdit.Clear();
            txtSupplierNameEdit.Clear();
            txtCustomerFirstName.Clear();
            txtCustomerLastName.Clear();
            txtCustomerPhoneNumber.Clear();
            txtCompanyName.Clear();
            txtSupplierFirstName.Clear();
            txtSupplierLastName.Clear();
            txtSupplierPhoneNumber.Clear();
            txtEmployeeFirstName.Clear();
            txtEmployeeLastName.Clear();
            txtEmployeePhoneNumber.Clear();
            txtEmployeeTitle.Clear();
            txtEmployeeWage.Clear();
            txtCustomerFirstName.Clear();
            txtCustomerLastName.Clear();
            txtCustomerPhoneNumber.Clear();
        }

        public void hidePanels()
        {
            pnlCustomerEdit.Visible = false;
            pnlEmployeeEdit.Visible = false;
            pnlSupplierEdit.Visible = false;
            pnlEdit.Visible = false;
            pnlCustomer.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Supplier S = (Supplier)listBox1.SelectedItem;
            S.FirstName = txtFirstNameEdit.Text;
            S.LastName = txtLastNameEdit.Text;
            S.PhoneNumber = txtNumberEdit.Text;
            S.Company = txtSupplierNameEdit.Text;
            hidePanels();
            txtClear();
            WriteListBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hidePanels();
            txtClear();
        }

        public void WriteListBox()
        {

            CustomerCounter = 0;
            EmployeeCounter = 0;
            SupplierCounter = 0;

            listBox1.Items.Clear();
            listBox1.Items.Add("Customers");
            foreach (Peeps item in Peeplist)
            {
                if (item is Customer)
                {
                    listBox1.Items.Add(item);
                    CustomerCounter++;
                }
            }

            listBox1.Items.Add(string.Empty);
            listBox1.Items.Add("\nEmployees");

            foreach (Peeps item in Peeplist)
            {
                if (item is Employee)
                {
                    listBox1.Items.Add(item);
                    EmployeeCounter++;
                }
            }

            listBox1.Items.Add(string.Empty);
            listBox1.Items.Add("\nSuppliers");

            foreach (Peeps item in Peeplist)
            {
                if (item is Supplier)
                {
                    listBox1.Items.Add(item);
                    SupplierCounter++;
                }

            }
            lblCounter.Text = string.Format("Det finns {0} Kunder, {1} Anställda och {2} Leverantörer registrerade!", CustomerCounter, EmployeeCounter, SupplierCounter);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
