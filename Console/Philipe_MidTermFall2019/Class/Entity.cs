using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Philipe_MidTermFall2019.Class
{
    abstract class Entity
    {
        internal int score;

        public Entity()
        {
            score = 100;
        }

        public abstract void Hit(Mario mario);
    }
}
