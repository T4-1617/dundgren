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
        int i = 0;

        public Form1()
        {
            InitializeComponent();
            Cars = new System.Collections.ArrayList();

            pnlShowCars.Visible = false;
            pnlAddCar.Visible = false;
            pnlReturnCar.Visible = false;



            Cars.Add(new Car() { Make = "Volvo", Model = "V70", Color = "Brown", Rented = false });
            Cars.Add(new Car() { Make = "BMW", Model = "M2", Color = "Blue", Rented = false });
            Cars.Add(new Car() { Make = "Mercedes-Benz", Model = "A250", Color = "Red", Rented = false });        

        }

        private void ShowCars_Click(object sender, EventArgs e)
        {
            listShowCar.Items.Clear();
            pnlShowCars.Visible = true;
            pnlInfo.Visible = false;
            pnlAddCar.Visible = false;
            pnlReturnCar.Visible = false;

            i = 0;

            foreach (Car Item in Cars)
            {
                if (!Item.Rented)
                {
                    listShowCar.Items.Add(Item);
                    
                    i++;
                    
                }
            }

            CarsAvailable.Text = string.Format("We have {0} cars available!", i);

        }

        private void listShowCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Car x = (Car)listShowCar.SelectedItem;

            if (x != null)
            {
                pnlInfo.Visible = true;
                lblMake.Text = x.Make;
                lblModel.Text = x.Model;
                lblColor.Text = x.Color;
            }
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            Car x = (Car)listShowCar.SelectedItem;
            x.Rented = true;
            listShowCar.Items.Clear();
            pnlInfo.Visible = false;

            i = 0;
            
            foreach (Car Item in Cars)
            {
                if (!Item.Rented)
                {
                    listShowCar.Items.Add(Item);
                    i++;
                    

                }
            }

            CarsAvailable.Text = string.Format("We have {0} cars available!", i);

        }

        private void AddCar_Click(object sender, EventArgs e)
        {
            pnlShowCars.Visible = false;
            pnlAddCar.Visible = true;
            pnlReturnCar.Visible = false;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cars.Add(new Car() { Make = txtMake.Text, Model = txtModel.Text, Color = txtColor.Text, Rented = false });
            txtMake.Text = String.Empty;
            txtModel.Text = String.Empty;
            txtColor.Text = String.Empty;
            txtMake.Focus();

        }

        private void ReturnCar_Click(object sender, EventArgs e)
        {
            pnlReturnCar.Visible = true;
            pnlShowCars.Visible = false;
            pnlAddCar.Visible = false;
            btnReturn.Visible = false;

            foreach (Car Item in Cars)
            {
                if (Item.Rented)
                {
                    listReturnCar.Items.Add(Item);
                }
            }

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Car x = (Car)listReturnCar.SelectedItem;
            x.Rented = false;
            listReturnCar.Items.Clear();
            btnReturn.Visible = false;

        }

        private void listReturnCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            Car x = (Car)listReturnCar.SelectedItem;

            if(x != null)
            {
                btnReturn.Visible = true;
            }
        }

        private void CarsAvailable_Click(object sender, EventArgs e)
        {

        }
    }
}
