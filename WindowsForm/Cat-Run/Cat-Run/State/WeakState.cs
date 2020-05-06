using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat_Run.State
{
    class WeakState : IState
    {
        #region Singleton Pattern
        private static WeakState instance = null;
        private WeakState() { }
        public static WeakState GetInstance()
        {
            if (instance == null) { instance = new WeakState(); }
            return instance;
        }
        #endregion

        #region Attributes
        private int pointsRatio = 1;
        private int forceRatio = -3;
        #endregion

        public int CalculatePoints(int points)
        {
            return points + pointsRatio;
        }

        public int CalculateForce(int force)
        {
            return force + forceRatio;
        }

        public override string ToString()
        {
            return "Weak";
        }
    }
}
