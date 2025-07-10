using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Interface
    internal interface IVehicle
    {
        void Start();
        void Stop();
    }

    // Class implementing interface
    class Car1: IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Car is starting");
        }
        public void Stop()
        {
            Console.WriteLine("Car is stopping");        }
        }
    }

   // Another class implementing interface
   class Bike1 : IVehicle
   {
    public void Start()
    {
        Console.WriteLine("Bike is starting");
    }
    public void Stop()
    {
        Console.WriteLine("Bike is stopping");
    }

   }

