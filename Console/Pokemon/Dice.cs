using System;

namespace Pokemon
{
    public class Dice : Random //Singleton
    {
        private static Dice instance = null;

        private Dice() : base() { }

        public static Dice GetInstance()
        {
            if (instance == null) { return new Dice(); }
            else { return instance; }
        }
    }
}
