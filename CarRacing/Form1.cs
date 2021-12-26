using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRacing
{
    public partial class Form1 : Form
    {
        int timerSpeed;
        int gameSpeed;
        int carTurnSpeed;
        bool isGameOver;

        PictureBox[] roadlines;
        PictureBox[] enemys;
        PictureBox[] coins;
        Random random;
        int collectedCoins;
        public Form1()
        {
            InitializeComponent();
            init_game();
        }

        void init_game()
        {
            timerSpeed = 100;
            gameSpeed = 4;
            carTurnSpeed = 15;
            isGameOver = false;

            roadlines = new PictureBox[] { pbRoadLine1, pbRoadLine2, pbRoadLine3, pbRoadLine4 };
            enemys = new PictureBox[] { Enemy1, Enemy2, Enemy3 };
            coins = new PictureBox[] { Coin1, Coin2, Coin3, Coin4 };

            random = new Random();
            gen_start_pos();

            collectedCoins = 0;
            lblGameOver.Visible = false;

            gameTimer.Interval = 1000 / timerSpeed;
            gameTimer.Start();
        }
        void gen_start_pos()
        {
            int StartY = -Enemy1.Height;
            int x;
            for(int i = 0; i < enemys.Length; i++)
            {
                x = 
                    random.Next(
                        pbBoundLeft.Right, 
                        pbBoundRight.Left);
                enemys[i].Location = new Point(x, StartY);
                StartY -= this.Height / enemys.Length;
            }
        }

        void gameover_actions()
        {
            gameTimer.Stop();
            lblGameOver.Visible = true;
            Car.Image = Properties.Resources.explosion;

            DialogResult result = MessageBox.Show(
                "Хочешь сыграть еще раз?",
                "Ты проиграл",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                init_game();
            }
            else
            {
                Close();
            }
        }

        void is_gameover() 
        { 
            
        }

        void is_get_coins()
        {
            int x;
            for(int i = 0; i < coins.Length; i++)
            {
                if(Car.Bounds.IntersectsWith(coins[i].Bounds))
                {
                    collectedCoins++;
                    x = random.Next(pbBoundLeft.Right, pbBoundRight.Left - coins[i].Width);
                    coins[i].Location = new Point(x, -coins[i].Height);
                }
            }
            lblCoins.Text = "Coins = " + collectedCoins;
        }

        bool check_intersections()
        {
            for(int i = 0; i < enemys.Length; i++)
            {
                if(Car.Bounds.IntersectsWith (enemys[i].Bounds))
                {
                    return true;
                }
            }
            return false;
        }

        void move_enemys()
        {
            int x;
            for (int i = 0; i < enemys.Length; i++)
            {
                if(enemys[i].Top > this.Height)
                {
                    x = random.Next(pbBoundLeft.Right, pbBoundRight.Left);
                    enemys[i].Location = new Point(x, -enemys[i].Height);
                }
                else
                {
                    enemys[i].Top += gameSpeed;
                }
            }
        }
        void move_coins()
        {
            int x;
            for(int i = 0; i < coins.Length; i++)
            {
                if(coins[i].Top > this.Height)
                {
                    x = random.Next(pbBoundLeft.Right, pbBoundRight.Left - coins[i].Width);
                    coins[i].Location = new Point(x, -coins[i].Height);
                }
                else
                {
                    coins[i].Top += gameSpeed;
                }
            }
        }

        void move_lines() 
        {
            for (int i = 0; i < roadlines.Length; i++)
            {
                if(roadlines[i].Top > this.Height)
                {
                    roadlines[i].Top = -roadlines[i].Height;
                }
                else
                {
                    roadlines[i].Top += gameSpeed;
                }
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            move_enemys();
            move_coins();
            move_lines();
            is_get_coins();
            isGameOver = check_intersections();
            if(isGameOver)
            {
                gameover_actions();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!isGameOver)
            {
                switch (e.KeyCode)
                {
                    case Keys.Left:
                        if (Car.Left > pbBoundLeft.Right)
                        {
                            Car.Left -= carTurnSpeed;
                        }
                        break;
                    case Keys.Right:
                        if (Car.Right < pbBoundRight.Left)
                        {
                            Car.Left += carTurnSpeed;
                        }
                        break;
                    case Keys.Up:
                        if (gameSpeed < 23)
                        {
                            gameSpeed++;
                        }
                        break;
                    case Keys.Down:
                        if (gameSpeed > 3)
                        {
                            gameSpeed--;
                        }
                        break;
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
