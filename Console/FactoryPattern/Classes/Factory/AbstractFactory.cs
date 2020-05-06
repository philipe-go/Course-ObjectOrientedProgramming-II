using FactoryPattern.Classes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Classes.Factory
{
    public abstract class AbstractFactory
    {
        public abstract Enemy CreateEnemy() { }
        public abstract Weapon CreateWeapon() { }
        public abstract Potion CreatePotion() { }
        public abstract Item CreateCollectable() { }
    }
}
