using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalExam.Entities;

namespace FinalExam.State
{
    public interface IState
    {
        //Question 2.1
        void Get_Weapon(Mario mario);
        void Get_Coin(Mario mario);
        void Hit_Enemy(Mario mario, Enemy enemy);
    }
}
