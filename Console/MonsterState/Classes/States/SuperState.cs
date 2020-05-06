namespace MonsterState.Classes.States
{
    public class SuperState : IState
    {
        private static SuperState instance = null;

        private SuperState() { }

        internal IState IState
        {
            get => default;
            set
            {
            }
        }

        public static SuperState GetInstance()
        {
            if (instance == null)
            {
                instance = new SuperState();
            }

            return instance;
        }

        public int CalculateDamage(int damage)
        {
            return damage * 2;
        }

        public int CalculateDefence(int defence)
        {
            return defence * 2;
        }

        public int CalculateRegen(int regen)
        {
            return regen * 2;
        }

    }
}
