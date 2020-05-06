using System;

namespace MonsterState.Classes.States
{
    public class WeakState : IState
    {
        private static WeakState instance = null;

        private WeakState() { }

        internal IState IState
        {
            get => default;
            set
            {
            }
        }

        public static WeakState GetInstance()
        {
            if (instance == null)
            {
                instance = new WeakState();
            }

            return instance;
        }

        public int CalculateDamage(int damage)
        {
            return Convert.ToInt16(damage/2);
        }

        public int CalculateDefence(int defence)
        {
            return Convert.ToInt16(defence/2);
        }

        public int CalculateRegen(int regen)
        {
            return Convert.ToInt16(regen/2);
        }

    }
}
