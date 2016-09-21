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

            Peeplist.Add(new Customer() { FirstName = "Daniel", LastName = "Lundgren", CustomerId = 1, PhoneNumber = 0702324562 });
            Peeplist.Add(new Customer() { FirstName = "Sebbe", LastName = "Kullander", CustomerId = 2, PhoneNumber = 0762524644 });

            Peeplist.Add(new Employee() { FirstName = "Steven", LastName = "Bergqvist", EmployeeId = 1, PhoneNumber = 0705326247, Title = "CEO", Wage = "40.000kr" });
            Peeplist.Add(new Employee() { FirstName = "Kent", LastName = "Konradsson", EmployeeId = 2, PhoneNumber = 0707217129, Title = "Mekaniker", Wage = "24.392kr" });

            Peeplist.Add(new Supplier() { FirstName = "Snorre", LastName = "Sturesson", Company = "MotorikAB", PhoneNumber = 0762515273 });

            pnlEmployee.Visible = false;
            pnlSupplier.Visible = false;


            foreach  (var Customer in Peeplist)
            {
                listBox1.Items.Add(Customer);
            }

           

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ComboPeople_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ComboPeople.Text)
            {

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
                    pnlCustomer.Visible = true;
                    pnlEmployee.Visible = false;
                    pnlSupplier.Visible = false;
                    break;
            }

        }
    }
}
