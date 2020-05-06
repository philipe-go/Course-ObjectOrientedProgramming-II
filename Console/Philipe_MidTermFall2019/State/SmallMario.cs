using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Philipe_MidTermFall2019.Class;

namespace Philipe_MidTermFall2019.State
{
    class SmallMario : IState
    {
        #region SingletonPattern
        private static SmallMario instance = null;
        private SmallMario() { }
        public static SmallMario GetInstance()
        {
            if (instance == null)
            {
                instance = new SmallMario();
            }
            return instance;
        }
        #endregion

        public void GetShield(Mario mario, Entity shield)
        {
            mario.State = SuperMario.GetInstance();
            mario.score += shield.score;
        }

        public void HitBomb(Mario mario, Entity bomb)
        {
            bomb.Hit(mario);
        }

        public override string ToString()
        {
            return "Small Mario";
        }
    }
}
