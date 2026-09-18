using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CulminatingOL
{
    public partial class Sorter : Form
    {
        int intUserCoins = 0; //The amount of coins the user has saved
        int[] intNumbers, intTemp, intTopFive = new int[5]; //Number arrays to hold the values, top five as well
        Random rndGen = new Random(); //Random number generator
        int intIndexNumber = 0; //Index number 
        int intSize = 1; //Size of the array
        int intCurrentNumber = 0; //The current number generated
        bool blnFirstNumber = true; //Tracks if this is the first number generated

        public Sorter(int intCoins)
        {
            InitializeComponent();
            intUserCoins = intCoins; //Saves the number of coins in the form
            InitializeTopFive(); //Initialize the top five array
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            TitlePage TitlePage = new TitlePage(intUserCoins);
            this.Hide();
            TitlePage.Show();
        } //exits back to the title page

        private void btnRules_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Press the New Number button to get a new number.\n" +
                "It will show you what number you have selected.\n" +
                "If the number is one of the highest five numbers you have achieved, it will automatically sort itself into the highest possible position."); //outlines the rules
        } //outlines how to run the program

        private void btnNumber_Click(object sender, EventArgs e)
        {
            intCurrentNumber = rndGen.Next(1, 1000001); //Generate random number from 1 to 1mil
            this.lblGeneratedNumber.Text = intCurrentNumber.ToString(); //Displays the chosen number
            if (blnFirstNumber == true)
            {
                intTopFive[0] = intCurrentNumber; //Put first number in first position
                blnFirstNumber = false; //No longer the first number
            }
            else
            {
                CheckAndSortNumber(intCurrentNumber); //Check if number belongs in top five and sort it
            }

            DisplayTopFive(); //Display the current top five numbers
        } //generates a new number

        //Functions
        private void InitializeTopFive()
        {
            for (int i= 0; i < 5; i++)
            {
                intTopFive[i] = 0; //Initialize all positions to 0
            }
        } //initializes the top five array with zeros

        private void CheckAndSortNumber(int intNewNumber)
        {
            //Check if the new number should replace the smallest number in top five
            if (intNewNumber > intTopFive[4] || intTopFive[4] == 0)
            {
                intTopFive[4] = intNewNumber; //Replace the smallest number (or empty slot)
                BubbleSortTopFive(); //Sort the array using bubble sort
            }
        } //checks if the new number belongs in the top five

        private void BubbleSortTopFive()
        {
            int intTemp = 0; //Temporary variable for swapping
            bool blnSwapped = true; //Flag to track if any swaps were made

            //Continue sorting until no swaps are made
            while (blnSwapped == true)
            {
                blnSwapped = false; //Reset swap flag

                //Go through the array and compare adjacent elements
                for (int i = 0; i< 4; i++)
                {
                    //If current number is smaller than next number, swap them (descending order)
                    if (intTopFive[i] < intTopFive[i+1])
                    {
                        intTemp = intTopFive[i]; //Store current element
                        intTopFive[i] = intTopFive[i+1]; //Move larger element forward
                        intTopFive[i+1] = intTemp; //Place smaller element back
                        blnSwapped = true; //Mark that a swap was made
                    }
                }
            }
        } //sorts the top five array in descending order using bubble sort

        private void DisplayTopFive()
        {
            //Update the labels with the top five numbers
            if (intTopFive[0] > 0)
            {
                this.lblFirstNumber.Text = intTopFive[0].ToString();
            }
            else
            {
                this.lblFirstNumber.Text = "---";
            }

            if (intTopFive[1] > 0)
            {
                this.lblSecondNumber.Text = intTopFive[1].ToString();
            }
            else
            {
                this.lblSecondNumber.Text = "---";
            }

            if (intTopFive[2] > 0)
            {
                this.lblThirdNumber.Text = intTopFive[2].ToString();
            }
            else
            {
                this.lblThirdNumber.Text = "---";
            }

            if (intTopFive[3] > 0)
            {
                this.lblFourthNumber.Text = intTopFive[3].ToString();
            }
            else
            {
                this.lblFourthNumber.Text = "---";
            }

            if (intTopFive[4] > 0)
            {
                this.lblFifthNumber.Text = intTopFive[4].ToString();
            }
            else
            {
                this.lblFifthNumber.Text = "---";
            }
        } //displays the top five numbers in the labels
    }
}