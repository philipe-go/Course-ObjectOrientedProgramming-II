using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Classes.Entities
{
    class Weapon
    {
        private string name;
        private int atk;

        public Weapon(string name, int atk)
        {
            this.name = name;
            this.atk = atk;
        }
    }
}
