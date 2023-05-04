using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using System.IO;

namespace PacMan_Game
{
    public partial class Insertnameform : Form
    {
        private string hard;
        private int score;
        public static string username;

        public Insertnameform()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            username = nameBox1.Text;
            string highScore = PacManForm.myScore;
            string path = ("highscore.txt");
            string lines = (username +" ------ " + highScore + "\n");
            File.AppendAllText(path, lines);
            Leaderboard opennamess = new Leaderboard();
            opennamess.ShowDialog();

            // this code will allow the user to insert their name into the text box
            //and then the program will display their name and score into the leaderboard form, it also opens the leaderboard form .


            MessageBox.Show( username + " Your final Score has been Saved!");
            // this code above will show a message box saying "Your final score has been saved!" once the user clicks Continue
        }

        private void Insertnameform_Load(object sender, EventArgs e)
        {

        }

        private void closeFrm_Click(object sender, EventArgs e)
        {
            this.Hide();
            //the code above will close this form 


            DialogResult result = MessageBox.Show("You Lose!!", "Another GO?", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                PacManForm openPacFrm = new PacManForm();
                openPacFrm.ShowDialog();
            }
            else
            {
                MenuForm openMenuFrm = new MenuForm();
                openMenuFrm.ShowDialog();
               
                // the code above from line 55 onwards will display a message box with a yes or no option, 
                //it will ask the user whether they want to play again or not. if they click "yes" 
                //then the Easy pacman form will open, but if they click no then the main menu form will open

            }
        }
    
    }
}
