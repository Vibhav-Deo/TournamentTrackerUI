using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess;
using TrackerLibrary;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private void CreatePrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel prizeModel = new PrizeModel(
                PlaceNameTextBox.Text,
                PlaceNumberTextbox.Text,
                PrizePercentageTextBox.Text,
                PrizeAmountTextBox.Text);

                GlobalConfig.Connection.CreatePrize(prizeModel);

                PlaceNameTextBox.Text = "";
                PlaceNumberTextbox.Text = "";
                PrizePercentageTextBox.Text = "0";
                PrizeAmountTextBox.Text = "0";
            }
            else
            {
                MessageBox.Show("Please make sure the form has correct data");
            }
        }
        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;
            bool validPlaceNumber = int.TryParse(PlaceNumberTextbox.Text, out placeNumber);

            if (!validPlaceNumber || placeNumber < 1)
            {
                output = false;
            }

            if (PlaceNameTextBox.Text.Length == 0)
            {
                output = false;
            }

            decimal prizeAmount = 0;
            double prizePercentage = 0.0;

            bool validPrizeAmount = decimal.TryParse(PrizeAmountTextBox.Text, out prizeAmount);
            bool validPrizePercentage = double.TryParse(PrizePercentageTextBox.Text, out prizePercentage);

            if (!validPrizeAmount || !validPrizePercentage)
            {
                output = false;
            }

            if (prizeAmount <= 0 && prizePercentage <= 0)
            {
                output = false;
            }

            if (prizePercentage < 0 && prizePercentage > 100)
            {
                output = false;
            }
            return output;
        }
    }
}
