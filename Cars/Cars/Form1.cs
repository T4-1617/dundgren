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
            Car c = new Car() { name="Volvo V70", fuel="Gasoline", hp="170", price="200.000kr", seats="5"  };
            //Lägger till bilen i arraylisten
            MyCars.Add(c);
            //lägger till bilen i listan
            listBox1.Items.Add(c);
        }
    }
}
