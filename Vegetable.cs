using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Base class
    internal class Vegetable
    {
        public void Chopped()
        {
            Console.WriteLine("Vegetables are Chopped");
        }
    }

    // Derived class
    class Carrot: Vegetable
    {
        public void Boiled()
        {
            Console.WriteLine("Carrots are boiled");
        }
    }

}
