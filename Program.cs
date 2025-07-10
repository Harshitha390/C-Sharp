using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.DisplayDetails();

            TypeCasting tc = new TypeCasting();
            tc.Typecasting();

            Operators op = new Operators();
            op.PerformArithmaticOp();
            op.PerformAssignmentOp();
            op.PerformComparisonOp();
            op.PerformLogicalOp();
            op.MathFunction();

            Strings str = new Strings();
            str.StringMethods();
            str.ConcatStrings();

            Statements st = new Statements();
            st.Test1();
            st.Test2();
            st.Test3();
            st.Test4();
            st.Test5();
            st.Test6();
            st.Test7();

            Arrays arr = new Arrays();
            arr.DisplayArray();
            arr.IterateArray();
            arr.SortArray();
            
            Methods m = new Methods();
            m.Method1("Rama", "Chandra");
            m.Method1("Anu", "Pallavi");
            m.Method2("Veena");
            m.Method2();
            int mul = m.Method3(5, 2);
            Console.WriteLine("Multiplication of numbers is: " + mul);
            m.Method4(lname: "Murthy", city: "Mysore", fname: "Krishna");
            m.Method4("Ravi", "Chandran");

            // Multiple Objects
            Mobile mob1 = new Mobile();
            mob1.brand = "Samsung";
            mob1.model = "Galaxy S24";
            mob1.price = 79000;

            Mobile mob2 = new Mobile();
            mob2.brand = "Apple";
            mob2.model = "iphone 15 Pro";
            mob2.price = 120000;

            Pen pen1 = new Pen();
            Console.WriteLine(pen1);

            Pen pen2 = new Pen("Cello", "Red", 20);

            // Encapsulation example
            Book book = new Book();
            book.Pages = 200;
            Console.WriteLine(book.Pages);

            // Inheritance example
            Carrot carrot = new Carrot();
            carrot.Chopped();
            carrot.Boiled();

            // Polymorphism example
            Shape shape = new Shape();
            Circle circle = new Circle();
            Rectangle rectangle = new Rectangle();
            shape.Draw();
            circle.Draw();
            rectangle.Draw();

            // Abstraction example
            Vehicle car = new Car();
            Vehicle bike = new Bike();
            car.StartEngine();
            car.StopEngine();
            bike.StartEngine();
            bike.StopEngine();

            //Interface example
            IVehicle car1 = new Car1();
            IVehicle bike1 = new Bike1();
            car1.Start();
            car1.Stop();
            bike1.Start();
            bike1.Stop();

            // Enum example
            Direction direction = Direction.North;
            Console.WriteLine("Current Direction: " + direction);

            int directionValue = (int)Direction.West;
            Console.WriteLine("Integer value of Wednesday is: " + directionValue);

            // Exception example
            int num1 = 5;
            int num2 = 0;
            try
            {
                Console.WriteLine("Excecution started");
                int result = num1 / num2;
                Console.WriteLine("Result: " + result);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                Console.WriteLine("This is finally block");
            }
            Console.WriteLine("Excection ended");

            // File Handling Example
            string filePath = "C://Users//Admin//Desktop//Files//c sharp file.txt";

            // Writing to a file
            File.WriteAllText(filePath, "Welcome!!!");
            Console.WriteLine("File created successfully");

            // Reading a file
            if (File.Exists(filePath))
            {
                string content = File.ReadAllText(filePath);
                Console.WriteLine("File content:\n" + content);
            }
            else
            {
                Console.WriteLine("File does not exist"); 
            }
        }
    }
}
