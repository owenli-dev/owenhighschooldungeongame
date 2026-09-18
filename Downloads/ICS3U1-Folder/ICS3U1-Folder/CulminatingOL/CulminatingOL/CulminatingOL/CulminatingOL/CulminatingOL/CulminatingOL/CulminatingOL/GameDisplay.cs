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
    public partial class GameDisplay : Form
    {
        int intUserCoins = 0; //The amount of coins the user has earned from dungeons
        int intDifficulty = 0; //The difficulty set by the user (1-easy, 2-medium, 3-hard)
        int intLevel = 0; //The level selected by the user (1-5)
        public GameDisplay(int intCoinsEarned)
        {
            InitializeComponent();
            this.pnlDifficulty.Visible = false; //difficulty panel hidden
            this.pnlLevelSelect.Visible = true; //level select panel shown
            this.lblCoinAmount.Text = intUserCoins.ToString(); //Displays the number of coins the user has
            intUserCoins = intUserCoins + intCoinsEarned;
        }
        private void btnTitlePage_Click(object sender, EventArgs e)
        {
            TitlePage TitlePage = new TitlePage(intUserCoins);
            this.Close(); //hides the game page
            TitlePage.Show(); //shows the title page
        } //returns to the title page
        private void btnLevelOne_Click(object sender, EventArgs e)
        {
            this.pnlDifficulty.Visible = true;
            intLevel = 1; //Level one
        }

        private void btnLevelTwo_Click(object sender, EventArgs e)
        {
            this.pnlDifficulty.Visible = true;
            intLevel = 2; //Level two
        }

        private void btnLevelThree_Click(object sender, EventArgs e)
        {
            this.pnlDifficulty.Visible = true;
            intLevel = 3; //Level three
        }

        private void btnLevelFour_Click(object sender, EventArgs e)
        {
            this.pnlDifficulty.Visible = true;
            intLevel = 4; //Level four
        }

        private void btnLevelFive_Click(object sender, EventArgs e)
        {
            this.pnlDifficulty.Visible = true;
            intLevel = 5; //Level five
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            intDifficulty = 1; //Sets easy difficulty
            MainGame MainGame = new MainGame(intDifficulty,intLevel); //Creates a new form
            this.Hide(); //hides the form
            MainGame.Show(); //Starts up the main game
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            intDifficulty = 2; //Sets medium difficulty
            MainGame MainGame = new MainGame(intDifficulty, intLevel); //Creates a new form
            this.Hide(); //hides the form
            MainGame.Show(); //Starts up the main game
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            intDifficulty = 3; //Sets hard difficulty
            MainGame MainGame = new MainGame(intDifficulty, intLevel); //Creates a new form
            this.Hide(); //hides the form
            MainGame.Show(); //Starts up the main game
        }
    }
}
