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
        public Rules()
        {
            InitializeComponent();
        }

        //Button functions
        private void btnReturnToTitle_Click(object sender, EventArgs e)
        {
            TitlePage TitlePage = new TitlePage(0); //Initializes title page form
            this.Hide(); //Hides the form
            TitlePage.Show(); //Shows the title page
        } //Returns to the title page
    }
}
