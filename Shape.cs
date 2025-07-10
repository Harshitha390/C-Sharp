using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// Base class
    internal class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape");
        }
    }

    // Derived class1
    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Circle");
        }
    }

    // Derived class2
    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Rectangle");
        }
    }

}
