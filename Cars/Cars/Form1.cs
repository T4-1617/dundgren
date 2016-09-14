using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cars
{
    public partial class Form1 : Form
    {
        System.Collections.ArrayList MyCars = new System.Collections.ArrayList();

        public Form1()
        {
            InitializeComponent();

            //gömmer panelen
            panel1.Visible = false;
            //Skapar ett objekt(bil) och ger den värden till properties
            cars c = new cars() { name="Volvo V70", fuel="Gasoline", hp="170", price="300kr/h", seats="5"  };
            //Lägger till bilen i arraylisten
            MyCars.Add(c);
            //lägger till bilen i listan
            listBox1.Items.Add(c.name);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cars c = (cars)listBox1.SelectedItem;

            panel1.Visible = true;
            label1.Text = string.Format(" Reg: {0}\n Fuel: {1}\n Horsepowers: {2}\n Price: {3}\n Seats: {4}", c.name, c.fuel, c.hp, c.price, c.seats);
        }
    }
}
