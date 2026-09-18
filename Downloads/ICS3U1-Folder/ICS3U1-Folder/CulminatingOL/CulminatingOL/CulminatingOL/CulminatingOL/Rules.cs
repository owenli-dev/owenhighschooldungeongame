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
    public partial class Rules : Form
    {
        int intCurrentCoins = 0; //Stores the current coin amount
        public Rules(int intCoins = 0)
        {
            InitializeComponent();
            intCurrentCoins = intCoins; //makes sure the coin amount is stored
        }

        //Button functions
        private void btnReturnToTitle_Click(object sender, EventArgs e)
        {
            TitlePage TitlePage = new TitlePage(intCurrentCoins); //Initializes title page form
            this.Hide(); //Hides the form
            TitlePage.Show(); //Shows the title page
        } //Returns to the title page

        private void lblRulesTwo_Click(object sender, EventArgs e)
        {

        }
    }
}
