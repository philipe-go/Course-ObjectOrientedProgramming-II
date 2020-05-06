using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class20190906
{
    class Program
    {
        static void Main(string[] args)
        {

            Car myObj1 = new Car(2012, "BMW");
            Car myObj2 = new Car(2012, "BMW");

            //Calling the EQUAL overriden method to compare two objects not their Hash Codes

            if (myObj1.Equals(myObj2)) 
            {
                Console.WriteLine("they are equal");
            }
            else
            {
                Console.WriteLine("they are different");
            }

            //Calling the "CONSTRUCTOR BY COPY" method created inside the class CAR to avoid wrong copying an object

            Car myCopy = myObj2;
            myCopy.year++;
            Console.WriteLine($"myCar year = {myCopy.year.ToString()} / myObj2 year = {myObj2.year.ToString()}");
            myCopy = new Car(myObj2); 
            myCopy.year++;
            Console.WriteLine($"myCar year = {myCopy.year.ToString()} / myObj2 year = {myObj2.year.ToString()}");

            //Calling the "CLONE" method to create an object and copy attributes from other object

            Car myClone = myObj2.Clone(); 
            myClone.year++;
            Console.WriteLine($"myClone year = {myClone.year.ToString()} / myObj2 year = {myObj2.year.ToString()}");

            List<Car> array1 = new List<Car>();
            for (int i = 0; i < 2; i++)
            {
                array1.Add(new Car(2012, "BMW"));
            }

            List<Car> array2 = new List<Car>();
            for (int i = 0; i < 2; i++)
            {
                array2.Add(array1[i]);
            }

            Console.ReadKey();
        }
    }
}
