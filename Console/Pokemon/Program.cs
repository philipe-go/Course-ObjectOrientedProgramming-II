using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            FireMonster m = new FireMonster(100, 9, 0, 0, 8);
            WaterMonster w = new WaterMonster(100, 9, 0, 0, 8);
            Battle(m, w);
            Console.ReadKey();
        }

        static void Battle(Monster monster1, Monster monster2)
        {
            monster1.Target = monster2;
            monster2.Target = monster1;

            Dice dice = Dice.GetInstance();

            Monster currentMonster = (dice.Next(1,100) < 50)? monster1 : monster2; //random initial monster

            while (!currentMonster.IsDead() && !currentMonster.Target.IsDead())
            {
                currentMonster.Atack();
                currentMonster = (currentMonster == monster1) ? monster2 : monster1;
            }
        }
    }
}
