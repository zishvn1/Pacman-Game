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

namespace PacMan_Game
{
    public partial class Leaderboard : Form
    {
        public Leaderboard()
        {
            InitializeComponent();
            NameList.DataSource = File.ReadAllLines("highscore.txt");
            // this code tells the program to read the contents of the text file and display it on the listbox. the contects will consist of
            // the players username and score
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
            
        {
   
        }

        private void Leaderboard_Load(object sender, EventArgs e)
        {
           
        }
    }
} 
