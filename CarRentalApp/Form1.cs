using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string customerName = tbCustomerName.Text;
                DateTime dateOut = dtRented.Value;
                DateTime dateIn = dtReturned.Value;
                var car = carType.Text;
                double cost = Convert.ToDouble(tbCost.Text);
                bool isValid = true;
                var errorMessage = "";

                if (string.IsNullOrEmpty(customerName) || string.IsNullOrWhiteSpace(car))
                {
                    isValid = false;

                  errorMessage += "Please enter missing data \n";

                }

                if (dateOut > dateIn)
                {
                    isValid = false;

                    errorMessage += "Please enter returned date later than rented date \n";
                }

                if (isValid)
                {
                    MessageBox.Show($"Thank you {customerName} for renting a {car} \n on date {dateIn} you have the car until {dateOut} \n your new cost is {cost} ");

                } else
                {
                    MessageBox.Show(errorMessage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            




        }
    }
}
