using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cat_Run.Entities;

namespace Cat_Run
{
    public partial class Form1 : Form
    {
        #region Attributes
        private GameManager gameManager = GameManager.GetInstance();
        private Dice dice = Dice.GetInstance(); //dice will be used to return random number where the obstacles will be spawned
        #endregion

        public Form1()
        {
            InitializeComponent();
            ResetGame();
        }

        //GamePlay main event
        private void GameEvent(object sender, EventArgs e)
        {
            catPic.Top += gameManager.JumpSpeed;

            scoreTxt.Text = $"Score: {gameManager.Score}";
            stateTxt.Text = $"State:\n{gameManager.Cat.State.ToString()}";
            ratioTxt.Text = $"Score Ratio: +{gameManager.PointsRatio}";

            gameManager.PlayGame();

            foreach (Control control in this.Controls)
            {
                if (control is PictureBox && control.Tag is "obstacle")
                {
                    control.Left -= Convert.ToInt32(gameManager.ObstacleSpeed);

                    if (control.Left + control.Width < -120)
                    {
                        control.Left = this.ClientSize.Width + dice.Next(200, 800);
                        gameManager.CalculateScore();
                    }

                    if (catPic.Bounds.IntersectsWith(control.Bounds))
                    {
                        gameTimer.Stop();
                        catPic.Image = Properties.Resources.dead;
                        restartTxt.Visible = true;
                    }
                }
            }

            if (catPic.Top >= 380 && !gameManager.Jump)
            {
                gameManager.Force = gameManager.Cat.CalculateForce();
                catPic.Top = floor.Top - catPic.Height;
                gameManager.JumpSpeed = 0;
            }


            if (gameManager.Score >= gameManager.DifficultManager)
            {
                gameManager.ObstacleSpeed *= gameManager.Difficult;
                gameManager.DifficultManager += 10;
                gameManager.ChangeState();
            }
        }

        //Event Handler for the down key
        private void KeyisDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && !gameManager.Jump)
            {
                gameManager.Jump = true;
            }
        }

        //Event Handler for the up key
        private void KeyisUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R)
            {
                ResetGame();
            }

            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }

            if (gameManager.Jump)
            {
                gameManager.Jump = false;
            }
        }

        //Method to reset the game to initial state
        private void ResetGame()
        {
            gameManager.ResetGame();

            catPic.Top = floor.Top - catPic.Height;
            catPic.Image = Properties.Resources.running;

            foreach (Control control in this.Controls)
            {
                if (control is PictureBox && control.Tag is "obstacle")
                {
                    int position = dice.Next(600, 1000);

                    control.Left = 640 + (control.Left + position + control.Width * 3);
                }
            }

            restartTxt.Visible = false;
            gameTimer.Start();
        }
    }
}

