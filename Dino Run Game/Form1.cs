using System.Transactions;

namespace Dino_Run_Game
{
    public partial class Form1 : Form
    {
        bool jumping = false;
        int jumpSpeed = 12;
        int force = 12;
        int score = 00000;
        int obstacleSpeed = 10;
        Random rand = new Random();
        int position;
        bool isGameOver = false;




        public Form1()
        {
            InitializeComponent();
            txtHighScoreValue.Text = Properties.Settings.Default.high_score;
            GameReset();
        }



        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            dino.Top += jumpSpeed;

            txtScore.Text = score.ToString("D5");

            if (jumping == true && force < 0)
            {
                jumping = false;
            }


            if (jumping == true)
            {
                jumpSpeed = -12;
                force -= 1;
            }
            else
            {
                jumpSpeed = 12;
            }

            if (dino.Top > 319 && jumping == false)
            {
                force = 12;
                dino.Top = 320;
                jumpSpeed = 0;
            }


            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    x.Left -= obstacleSpeed;

                    if (x.Left < -100)
                    {
                        x.Left = this.ClientSize.Width + rand.Next(200, 500) + (x.Width * 15);
                        score++;
                    }

                    if (dino.Bounds.IntersectsWith(x.Bounds))
                    {
                        GameOver();
                    }
                }
            }

            if (score > 10)
            {
                obstacleSpeed = 15;
            }
        }


        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && jumping == false)
            {
                jumping = true;
            }

        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (jumping == true)
            {
                jumping = false;
            }

            if (e.KeyCode == Keys.R && isGameOver == true)
            {
                GameReset();
            }
        }
        private void GameOver()
        {
            gameTimer.Stop();
            dino.Image = Properties.Resources.dead;
            txtRestart.Text = " Press R to restart the game ";
            isGameOver = true;

            int a = Int32.Parse(txtHighScoreValue.Text);
            if (score > a)
            {
                txtHighScoreValue.Text = score.ToString("D5");
                Properties.Settings.Default.high_score = score.ToString("D5");
                Properties.Settings.Default.Save();
            }
        }
        private void GameReset()
        {
            force = 12;
            jumpSpeed = 00000;
            jumping = false;
            score = 0;
            obstacleSpeed = 10;
            txtScore.Text = score.ToString("D5");
            dino.Image = Properties.Resources.running;
            isGameOver = false;
            dino.Top = 320;
            txtRestart.Text = " ";

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    position = this.ClientSize.Width + rand.Next(500, 800) + (x.Width * 10);

                    x.Left = position;
                }

            }

            gameTimer.Start();

        }

    }

}


