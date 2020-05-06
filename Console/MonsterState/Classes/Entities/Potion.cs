namespace MonsterState.Classes.Entities
{
    class Potion
    {
        private int rounds;
        private int quantity;

        public int Rounds 
        { 
            get => rounds; 
            set => rounds = (value <= 0)? 1 : (value > 3)? 3 : value; 
        }
        public int Quantity 
        { 
            get => quantity;
            set => quantity = (value <= 0)? 1 : (value > 3)? 3 : value; 
        }

        public Potion(int rounds, int quantity)
        {
            this.Rounds = rounds;
            this.Quantity = quantity;
        }

    }
}
