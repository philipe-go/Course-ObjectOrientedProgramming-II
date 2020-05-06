using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Classes.Entities
{
    public class Item
    {
        private string name;
        private int score;

        public Item(string aName, int aScore)
        {
            this.name = aName;
            this.score = aScore;
        }



    }
}
