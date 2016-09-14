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
            cars c = new cars() { name="Volvo", fuel="Gasoline", hp="170", price="300kr/h", seats="5"  };
            cars d = new cars() { name = "BMW", fuel = "Magic", hp = "2000", price = "?kr/h", seats = "5" };
            cars e = new cars() { name = "Mazda", fuel = "Electricity", hp = "150", price = "200kr/h", seats = "5" };
            cars f = new cars() { name = "Mercedes-Benz", fuel = "Gasoline", hp = "200", price = "250kr/h", seats = "5" };
            cars g = new cars() { name = "Audi", fuel = "Diesel", hp = "300", price = "500kr/h", seats = "7" };
            //Lägger till bilen i arraylisten
            MyCars.Add(c);
            MyCars.Add(d);
            MyCars.Add(e);
            MyCars.Add(f);
            MyCars.Add(g);
            //lägger till bilen i listan
            listBox1.Items.Add(c.name);
            listBox1.Items.Add(d.name);
            listBox1.Items.Add(e.name);
            listBox1.Items.Add(f.name);
            listBox1.Items.Add(g.name);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Vald bil visar panel och textbox med properties
            cars x = (cars)MyCars[listBox1.SelectedIndex];

            panel1.Visible = true;
            textBox1.Text = string.Format("{0}", x.fuel);
            textBox2.Text = string.Format("{0}", x.hp);
            textBox3.Text = string.Format("{0}", x.price);
            textBox4.Text = string.Format("{0}", x.seats);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //stänger av readonly så att man kan redigera
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = false;
            textBox4.ReadOnly = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cars x = (cars)MyCars[listBox1.SelectedIndex];
            //vald bil ändrar värdet på property med textbox-värdet
            x.fuel = textBox1.Text;
            x.hp = textBox2.Text;
            x.price = textBox3.Text;
            x.price = textBox4.Text;
            //sätter på readonly
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //sätter på readonly och gömmer panelen
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            panel1.Visible = false;

        }
    }
}
