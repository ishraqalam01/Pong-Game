//Name: Ishraq Alam
//Date: June 5, 2024
//Title: A10PongMovingGameIA
//Purpose: To create a Pong game application where the user can play against an AI. 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovingGamePractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //variable Declaration 
        static int intSpeed = 3; //Speed of the ball 
        static int intDirection = 1; //Initial direction that the ball is traveling in (changed from 1-4 later)
        static int intHMove = intSpeed; //The horizontal location change of the ball
        static int intVMove = intSpeed; //The vertical location change of the ball 
        static int intAngle = 45; //The angle that the ball travels at after hitting the paddle

        static int intBottomBound; //The bottom boundary (if hit, computer wins)
        static int intTopBound; //The top boundary (if hit, user wins)
        static int intPaddleSize; //The size of the user's paddle which gets split into 3 parts
        static int intPaddleLeft; //The left third of the user's paddle 
        static int intPaddleMiddle; //The middle third of the user's paddle 
        static int intPaddleRight; //The right third of the user's paddle 
        static int intComputerPaddleSize; //The size of the computer's paddle which gets split into 3 parts 
        static int intComputerPaddleLeft; //The left third of the computer's paddle 
        static int intComputerPaddleMiddle; //The middle third of the computer's paddle  
        static int intComputerPaddleRight; //The right third of the computer's paddle 

        static int intNumUserHits = 0; //Number of times ball hits user's paddle 
        static int intCurrentScore = 0; //The current score of the user 
        static int intHighScore = 0; //The highest score of the user 

        static int intUserWins = 0;
        static int intComputerWins = 0;


        Random RandomClass = new Random(); //Random number generator 

        public int horizontalVal(int intHyp, int intDegree) //horizontal displacement function
        {
            return (int)(intHyp * Math.Cos((double)intDegree * Math.PI / 180)); //Used to calculate the horizontal displacement of the ball over time using the formula (hyp * cos x = adj)
        }

        public int verticalVal(int intHyp, int intDegree) //vertical displacement function
        {
            return (int)(intHyp * Math.Sin((double)intDegree * Math.PI / 180)); //Used to calculate the vertical displacement of the ball over time using the formula (hyp * sin x = opp)
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmrGame.Enabled = true; //Enables the timer
        }





        private void tmrGame_Tick(object sender, EventArgs e)
        {
            intHMove = horizontalVal(intSpeed, intAngle); //Sets the horizontal displacement by using speed as hypotenuse and angle for cos/sin calc
            intVMove = verticalVal(intSpeed, intAngle); //Sets the vertical displacement by using speed as hypotenuse and angle for cos/sin calc



            //bumps
            //Anti-Clockwise
            if (pcbBall.Left + pcbBall.Width > this.Width && intDirection == 1) //If the ball touches the right boundary of the window form, it will go up left 
            {
                intDirection = 2;
            }

            else if (pcbBall.Left < 0 && intDirection == 3) //If the ball touches the left boundary of the window form, it will go down right
            {
                intDirection = 4;

            }

            else if (pcbBall.Top > intBottomBound && intDirection == 4) //If the ball touches the bottom boundary, the user loses
            {
                this.tmrGame.Enabled = false; //Stops timer
                MessageBox.Show("You lost! You can start the game over again."); //Loss message
                this.pcbBall.Left = this.Width / 2; //Places ball back to set place 
                this.pcbBall.Top = this.Width / 3; //Places ball back to set place 
                this.pcbComputerPaddle.Left = this.Width / 2; //Sets comp paddle back  
                this.pcbInvisibleComputerPaddle.Left = this.Width / 2; //Sets comp paddle back 
                intDirection = 1; //Resets direction ball will start going in 

                intCurrentScore = intNumUserHits; //The current score is the number of hits user gets 

                if (intCurrentScore > intHighScore) //If the current score outperforms the high score, then it will replace, if not, it won't 
                {
                    intHighScore = intCurrentScore; //Changes high score value 
                    this.lblHighScoreValue.Text = intHighScore.ToString(); //Changes high score value 
                }

                intNumUserHits = 0; //Resets number of times user hits paddle 
                this.lblCurrentScoreValue.Text = intNumUserHits.ToString(); //Resets value on window 

                intComputerWins++; //Increases number of wins by computer
                this.lblCompWinsValue.Text = intComputerWins.ToString(); //Increases number of wins on windows form
            }

            else if (pcbBall.Top < intTopBound && intDirection == 2) //If the ball touches the top boundary, the computer loses 
            {
                this.tmrGame.Enabled = false; //Stops timer
                MessageBox.Show("You won! You can start the game over again."); //Win Message
                this.pcbBall.Left = this.Width / 2; //Places ball back to set place 
                this.pcbBall.Top = this.Width / 3; //Places ball back to set place 
                this.pcbComputerPaddle.Left = this.Width / 2; //Sets comp paddle back  
                this.pcbInvisibleComputerPaddle.Left = this.Width / 2; //Sets comp paddle back 
                intDirection = 1; //Resets direction ball will start going in 

                intCurrentScore = intNumUserHits; //The current score is the number of hits user gets 

                if (intCurrentScore > intHighScore) //If the current score outperforms the high score, then it will replace, if not, it won't 
                {
                    intHighScore = intCurrentScore; //Changes high score value 
                    this.lblHighScoreValue.Text = intHighScore.ToString(); //Changes high score value 
                }

                intNumUserHits = 0; //Resets number of times user hits paddle 
                this.lblCurrentScoreValue.Text = intNumUserHits.ToString(); //Resets value on window 

                intUserWins++; //Increases win count for user 
                this.lblUserWinsValue.Text = intUserWins.ToString(); //Changes value on windows form
            }

            //ClockWise
            if (pcbBall.Left < 0 && intDirection == 2) //If the ball touches the left boundary, it goes up right 
            {
                intDirection = 1;

            }

            else if (pcbBall.Left + pcbBall.Width > this.Width && intDirection == 4) //If the ball touches the right boundary, it goes down left 
            {
                intDirection = 3;

            }

            else if (pcbBall.Top > intBottomBound && intDirection == 3) //If the ball touches the bottom boundary 
            {
                this.tmrGame.Enabled = false; //Stops timer
                MessageBox.Show("You lost! You can start the game over again."); //Loss message
                this.pcbBall.Left = this.Width / 2; //Places ball back to set place 
                this.pcbBall.Top = this.Width / 3; //Places ball back to set place 
                this.pcbComputerPaddle.Left = this.Width / 2; //Sets comp paddle back  
                this.pcbInvisibleComputerPaddle.Left = this.Width / 2; //Sets comp paddle back 
                intDirection = 1; //Resets direction ball will start going in 

                intCurrentScore = intNumUserHits; //The current score is the number of hits user gets 

                if (intCurrentScore > intHighScore) //If the current score outperforms the high score, then it will replace, if not, it won't 
                {
                    intHighScore = intCurrentScore; //Changes high score value 
                    this.lblHighScoreValue.Text = intHighScore.ToString(); //Changes high score value 
                }

                intNumUserHits = 0; //Resets number of times user hits paddle 
                this.lblCurrentScoreValue.Text = intNumUserHits.ToString(); //Resets value on window 

                intComputerWins++; //Increases number of wins by computer
                this.lblCompWinsValue.Text = intComputerWins.ToString(); //Increases number of wins on windows form


            }

            else if (pcbBall.Top < intTopBound && intDirection == 1) //If the ball touches the top boundary 
            {
                this.tmrGame.Enabled = false; //Stops timer
                MessageBox.Show("You won! You can start the game over again."); //Win Message
                this.pcbBall.Left = this.Width / 2; //Places ball back to set place 
                this.pcbBall.Top = this.Width / 3; //Places ball back to set place 
                this.pcbComputerPaddle.Left = this.Width / 2; //Sets comp paddle back  
                this.pcbInvisibleComputerPaddle.Left = this.Width / 2; //Sets comp paddle back 
                intDirection = 1; //Resets direction ball will start going in 

                intCurrentScore = intNumUserHits; //The current score is the number of hits user gets 

                if (intCurrentScore > intHighScore) //If the current score outperforms the high score, then it will replace, if not, it won't 
                {
                    intHighScore = intCurrentScore; //Changes high score value 
                    this.lblHighScoreValue.Text = intHighScore.ToString(); //Changes high score value 
                }

                intNumUserHits = 0; //Resets number of times user hits paddle 
                this.lblCurrentScoreValue.Text = intNumUserHits.ToString(); //Resets value on window 

                intUserWins++; //Increases win count for user 
                this.lblUserWinsValue.Text = intUserWins.ToString(); //Changes value on windows form
            }
            //These control the direction the ball continues to travel in 
            if (intDirection == 1) //Travelling Top right
            {
                intHMove = Math.Abs(intHMove); //Horizontal stays same 
                intVMove = Math.Abs(intVMove) * -1; //Vertical goes up (negative)
            }

            else if (intDirection == 2)
            {
                intHMove = Math.Abs(intHMove) * -1; //Horizontal goes left (negative)
                intVMove = Math.Abs(intVMove) * -1; //Vertical goes up (negative)
            }

            else if (intDirection == 3)
            {
                intHMove = Math.Abs(intHMove) * -1; //Horizontal goes left (negative)
                intVMove = Math.Abs(intVMove); //Vertical stays same 
            }

            else if (intDirection == 4)
            {
                intHMove = Math.Abs(intHMove); //Horizontal stays same 
                intVMove = Math.Abs(intVMove); //Vertical stays same 
            }

            intPaddleSize = this.pcbPaddle.Left + 215; //Finds the size of the paddle respective to moving location 
            intPaddleLeft = intPaddleSize / 3; //Divides into 3, assigns left third to this 
            intPaddleMiddle = intPaddleLeft + (intPaddleSize / 3); //Assigns middle third to this 
            intPaddleRight = intPaddleSize; //Assigns right third to this 



            //ball hits paddle 
            if (this.pcbPaddle.Bounds.IntersectsWith(this.pcbBall.Bounds)) //If paddle hits the ball 
            {
                if (intNumUserHits % 2 == 0 && intNumUserHits < 20) //If the score is even and below 20
                {
                    intSpeed++; //Speed increases for ball
                }

                else if (intNumUserHits % 2 != 0 && intNumUserHits < 20) //If the score is odd and below 20
                {
                    intSpeed--; //Speed  decreases for ball 
                }

                else if (intNumUserHits % 2 == 0 && intNumUserHits > 20) //If the score is even and above 20
                {
                    //Speed increases twice for ball 
                    intSpeed++;
                    intSpeed++;
                }

                else if (intNumUserHits % 2 != 0 && intNumUserHits > 20) //If the score is odd and above 20
                {
                    //Speed decreases for ball 
                    intSpeed--;
                    
                }
                //how the ball bounces

                if (this.pcbBall.Width < intPaddleLeft) //if the ball touches the left part of the paddle 
                {
                    intNumUserHits++; //The score increases
                    
                    
                    this.lblCurrentScoreValue.Text = intNumUserHits.ToString(); //Changes current score value on window 
                    int rndAngle = RandomClass.Next(20, 61); //Generates random angle for ball to travel at 

                    intAngle = rndAngle; //Changes angle value 

                    if (intDirection == 4) //If the direction is 4, changes to 1
                    {
                        intDirection = 1;

                    }

                    else if (intDirection == 3) //If the direction is 3, changes to 2
                    {
                        intDirection = 2;
                    }

                }

                else if (this.pcbBall.Width >= intPaddleLeft && this.pcbBall.Width <= intPaddleMiddle) //If ball hits middle part of paddle 
                {
                    intNumUserHits++; //Updates score
                    this.lblCurrentScoreValue.Text = intNumUserHits.ToString(); //Changes score value on window 
                    int rndAngle = RandomClass.Next(61, 121); //Generates random angle for ball to travel 

                    intAngle = rndAngle; //Changes angle value 

                    if (intDirection == 4) //if direction is 4, changes to 1
                    {
                        intDirection = 1;


                    }

                    else if (intDirection == 3) //If direction is 3, changes to 2 
                    {
                        intDirection = 2;

                    }
                }

                else if (this.pcbBall.Width > intPaddleMiddle && this.pcbBall.Width <= intPaddleRight) //If ball hits right part of paddle
                {
                    intNumUserHits++; //Changes score 
                    this.lblCurrentScoreValue.Text = intNumUserHits.ToString(); //Updates score value 
                    int rndAngle = RandomClass.Next(121, 160); //Makes ball go at a random angle 

                    intAngle = rndAngle; //Changes angle 

                    if (intDirection == 4) //If direction is 4, changes to 1 
                    {
                        intDirection = 1;

                    }

                    else if (intDirection == 3) //If direction is 3, changes to 2
                    {
                        intDirection = 2;

                    }

                }



            }
            
            



            //move ball 
            intComputerPaddleSize = this.pcbInvisibleComputerPaddle.Left + 215; //Finds computer paddle size 
            intComputerPaddleLeft = intComputerPaddleSize / 3; //Finds left part of computer paddle 
            intComputerPaddleMiddle = intComputerPaddleLeft + (intComputerPaddleSize / 3); //Finds middle part of computer paddle 
            intComputerPaddleRight = intComputerPaddleSize; //Finds Right part of computer paddle 

            if (this.pcbInvisibleComputerPaddle.Bounds.IntersectsWith(this.pcbBall.Bounds)) //Checks if the Invisible, attached part of the paddle connected to computer paddle, is hit by the ball - This is because the ball shouldn't sink into the computer's paddle
            {
                
                if (this.pcbBall.Width < intComputerPaddleLeft) //If the ball touches the left part of computer paddle 
                {

                    int rndAngle = RandomClass.Next(20, 61); //Generates random angle 

                    intAngle = rndAngle; //Updates angle 
                     
                    if (intDirection == 1) //If direction is 1, changes to 4 
                    {
                        intDirection = 4;
                    }

                    else if (intDirection == 2) //If direction is 2, changes to 3 
                    {
                        intDirection = 3;
                    }

                }

                else if (this.pcbBall.Width >= intComputerPaddleLeft && this.pcbBall.Width <= intComputerPaddleMiddle) //If ball hits middle part of paddle 
                {

                    int rndAngle = RandomClass.Next(61, 121); //Generates random angle 

                    intAngle = rndAngle; //Changes angle value 

                    if (intDirection == 1) //if direction is 1, changes to 4 
                    {
                        intDirection = 4;


                    }

                    else if (intDirection == 2) //if direction is 2, changes to 3
                    {
                        intDirection = 3;

                    }
                }

                else if (this.pcbBall.Width  > intComputerPaddleMiddle && this.pcbBall.Width <= intComputerPaddleRight) //If ball touches right part of paddle 
                {

                    int rndAngle = RandomClass.Next(121, 160); //Generates random angle 

                    intAngle = rndAngle; //Changes angle value 

                    if (intDirection == 1) //If direction is 1, changes to 4 
                    {
                        intDirection = 4;

                    }

                    else if (intDirection == 2) //If direction is 2, changes to 3 
                    {
                        intDirection = 3;

                    }

                }


            }

            ErrorFactor(); //Incorporates error factor to ensure computer does not win 100% of the time. If the random number in the method and score value matchup, then the computer will lose 
            this.pcbBall.Left += intHMove; //Ball's horizontal displacement 
            this.pcbBall.Top += intVMove; //Ball's vertical displacement 
            this.pcbComputerPaddle.Left += intHMove; //The computer paddle tracks the ball's horizontal displacement (AI)
            this.pcbInvisibleComputerPaddle.Left += intHMove; //The invisible part of the computer paddle follows the computer paddle around (AI)
        }

        public void ErrorFactor() //Error factor used to make game more fair - paddle slows down when approaching the ball 
        {
            int rndRandomErrorFactor = RandomClass.Next(10, 40); //Generates random number between 10 and 40. If the score lands on the random number or nearby number, then it will ensure the computer will lose within the score of 40

            if (intNumUserHits == rndRandomErrorFactor || intNumUserHits == rndRandomErrorFactor - 1 || intNumUserHits == rndRandomErrorFactor - 2 || intNumUserHits == rndRandomErrorFactor + 1 || intNumUserHits == rndRandomErrorFactor + 2)
            {
                this.pcbComputerPaddle.Left -= intHMove; //Slows down computer paddle if matches criteria 
                this.pcbInvisibleComputerPaddle.Left -= intHMove; //Slows down computer paddle if matches criteria 
            }

            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to Ishraq's Version of Pong! \n Use the \"A\" and \"D\" keys to move your paddle left and right.");
            intBottomBound = this.pcbPaddle.Top + this.pcbPaddle.Height; //Player out of bounds 

            intTopBound = this.pcbComputerPaddle.Top; //Computer out of bounds

        }
        
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //paddles move left and right 

            if (e.KeyData == Keys.D) //If the user clicks "D", the paddle will move to the right by 10
            {
                this.pcbPaddle.Left += 10;

            }

            else if (e.KeyData == Keys.A) //If the user clicks "A", the paddle will move to the left by 10
            {
                this.pcbPaddle.Left -= 10;
            }
        }

        

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Exits the application
        }
    }
}
