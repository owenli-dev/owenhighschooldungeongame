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
    public partial class DragonSpin : Form
    {
        int intSpinCoins = 0;
        int intLeftOver = 0;
        int intMonsters = 0;
        Random rndGen = new Random(); //Random number generator for the monsters
        int intSelected = 0; //Selected monster (1-common, 2-rare, 3-legendary,4-godly, 5-secret)
        string[] strMonsters = new string[40000000]; //Holds however many monsters the user chooses to spin 
        int intIndexNumber = 0; //The index number that the user spins (resets to 0 after exiting) 
        public DragonSpin(int intCoins, int intVal)
        {
            InitializeComponent();
            intSpinCoins += intCoins; //setting variables for coins and number of monsters
            intMonsters = intVal;
            this.lblRemainingCoins.Text = intSpinCoins.ToString();
        }

        private void btnTitlePage_Click(object sender, EventArgs e)
        {
            writeSpunMonsters(); //Save all spun monsters to file
            strMonsters = new string[40000000]; //Resets the array
            TitlePage TitlePage = new TitlePage(intLeftOver);
            intIndexNumber = 0; //Resets index number
            this.Hide();
            TitlePage.Show(); //Shows the title page
        } //returns back to game title page

        private void btnSpinButton_Click(object sender, EventArgs e)
        {
            if (intSpinCoins < 50 && intMonsters != 0)
            {
                MessageBox.Show("You do not have enough coins to spin!");
            } //Invalid/insufficient amount
            else if (intSpinCoins >= 50 || intMonsters == 0)
            {
                if (intMonsters != 0) //Run only if the person has no monsters
                {
                    intSpinCoins -= 50;//Subtract 50 coins from spin
                }
                this.lblRemainingCoins.Text = intSpinCoins.ToString(); //Shows remaining amount of coins left
                intSelected = rndGen.Next(1, 10001); //selects a random number from 1-10000
                if (intSelected == 1) //secret roll
                {
                    this.lblSpunMonster.Text = "Sania"; //changes text + color + image
                    this.lblSpunMonster.ForeColor = Color.Purple;
                    this.pcbResult.BackgroundImage = MonsterImages.sania;
                    strMonsters[intIndexNumber] = "Sania"; //secret monster is pulled
                    intIndexNumber++;
                    intMonsters++;
                }
                else if (intSelected <=50) //godly roll
                {
                    this.lblSpunMonster.Text = "Doveria"; //changes text + color + image
                    this.lblSpunMonster.ForeColor = Color.Yellow;
                    this.pcbResult.BackgroundImage = MonsterImages.doveria;
                    strMonsters[intIndexNumber] = "Doveria"; //godly monster is pulled
                    intIndexNumber++;
                    intMonsters++;
                }
                else if (intSelected <=250) //legendary roll
                {
                    this.lblSpunMonster.Text = "Tellaria"; //changes text + color + image
                    this.lblSpunMonster.ForeColor = Color.Red;
                    this.pcbResult.BackgroundImage = MonsterImages.tellaria;
                    strMonsters[intIndexNumber] = "Tellaria"; //legendary monster is pulled
                    intIndexNumber++;
                    intMonsters++;
                }
                else if (intSelected <=3750) //rare roll
                {
                    this.lblSpunMonster.Text = "Falacia"; //changes text + color + image
                    this.lblSpunMonster.ForeColor = Color.Cyan;
                    this.pcbResult.BackgroundImage = MonsterImages.fallacia;
                    strMonsters[intIndexNumber] = "Falacia"; //rare monster is pulled
                    intIndexNumber++;
                    intMonsters++;
                }
                else if (intSelected <=10000) //common roll
                {
                    this.lblSpunMonster.Text = "Exparia"; //changes text + color + image
                    this.lblSpunMonster.ForeColor = Color.Green;
                    this.pcbResult.BackgroundImage = MonsterImages.exparia;
                    strMonsters[intIndexNumber] = "Exparia"; //common monster is pulled
                    intIndexNumber++;
                    intMonsters++;
                }
            }



        }
        public void writeSpunMonsters()
        {
            FileInfo SpunMonster = new FileInfo("monsterholder.txt");
            StreamWriter Tex = SpunMonster.AppendText(); //Appends to existing monsters instead of overriding

            for (int i = 0; i < intIndexNumber; i++)
            {
                Tex.WriteLine(strMonsters[i]); //Writes each spun monster to the file
            }

            Tex.Close(); //Close the writer
        } //adds the spun monsters to the existing monster holder text file
    }
}
