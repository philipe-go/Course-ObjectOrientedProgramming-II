using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideMethods
{
    class Shape
    {
        public override string ToString()
        {
            return "I am isntance of Shape";
        }

        public string Display()
        {
            return "I am Shape";
        }
    }
}
