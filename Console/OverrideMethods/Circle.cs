using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideMethods
{
    class Circle : Shape
    {
        public override string ToString()
        {
            return "I am instance of Circle";
        }

        new public string Display()
        {
            return "I am Circle";
        }
    }
}
