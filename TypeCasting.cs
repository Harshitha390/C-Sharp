using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  class TypeCasting
    {
        public void typecasting()
        {
            // Implicit Typecasting
            int myInt = 100;
            double myDouble = myInt;

            Console.WriteLine("Implicit TypeCasting:");
            Console.WriteLine("Int value: " + myInt);
            Console.WriteLine("Converted to Double: " + myDouble);

            // Explicit Typecasting
            double myDouble2 = 123.45;
            int myInt2 = (int)myDouble2; 

            Console.WriteLine("Explicit TypeCasting:");
            Console.WriteLine("Double value: " + myDouble2);
            Console.WriteLine("Converted to Int: " + myInt2);
        }

    }
}
