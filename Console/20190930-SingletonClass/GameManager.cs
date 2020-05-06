
using System;

namespace _20190930_SingletonClass
{
    class GameManager //SINGLETON class
    {
        //Class attributes
        private int score;
        /*step1*/
        private static GameManager instance = null; //instance created in the heap to be the Highlander of the class GameManager

        //Class attributes properties
        public int Score
        {
            get
            {
                return score;
            }
            set //BUSINESS RULE
            {
                if (value < 0) { score = -value; }
                else { score = value; }
            }
        }

        /*Step 2*/
        private GameManager() //private constructor to avoid a class constructor to be called creating new instances in the heap
        {
            //Random aNumber = RandomGenerator.GetInstance();
            Random aNumber = new Random();
            score = aNumber.Next(0,100);
            instance = this;
        }

        public static GameManager GetInstance() //static method to get the instance created and attach its address ot any value in the stack
        {
            if (instance is null)
            {
                instance = new GameManager();
            }
            return instance;
        }
    }
}
