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
    public partial class Form2 : Form
    {
        Random random = new Random();
        
        bool back, forward;
        bool won = false;
        int respawnSec = 0;
        int endSec = 0;
        int duterteSpeed = 10;
        int bulletSpeed = 20;
        int lives = 3;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            duterte.Image = Properties.Resources.duterte;
            leni.Image = Properties.Resources.leni;
            livesLabel.Text = "Lives: " + lives.ToString();
            gameOverLabel.Hide();
            wonLabel.Hide();
            respawnTimer.Stop();
            duterteTimer.Start();
            bulletTimer.Start();
        }

        public bool isGameOver()
        {
            return (lives <= 0) & (endSec >= 2);
        }

        public bool didWin()
        {
            return won & (endSec >= 2);
        }

        private void duterteTimer_Tick(object sender, EventArgs e)
        {
            if (back && duterte.Location.X > 0)
            {
                duterte.Left -= duterteSpeed;
            } else if (forward && duterte.Location.X + duterte.Width < this.Width)
            {
                duterte.Left += duterteSpeed;
            }

            if (duterte.Bounds.IntersectsWith(leni.Bounds))
            {
                bulletTimer.Stop();
                duterteTimer.Stop();
                leni.Image = Properties.Resources.leni_hearts;
                duterte.Image = Properties.Resources.duterte_hearts;
                wonLabel.Show();
                saveMeLabel.Hide();
                finalTimer.Start();
                won = true;
            }
        }

        private void Form2_KeyUp(object sender, KeyEventArgs e)
        {
            forward = false;
            back = false;
        }

        private void bulletTimer_Tick(object sender, EventArgs e)
        {
            foreach (Control b in this.Controls)
            {
                if (b is PictureBox && (string) b.Tag == "bullet")
                {
                    b.Top += bulletSpeed;

                    if (duterte.Bounds.IntersectsWith(b.Bounds))
                    {
                        duterteTimer.Stop();
                        bulletTimer.Stop();
                        duterte.Image = Properties.Resources.duterte_dead;
                        respawnTimer.Start();
                        lives--;
                        livesLabel.Text = "Lives: " + lives.ToString();
                    }
                    
                    if (this.Height < b.Top)
                    {
                        b.Top = random.Next(-2000, 0);
                        b.Left = random.Next(duterte.Width + 50, this.Width - (duterte.Width + 50));
                    }
                }
            }
        }

        private void respawnTimer_Tick(object sender, EventArgs e)
        {
            if (respawnSec >= 1)
            {
                if (lives <= 0)
                {
                    gameOverLabel.Show();
                    duterteTimer.Stop();
                    respawnTimer.Stop();
                    bulletTimer.Stop();
                    finalTimer.Start();
                    return;
                }
                duterte.Left = 0;
                duterteTimer.Start();
                bulletTimer.Start();
                duterte.Image = Properties.Resources.duterte;
                respawnSec = 0;
                respawnTimer.Stop();
            }

            respawnSec++;
        }

        private void finalTimer_Tick(object sender, EventArgs e)
        {
            endSec++;
            if (endSec > 2)
            {
                this.Hide();
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            lives = 0;
            endSec = 2;
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                back = true;
                forward = false;
            }
            else if (e.KeyCode == Keys.Right)
            {
                forward = true;
                back = false;
            }
        }
    }
}
