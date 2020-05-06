using FinalExam.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam.State
{
    public class Fighter_State : IState
    {
        //Question 2.2
        private static Fighter_State instance = null;
        private Fighter_State() { }
        public static Fighter_State GetInstance()
        {
            if (instance == null) instance = new Fighter_State();
            return instance;
        }

        public void Get_Coin(Mario mario)
        {
            mario.Heal();
        }

        public void Get_Weapon(Mario mario)
        {
            mario.Heal();
        }

        public void Hit_Enemy(Mario mario, Enemy enemy)
        {
            enemy.Attack(mario);
        }

        public override string ToString()
        {
            return "Fighter";
        }
    }
}
