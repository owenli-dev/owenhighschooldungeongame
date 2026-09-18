using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CulminatingOL
{
    public partial class MainGame : Form
    {
        string strMonster = ""; //The monster the user selects
        int intCoinsCollected = 0; //The number of coins collected by the user (random amount for winning, random amount for losing)
        Random rndGen = new Random(); //Random number generator for the game
        int intDamage = 0; //Damage dealt by the monster
        public MainGame(int intDifficulty, int intLevel)
        {
            InitializeComponent();
        }

        private void btnExparia_Click(object sender, EventArgs e)
        {
            strMonster = "Exparia";
            collectedMonster(strMonster); //Runs function to check if monster is collected
            if (collectedMonster(strMonster) == false) //If not collected
            {
                MessageBox.Show("You do not have this monster."); //Show message that invalid alert is detected
            }
            else
            {
                this.pnlMonsterSelect.Visible = false; //Hides the monster select panel
            }
            this.btnAttack1.Text = "Star Blast"; //Sets the three unique attacks of the monster
            this.btnAttack2.Text = "Supernova";
            this.btnAttack3.Text = "Crescent Moon";
        } //Common monster Exparia selected

        private void btnFalacia_Click(object sender, EventArgs e)
        {
            strMonster = "Falacia";
            collectedMonster(strMonster); //Runs function to check if monster is collected
            if (collectedMonster(strMonster) == false) //If not collected
            {
                MessageBox.Show("You do not have this monster."); //Show message that invalid alert is detected
            }
            else
            {
                this.pnlMonsterSelect.Visible = false; //Hides the monster select panel
            }
            this.btnAttack1.Text = "Colossal Crusher"; //Sets the three unique attacks of the monster
            this.btnAttack2.Text = "Taparova";
            this.btnAttack3.Text = "Winter Sunshine";
        } //Rare monster Falacia selected

        private void btnTellaria_Click(object sender, EventArgs e)
        {
            strMonster = "Tellaria";
            collectedMonster(strMonster); //Runs function to check if monster is collected
            if (collectedMonster(strMonster) == false) //If not collected
            {
                MessageBox.Show("You do not have this monster."); //Show message that invalid alert is detected
            }
            else
            {
                this.pnlMonsterSelect.Visible = false; //Hides the monster select panel
            }
            this.btnAttack1.Text = "Smokescreen"; //Sets the three unique attacks of the monster
            this.btnAttack2.Text = "Skull Crusher";
            this.btnAttack3.Text = "Explosive Death";
        } //Legendary monster Tellaria selected

        private void btnDoveria_Click(object sender, EventArgs e)
        {
            strMonster = "Doveria";
            collectedMonster(strMonster); //Runs function to check if monster is collected
            if (collectedMonster(strMonster) == false) //If not collected
            {
                MessageBox.Show("You do not have this monster."); //Show message that invalid alert is detected
            }
            else
            {
                this.pnlMonsterSelect.Visible = false; //Hides the monster select panel
            }
            this.btnAttack1.Text = "Heavenly Spiral"; //Sets the three unique attacks of the monster
            this.btnAttack2.Text = "Tornado Spike";
            this.btnAttack3.Text = "God's Will";
        } //Godly monster Doveria selected

        private void btnSania_Click(object sender, EventArgs e)
        {
            strMonster = "Sania";
            collectedMonster(strMonster); //Runs function to check if monster is collected
            if (collectedMonster(strMonster) == false) //If not collected
            {
                MessageBox.Show("You do not have this monster."); //Show message that invalid alert is detected
            }
            else
            {
                this.pnlMonsterSelect.Visible = false; //Hides the monster select panel
            }
            this.btnAttack1.Text = "The Kill."; //Sets the three unique attacks of the monster
            this.btnAttack2.Text = "Night Falls.";
            this.btnAttack3.Text = "Destruction.";
        } //Secret monster Sania selected
        private void btnExitGame_Click(object sender, EventArgs e)
        {
            GameDisplay GameDisplay = new GameDisplay(intCoinsCollected); //initializes designer
            intCoinsCollected = 0; //No coins collected
            this.Hide(); //Hides the game display
            GameDisplay.Show(); //Shows the game display design page

        } //exits the game



        //Functions
        public bool collectedMonster(string strMonster)
        {
            StreamReader Re = File.OpenText("monsterholder.txt"); //Opens the old monster file reader to read monsters
            string strInput = null; //Sets input to null
            bool blnCondition = false; //Assumes the person has not collected the monster
            while ((strInput = Re.ReadLine()) != null)
            {
                if (strInput == strMonster)
                {
                    blnCondition = true; //monster does exist, assumes true value
                    break;
                }
            }
            return blnCondition; //returns the true or false statement
        }

        private void btnAttack1_Click(object sender, EventArgs e)
        {
            if (strMonster == "Exparia") //If the common monster is chosen
            {

            }
            else if (strMonster == "Falacia") //If the rare monster is chosen
            {

            }
            else if (strMonster == "Tellaria") //If the legendary monster is chosen
            {

            }
            else if (strMonster == "Doveria") //If the godly monster is chosen
            {

            }
            else if (strMonster == "Sania") //If the ???/secret mosnter is chosen
            {

            }
        }

        private void btnAttack2_Click(object sender, EventArgs e)
        {
            if (strMonster == "Exparia") //If the common monster is chosen
            {

            }
            else if (strMonster == "Falacia") //If the rare monster is chosen
            {

            }
            else if (strMonster == "Tellaria") //If the legendary monster is chosen
            {

            }
            else if (strMonster == "Doveria") //If the godly monster is chosen
            {

            }
            else if (strMonster == "Sania") //If the ???/secret mosnter is chosen
            {

            }
        }

        private void btnAttack3_Click(object sender, EventArgs e)
        {
            if (strMonster == "Exparia") //If the common monster is chosen
            {

            }
            else if (strMonster == "Falacia") //If the rare monster is chosen
            {

            }
            else if (strMonster == "Tellaria") //If the legendary monster is chosen
            {

            }
            else if (strMonster == "Doveria") //If the godly monster is chosen
            {

            }
            else if (strMonster == "Sania") //If the ???/secret mosnter is chosen
            {

            }
        }
    }
}
