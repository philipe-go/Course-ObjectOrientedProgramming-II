namespace MonsterState.Classes.States
{
    public class NormalState : IState
    {
        private static NormalState instance = null;

        private NormalState() { }

        internal IState IState
        {
            get => default;
            set
            {
            }
        }

        public static NormalState GetInstance()
        {
            if (instance == null)
            {
                instance = new NormalState();
            }

            return instance;
        }
       

        public int CalculateDamage(int damage)
        {
            return damage;
        }

        public int CalculateDefence(int defence)
        {
            return defence;
        }

        public int CalculateRegen(int regen)
        {
            return regen;
        }
    }
}
