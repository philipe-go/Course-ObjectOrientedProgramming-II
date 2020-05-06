
using System;

namespace _20190930_SingletonClass
{
    class Program
    {
        static void Main(string[] png)
        {
            GameManager manager = GameManager.GetInstance();
            //Random aNumber = RandomGenerator.GetInstance();
            Random aNumber = new Random();
            int x = aNumber.Next(0, 100);
            int counter = 0;
            while (x == manager.Score)
            {
                Console.WriteLine($"Score = {manager.Score}");
                Console.WriteLine($"Random = {x}");
                x = aNumber.Next(0, 100);
                manager = GameManager.GetInstance();
                counter++;
            }
            Console.WriteLine("-------------");
            Console.WriteLine($"Counter: {counter}");
            Console.WriteLine($"Score = {manager.Score}");
            Console.WriteLine($"Random = {x}");
            Console.ReadKey();
        }
    }
}
