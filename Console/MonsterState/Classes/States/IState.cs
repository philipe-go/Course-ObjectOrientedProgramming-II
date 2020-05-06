using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterState.Classes.States
{
    interface IState
    {
        int CalculateDamage(int d);
        int CalculateRegen(int r);
        int CalculateDefence(int de);
    }
}
