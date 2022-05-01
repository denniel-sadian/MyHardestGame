namespace MyHardestGame
{
    public partial class Form1 : Form
    {

        int counts = 0;
        int levelsWon = 0;
        Form2? level1;
        Form3? level2;
        Form4? level3;
        Form5? wonPage;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            startTimer.Start();
            this.BackColor = Color.Black;
            welcomeTo.Hide();
            gameName.Hide();
            startBtn.Hide();
        }

        private void startTimer_Tick(object sender, EventArgs e)
        {
            counts++;
            if (counts == 1)
            {
                this.BackColor = Color.White;
                welcomeTo.Show();
            }
            else if (counts == 3)
            {
                gameName.Show();
            }
            else if (counts == 4)
            {
                this.BackColor = Color.Red;
                welcomeTo.ForeColor = Color.White;
                gameName.ForeColor = Color.White;
            }
            else if (counts == 5)
            {
                this.BackColor = Color.Green;
            }
            else if (counts == 6)
            {
                this.BackColor = Color.Blue;
                this.startBtn.Show();
                this.startBtn.BackColor = Color.White;
                this.startTimer.Stop();
            }
        }

        private void nullTheLevels()
        {
            level1 = null;
            level2 = null;
            level3 = null;
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            nullTheLevels();
            levelsWon = 0;
            level1 = new Form2();
            level1.Show();
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            if (level1 != null && levelsWon == 0)
            {
                if (level1.didWin())
                {
                    nullTheLevels();
                    levelsWon = 1;
                    level2 = new Form3();
                    level2.Show();
                }
                else if (level1.isGameOver())
                {
                    nullTheLevels();
                    this.Show();
                    levelsWon = 0;
                }
            }
            else if (level2 != null && levelsWon == 1)
            {
                if (level2.didWin())
                {
                    nullTheLevels();
                    levelsWon = 2;
                    level3 = new Form4();
                    level3.Show();
                }
                else if (level2.isGameOver())
                {
                    nullTheLevels();
                    this.Show();
                    levelsWon = 0;
                }
            }
            else if (level3 != null && levelsWon == 2)
            {
                if (level3.didWin())
                {
                    nullTheLevels();
                    wonPage = new Form5();
                    wonPage.Show();
                }
                else if (level3.isGameOver())
                {
                    nullTheLevels();
                    this.Show();
                    levelsWon = 0;
                }
            }
            else if (wonPage != null && wonPage.IsDisposed)
            {
                wonPage = null;
                this.Show();
            }
        }
    }
}