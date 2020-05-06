using System;

namespace MonsterState.Classes.Entities
{
    public class Dice : Random
    {
        private static Dice instance = null;

        private Dice() : base() { } //dont forget to add the base constructor so the singleton calls the Random constructor

        public static Dice GetInstance()
        {
            if (instance == null) { instance = new Dice(); }
            return instance;
        }
    }
}
