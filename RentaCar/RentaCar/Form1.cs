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
        System.Collections.ArrayList Cars;//Prepares the use of an arraylist called Cars
        int AvailableCars = 0;//Int for keeping track of unrented cars

        public Form1()
        {
            InitializeComponent();
            Cars = new System.Collections.ArrayList();//Initializes Arraylist
            pnlShowCars.Visible = false;//Hide panel
            pnlAddCar.Visible = false;//Hide panel
            pnlReturnCar.Visible = false;//Hide panel
            pnlRents.Visible = false;



            Cars.Add(new Car() { Make = "Volvo", Model = "V70", Color = "Brown", Rented = false });//Adds object type Car into ArrayList Cars and gives it property values
            Cars.Add(new Car() { Make = "BMW", Model = "M2", Color = "Blue", Rented = false });
            Cars.Add(new Car() { Make = "Mercedes-Benz", Model = "A250", Color = "Red", Rented = false });        

        }

        private void ShowCars_Click(object sender, EventArgs e)
        {
            listShowCar.Items.Clear();//Clears listbox for an update
            pnlShowCars.Visible = true;//Shows showcar-panel
            pnlInfo.Visible = false;//hides panel
            pnlAddCar.Visible = false;
            pnlReturnCar.Visible = false;
            pnlRents.Visible = false;

            AvailableCars = 0;//"Clears" car-counter for an update

            foreach (Car Item in Cars)//For every Object Car in the Arraylist Cars do the following:
            {
                if (!Item.Rented)//If Car.Rented is false do the following:
                {
                    listShowCar.Items.Add(Item);//Adds object to the list
                    AvailableCars++;//+1 to carcounter to keep track of available cars
                    
                }
            }

            CarsAvailable.Text = string.Format("We have {0} cars available!", AvailableCars);//Changes label-text.

        }

        private void listShowCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Car x = (Car)listShowCar.SelectedItem;//Creates variable out of chosen item.

            if (x != null)//if the created int is not empty do the following:
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
            x.Rented = true;//Changes value of a property of the chosen Item.
            x.CustomerName = txtCustomer.Text;
            listShowCar.Items.Clear();//Clears list for update
            pnlInfo.Visible = false;
            txtCustomer.Text = string.Empty;

            AvailableCars = 0;
            
            foreach (Car Item in Cars)
            {
                if (!Item.Rented)
                {
                    listShowCar.Items.Add(Item);
                    AvailableCars++;
                    

                }
            }

            CarsAvailable.Text = string.Format("We have {0} cars available!", AvailableCars);

        }

        private void AddCar_Click(object sender, EventArgs e)
        {
            pnlShowCars.Visible = false;
            pnlAddCar.Visible = true;
            pnlReturnCar.Visible = false;
            pnlRents.Visible = false;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cars.Add(new Car() { Make = txtMake.Text, Model = txtModel.Text, Color = txtColor.Text, Rented = false });
            txtMake.Text = String.Empty;//Clears text-box
            txtModel.Text = String.Empty;
            txtColor.Text = String.Empty;
            txtMake.Focus();//Focuses txtMake (top text-box)

        }

        private void ReturnCar_Click(object sender, EventArgs e)
        {
            listReturnCar.Items.Clear();
            pnlReturnCar.Visible = true;
            pnlShowCars.Visible = false;
            pnlAddCar.Visible = false;
            btnReturn.Visible = false;
            pnlRents.Visible = false;

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

            foreach (Car Item in Cars)
            {
                if (Item.Rented)
                {
                    listReturnCar.Items.Add(Item);
                }
            }

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

        private void btnRents_Click(object sender, EventArgs e)
        {
           
        }

        private void btnRents_Click_1(object sender, EventArgs e)
        {
            listRents.Items.Clear();
            pnlReturnCar.Visible = false;
            pnlShowCars.Visible = false;
            pnlAddCar.Visible = false;
            pnlRents.Visible = true;

            foreach (Car Item in Cars)
            {
                if (Item.Rented)
                {
                    listRents.Items.Add(string.Format("{0} has rented a {1} {2} {3}", Item.CustomerName, Item.Color, Item.Make, Item.Model));
                }
            }
        }

        private void listRentedCars_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listRents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
