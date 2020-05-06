namespace FactoryPattern.Classes.State
{
    public class Player
    {
        private int hp;
        private readonly int hpMax;

        private int hidingDuration = 3;
        private IState currentState;



        public void Heal() { }

        public void Hide() { }
    }
}