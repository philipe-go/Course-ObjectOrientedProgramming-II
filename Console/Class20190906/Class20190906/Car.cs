using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class20190906
{
    class Car
    {
        public int year;
        public string model;

        public Car(int year, string model)
        {
            this.year = year;
            this.model = model;
        }

        public override bool Equals(object obj) // METHOD TO COMPARE THE ATTRIBUTES OF THE OBJECT
        {
            if (obj is Car)    // IMPORTANT TO ADD THIS IF STATEMENT SO TO AVOID ANY EXECUTION TIME ERROR DUE TO OBJECTS OTHER THAN CAR BEING USED
            {
                if (((obj as Car).year == this.year) && ((obj as Car).model == this.model))
                {
                    return true;
                }
            }
           return false;
        }

        public Car (Car copy) // CONSTRUCTOR BYCOPY TO AVOID WRONG COPYING AN OBJECT
        {
            this.year = copy.year;
            this.model = copy.model;
        }

        public Car Clone() //CLONE METHOD SO THERE IS NO NEED TO DEFINE A BYCOPY METHOD
        {
            Car temp = new Car(this.year, this.model);
            return temp;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
