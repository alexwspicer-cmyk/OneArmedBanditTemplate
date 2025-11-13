using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace OneArmedBandit
{
    public partial class Form1 : Form
    {
        // random number generator
        Random randNum = new Random();

        // int value for score initialized to 10
        int score = 25;
        int seven = 1;
        int cherries = 2;
        int diamonds = 3;

        string reel1;
        string reel2;
        string reel3;

        public Form1()
        {
            InitializeComponent();
            scoreDisplay.Text = score.ToString();
        }

        private void spinButton_Click(object sender, EventArgs e) 
        {

            // get random values for each reel (store each in separate int variable)

            // check value of reel 1 with a switch statement to set appropriate image to
            // BackgroundImage property of pictureBox. Get images from Properties.Resources

            int i = 0;
            while (i <= 5)
            {
                outputLabel.Text = "Spinning!";
                switch (randNum.Next(0, 3)) //This is the short animation of it spinning for the first reel
                {
                    case 0:
                        //If the num is 0, it gives you 7s
                        pictureBox1.BackgroundImage = OneArmedBandit.Properties.Resources._7_100x125;
                        break;
                    case 1:
                        //If the num is 1, it gives you cherries
                        pictureBox1.BackgroundImage = OneArmedBandit.Properties.Resources.cherry_100x125;
                        break;
                    case 2:
                        //If the num is 2, it gives you diamonds
                        pictureBox1.BackgroundImage = OneArmedBandit.Properties.Resources.diamond_100x125;
                        break;
                        
                }
                switch (randNum.Next(0, 3)) //This is the short animation of it spinning for the second reel
                {
                    case 0:
                        //If the num is 0, it gives you 7s
                        pictureBox2.BackgroundImage = OneArmedBandit.Properties.Resources._7_100x125;
                        break;
                    case 1:
                        //If the num is 1, it gives you cherries
                        pictureBox2.BackgroundImage = OneArmedBandit.Properties.Resources.cherry_100x125;
                        break;
                    case 2:
                        //If the num is 2, it gives you diamonds
                        pictureBox2.BackgroundImage = OneArmedBandit.Properties.Resources.diamond_100x125;
                        break;

                }
                switch (randNum.Next(0, 3)) //This is the short animation of it spinning for the third reel
                {
                    case 0:
                        //If the num is 0, it gives you 7s
                        pictureBox3.BackgroundImage = OneArmedBandit.Properties.Resources._7_100x125;
                        break;
                    case 1:
                        //If the num is 1, it gives you cherries
                        pictureBox3.BackgroundImage = OneArmedBandit.Properties.Resources.cherry_100x125;
                        break;
                    case 2:
                        //If the num is 2, it gives you diamonds
                        pictureBox3.BackgroundImage = OneArmedBandit.Properties.Resources.diamond_100x125;
                        break;

                }
                i++;
                Refresh();
                Thread.Sleep(100);
            }

            switch (randNum.Next(0,3)) //This is the code for reel 1
            {
                case 0:
                    //If the num is 0, it gives you 7s
                    pictureBox1.BackgroundImage = OneArmedBandit.Properties.Resources._7_100x125;
                    reel1 = "7";
                    break;
                case 1:
                    //If the num is 1, it gives you cherries
                    pictureBox1.BackgroundImage = OneArmedBandit.Properties.Resources.cherry_100x125;
                    reel1 = "cherry";
                    break;
                case 2:
                    //If the num is 2, it gives you diamonds
                    pictureBox1.BackgroundImage = OneArmedBandit.Properties.Resources.diamond_100x125;
                    reel1 = "diamond";
                    break;

            }

            // check value of reel 2 with a switch statement to set appropriate image to
            // BackgroundImage property of pictureBox. Get images from Properties.Resources

            switch (randNum.Next(0, 3)) //This is the code for reel 2
            {
                case 0:
                    //If the num is 0, it gives you 7s
                    pictureBox2.BackgroundImage = OneArmedBandit.Properties.Resources._7_100x125;
                    reel2 = "7";
                    break;
                case 1:
                    //If the num is 1, it gives you cherries
                    pictureBox2.BackgroundImage = OneArmedBandit.Properties.Resources.cherry_100x125;
                    reel2 = "cherry";
                    break;
                case 2:
                    //If the num is 2, it gives you diamonds
                    pictureBox2.BackgroundImage = OneArmedBandit.Properties.Resources.diamond_100x125;
                    reel2 = "diamond";
                    break;

            }

            // check value of reel 3 with a switch statement to set appropriate image to
            // BackgroundImage property of pictureBox. Get images from Properties.Resources

            switch (randNum.Next(0, 3)) //This is the code for reel 3
            {
                case 0:
                    //If the num is 0, it gives you 7s
                    pictureBox3.BackgroundImage = OneArmedBandit.Properties.Resources._7_100x125;
                    reel3 = "7";
                    break;
                case 1:
                    //If the num is 1, it gives you cherries
                    pictureBox3.BackgroundImage = OneArmedBandit.Properties.Resources.cherry_100x125;
                    reel3 = "cherry";
                    break;
                case 2:
                    //If the num is 2, it gives you diamonds
                    pictureBox3.BackgroundImage = OneArmedBandit.Properties.Resources.diamond_100x125;
                    reel3 = "diamond";
                    break;

            }

            /// STOP HERE ----------------------------------------------------------
            /// Test to make sure that your program will display random
            /// images to each reel. Only continue on after you know this works
            /// --------------------------------------------------------------------


            // Use compound if statement to check if all reels are equal. 
            // If yes show "winner" statement and add 3 to score.
            // If no show "play again" statement and subtract 1 from score.         

            if (reel1 == "7" && reel2 == "7" && reel3 == "7")
            {
                score += 3;
                outputLabel.Text = "Winner!";
            }
            else if (reel1 == "cherry" && reel2 == "cherry" && reel3 == "cherry")
            {
                score += 3;
                outputLabel.Text = "Winner!";
            }
            else if (reel1 == "diamond" && reel2 == "diamond" && reel3 == "diamond")
            {
                score += 3;
                outputLabel.Text = "Winner!";
            }
            else
            {
                score -= 1;
                outputLabel.Text = "Play Again";
            }

            // if score has reached 0 display "lose" message and set button enabled property to false

            if (score  == 0)
            {
                outputLabel.Text = "Loser";
                spinButton.Enabled = false;
            }

            // display updated score

            scoreDisplay.Text = score.ToString();

        }
    }
}
