using System;
using System.Collections.Generic;
using Philipe_MidTermFall2019.Class;
using Philipe_MidTermFall2019.State;

namespace Philipe_MidTermFall2019
{
    class Program
    {
        static void Main(string[] args)
        {
            Dice dice = Dice.GetInstance();
            bool play = true;

            do
            {
                Mario hero = new Mario();

                Console.WriteLine($"\t Mario's initial stats are:\n \t Points: {hero.score} \t Lives: {hero.Lives} \t State: {hero.State} \n \n **************************************\n");
                
                while (hero.Lives > 0)
                {
                    switch (dice.Next(1, 3))
                    {
                        case (1):
                            {
                                Entity item = new Shield();
                                hero.Explore(item);
                                Console.WriteLine("\nMario has found a shield\n");
                                Console.WriteLine($"\t Mario's stats are:\n \t Points: {hero.score} \t Lives: {hero.Lives} \t State: {hero.State.ToString()} ");
                            }
                            break;
                        case (2):
                            {
                                Entity item = new Bomb();
                                hero.Explore(item);
                                Console.WriteLine("\nMario has found a bomb.\n");
                                Console.WriteLine($"\t Mario's stats are:\n \t Points: {hero.score} \t Lives: {hero.Lives} \t State: {hero.State.ToString()} ");
                            }
                            break;
                        default:
                            {
                                Console.WriteLine("\nMario has found no object");
                                Console.WriteLine($"\t Mario's stats are:\n \t Points: {hero.score} \t Lives: {hero.Lives} \t State: {hero.State.ToString()} ");
                            }
                            break;
                    }

                    Console.ReadKey();
                }

                Console.WriteLine("\nMario has died");
                Console.Write("\nDo you want to play again? (y/n) ");
                if ((Console.ReadLine() == "n") || (Console.ReadLine() == "N"))
                {
                    play = false;
                }
            } while (play);
        }
    }
}
