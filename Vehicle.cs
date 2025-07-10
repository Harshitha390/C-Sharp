using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //Abstract class 
    internal abstract class Vehicle
    {
        public abstract void StartEngine();
        public void StopEngine()
        {
            Console.WriteLine("Engine Stopped");
        }
    }

    //Derived Class1
    class Car : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Car Engine started");
        }
    }

    // Derived class2
    class Bike : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Bike engine started");
        }

    }
}
