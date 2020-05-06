using Philipe_MidTermFall2019.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Philipe_MidTermFall2019.Class
{
    class Mario : Entity
    {
        private IState state;
        private int lives;

        public int Lives { get => lives; set => lives = value; }
        internal IState State { get => state; set => state = value; }

        public Mario() : base()
        {
            State = SmallMario.GetInstance();
            Lives = 3;
        }

        public void Explore(Entity item)
        {
            item.Hit(this);

            if (item is Shield)
            {
                State.GetShield(this, item);
            }
            else
            {
                State.HitBomb(this, item);
            }
        }

        public override void Hit(Mario mario)
        {
        }
    }
}
