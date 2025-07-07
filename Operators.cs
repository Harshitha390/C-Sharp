using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    internal class Operators
    {
        int num1 = 10;
        int num2 = 5;

        //Arithmatic Operators
        public void PerformArithmaticOp()
        {
            
            Console.WriteLine("Addition of Numbers: " + (num1 + num2));
            Console.WriteLine("Subtraction of Numbers: " + ( num1 - num2));
            Console.WriteLine("Multiplication of Numbers: " + (num1 * num2));
            Console.WriteLine("Division of Numbers: " + (num1 / num2));
            Console.WriteLine("Modulus of Numbers: " + (num1 % num2));
            Console.WriteLine("Increment of num1 is: " + (num1++));
            Console.WriteLine("Decrement of num1 is: " + (num1--));
        }

        //Assignment Operators
        public void PerformAssignmentOp()
        {
            Console.WriteLine("num1=10:" + num1);
            Console.WriteLine("num1+=2: " + (num1 += 2));
            Console.WriteLine("num1-=2: " + (num1 -= 2));
            Console.WriteLine("num1*=2: " + (num1 *= 2));
            Console.WriteLine("num1/=2: " + (num1 /= 2));
            Console.WriteLine("num1%=2: " + (num1 %= 2));
            Console.WriteLine("num1&=2: " + (num1 &= 2));
            Console.WriteLine("num1|=2: " + (num1 |= 2));
            Console.WriteLine("num1>>=2: " + (num1 >>= 2));
            Console.WriteLine("num1<<=2: " + (num1 <<= 2));
        }

        //Comparison Operators
        public void PerformComparisonOp()
        {
            Console.WriteLine("num1==num2 :" + (num1==num2));
            Console.WriteLine("num1!=num2 :" + (num1 != num2));
            Console.WriteLine("num1>num2 :" + (num1 > num2));
            Console.WriteLine("num1<num2 :" + (num1 < num2));
            Console.WriteLine("num1>=num2 :" + (num1 >= num2));
            Console.WriteLine("num1<num2 :" + (num1 <= num2));
        }

        //Logical Operators
        public void PerformLogicalOp()
        {
            Console.WriteLine("num1>=10 && num2<=5: " + (num1 >= 10 && num2 <= 5));
            Console.WriteLine("num1>=10 || num2<=6: " + (num1 >= 10 || num2 <= 5));
            Console.WriteLine("!(num1>=10 || num2<=6): " + !(num1 >= 10 || num2 <= 5));
        }

        //Math Function
        public void MathFunction()
        {
            //Math.Max
            int max = Math.Max(num1, num2);
            Console.WriteLine($"Max of {num1} and {num2} is: {max}");

            //Math.Min
            int min = Math.Min(num1,num2);
            Console.WriteLine($"Min of {num1} and {num2} is: {min}");

            //Math.Sqrt
            double number = 64;
            double sqrt = Math.Sqrt(number);
            Console.WriteLine($"Square root of {number} is: {sqrt}");

            //Math.Abs
            int negativeNumber = -15;
            int absValue = Math.Abs(negativeNumber);
            Console.WriteLine($"Absolute value of {negativeNumber} is: {absValue}");

            //Math.Round
            double value = 3.56789;
            double rounded = Math.Round(value, 2); // Round to 2 decimal places
            Console.WriteLine($"Rounded value of {value} to 2 decimal places is: {rounded}");
        }
    }
}
