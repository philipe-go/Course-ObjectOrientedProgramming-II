using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Philipe_MidTermFall2019.Class;

namespace Philipe_MidTermFall2019.State
{
    class SuperMario : IState
    {
        #region SingletonPattern
        private static SuperMario instance = null;
        private SuperMario() { }
        public static SuperMario GetInstance()
        {
            if (instance == null)
            {
                instance = new SuperMario();
            }
            return instance;
        }
        #endregion

        public void GetShield(Mario mario, Entity shield)
        {
                mario.score += 2 * shield.score;
        }

        public void HitBomb(Mario mario, Entity bomb)
        {
            mario.State = SmallMario.GetInstance();
        }

        public override string ToString()
        {
            return "Super Mario";
        }
    }
}
