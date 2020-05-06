using System;

namespace _20190930_SingletonClass
{
    class RandomGenerator
    {
        private static Random instance = null;

        private RandomGenerator() { }

        public static Random GetInstance()
        {
            if (instance is null)
            {
                instance = new Random();
            }
            return instance;
        }
    }
}
