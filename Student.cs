using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student
    {
        string name="Rama";
        int age=23;
        float height=5.7f;
        long phoneNum=9877877987;
        double percentage=89.9;
        char grade='A';
        bool isPassed=true;
        
        public void DisplayDetails()
        {
            Console.WriteLine("Student Details");
            Console.WriteLine($"Name:{name}");
            Console.WriteLine($"Age:{age}");
            Console.WriteLine($"Height:{height}");
            Console.WriteLine($"Phone Number:{phoneNum}");
            Console.WriteLine($"Percentage:{percentage}");
            Console.WriteLine($"Grade:{grade}");
            Console.WriteLine($"Is Passed:{isPassed}");
        }

    }
}
