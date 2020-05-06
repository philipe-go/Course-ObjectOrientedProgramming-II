using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape myShape = new Shape();
            Console.WriteLine(myShape);
            Console.WriteLine(myShape.Display());

            Shape myCircle = new Circle();
            Console.WriteLine(myCircle);
            Console.WriteLine(myCircle.Display());
            Console.WriteLine((Circle)myCircle); //circle override ToString() method replaced the mother class method. 
            Console.WriteLine(((Circle)myCircle).Display());

            Console.ReadKey();
        }
    }
}
