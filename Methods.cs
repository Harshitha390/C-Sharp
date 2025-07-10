using System;

namespace ConsoleApp1
{
    internal class Methods
    {
       //Multiple Parameters
       public void Method1(string fname,string lname)
        {
            Console.WriteLine($"Full name is {fname} {lname}");
        }

       //Default Parameter
       public void Method2(string name="Guest")
        {
            Console.WriteLine("Welcome " + name);
        }

        //Return values
        public int Method3(int a, int b)
        {
            return a * b;
        }
        
        //Named Arguments
        public void Method4(string fname,string lname,string city)
        {
            Console.WriteLine($"Name: {fname} {lname},City:{city}");
        }

        //Method Overloading
        public void Method4(string fname,string lname)
        {
            Console.WriteLine($"Name: {fname} {lname}");
        }
    }
}
