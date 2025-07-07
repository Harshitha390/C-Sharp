using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Statements
    {
        //Conditional Statements
        public void test1()
        {
            int number = -5;

            if (number > 0)
            {
                Console.WriteLine("The number is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine("The number is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }
        }

        //ShortHand If-Else Statement
        public void test2()
        {
            int number = 7;

            // Using ternary operator
            string result = (number % 2 == 0) ? "Even" : "Odd";

            Console.WriteLine($"The number {number} is {result}.");
        }

        //Switch Statement
        public void test3()
        {
            int day = 3;

            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid day number");
                    break;
            }
        }

        //do-while loop
        public void test4()
        {
            int count = 1;

            do
            {
                Console.WriteLine("Welcome!");
                count++;
            }
            while (count <= 3);
        }

        //while loop
        public void test5()
        {
            int count = 5;

            while (count <= 10)
            {
                Console.WriteLine("Hello");
                count++;
            }
        }

        //Break Statement
        public void test6()
        {
            for (int i = 1; i <= 5; i++)
            {
                if (i == 3)
                {
                    Console.WriteLine("Break at i = 3");
                    break; 
                }

                Console.WriteLine("i = " + i);
            }
        }
        public void test7()
        {
            for (int i = 1; i <= 5; i++)
            {
                if (i == 3)
                {
                    continue;
                }

                Console.WriteLine("i = " + i);
            }
        }
    }
}
