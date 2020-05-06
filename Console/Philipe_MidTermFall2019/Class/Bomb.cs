using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Philipe_MidTermFall2019.Class
{
    class Bomb : Entity
    {
        private int damage;

        public Bomb() 
        {
            damage = Dice.GetInstance().Next(1,3);
        }

        public override void Hit(Mario mario)
        {
            mario.Lives -= damage;
        }
    }
}
