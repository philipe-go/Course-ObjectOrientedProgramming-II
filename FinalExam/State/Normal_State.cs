using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalExam.Entities;

namespace FinalExam.State
{
    public class Normal_State : IState
    {
        //Question 2.2
        private static Normal_State instance = null;
        private Normal_State() { }
        public static Normal_State GetInstance()
        {
            if (instance == null) instance = new Normal_State();
            return instance;
        }

        public void Get_Coin(Mario mario)
        {
            mario.State = Super_State.GetInstance();
        }

        public void Get_Weapon(Mario mario)
        {
            mario.State = Fighter_State.GetInstance();
        }

        public void Hit_Enemy(Mario mario, Enemy enemy)
        {
            mario.Loose_Life();
        }

        public override string ToString()
        {
            return "Normal";
        }
    }



}
