using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalExam.Entities;

namespace FinalExam.State
{
    public class Super_State : IState
    {
        //Question 2.2
        private static Super_State instance = null;
        private Super_State() { }
        public static Super_State GetInstance()
        {
            if (instance == null) instance = new Super_State();
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
            enemy.Die();
            mario.State = Normal_State.GetInstance();
        }

        public override string ToString()
        {
            return "Super";
        }
    }
}
