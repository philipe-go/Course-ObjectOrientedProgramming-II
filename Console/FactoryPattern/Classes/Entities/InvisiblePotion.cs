using FactoryPattern.Classes.State;
using System;

namespace FactoryPattern.Classes.Entities
{
    public class InvisiblePotion : Potion
    {
        public InvisiblePotion() : base("Invisible Potion") {  }

        public override void Drink(Player p)
        {
            p.Hide();
        }
    }
}
