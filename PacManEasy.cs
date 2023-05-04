using System;
using System.Windows.Forms;

namespace PacMan_Game
{
    public partial class PacManForm : Form
    {

        bool goUp, goDown, goLeft, goRight, isGameOver;
        int playerSpeed, redGhostSpeed, yellowGhostSpeed, pinkGhostX, pinkGhostY;
        public static int score;
        public static string myScore;



        private void PacManForm_Load(object sender, EventArgs e)
        {

        }

        public PacManForm()
        {
            InitializeComponent();

            resetGame();
        }
        // this code will reset the game every time this form loads


        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
            }
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
        }
        //this block of code allows the user to use the arrows on their keyboard to move pacman


        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goUp = !true;
            }          
            if (e.KeyCode == Keys.Down)
            {
                goDown = !true;
            }
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;                
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Enter && isGameOver == true)
            {
            }
        }
        // this block of code will stop pacman from moving automatically when the user is not pressing the arrows on their keyboard

        private void mainGameTimer(object sender, EventArgs e)
        {
            txtScore.Text = "Score: " + score; //when coin is collected score increases by 1

            if (goLeft == true)// the player will proceed in left direction
            {
                pacman.Left -= playerSpeed;
                pacman.Image = Properties.Resources.left; //the player looks like pacman in left direction
            }
            if (goRight == true) // the player will proceed in right direction
            {
                pacman.Left += playerSpeed;
                pacman.Image = Properties.Resources.right; //the player looks like pacman in right direction
            }
            if (goDown == true) // the player will proceed in down direction
            {
                pacman.Top += playerSpeed;
                pacman.Image = Properties.Resources.down; //the player looks like pacman in down direction
            }
            if (goUp == true) // the player will proceed in up direction
            {
                pacman.Top -= playerSpeed;
                pacman.Image = Properties.Resources.Up; //the player looks like pacman in up direction
            }

            if (pacman.Left < -10)
            { 
                pacman.Left = 893; 
            }
            if (pacman.Left > 893)
            {
                pacman.Left = -10;
            }
            // this block of code from 100 onwards allows pacman to go through the left side of the form and come out of the right side and vice versa.

            if (pacman.Top < -10)
            {
                pacman.Top = 673;
            }
            if (pacman.Top > 673)
            {
                pacman.Top = 0;
            }
            // this block of code from 111 onwards allows pacman to go through the bottom side of the form and come out of the top side and vice versa.


            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "coin" && x.Visible == true) // this code states that the coin is visible
                    {
                        if (pacman.Bounds.IntersectsWith(x.Bounds))
                        {
                            score += 1;
                            x.Visible = false;
                        }
                        // this code from 128 onwards is saying that if pacman comes into contact with a coin,
                        //then make the coin disappear and add 1 point to the score
                    }
                    if ((string)x.Tag == "wall") // this code states there is a wall
                    {
                        if (pacman.Bounds.IntersectsWith(x.Bounds)) // this code from line 136 states if pacman comes into contact with a wall, the game ends.
                        {
                            gameOver("You Lose!");
                            DialogResult result = MessageBox.Show("You Lose!", "Another GO?", MessageBoxButtons.YesNo);
                            // this will display a message box saying "You lose", "another go?" with a yes or no option

                            if (result == DialogResult.Yes)
                            {
                                resetGame();
                            }
                            else
                            {
                                Insertnameform frmHighscore = new Insertnameform();
                                frmHighscore.ShowDialog();
                                // if the user clicks yes on the message box then the game will reset, 
                                // if they click no then the form where the user can insert their name will open.
                            }

                        }

                        if (pinkGhost.Bounds.IntersectsWith(x.Bounds))
                        {
                            pinkGhostX = -pinkGhostX;
                            // this code is saying if the pink ghost intersects with the edges of the form it will bounce off them. 
                        }
                    }

                    if ((string)x.Tag == "ghost")
                    {
                        if (pacman.Bounds.IntersectsWith(x.Bounds)) // this code  if pacman comes into contact with a ghost, the game ends.
                        {
                            gameOver("You Lose!");

                            DialogResult result = MessageBox.Show("You Lose!", "Another GO?", MessageBoxButtons.YesNo);
                            // this will display a message box saying "You lose", "another go?" with a yes or no option

                            if (result == DialogResult.Yes)
                            {
                                resetGame();
                            }
                            else
                            {
                                Insertnameform frmHighscore = new Insertnameform();
                                frmHighscore.ShowDialog();
                                //, if the user clicks yes on the message box then the game will reset, 
                                // if they click no then the form where the user can insert their name will open.
                            }
                        }
                    }
                }
            }


            redGhost.Left += redGhostSpeed;

            if (redGhost.Bounds.IntersectsWith(pictureBox1.Bounds) || redGhost.Bounds.IntersectsWith(pictureBox2.Bounds)) 
            {
                redGhostSpeed = -redGhostSpeed;
                // this code above from line 191 says that the red ghost comes into contact with picture box 1 and 2, it will bounce off them
            }

            yellowGhost.Left -= yellowGhostSpeed;

            if (yellowGhost.Bounds.IntersectsWith(pictureBox3.Bounds) || yellowGhost.Bounds.IntersectsWith(pictureBox4.Bounds))
            {
                yellowGhostSpeed = -yellowGhostSpeed;
                // this code above from line 199 says that the yellow ghost comes into contact with picture box 3 and 4, it will bounce off them
            }

            pinkGhost.Left -= pinkGhostX;
            pinkGhost.Top -= pinkGhostY;

            if (pinkGhost.Top < 0|| pinkGhost.Top > 600) // this code says that if the forms Y axis is smaller than 600 and larger than 0 pixels,
                                                         // then the pink ghost will move freely in that space
            {
                pinkGhostY = -pinkGhostY;
            }

            if (pinkGhost.Left < 0|| pinkGhost.Left > 640) // this code says that if the forms X axis is smaller than 640 and larger than 0 pixels,
                                                           // then the pink ghost will move freely in that space
            {
                pinkGhostX = -pinkGhostX;
            }



            if (score == 96)
            {
                gameOver("You Win!");
                Insertnameform openname = new Insertnameform();
                openname.ShowDialog();
                // this code says if the code is equivalent to 96, display a message box saying "You Win and then open the InsertnameForm.
            }
        }

        private void resetGame()
        {
            txtScore.Text = "Score: 0";
            score = 0;
            // this a code will reset the games score to 0

            redGhostSpeed = 5;
            yellowGhostSpeed = 5;
            pinkGhostX = 5;
            pinkGhostY = 5;
            playerSpeed = 8;
            // this code will determine the speed of the ghosts and PacMan

            isGameOver = false;
            //this code says that the game is not over

            pacman.Left = 31;
            pacman.Top = 76;

            redGhost.Left = 308;
            redGhost.Top = 75;

            yellowGhost.Left = 346;
            yellowGhost.Top = 426;

            pinkGhost.Left = 640;
            pinkGhost.Top = 201;

            //this code shows the sizes of the ghosts and pacman.

            


            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                   x.Visible = true;
                }
                // this says if there are any picture boxes, then they should all be visible

            }
            gameTimer.Start();
            //this code activates the game timer.
        }

        private void gameOver(string message)
        {
            isGameOver = true;
            gameTimer.Stop();
            myScore = score.ToString(); // this changes the score from and int to a string
            txtScore.Text = "Score: " + score + Environment.NewLine + message;
            // this code says that when the game ends and the timer stops timing, the score will be recorded into the leaderboard
        }
    }
}
