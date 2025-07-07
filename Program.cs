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
            tc.typecasting();

            Operators op = new Operators();
            op.PerformArithmaticOp();
            op.PerformAssignmentOp();
            op.PerformComparisonOp();
            op.PerformLogicalOp();
            op.MathFunction();

            Strings str = new Strings();
            str.StringMethods();
            str.concatStrings();

            Statements st = new Statements();
            st.test1();
            st.test2();
            st.test3();
            st.test4();
            st.test5();
            st.test6();
            st.test7();

            Arrays arr = new Arrays();
            arr.displayArray();
            arr.iterateArray();
            arr.sortArray();
        }
    }
}
