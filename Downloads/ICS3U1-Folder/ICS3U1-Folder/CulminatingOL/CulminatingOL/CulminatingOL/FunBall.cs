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
    public partial class FunBall : Form
    {
        int intUserCoins = 0; //The amount of coins that the user has earned so far
        Random rndGen = new Random(); //Random number generator
        int intDirection = 1; //Direction variable moved to class level
        double dblTime = 0; //Time parameter for math functions
        int intVerticalDirection = 1; //1 = down, -1 = up (for bouncing)

        public FunBall(int intCoins)
        {
            InitializeComponent();
            intUserCoins = intCoins; //Saves the number of coins that the user has earned
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            TitlePage TitlePage = new TitlePage(intUserCoins);
            this.Hide();
            TitlePage.Show();
        } //Exits back to the titlepage

        private void btnStartBall_Click(object sender, EventArgs e)
        {
            this.tmrMove.Enabled = true; //Starts the ball movement
            intDirection = 1; //Reset to moving right
            dblTime = 0; //Reset time
            intVerticalDirection = 1; //Reset vertical direction
        } //starts the timer for the ball to move

        private void tmrMove_Tick(object sender, EventArgs e)
        {
            int intHolder = 0; //Holds a random value to determine random direction

            if (intDirection == 1) //Sends the ball going straight right
            {
                if (this.pcbBall.Left > this.Width - this.pcbBall.Width)
                {
                    intHolder = rndGen.Next(1, 3); //random number from 1 to 2 (straight motion, zigzag motion)
                    if (intHolder == 1)
                    {
                        intDirection = 2; //Sends the ball straight left
                    }
                    else if (intHolder == 2)
                    {
                        intDirection = 3; //Sends the ball zigzagging left
                        dblTime = 0; //Reset time for zigzag
                    }
                }
                else
                {
                    this.pcbBall.Left += 3; //moves the ball right (slower)
                }
            }
            else if (intDirection == 2) //Sends the ball going straight left
            {
                if (this.pcbBall.Left < 0)
                {
                    intHolder = rndGen.Next(1, 3); //random number from 1 to 2 (straight motion, zigzag motion)
                    if (intHolder == 1)
                    {
                        intDirection = 1; //Sends the ball straight right
                    }
                    else if (intHolder == 2)
                    {
                        intDirection = 4; //Sends the ball zigzagging right
                        dblTime = 0; //Reset time for zigzag
                    }
                }
                else
                {
                    this.pcbBall.Left -= 3; //moves the ball left (slower)
                }
            }
            else if (intDirection == 3) //zigzag going left
            {
                if (this.pcbBall.Left < 0)
                {
                    intHolder = rndGen.Next(1, 3); //random number from 1 to 2 (straight motion, zigzag motion)
                    if (intHolder == 1)
                    {
                        intDirection = 2; //Sends the ball straight left
                    }
                    else if (intHolder == 2)
                    {
                        intDirection = 3; //Sends the ball zigzagging left
                        dblTime = 0; //Reset time
                    }
                }
                else
                {
                    this.pcbBall.Left += zigzagHorizontal(); //Move horizontally (left)
                    this.pcbBall.Top += zigzagVertical() * intVerticalDirection; //Move vertically with bounce

                    //Check top and bottom boundaries for zigzag - bounce off them
                    if (this.pcbBall.Top <= 0)
                    {
                        intVerticalDirection = 1; //Change to downward movement
                        this.pcbBall.Top = 1; //Move ball slightly away from edge
                    }
                    else if (this.pcbBall.Top >= this.Height - this.pcbBall.Height)
                    {
                        intVerticalDirection = -1; //Change to upward movement
                        this.pcbBall.Top = this.Height - this.pcbBall.Height - 1; //Move ball slightly away from edge
                    }

                    dblTime += 0.2; //Increment time for zigzag function (slower)
                }
            }
            else if (intDirection == 4) //zigzag going right
            {
                if (this.pcbBall.Left > this.Width - this.pcbBall.Width)
                {
                    intHolder = rndGen.Next(1, 3); //random number from 1 to 2
                    if (intHolder == 1)
                    {
                        intDirection = 1; //Sends the ball straight right
                    }
                    else if (intHolder == 2)
                    {
                        intDirection = 4; //Continue zigzagging right
                        dblTime = 0; //Reset time
                    }
                }
                else
                {
                    this.pcbBall.Left -= zigzagHorizontal(); //Move horizontally (right)
                    this.pcbBall.Top += zigzagVertical() * intVerticalDirection; //Move vertically with bounce

                    //Check top and bottom boundaries for zigzag - bounce off them
                    if (this.pcbBall.Top <= 0)
                    {
                        intVerticalDirection = 1; //Change to downward movement
                        this.pcbBall.Top = 1; //Move ball slightly away from edge
                    }
                    else if (this.pcbBall.Top >= this.Height - this.pcbBall.Height)
                    {
                        intVerticalDirection = -1; //Change to upward movement
                        this.pcbBall.Top = this.Height - this.pcbBall.Height - 1; //Move ball slightly away from edge
                    }

                    dblTime += 0.2; //Increment time for zigzag function (slower)
                }
            }
        } //ball movement


        //Functions
        //Zigzag motion
        public int zigzagVertical()
        {
            //Uses sine function: y = A * sin(B * x) where A is amplitude, B affects frequency
            double dblAmplitude = 8.0; //How high/low the zigzag goes (reduced for smoother bouncing)
            double dblFrequency = 2.0; //How fast it zigzags
            return (int)(dblAmplitude * Math.Sin(dblFrequency * dblTime));
        } //vertical zigzag motion

        public int zigzagHorizontal()
        {
            return -2; //Constant horizontal movement (slower - negative = left, positive = right)
        } //horizontal zigzag motion
    }
}