using Cat_Run.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat_Run.Entities
{
    class Cat
    {
        #region SingletonPattern
        private static Cat instance = null;
        private Cat() { }
        public static Cat GetInstance()
        {
            if (instance == null) { instance = new Cat(); }
            return instance;
        }
        #endregion

        #region Attributes
        private IState state;
        private int force = 12;
        #endregion

        #region Properties
        internal IState State { get => state; set => state = value; }
        public int Force { get => force; set => force = value; }
        #endregion

        public int CalculateForce()
        {
            if (state != null) return state.CalculateForce(force);
            else return force;
        }
    }
}
