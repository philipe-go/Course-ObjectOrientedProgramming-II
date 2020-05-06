using Philipe_MidTermFall2019.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Philipe_MidTermFall2019.State
{
    interface IState
    {
        void GetShield(Mario mario, Entity shield);
        void HitBomb(Mario mario, Entity bomb);
    }
}
