using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CulminatingOL
{
    public partial class TitlePage : Form
    {
        int intTotalCoins = 0; //The total coins of the user
        static int intTotalMonsters = 0; //The total monsters the user has

        public TitlePage(int intCoins)
        {
            InitializeComponent();
            intTotalMonsters = monsterCount();
            intTotalCoins = intCoins; //Set the coins (don't add)
        }

        //Button functions
        private void btnRules_Click(object sender, EventArgs e)
        {
            Rules Rules = new Rules(intTotalCoins);
            this.Hide(); //hides the title page
            Rules.Show(); //shows the rules page
        } //Opens up the rules and shows the rules of the game

        private void btnPlayGame_Click(object sender, EventArgs e)
        {
            GameDisplay GameDisplay = new GameDisplay(0, intTotalCoins); //Pass current coins to sync
            this.Hide();
            GameDisplay.Show(); //starts the game
        } //Opens the game display up

        private void btnExitGame2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for playing my game!"); //Shows exit message
            Application.Exit(); //Exits the application
        } //Exits the game

        private void btnExitGame_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for playing my game!"); //Shows exit message
            Application.Exit(); //Exits the application
        } //Exits the game

        private void btnSpinMonster_Click(object sender, EventArgs e)
        {
            DragonSpin DragonSpin = new DragonSpin(intTotalCoins, intTotalMonsters);
            this.Hide();
            DragonSpin.Show(); //shows the dragon spinning application
        } //Loads up the spin monster form

        private void btnBall_Click(object sender, EventArgs e)
        {
            FunBall Funball = new FunBall(intTotalCoins);
            this.Hide();
            Funball.Show();
        } //open the funball activity

        private void btnRandomNumberSorter_Click(object sender, EventArgs e)
        {
            Sorter Sorter = new Sorter(intTotalCoins);
            this.Hide();
            Sorter.Show();
        } //loaded up the random number generator program
        //Loads up all the monsters previously saved in the game
        public int monsterCount()
        {
            string strInput = null; //The line input in the created file
            int intMonsters = 0; //Number of monsters the user has
            StreamReader Re = File.OpenText("monsterholder.txt"); //Opens the old monster file reader to read monsters
            //Adding the number of monsters depending on the amount of monsters in the monster holder file
            while ((strInput = Re.ReadLine()) != null)
            {
                intMonsters++;
            }
            Re.Close(); //Close the reader
            return intMonsters;
        } //counts the number of monsters

       
    }
}