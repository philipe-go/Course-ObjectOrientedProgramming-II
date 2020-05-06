using FactoryPattern.Classes.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Classes.Entities
{
    public class Potion
    {
        private string name;

        protected Potion(string aName)
        {
            this.name = aName;
        }
        
        public abstract void Drink(Player p);
    }
}
