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
        int intUserHealth = 100, intCompHealth = 100, intStamina = 100, intStaminaDeduction = 0; //health for both players and stamina
        int intTurnCount = 1; //turn counter
        int intBlindTurns = 0; //blindness effect turns
        int intTurn = 0; //Turns of game (0 - user, 1 - computer)
        int intCoin = -1; //Coin flipper 
        int intComputerChoice = 0; //Random move from computer 1-3
        string strComputerMoveName = ""; //The name of the computer's move
        int intComputerMode = 0; //Modes 1-9 for different difficulties and levels (1-3 for easy, 4-6 for medium, 7-9 for hard)
        int intComputerAttack = 0, intUserAttack = 0; //Damage of the attack done by computer and user
        int intUserLevel = 0, intUserDifficulty = 0; //Level and difficulty chosen by the user
        int intGainAmount = 0; //Gain amount for stamina
        public MainGame(int intDifficulty, int intLevel)
        {
            InitializeComponent();
            this.tmrGame.Enabled = false; //starts with timer off for insurance
            this.pnlMonsterSelect.Visible = true; //set the visible panel to true
            intUserLevel = intLevel; //Sets chosen level and difficulty equal to each other
            intUserDifficulty = intDifficulty;
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
            this.pcbUserMonster.BackgroundImage = MonsterImages.exparia; //sets the image of the monster to the monster selected
            this.lblUserMonsterName.Text = "Exparia"; //Sets the name of the monster
            this.tmrGame.Enabled = true; //starts the game
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
            this.pcbUserMonster.BackgroundImage = MonsterImages.fallacia; //sets the image of the monster to the monster selected
            this.lblUserMonsterName.Text = "Falacia"; //Sets the name of the monster
            this.tmrGame.Enabled = true; //starts the game
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
            this.pcbUserMonster.BackgroundImage = MonsterImages.tellaria; //sets the image of the monster to the monster selected
            this.lblUserMonsterName.Text = "Tellaria"; //Sets the name of the monster
            this.tmrGame.Enabled = true; //starts the game
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
            this.pcbUserMonster.BackgroundImage = MonsterImages.doveria; //sets the image of the monster to the monster selected
            this.lblUserMonsterName.Text = "Doveria"; //Sets the name of the monster
            this.tmrGame.Enabled = true; //starts the game
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
            this.pcbUserMonster.BackgroundImage = MonsterImages.sania; //sets the image of the monster to the monster selected
            this.lblUserMonsterName.Text = "Sania"; //Sets the name of the monster
            this.tmrGame.Enabled = true; //starts the game
        } //Secret monster Sania selected
        private void btnExitGame_Click(object sender, EventArgs e)
        {
            GameDisplay GameDisplay = new GameDisplay(intCoinsCollected); //initializes designer
            intCoinsCollected = 0; //No coins collected
            this.Hide(); //Hides the game display
            GameDisplay.Show(); //Shows the game display design page

        } //exits the game
        private void btnAttack1_Click(object sender, EventArgs e)
        {
            try
            {
                if (tmrGame.Enabled == false || intTurn != 0)
                {
                    throw new Exception("You cannot make that turn!");
                }
                else
                {
                    if (strMonster == "Exparia") //If the common monster is chosen
                    {
                        if (intStamina-20 < 0)
                        {
                            throw new Exception("Not enough stamina!"); 
                        } //not enough stamina!
                        else
                        {
                            intUserAttack = rndGen.Next(10, 21); //User attack amount
                            if (intCompHealth < intUserAttack)
                            {
                                intCompHealth = 0; //set all health and comp hp widths to 0
                                this.pcbCompHP.Width = 0;
                            }
                            else
                            {
                                intCompHealth -= intUserAttack; //Deals damage to attacker
                                this.pcbCompHP.Width = Math.Max(0, this.pcbCompHP.Width - (2 * intUserAttack)); //Takes off hp from computer
                            }
                            intStamina -= 20; //Takes away 20 stamina from user
                            this.pcbStaminaBar.Width = Math.Max(0, Math.Min(200, this.pcbStaminaBar.Width - 40)); //Shortening the width of the stamina bar
                        }
                    }
                    else if (strMonster == "Falacia") //If the rare monster is chosen
                    {
                        if (intStamina - 30 < 0)
                        {
                            throw new Exception("Not enough stamina!");
                        } //not enough stamina!
                        else
                        {
                            intUserAttack = rndGen.Next(25, 36); //User attack amount
                            if (intCompHealth < intUserAttack)
                            {
                                intCompHealth = 0; //set all health and comp hp widths to 0
                                this.pcbCompHP.Width = 0;
                            }
                            else
                            {
                                intCompHealth -= intUserAttack; //Deals damage to attacker
                                this.pcbCompHP.Width = Math.Max(0, this.pcbCompHP.Width - (2 * intUserAttack)); //Takes off hp from computer
                            }
                            intStamina -= 30; //Takes away 30 stamina from user
                            this.pcbStaminaBar.Width = Math.Max(0, Math.Min(200, this.pcbStaminaBar.Width - 60)); //Shortening the width of the stamina bar
                        }
                    }
                    else if (strMonster == "Tellaria") //If the legendary monster is chosen
                    {
                        if (intStamina - 80 < 0)
                        {
                            throw new Exception("Not enough stamina!");
                        } //not enough stamina!
                        else
                        {
                            intBlindTurns = 3; //Blinds opponent for 3 turns
                            intUserAttack = 20; //User attack amount
                            if (intCompHealth < intUserAttack)
                            {
                                intCompHealth = 0; //set all health and comp hp widths to 0
                                this.pcbCompHP.Width = 0;
                            }
                            else
                            {
                                intCompHealth -= intUserAttack; //Deals damage to attacker
                                this.pcbCompHP.Width = Math.Max(0, this.pcbCompHP.Width - (2 * intUserAttack)); //Takes off hp from computer
                            }
                            intStamina -= 80; //Takes away 80 stamina from user
                            this.pcbStaminaBar.Width = Math.Max(0, Math.Min(200, this.pcbStaminaBar.Width - 160)); //Shortening the width of the stamina bar
                        }
                    }
                    else if (strMonster == "Doveria") //If the godly monster is chosen
                    {
                        if (intStamina - 60 < 0)
                        {
                            throw new Exception("Not enough stamina!");
                        } //not enough stamina!
                        else
                        {
                            intUserAttack = 50; //User attack amount
                            if (intCompHealth < intUserAttack)
                            {
                                intCompHealth = 0; //set all health and comp hp widths to 0
                                this.pcbCompHP.Width = 0;
                            }
                            else
                            {
                                intCompHealth -= intUserAttack; //Deals damage to attacker
                                this.pcbCompHP.Width = Math.Max(0, this.pcbCompHP.Width - (2 * intUserAttack)); //Takes off hp from computer
                            }
                            intStamina -= 60; //Takes away 60 stamina from user
                            this.pcbStaminaBar.Width = Math.Max(0, Math.Min(200, this.pcbStaminaBar.Width - 120)); //Shortening the width of the stamina bar
                        }
                    }
                    else if (strMonster == "Sania") //If the ???/secret mosnter is chosen
                    {
                        if (intTurnCount == 1 || intStamina - 100 < 0)
                        {
                            throw new Exception("Not enough stamina, or you're on turn cooldown!");
                        }
                        else
                        {
                            intStamina -= 100; //Takes away 100 stamina from user
                            intUserAttack = 100; //User attack amount
                            if (intCompHealth < intUserAttack)
                            {
                                intCompHealth = 0; //set all health and comp hp widths to 0
                                this.pcbCompHP.Width = 0;
                            }
                            else
                            {
                                intCompHealth -= intUserAttack; //Deals damage to attacker
                                this.pcbCompHP.Width = Math.Max(0, this.pcbCompHP.Width - (2 * intUserAttack)); //Takes off hp from computer
                            }
                            this.pcbStaminaBar.Width = Math.Max(0, Math.Min(200, this.pcbStaminaBar.Width - 200)); //Shortening the width of the stamina bar
                        }
                    }
                }
                intTurn = 1;
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message); //Shows the error message
            }
            
        } //if attack one is selected
        private void btnAttack2_Click(object sender, EventArgs e)
        {
            try
            {
                if (tmrGame.Enabled == false || intTurn != 0)
                {
                    throw new Exception("Game has not started yet, you cannot make your turn!");
                }
                else
                {
                    if (strMonster == "Exparia") //If the common monster is chosen
                    {
                        if (intStamina - 30 < 0)
                        {
                            throw new Exception("Not enough stamina!");
                        } //not enough stamina!
                        else
                        {
                            intUserAttack = 20; //User attack amount
                            if (intCompHealth < intUserAttack)
                            {
                                intCompHealth = 0; //set all health and comp hp widths to 0
                                this.pcbCompHP.Width = 0;
                            }
                            else
                            {
                                intCompHealth -= intUserAttack; //Deals damage to attacker
                                this.pcbCompHP.Width = Math.Max(0, this.pcbCompHP.Width - (2 * intUserAttack)); //Takes off hp from computer
                            }
                            intStamina -= 30; //Takes away 30 stamina from user 
                            this.pcbStaminaBar.Width = Math.Max(0, Math.Min(200, this.pcbStaminaBar.Width - 60)); //Shortening the width of the stamina bar
                        }
                    }
                    else if (strMonster == "Falacia") //If the rare monster is chosen
                    {
                        if (intStamina - 40 < 0)
                        {
                            throw new Exception("Not enough stamina!");
                        } //not enough stamina!
                        else
                        {
                            intUserAttack = 40; //User attack amount
                            if (intCompHealth < intUserAttack)
                            {
                                intCompHealth = 0; //set all health and comp hp widths to 0
                                this.pcbCompHP.Width = 0;
                            }
                            else
                            {
                                intCompHealth -= intUserAttack; //Deals damage to attacker
                                this.pcbCompHP.Width = Math.Max(0, this.pcbCompHP.Width - (2 * intUserAttack)); //Takes off hp from computer
                            }
                            intStamina -= 30; //Takes away 30 stamina from user (40-10)
                            this.pcbStaminaBar.Width = Math.Max(0, Math.Min(200, this.pcbStaminaBar.Width - 60)); //Shortening the width of the stamina bar
                        }
                    }
                    else if (strMonster == "Tellaria") //If the legendary monster is chosen
                    {
                        if (intStamina - 40 < 0)
                        {
                            throw new Exception("Not enough stamina!");
                        }//not enough stamina!
                        else
                        {
                            intUserAttack = intBlindTurns * 30; //User attack amount
                            if (intCompHealth < intUserAttack)
                            {
                                intCompHealth = 0; //set all health and comp hp widths to 0
                                this.pcbCompHP.Width = 0;
                            }
                            else
                            {
                                intCompHealth -= intUserAttack; //Deals damage to attacker
                                this.pcbCompHP.Width = Math.Max(0, this.pcbCompHP.Width - (2 * intUserAttack)); //Takes off hp from computer
                            }
                            intStamina -= 40;
                            this.pcbStaminaBar.Width = Math.Max(0, Math.Min(200, this.pcbStaminaBar.Width - 80)); //Shortening the width of the stamina bar

                        }
                    }
                    else if (strMonster == "Doveria") //If the godly monster is chosen
                    {
                        if (intStamina - 50 < 0)
                        {
                            throw new Exception("Not enough stamina!");
                        }//not enough stamina!
                        else
                        {
                            intBlindTurns = 2; //Blinds the opponents for two turns
                            intUserAttack = intCompHealth / 2; //User attack amount
                            if (intCompHealth < intUserAttack)
                            {
                                intCompHealth = 0; //set all health and comp hp widths to 0
                                this.pcbCompHP.Width = 0;
                            }
                            else
                            {
                                intCompHealth -= intUserAttack; //Deals damage to attacker
                                this.pcbCompHP.Width = Math.Max(0, this.pcbCompHP.Width - (2 * intUserAttack)); //Takes off hp from computer
                            }
                            intStamina -= 50; //Takes away 50 stamina from user
                            this.pcbStaminaBar.Width = Math.Max(0, Math.Min(200, this.pcbStaminaBar.Width - 100)); //Shortening the width of the stamina bar
                        }
                    }
                    else if (strMonster == "Sania") //If the ???/secret mosnter is chosen
                    {
                        if (intStamina - 50 < 0)
                        {
                            throw new Exception("Not enough stamina!");
                        }//not enough stamina!
                        else
                        {
                            intBlindTurns = 5; //Blinds the opponents for five turns
                            intUserAttack = 40; //User attack amount
                            if (intCompHealth < intUserAttack)
                            {
                                intCompHealth = 0; //set all health and comp hp widths to 0
                                this.pcbCompHP.Width = 0;
                            }
                            else
                            {
                                intCompHealth -= intUserAttack; //Deals damage to attacker
                                this.pcbCompHP.Width = Math.Max(0, this.pcbCompHP.Width - (2 * intUserAttack)); //Takes off hp from computer
                            }
                            intStamina -= 50;//Takes away 50 stamina from user
                            this.pcbStaminaBar.Width = Math.Max(0, Math.Min(200, this.pcbStaminaBar.Width - 100)); //Shortening the width of the stamina bar
                        }   
                    }
                }
                intTurn = 1;
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message); //Shows the error message
            }
        } //if attack two is selected
        private void btnAttack3_Click(object sender, EventArgs e)
        {
            try
            {
                if (tmrGame.Enabled == false || intTurn != 0)
                {
                    throw new Exception("Game has not started yet, you cannot make your turn!");
                }
                else
                {
                    if (strMonster == "Exparia") //If the common monster is chosen
                    {
                        intGainAmount = Math.Min(40, 100 - intStamina); //returns the value that ends up being smaller
                        intStamina += intGainAmount;
                        this.pcbStaminaBar.Width = Math.Min(200, this.pcbStaminaBar.Width + (2 * intGainAmount)); //resizes the stamina bar to smallest value
                    }
                    else if (strMonster == "Falacia") //If the rare monster is chosen
                    {
                        if (intStamina - 40 < 0)
                        {
                            throw new Exception("Not enough stamina!");
                        }//not enough stamina!
                        else
                        {
                            intCoin = rndGen.Next(0, 2); //Coinflips to find winner
                            if (intCoin == 0) //user wins coinflip
                            {
                                intStaminaDeduction += 50; //Gives the user 50 stamina
                            }
                            else
                            {
                                //"gives" the computer stamina
                            }
                            intStamina -= Math.Abs(intStaminaDeduction - 40);//Takes away 40 stamina from user
                            if (intStaminaDeduction - 40 > 0) //if the stamina deduction number is positive (meaning it should add)
                            {
                                if (intStamina + Math.Abs(intStaminaDeduction - 40) > 100)
                                {
                                    intStamina += 100 - Math.Abs(intStaminaDeduction - 40);
                                    this.pcbStaminaBar.Width += 2 * (100 - Math.Abs(intStaminaDeduction - 40));
                                }
                                else
                                {
                                    intStamina += Math.Abs(intStaminaDeduction - 40);
                                    this.pcbStaminaBar.Width += 2 * (Math.Abs(intStaminaDeduction - 40));
                                }
                            }
                            else //if the stamina deduction number is negative (meaning it should subtract)
                            {
                                intStamina -= Math.Abs(intStaminaDeduction - 40);
                                this.pcbStaminaBar.Width -= 2 * (Math.Abs(intStaminaDeduction - 40));
                            }
                            intStaminaDeduction = 0; //Resets the stamina deduction variable
                            intCoin = -1; //Resets the coin to not have it "rigged"
                        }
                    }
                    else if (strMonster == "Tellaria") //If the legendary monster is chosen
                    {
                        if (intStamina - 50 < 0)
                        {
                            throw new Exception("Not enough stamina!");
                        } //not enough stamina!
                        else
                        {
                            intStamina -= 50;//Takes away 50 stamina from user;
                            this.pcbStaminaBar.Width = Math.Max(0, Math.Min(200, this.pcbStaminaBar.Width - 100)); //Shortening the width of the stamina bar
                            intCoin = rndGen.Next(0, 11); //Random number from 1-10 for the coin
                            if (intCoin == 1) //User wins the coinflip
                            {
                                intCompHealth = 0; //User deals 100 damage to computer
                                this.pcbCompHP.Width = 0;
                            }
                            else
                            {
                                intUserHealth = 0; //Computer deals 100 damage to user
                                this.pcbUserHP.Width = 0;
                            }
                            intCoin = -1; //Resets the coin for no bias
                        } 
                    }
                    else if (strMonster == "Doveria") //If the godly monster is chosen
                    {
                        if (intStamina - 80 < 0)
                        {
                            throw new Exception("Not enough stamina!");
                        } //not enough stamina!
                        else
                        {
                            intStamina -= 80; //Takes away 80 stamina from user
                            this.pcbStaminaBar.Width = Math.Max(0, Math.Min(200, this.pcbStaminaBar.Width - 160)); //Shortening the width of the stamina bar
                            intCoin = rndGen.Next(0, 2); //Coinflips to determine instant death
                            if (intCoin == 0)
                            {
                                intCompHealth = 0; //Deals 100 damage to the computer
                                this.pcbCompHP.Width = 0;
                            }
                            intCoin = -1; //resets the coin
                        }   
                    }
                    else if (strMonster == "Sania") //If the ???/secret mosnter is chosen
                    {
                        if (intStamina - 40 < 0)
                        {
                            throw new Exception("Not enough stamina!");
                        } //not enough stamina!
                        else
                        {
                            intStamina -= 40; //Takes away 40 stamina from the user
                            this.pcbStaminaBar.Width = Math.Max(0, Math.Min(200, this.pcbStaminaBar.Width - 80)); //Shortening the width of the stamina bar
                            intUserHealth = 75; //Sets the user's health to 75 
                            intCoin = rndGen.Next(0, 11);//Sets a coinflip
                            if (intCoin <= 1) //20% chance of instant kill
                            {
                                intCompHealth = 0; //Deals 100 damage to the computer
                                this.pcbCompHP.Width = 0;
                            }
                            else //Just deals damage
                            {
                                intUserAttack = 35; //User attack amount
                                if (intCompHealth < intUserAttack)
                                {
                                    intCompHealth = 0; //set all health and comp hp widths to 0
                                    this.pcbCompHP.Width = 0;
                                }
                                else
                                {
                                    intCompHealth -= intUserAttack; //Deals damage to attacker
                                    this.pcbCompHP.Width = Math.Max(0, this.pcbCompHP.Width - (2 * intUserAttack)); //Takes off hp from computer
                                }
                            }
                            intCoin = -1; //resets the coin
                        }   
                    }
                }
                intTurn = 1;
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message); //Shows the error message
            }
        } //if attack three is selected
        private void tmrGame_Tick(object sender, EventArgs e)
        {
            if (intUserLevel == 1 && intTurn == 1)
            {
                this.tmrGame.Enabled = false;
                levelOneGameplay(intUserDifficulty);
                intTurn = 0;
                this.tmrGame.Enabled = true;
            }
            else if (intUserLevel == 2 && intTurn == 1)
            {
                this.tmrGame.Enabled = false;
                levelTwoGameplay(intUserDifficulty);
                intTurn = 0;
                this.tmrGame.Enabled = true;
            }
            else if (intUserLevel == 3 && intTurn == 1)
            {
                this.tmrGame.Enabled = false;
                levelThreeGameplay(intUserDifficulty);
                intTurn = 0;
                this.tmrGame.Enabled = true;
            }

            if (intCompHealth == 0 || intUserHealth == 0)
            {
                //stops the game
                this.tmrGame.Enabled = false;

                if (intCompHealth == 0) //Winner message, calculates number of coins won
                {
                    intCoinsCollected = coinsEarned();
                    MessageBox.Show("You have won the game. You have earned a total of " + intCoinsCollected + " coins! Press ok to exit."); //winning exit message
                }
                else if (intUserHealth == 0) //Loser message
                {
                    intCoinsCollected = 0;
                    MessageBox.Show("You have lost the game. Press ok to exit."); //losing exit message
                }

                GameDisplay GameDisplay = new GameDisplay(intCoinsCollected); //returns back to the gamedisplay form
                this.Hide();
                //Resets the width of the HP and Stamina bars
                this.pcbCompHP.Width = 200;
                this.pcbUserHP.Width = 200;
                this.pcbStaminaBar.Width = 200;
                GameDisplay.Show();
                return;
            }

            
        } //game controls

        private void btnSkipTurn_Click(object sender, EventArgs e)
        {
            if (tmrGame.Enabled == true)
            {
                intTurnCount++; //Adds a turn to the game
                intTurn = 1; //Skips to next turn
                intStamina += 50; //Adds 50 to the stamina
                this.pcbStaminaBar.Width = Math.Min(200, this.pcbStaminaBar.Width + (2 * 50));
            }
        } //Skips the turn

        private void btnAttackInfo_Click(object sender, EventArgs e)
        {
            if (strMonster == "Exparia") //If the common monster is chosen
            {
                MessageBox.Show("Attack 1: Star Blast - Launches stars and deals 10-20 damage to attacker. Costs 20 Stamina\n" +
                    "Attack 2: Supernova - Blasts a galaxy at the opponent, deals 20 damage to attacker. Costs 30 Stamina\n" +
                    "Attack 3: Crescent Moon - Channels the power of the moon, gains 40 Stamina. Costs no stamina");
            }
            else if (strMonster == "Falacia") //If the rare monster is chosen
            {
                MessageBox.Show("Attack 1: Colossal Crusher - Bites the opponent, deals 25-35 damage to attacker. Costs 30 Stamina\n" +
                    "Attack 2: Taparova - Sends a magical attack, deals 40 damage to the attacker and gains 10 stamina. Costs 40 Stamina\n" +
                    "Attack 3: Winter Sunshine - Winter explosion, will perform a coinflip to give you or the computer 50 stamina. Costs 40 Stamina.");
            }
            else if (strMonster == "Tellaria") //If the legendary monster is chosen
            {
                MessageBox.Show("Attack 1: Smokescreen - Blinds the opponent for three turns, deals 20 damage to attacker. Costs 80 Stamina. Does not stack\n" +
                    "Attack 2: Skull Crusher - If opponent is blinded, it will deal 30 damage for every turn opponent is blinded. Costs 40 Stamina\n" +
                    "Attack 3: Explosive Death - Flips a coin to determine winner (loser's monster dies). 10% chance of winning. Costs 50 Stamina");
            }
            else if (strMonster == "Doveria") //If the godly monster is chosen
            {
                MessageBox.Show("Attack 1: Heavenly Spiral - Fires a wind column at the opponent, deals 50 damage. Costs 60 Stamina\n" +
                    "Attack 2: Tornado Spike - Blinds the opponent for two turns, sets the opponent health to half. Costs 50 Stamina. Does not stack\n" +
                    "Attack 3: God's Will - Has a 50% chance of instantly killing the opponent's monster. Costs 80 Stamina");
            }
            else if (strMonster == "Sania") //If the ???/secret mosnter is chosen
            {
                MessageBox.Show("Attack 1: The Kill. - Instantly kills the other opponents monster. Cannot play first turn. Costs 100 Stamina\n" +
                    "Attack 2: Night Falls. - Blinds the opponent for five turns, deals 40 damage. Costs 50 Stamina. Does not stack\n" +
                    "Attack 3: Destruction. - Regains to 75% of full health, deals 35 damage, has a 20% chance of instant kill. Costs 40 Stamina");
            }
        } //Displays the attack information of all the monsters
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
        } //checking if a monster is in the collection

        //Level 1 Games - Easy, Medium, Hard
        public void levelOneGameplay(int intDifficulty) //level one function for gameplay
        {
            if (intDifficulty == 1) //easy
            {
                intComputerMode = 1; //Level 1 Easy
                intComputerChoice = rndGen.Next(1, 4); //random number from 1 to 3 for moves
                if (intComputerChoice == 1) //Move one
                {
                    strComputerMoveName = "Techno Blast"; //Techno Blast
                    if (intBlindTurns > 0)
                    {
                        intUserHealth -= 0; //No damage because blind
                        intBlindTurns--; //Subtract from turns
                    }
                    else
                    {
                        intComputerAttack = rndGen.Next(10, 21);
                        if (intUserHealth < intComputerAttack)
                        {
                            intUserHealth = 0; //user loses
                            this.pcbUserHP.Width = 0;
                        }
                        else
                        {
                            intUserHealth -= intComputerAttack; //Damages user health by 10-20 HP
                            this.pcbUserHP.Width -= (intComputerAttack * 2); //decreases the width of the HP bar to reflect health lost
                        }   
                    }
                }
                else if (intComputerChoice == 2) //Move two
                {
                    strComputerMoveName = "Cyber Stun"; //Cyber stun
                    if (intBlindTurns > 0)
                    {
                        intUserHealth -= 0; //No damage because blind
                        intBlindTurns--; //Subtract from turns
                    }
                    else
                    {
                        intComputerAttack = rndGen.Next(10, 21);
                        if (intUserHealth < intComputerAttack)
                        {
                            intUserHealth = 0; //user loses
                            this.pcbUserHP.Width = 0;
                        }
                        else
                        {
                            intUserHealth -= intComputerAttack; //Damages user health by 10-20 HP
                            this.pcbUserHP.Width -= (intComputerAttack * 2); //decreases the width of the HP bar to reflect health lost
                        }
                    }
                }
                else if (intComputerChoice == 3) //Move three
                {
                    strComputerMoveName = "Hacked."; //Hacked
                    if (intBlindTurns > 0)
                    {
                        intUserHealth -= 0; //No damage because blind
                        intBlindTurns--; //Subtract from turns
                    }
                    else
                    {
                        intComputerAttack = rndGen.Next(10, 21);
                        if (intUserHealth < intComputerAttack)
                        {
                            intUserHealth = 0; //user loses
                            this.pcbUserHP.Width = 0;
                        }
                        else
                        {
                            intUserHealth -= intComputerAttack; //Damages user health by 10-20 HP
                            this.pcbUserHP.Width -= (intComputerAttack * 2); //decreases the width of the HP bar to reflect health lost
                        }
                    }
                }
                MessageBox.Show("The computer has played move: " + strComputerMoveName + " and dealt " +intComputerAttack+" damage (HP)."); //Shows what computer has moved
                intTurn = 0; //Switches turn to user
            }
            else if (intDifficulty == 2) //medium
            {
                intComputerMode = 2; //Level 1 Medium
                intComputerChoice = rndGen.Next(1, 4); //random number from 1 to 3 for moves
                if (intComputerChoice == 1) //Move one
                {
                    strComputerMoveName = "Techno Blast"; //Techno Blast
                    if (intBlindTurns > 0)
                    {
                        intUserHealth -= 0; //No damage because blind
                        intBlindTurns--; //Subtract from turns
                    }
                    else
                    {
                        intComputerAttack = rndGen.Next(20, 31);
                        if (intUserHealth < intComputerAttack)
                        {
                            intUserHealth = 0; //user loses
                            this.pcbUserHP.Width = 0;
                        }
                        else
                        {
                            intUserHealth -= intComputerAttack; //Damages user health by 20-30 HP
                            this.pcbUserHP.Width -= (intComputerAttack * 2); //decreases the width of the HP bar to reflect health lost
                        }
                    }
                }
                else if (intComputerChoice == 2) //Move two
                {
                    strComputerMoveName = "Cyber Stun"; //Cyber stun
                    if (intBlindTurns > 0)
                    {
                        intUserHealth -= 0; //No damage because blind
                        intBlindTurns--; //Subtract from turns
                    }
                    else
                    {
                        intComputerAttack = rndGen.Next(20, 31);
                        if (intUserHealth < intComputerAttack)
                        {
                            intUserHealth = 0; //user loses
                            this.pcbUserHP.Width = 0;
                        }
                        else
                        {
                            intUserHealth -= intComputerAttack; //Damages user health by 20-30 HP
                            this.pcbUserHP.Width -= (intComputerAttack * 2); //decreases the width of the HP bar to reflect health lost
                        }
                    }
                }
                else if (intComputerChoice == 3) //Move three
                {
                    strComputerMoveName = "Hacked."; //Hacked
                    if (intBlindTurns > 0)
                    {
                        intUserHealth -= 0; //No damage because blind
                        intBlindTurns--; //Subtract from turns
                    }
                    else
                    {
                        intComputerAttack = rndGen.Next(20, 31);
                        if (intUserHealth < intComputerAttack)
                        {
                            intUserHealth = 0; //user loses
                            this.pcbUserHP.Width = 0;
                        }
                        else
                        {
                            intUserHealth -= intComputerAttack; //Damages user health by 20-30 HP
                            this.pcbUserHP.Width -= (intComputerAttack * 2); //decreases the width of the HP bar to reflect health lost
                        }
                    }
                }
                MessageBox.Show("The computer has played move: " + strComputerMoveName + " and dealt " + intComputerAttack + " damage (HP)."); //Shows what computer has moved
                intTurn = 0; //Switches turn to user
            }
            else if (intDifficulty == 3) //hard
            {
                intComputerMode = 3; //Level 1 Hard
                intComputerChoice = rndGen.Next(1, 4); //random number from 1 to 3 for moves
                if (intComputerChoice == 1) //Move one
                {
                    strComputerMoveName = "Techno Blast"; //Techno Blast
                    if (intBlindTurns > 0)
                    {
                        intUserHealth -= 0; //No damage because blind
                        intBlindTurns--; //Subtract from turns
                    }
                    else
                    {
                        intComputerAttack = rndGen.Next(25, 36);
                        if (intUserHealth < intComputerAttack)
                        {
                            intUserHealth = 0; //user loses
                            this.pcbUserHP.Width = 0;
                        }
                        else
                        {
                            intUserHealth -= intComputerAttack; //Damages user health by 25-35 HP
                            this.pcbUserHP.Width -= (intComputerAttack * 2); //decreases the width of the HP bar to reflect health lost
                        }
                    }
                }
                else if (intComputerChoice == 2) //Move two
                {
                    strComputerMoveName = "Cyber Stun"; //Cyber stun
                    if (intBlindTurns > 0)
                    {
                        intUserHealth -= 0; //No damage because blind
                        intBlindTurns--; //Subtract from turns
                    }
                    else
                    {
                        intComputerAttack = rndGen.Next(25, 36);
                        if (intUserHealth < intComputerAttack)
                        {
                            intUserHealth = 0; //user loses
                            this.pcbUserHP.Width = 0;
                        }
                        else
                        {
                            intUserHealth -= intComputerAttack; //Damages user health by 25-35 HP
                            this.pcbUserHP.Width -= (intComputerAttack * 2); //decreases the width of the HP bar to reflect health lost
                        }
                    }
                }
                else if (intComputerChoice == 3) //Move three
                {
                    strComputerMoveName = "Hacked."; //Hacked
                    if (intBlindTurns > 0)
                    {
                        intUserHealth -= 0; //No damage because blind
                        intBlindTurns--; //Subtract from turns
                    }
                    else
                    {
                        intComputerAttack = rndGen.Next(25, 36);
                        if (intUserHealth < intComputerAttack)
                        {
                            intUserHealth = 0; //user loses
                            this.pcbUserHP.Width = 0;
                        }
                        else
                        {
                            intUserHealth -= intComputerAttack; //Damages user health by 25-35 HP
                            this.pcbUserHP.Width -= (intComputerAttack * 2); //decreases the width of the HP bar to reflect health lost
                        }
                    }
                }
                MessageBox.Show("The computer has played move: " + strComputerMoveName + " and dealt " + intComputerAttack + " damage (HP)."); //Shows what computer has moved
                intTurn = 0; //Switches turn to user
            }
        }
        //Level 2 Games - Easy, Medium, Hard
        public void levelTwoGameplay(int intDifficulty) //level two function for gameplay
        {
            if (intDifficulty == 1) //easy
            {
                intComputerMode = 4; //Level 2 Easy
                intComputerChoice = rndGen.Next(1, 4); //random number from 1 to 3 for moves
                if (intComputerChoice == 1) //Move one
                {
                    strComputerMoveName = "Techno Blast"; //techno blast
                    if (intBlindTurns > 0)
                    {
                        intUserHealth -= 0; //No damage because blind
                        intBlindTurns--; //Subtract from turns
                    }
                    else
                    {
                        intComputerAttack = rndGen.Next(20, 41);
                        if (intUserHealth < intComputerAttack)
                        {
                            intUserHealth = 0; //user loses
                            this.pcbUserHP.Width = 0;
                        }
                        else
                        {
                            intUserHealth -= intComputerAttack; //Damages user health by 20-40 HP
                            this.pcbUserHP.Width -= (intComputerAttack * 2); //decreases the width of the HP bar to reflect health lost
                        }
                    }
                }
                else if (intComputerChoice == 2) //Move two
                {
                    strComputerMoveName = "Cyber Stun"; //cyber stun
                    if (intBlindTurns > 0)
                    {
                        intUserHealth -= 0; //No damage because blind
                        intBlindTurns--; //Subtract from turns
                    }
                    else
                    {
                        intComputerAttack = rndGen.Next(25, 46);
                        if (intUserHealth < intComputerAttack)
                        {
                            intUserHealth = 0; //user loses
                            this.pcbUserHP.Width = 0;
                        }
                        else
                        {
                            intUserHealth -= intComputerAttack; //Damages user health by 25-45 HP
                            this.pcbUserHP.Width -= (intComputerAttack * 2); //decreases the width of the HP bar to reflect health lost
                        }
                    }
                }
                else if (intComputerChoice == 3) //Move three
                {
                    strComputerMoveName = "Hacked."; //hacked
                    if (intBlindTurns > 0)
                    {
                        intUserHealth -= 0; //No damage because blind
                        intBlindTurns--; //Subtract from turns
                    }
                    else
                    {
                        intComputerAttack = rndGen.Next(30, 36);
                        if (intUserHealth < intComputerAttack)
                        {
                            intUserHealth = 0; //user loses
                            this.pcbUserHP.Width = 0;
                        }
                        else
                        {
                            intUserHealth -= intComputerAttack; //Damages user health by 30-35 HP
                            this.pcbUserHP.Width -= (intComputerAttack * 2); //decreases the width of the HP bar to reflect health lost
                        }
                    }
                }
                MessageBox.Show("The computer has played move: " + strComputerMoveName + " and dealt " + intComputerAttack + " damage (HP)."); //Shows what computer has moved
                intTurn = 0; //Switches turn to user
            }
            else if (intDifficulty == 2) //medium
            {
                intComputerMode = 5; //Level 2 Medium
                intComputerChoice = rndGen.Next(1, 4); //random number from 1 to 3 for moves
                if (intComputerChoice == 1) //Move one
                {
                    strComputerMoveName = "Techno Blast"; //techno blast
                    if (intBlindTurns > 0)
                    {
                        intUserHealth -= 0; //No damage because blind
                        intBlindTurns--; //Subtract from turns
                    }
                    else
                    {
                        intComputerAttack = rndGen.Next(20, 51);
                        if (intUserHealth < intComputerAttack)
                        {
                            intUserHealth = 0; //user loses
                            this.pcbUserHP.Width = 0;
                        }
                        else
                        {
                            intUserHealth -= intComputerAttack; //Damages user health by 20-50 HP
                            this.pcbUserHP.Width -= (intComputerAttack * 2); //decreases the width of the HP bar to reflect health lost
                        }
                    }
                }
                else if (intComputerChoice == 2) //Move two
                {
                    strComputerMoveName = "Cyber Stun"; //cyber stun
                    if (intBlindTurns > 0)
                    {
                        intUserHealth -= 0; //No damage because blind
                        intBlindTurns--; //Subtract from turns
                    }
                    else
                    {
                        intComputerAttack = rndGen.Next(25, 46);
                        if (intUserHealth < intComputerAttack)
                        {
                            intUserHealth = 0; //user loses
                            this.pcbUserHP.Width = 0;
                        }
                        else
                        {
                            intUserHealth -= intComputerAttack; //Damages user health by 25-45 HP
                            this.pcbUserHP.Width -= (intComputerAttack * 2); //decreases the width of the HP bar to reflect health lost
                        }
                    }
                }
                else if (intComputerChoice == 3) //Move three
                {
                    strComputerMoveName = "Hacked."; //hacked
                    if (intBlindTurns > 0)
                    {
                        intUserHealth -= 0; //No damage because blind
                        intBlindTurns--; //Subtract from turns
                    }
                    else
                    {
                        intComputerAttack = rndGen.Next(40, 46);
                        if (intUserHealth < intComputerAttack)
                        {
                            intUserHealth = 0; //user loses
                            this.pcbUserHP.Width = 0;
                        }
                        else
                        {
                            intUserHealth -= intComputerAttack; //Damages user health by 40-45 HP
                            this.pcbUserHP.Width -= (intComputerAttack * 2); //decreases the width of the HP bar to reflect health lost
                        }
                    }
                }
                MessageBox.Show("The computer has played move: " + strComputerMoveName + " and dealt " + intComputerAttack + " damage (HP)."); //Shows what computer has moved
                intTurn = 0; //Switches turn to user
            }
            else if (intDifficulty == 3) //hard
            {
                intComputerMode = 6; //Level 2 Hard
                intComputerChoice = rndGen.Next(1, 4); //random number from 1 to 3 for moves
                if (intComputerChoice == 1) //Move one
                {
                    strComputerMoveName = "Techno Blast"; //techno blast
                    if (intBlindTurns > 0)
                    {
                        intUserHealth -= 0; //No damage because blind
                        intBlindTurns--; //Subtract from turns
                    }
                    else
                    {
                        intComputerAttack = rndGen.Next(35, 51);
                        if (intUserHealth < intComputerAttack)
                        {
                            intUserHealth = 0; //user loses
                            this.pcbUserHP.Width = 0;
                        }
                        else
                        {
                            intUserHealth -= intComputerAttack; //Damages user health by 35-50 HP
                            this.pcbUserHP.Width -= (intComputerAttack * 2); //decreases the width of the HP bar to reflect health lost
                        }
                    }
                }
                else if (intComputerChoice == 2) //Move two
                {
                    strComputerMoveName = "Cyber Stun"; //cyber stun
                    if (intBlindTurns > 0)
                    {
                        intUserHealth -= 0; //No damage because blind
                        intBlindTurns--; //Subtract from turns
                    }
                    else
                    {
                        intComputerAttack = rndGen.Next(40, 46);
                        if (intUserHealth < intComputerAttack)
                        {
                            intUserHealth = 0; //user loses
                            this.pcbUserHP.Width = 0;
                        }
                        else
                        {
                            intUserHealth -= intComputerAttack; //Damages user health by 40-45 HP
                            this.pcbUserHP.Width -= (intComputerAttack * 2); //decreases the width of the HP bar to reflect health lost
                        }
                    }
                }
                else if (intComputerChoice == 3) //Move three
                {
                    strComputerMoveName = "Hacked."; //hacked
                    if (intBlindTurns > 0)
                    {
                        intUserHealth -= 0; //No damage because blind
                        intBlindTurns--; //Subtract from turns
                    }
                    else
                    {
                        intComputerAttack = rndGen.Next(80,101);
                        if (intUserHealth < intComputerAttack)
                        {
                            intUserHealth = 0; //user loses
                            this.pcbUserHP.Width = 0;
                        }
                        else
                        {
                            intUserHealth -= intComputerAttack; //Damages user health by 80-100 HP
                            this.pcbUserHP.Width -= (intComputerAttack * 2); //decreases the width of the HP bar to reflect health lost
                        }
                    }
                }
                MessageBox.Show("The computer has played move: " + strComputerMoveName + " and dealt " + intComputerAttack + " damage (HP)."); //Shows what computer has moved
                intTurn = 0; //Switches turn to user
            }
        }
        //Level 3 Games - Easy, Medium, Hard
        public void levelThreeGameplay(int intDifficulty) //level three function for gameplay
        {
            if (intDifficulty == 1) //easy
            {
                intComputerMode = 7; //Level 3 Easy
                intComputerChoice = rndGen.Next(1, 4); //random number from 1 to 3 for moves
                if (intComputerChoice == 1) //Move one
                {
                    strComputerMoveName = "Techno Blast"; //techno blast
                    if (intBlindTurns > 0)
                    {
                        intUserHealth -= 0; //No damage because blind
                        intBlindTurns--; //Subtract from turns
                    }
                    else
                    {
                        intComputerAttack = rndGen.Next(40, 46);
                        if (intUserHealth < intComputerAttack)
                        {
                            intUserHealth = 0; //user loses
                            this.pcbUserHP.Width = 0;
                        }
                        else
                        {
                            intUserHealth -= intComputerAttack; //Damages user health by 40-45 HP
                            this.pcbUserHP.Width -= (intComputerAttack * 2); //decreases the width of the HP bar to reflect health lost
                        }
                    }
                }
                else if (intComputerChoice == 2) //Move two
                {
                    strComputerMoveName = "Cyber Stun"; //cyber stun
                    if (intBlindTurns > 0)
                    {
                        intUserHealth -= 0; //No damage because blind
                        intBlindTurns--; //Subtract from turns
                    }
                    else
                    {
                        intComputerAttack = rndGen.Next(40, 46);
                        if (intUserHealth < intComputerAttack)
                        {
                            intUserHealth = 0; //user loses
                            this.pcbUserHP.Width = 0;
                        }
                        else
                        {
                            intUserHealth -= intComputerAttack; //Damages user health by 40-45 HP
                            this.pcbUserHP.Width -= (intComputerAttack * 2); //decreases the width of the HP bar to reflect health lost
                        }
                    }
                }
                else if (intComputerChoice == 3) //Move three
                {
                    strComputerMoveName = "Hacked."; //hacked
                    if (intBlindTurns > 0)
                    {
                        intUserHealth -= 0; //No damage because blind
                        intBlindTurns--; //Subtract from turns
                    }
                    else
                    {
                        intComputerAttack = rndGen.Next(40, 46);
                        if (intUserHealth < intComputerAttack)
                        {
                            intUserHealth = 0; //user loses
                            this.pcbUserHP.Width = 0;
                        }
                        else
                        {
                            intUserHealth -= intComputerAttack; //Damages user health by 40-45 HP
                            this.pcbUserHP.Width -= (intComputerAttack * 2); //decreases the width of the HP bar to reflect health lost
                        }
                    }
                }
                MessageBox.Show("The computer has played move: " + strComputerMoveName + " and dealt " + intComputerAttack + " damage (HP)."); //Shows what computer has moved
                intTurn = 0; //Switches turn to user
            }
            else if (intDifficulty == 2) //medium
            {
                intComputerMode = 8; //Level 3 Medium
                intComputerChoice = rndGen.Next(1, 4); //random number from 1 to 3 for moves
                if (intComputerChoice == 1) //Move one
                {
                    strComputerMoveName = "Techno Blast"; //techno blast
                    if (intBlindTurns > 0)
                    {
                        intUserHealth -= 0; //No damage because blind
                        intBlindTurns--; //Subtract from turns
                    }
                    else
                    {
                        intComputerAttack = rndGen.Next(45, 61);
                        if (intUserHealth < intComputerAttack)
                        {
                            intUserHealth = 0; //user loses
                            this.pcbUserHP.Width = 0;
                        }
                        else
                        {
                            intUserHealth -= intComputerAttack; //Damages user health by 45-60 HP
                            this.pcbUserHP.Width -= (intComputerAttack * 2); //decreases the width of the HP bar to reflect health lost
                        }
                    }
                }
                else if (intComputerChoice == 2) //Move two
                {
                    strComputerMoveName = "Cyber Stun"; //cyber stun
                    if (intBlindTurns > 0)
                    {
                        intUserHealth -= 0; //No damage because blind
                        intBlindTurns--; //Subtract from turns
                    }
                    else
                    {
                        intComputerAttack = rndGen.Next(45,81);
                        if (intUserHealth < intComputerAttack)
                        {
                            intUserHealth = 0; //user loses
                            this.pcbUserHP.Width = 0;
                        }
                        else
                        {
                            intUserHealth -= intComputerAttack; //Damages user health by 45-80 HP
                            this.pcbUserHP.Width -= (intComputerAttack * 2); //decreases the width of the HP bar to reflect health lost
                        }
                    }
                }
                else if (intComputerChoice == 3) //Move three
                {
                    strComputerMoveName = "Hacked."; //hacked
                    if (intBlindTurns > 0)
                    {
                        intUserHealth -= 0; //No damage because blind
                        intBlindTurns--; //Subtract from turns
                    }
                    else
                    {
                        intComputerAttack = rndGen.Next(90,101);
                        if (intUserHealth < intComputerAttack)
                        {
                            intUserHealth = 0; //user loses
                            this.pcbUserHP.Width = 0;
                        }
                        else
                        {
                            intUserHealth -= intComputerAttack; //Damages user health by 90-100 HP
                            this.pcbUserHP.Width -= (intComputerAttack * 2); //decreases the width of the HP bar to reflect health lost
                        }
                    }
                }
                MessageBox.Show("The computer has played move: " + strComputerMoveName + " and dealt " + intComputerAttack + " damage (HP)."); //Shows what computer has moved
                intTurn = 0; //Switches turn to user
            }
            else if (intDifficulty == 3) //hard
            {
                intComputerMode = 9; //Level 3 Hard
                intComputerChoice = rndGen.Next(1, 4); //random number from 1 to 3 for moves
                if (intComputerChoice == 1) //Move one
                {
                    strComputerMoveName = "Techno Blast"; //techno blast
                    if (intBlindTurns > 0)
                    {
                        intUserHealth -= 0; //No damage because blind
                        intBlindTurns--; //Subtract from turns
                    }
                    else
                    {
                        intComputerAttack = rndGen.Next(70, 76);
                        if (intUserHealth < intComputerAttack)
                        {
                            intUserHealth = 0; //user loses
                            this.pcbUserHP.Width = 0;
                        }
                        else
                        {
                            intUserHealth -= intComputerAttack; //Damages user health by 70-75 HP
                            this.pcbUserHP.Width -= (intComputerAttack * 2); //decreases the width of the HP bar to reflect health lost
                        }
                    }
                }
                else if (intComputerChoice == 2) //Move two
                {
                    strComputerMoveName = "Cyber Stun"; //cyber stun
                    if (intBlindTurns > 0)
                    {
                        intUserHealth -= 0; //No damage because blind
                        intBlindTurns--; //Subtract from turns
                    }
                    else
                    {
                        intComputerAttack = rndGen.Next(80, 86);
                        if (intUserHealth < intComputerAttack)
                        {
                            intUserHealth = 0; //user loses
                            this.pcbUserHP.Width = 0;
                        }
                        else
                        {
                            intUserHealth -= intComputerAttack; //Damages user health by 80-85 HP
                            this.pcbUserHP.Width -= (intComputerAttack * 2); //decreases the width of the HP bar to reflect health lost
                        }
                    }
                }
                else if (intComputerChoice == 3) //Move three
                {
                    strComputerMoveName = "Hacked."; //hacked
                    if (intBlindTurns > 0)
                    {
                        intUserHealth -= 0; //No damage because blind
                        intBlindTurns--; //Subtract from turns
                    }
                    else
                    {
                        intComputerAttack = rndGen.Next(100,101);
                        if (intUserHealth < intComputerAttack)
                        {
                            intUserHealth = 0; //user loses
                            this.pcbUserHP.Width = 0;
                        }
                        else
                        {
                            intUserHealth -= intComputerAttack; //Instant kills
                            this.pcbUserHP.Width -= (intComputerAttack * 2); //decreases the width of the HP bar to reflect health lost
                        }
                    }
                }
                MessageBox.Show("The computer has played move: " + strComputerMoveName + " and dealt " + intComputerAttack + " damage (HP)."); //Shows what computer has moved
                intTurn = 0; //Switches turn to user
            }
        }
        //Random Coin determination from winning
        public int coinsEarned()
        {
            int intCoinsEarned = 0; //Coins earned from game
            if (intComputerMode == 1) //L1 Easy
            {
                intCoinsEarned = rndGen.Next(1, 6); //Coins earned: 1-5
            }
            else if (intComputerMode == 2) //L1 Medium
            {
                intCoinsEarned = rndGen.Next(3, 8); //Coins earned: 3-7
            }
            else if (intComputerMode == 3) //L1 Hard
            {
                intCoinsEarned = rndGen.Next(5, 11); //Coins earned: 5-10
            }
            else if (intComputerMode == 4) //L2 Easy
            {
                intCoinsEarned = rndGen.Next(20,26); //Coins earned: 20-25
            }
            else if (intComputerMode == 5) //L2 Medium
            {
                intCoinsEarned = rndGen.Next(25, 31); //Coins earned: 25-30
            }
            else if (intComputerMode == 6) //L2 Hard
            {
                intCoinsEarned = rndGen.Next(35,41); //Coins earned: 35-40
            }
            else if (intComputerMode == 7) //L3 Easy
            {
                intCoinsEarned = rndGen.Next(60, 71); //Coins earned: 60-70
            }
            else if (intComputerMode == 8) //L3 Medium
            {
                intCoinsEarned = rndGen.Next(70, 81); //Coins earned: 70-80
            }
            else if (intComputerMode == 9) //L3 Hard
            {
                intCoinsEarned = rndGen.Next(80,101); //Coins earned: 80-100
            }
            return intCoinsEarned; //return the calculated coins
        } //coins won from gameplay
    }
}
