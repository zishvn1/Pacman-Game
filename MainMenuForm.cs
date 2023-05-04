using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacMan_Game
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void easyFormBtn_Click(object sender, EventArgs e)
        {
            PacManForm newform = new PacManForm();
            newform.ShowDialog();
           
            // this code will open the easy pacman form 
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }

        private void hardFormBtn_Click(object sender, EventArgs e)
        {
            HardGameForm Hardformm = new HardGameForm();
            Hardformm.Show();
            // this code will open the hard pacman form 
        }

        private void leaderboardBtn_Click(object sender, EventArgs e)
        {
            Leaderboard newform = new Leaderboard();
            newform.ShowDialog();
            // this code will open the leaderboard form 
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
            // this will close the program down
        }
    }
}
