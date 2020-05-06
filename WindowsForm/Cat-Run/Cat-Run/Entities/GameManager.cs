using Cat_Run.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat_Run.Entities
{
    class GameManager
    {
        #region SingletonPattern
        private static GameManager instance = null;
        private GameManager() { }
        internal static GameManager GetInstance()
        {
            if (instance == null) { instance = new GameManager(); }
            return instance;
        }
        #endregion

        #region Attributes
        private bool jump;
        private int jumpSpeed;
        private int force;
        private int score;
        private double obstacleSpeed;
        private int difficultManager;
        private int timer;
        private readonly double difficult = 1.2;
        private int pointsRatio;

        private List<IState> statesList = new List<IState>()
        { WeakState.GetInstance(), NormalState.GetInstance(), SuperState.GetInstance() };

        private Cat cat = Cat.GetInstance();
        Dice dice = Dice.GetInstance();
        #endregion

        #region Properties
        public bool Jump { get => jump; set => jump = value; }
        public int JumpSpeed { get => jumpSpeed; set => jumpSpeed = value; }
        public int Force { get => force; set => force = value; }
        public int Score { get => score; set => score = value; }
        public double ObstacleSpeed { get => obstacleSpeed; set => obstacleSpeed = value; }
        public int DifficultManager { get => difficultManager; set => difficultManager = value; }
        public int Timer { get => timer; set => timer = value; }
        public double Difficult => difficult;
        internal Cat Cat { get => cat; set => cat = value; }
        public int PointsRatio { get => pointsRatio; set => pointsRatio = value; }
        #endregion

        internal void PlayGame()
        {
            if (jump && force < 0)
            {
                jump = false;
            }

            if (jump)
            {
                jumpSpeed = -12;
                force -= 1;
            }
            else
            {
                jumpSpeed = 12;
            }
        }

        internal void ResetGame()
        {
            jump = false;
            jumpSpeed = 0;
            force = cat.CalculateForce();
            score = 0;
            obstacleSpeed = 10;
            timer = 0;
            difficultManager = 10;
            cat.State = statesList[dice.Next(0, 3)];
            pointsRatio = cat.State.CalculatePoints(0);
        }

        internal void CalculateScore()
        {
            score = cat.State.CalculatePoints(this.score);
        }

        internal void ChangeState()
        {
            cat.State = statesList[dice.Next(0, 3)];
            pointsRatio = cat.State.CalculatePoints(0);
        }
    }
}
