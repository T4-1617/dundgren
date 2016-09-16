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
        System.Collections.ArrayList Cars;

        public Form1()
        {
            InitializeComponent();
            Cars = new System.Collections.ArrayList();

            pnlShowCars.Visible = false;

            Cars.Add(new Car() { Make = "Volvo", Model = "V70", Color = "Brown", Rented = false });
            Cars.Add(new Car() { Make = "BMW", Model = "M2", Color = "Blue", Rented = false });
            Cars.Add(new Car() { Make = "Mercedes-Benz", Model = "A250", Color = "Red", Rented = false });        

        }

        private void ShowCars_Click(object sender, EventArgs e)
        {
            pnlShowCars.Visible = true;
            btnRent.Visible = false;

            foreach (var x in Cars)
            {
                if(x.GetType().Make)
                listShowCar.Items.Add(x);
                listShowCar.DisplayMember = "MakeAndModel";

            }

        }

        private void listShowCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRent.Visible = true;
            


        }
    }
}
