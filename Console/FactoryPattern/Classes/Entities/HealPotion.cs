using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Classes.State;

namespace FactoryPattern.Classes.Entities
{
    class HealPotion : Potion
    {
        public HealPotion() : base("Heal Potion") { }
        
        public override void Drink(Player p)
        {
            p.Heal(); ;
        }
    }
}
