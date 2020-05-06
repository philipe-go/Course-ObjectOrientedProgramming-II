using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat_Run.State
{
    class SuperState : IState
    {
        #region SingletonPattern
        private static SuperState instance = null;
        private SuperState() { }
        public static SuperState GetInstance()
        {
            if (instance == null) { instance = new SuperState(); }
            return instance;
        }
        #endregion

        #region Attributes
        private int pointsRatio = 3;
        private int forceRatio = +4;
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
            return "Super";
        }
    }
}
