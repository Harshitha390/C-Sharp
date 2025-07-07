using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  class Strings
    {
        public void  StringMethods()
        {
            //Length() method
            string name = "Bangalore";
            Console.WriteLine("Length: " + name.Length);

            //ToUpper() and ToLower() methods
            Console.WriteLine("Upper: " + name.ToUpper()); 
            Console.WriteLine("Lower: " + name.ToLower());

            //SubString() method
            string sub = name.Substring(2, 5);
            Console.WriteLine("Substring: " + sub);

            //IndexOf() Method
            int index = name.IndexOf("l");
            Console.WriteLine("Index of 'l': " + index);

            //Replace() method
            string newName = name.Replace("Bangalore", "Mysore");
            Console.WriteLine(newName);
        }

        public void concatStrings()
        {
            string firstName = "Priya";
            string lastName = "Darshini";
            string fullName = firstName + lastName;
            Console.WriteLine(fullName);

            //using Concat Method
            string fname = "Suhas";
            string lname = "Kashyap";
            string fullName1 = string.Concat(fname, lname);
            Console.WriteLine(fullName1);

            //String Interpolation
            string myName = "Ram";
            int age = 22;
            Console.WriteLine($"My name is {myName} and I am {age} years old.");
        }
    }
}
