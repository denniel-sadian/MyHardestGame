using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHardestGame
{
    public partial class Form4 : Form
    {

        Point startingPoint;
        bool won = false;
        int seconds = 60;
        int endSec = 0;

        public Form4()
        {
            InitializeComponent();
            startingPoint = startLocation.Location;
            Cursor.Position = PointToScreen(startingPoint);
            timerLabel.Text = "Seconds Left: " + seconds.ToString();
        }

        private void wallEnter(object sender, EventArgs e)
        {
            if (!won)
            {
                startingPoint = startLocation.Location;
                Cursor.Position = PointToScreen(startingPoint);
            }
        }

        private void winWin(object sender, EventArgs e)
        {
            won = true;
            youWonLabel.Show();
            finalTimer.Start();
            levelTimer.Stop();
        }

        private void levelTimer_Tick(object sender, EventArgs e)
        {
            seconds--;
            timerLabel.Text = "Seconds Left: " + seconds.ToString();
            if (seconds <= 0)
            {
                gameOverLabel.Show();
                levelTimer.Stop();
                finalTimer.Start();
            }
            if (seconds < 30)
            {
                timerLabel.ForeColor = Color.Red;
            }
        }

        private void finalTimer_Tick(object sender, EventArgs e)
        {
            endSec++;
            if (endSec > 2)
            {
                this.Hide();
            }
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            seconds = 0;
            endSec = 2;
        }

        public bool isGameOver()
        {
            return !won & (seconds <= 0) & (endSec >= 2);
        }

        public bool didWin()
        {
            return won & (endSec >= 2);
        }
    }
}
