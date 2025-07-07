using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Arrays
    {
        public void displayArray()
        {
            //Array creation
            string[] fruits = {" apple", " pappaya", "banana", "grapes","Pineapple" };
            Console.WriteLine(fruits[1]);

            fruits[2] = "Guava";
            Console.WriteLine(fruits[2]);
        }

        public void iterateArray()
        {
            int[] numbers = { 10, 20, 30, 40, 50 };

            // Print all elements using a for loop
            Console.WriteLine("Array elements:");
            for (int i = 0; i < numbers.Length; i++)
            { 
                Console.WriteLine(numbers[i]);
            }
        }
        public void sortArray()
        {
            string[] languages = { "Python", "C#", "Java", "JavaScript", "Ruby" };

            // Sort the array alphabetically
            Array.Sort(languages);

            // Print sorted array
            Console.WriteLine("Sorted Languages:");
            foreach (string lang in languages)
            {
                Console.WriteLine(lang);
            }

        }

    }
}
