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
    public partial class Form3 : Form
    {

        bool goingDown = true;
        bool up, down;
        int delimaSpeed = 10;
        int duterteSpeed = 20;
        bool duterteFlip = false;
        int duterteFlipSec = 300;
        int duterteLife = 100;
        int levelSec = 40;
        int endSec = 0;

        int limaBulletSpeed = 20;
        Random random = new Random();

        public Form3()
        {
            InitializeComponent();
        }

        public bool isGameOver()
        {
            return (duterteLife <= 0) & (endSec >= 2);
        }

        public bool didWin()
        {
            return (duterteLife > 0) & (endSec >= 2);
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            duterteLife = 0;
            endSec = 2;
        }

        private void delimaTimer_Tick(object sender, EventArgs e)
        {
            bool directionBefore = goingDown;
            if (goingDown)
            {
                delima.Top += delimaSpeed;
                if (delima.Top >= (this.Height-delima.Height)) goingDown = false;
            } else
            {
                delima.Top -= delimaSpeed;
                if (delima.Top <= (0-(delima.Height / 2))) goingDown = true;
            }

            if (directionBefore != goingDown) delimaSpeed = random.Next(5, 30);

            foreach (Control lb in this.Controls)
            {
                if (lb is Label && (string)lb.Tag == "lima-bullet")
                {
                    lb.Left -= limaBulletSpeed;
                    if (lb.Left < 0) Controls.Remove(lb);
                    
                    if (lb.Bounds.IntersectsWith(duterte.Bounds))
                    {
                        duterteLife -= 5;
                        duterteFlipTimer.Start();
                        Controls.Remove(lb);
                    }
                }
            }
        }

        private void limaSpawnTimer_Tick(object sender, EventArgs e)
        {
            Label label = new Label();
            label.Text = "-5";
            label.Top = delima.Top + (delima.Height / 2);
            label.Left = delima.Left;
            label.Tag = "lima-bullet";
            label.Font = label1.Font;
            label.ForeColor = label1.ForeColor;
            label.Size = label1.Size;
            label.Visible = true;
            Controls.Add(label);

        }

        private void duterteTimer_Tick(object sender, EventArgs e)
        {
            duterteLifeLabel.Text = "Life: " + duterteLife.ToString();
            if (up && duterte.Top >= 0)
            {
                duterte.Top -= duterteSpeed;
            }
            else if (down && duterte.Top <= (this.Height - (duterte
                                 .Height + duterte.Width)))
            {
                duterte.Top += duterteSpeed;
            }
            if (duterteLife < 50)
            {
                duterteLifeLabel.ForeColor = Color.Red;
            }
            if (duterteLife <= 0)
            {
                endGame();
                gameOverLabel.Show();
                duterte.Image = Properties.Resources.duterte_dead;
            }
        }

        private void endGame()
        {
            delimaTimer.Stop();
            limaSpawnTimer.Stop();
            duterteTimer.Stop();
            duterteFlipTimer.Stop();
            levelTimer.Stop();
            finalTimer.Start();
        }

        private void Form3_KeyUp(object sender, KeyEventArgs e)
        {
            up = false;
            down = false;
        }

        private void duterteFlipTimer_Tick(object sender, EventArgs e)
        {
            if (duterteFlip)
            {
                duterte.Image = Properties.Resources.duterte_dead;
            } else
            {
                duterte.Image = Properties.Resources.duterte;
            }
            duterteFlip = !duterteFlip;
            duterteFlipSec -= duterteFlipTimer.Interval;
            if (duterteFlipSec < 0)
            {
                duterteFlipTimer.Stop();
                duterteFlipSec = 300;
                duterte.Image = Properties.Resources.duterte;
            }
        }

        private void levelTimer_Tick(object sender, EventArgs e)
        {
            levelSec -= 1;
            levelTimeLabel.Text = "Seconds: " + levelSec.ToString();
            if (levelSec <= 0 && duterteLife > 0)
            {
                endGame();
                youWonLabel.Show();
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

        private void Form3_Load(object sender, EventArgs e)
        {
            levelTimeLabel.Text = "Second: " + levelSec.ToString();
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                up = true;
                down = false;
            }
            else if (e.KeyCode == Keys.Down)
            {
                up = false;
                down = true;
            }
        }
    }
}
