using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Philipe_MidTermFall2019.Class
{
    class Shield : Entity
    {
        public Shield() : base() {}

        public override void Hit(Mario mario)
        {
            mario.score += 500;

        }
    }
}
