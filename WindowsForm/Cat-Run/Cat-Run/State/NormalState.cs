using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat_Run.State
{
    class NormalState : IState
    {
        #region Singleton Pattern
        private static NormalState instance = null;
        private NormalState() { }
        public static NormalState GetInstance()
        {
            if (instance == null) { instance = new NormalState(); }
            return instance;
        }
        #endregion

        #region Attributes
        private int pointsRatio = 2;
        private int forceRatio = 0;
        #endregion

        #region Properties
        public int PointsRatio { get => pointsRatio; set => pointsRatio = value; }
        #endregion

        public int CalculatePoints(int points)
        {
            return points + PointsRatio;
        }

        public int CalculateForce(int force)
        {
            return force + forceRatio;
        }

        public override string ToString()
        {
            return "Normal";
        }
    }
}
