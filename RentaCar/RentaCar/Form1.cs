using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentaCar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            System.Collections.ArrayList Cars = new System.Collections.ArrayList();



            Cars.Add(new Car() { Make = "Volvo", Model = "V70", Color = "Brown" });
            Cars.Add(new Car() { Make = "BMW", Model = "M2", Color = "Blue" });
            Cars.Add(new Car() { Make = "Mercedes-Benz", Model = "A250", Color = "Red" });
        }
    }
}
