using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // test 1
            Console.WriteLine("=== test 1 ===");
            ICalc calc1 = new Numbers(5, 10, 15, 20, 25, 30);
            Console.WriteLine("Numbers: 5, 10, 15, 20, 25, 30");
            Console.WriteLine($"Less than 15: {calc1.GetLessNumbersCount(15)}");
            Console.WriteLine($"Greater than 15: {calc1.GetGreaterNumbersCount(15)}");
            Console.WriteLine();

            // test 2
            Console.WriteLine("=== test 2 ===");
            ICalc calc2 = new Numbers(-10, -5, 0, 5, 10);
            Console.WriteLine("Numbers: -10, -5, 0, 5, 10");
            Console.WriteLine($"Less than 0: {calc2.GetLessNumbersCount(0)}");
            Console.WriteLine($"Greater than 0: {calc2.GetGreaterNumbersCount(0)}");
            Console.WriteLine();

            // test 3
            Console.WriteLine("=== test 3 ===");
            ICalc calc3 = new Numbers(7, 7, 7, 7, 7);
            Console.WriteLine("Numbers: 7, 7, 7, 7, 7");
            Console.WriteLine($"Less than 7: {calc3.GetLessNumbersCount(7)}");
            Console.WriteLine($"Greater than 7: {calc3.GetGreaterNumbersCount(7)}");
            Console.WriteLine();

            // test 4
            Console.WriteLine("=== test 4 ===");
            ICalc calc4 = new Numbers(100, 200, 300, 400, 500);
            Console.WriteLine("Numbers: 100, 200, 300, 400, 500");
            Console.WriteLine($"Less than 250: {calc4.GetLessNumbersCount(250)}");
            Console.WriteLine($"Greater than 250: {calc4.GetGreaterNumbersCount(250)}");
            Console.WriteLine();

            // test 5
            Console.WriteLine("=== test 5 ===");
            ICalc calc5 = new Numbers(1, 2, 3);
            Console.WriteLine("Numbers: 1, 2, 3");
            Console.WriteLine($"Greater than 0: {calc5.GetGreaterNumbersCount(0)}");
            Console.WriteLine($"Less than 10: {calc5.GetLessNumbersCount(10)}");
        }
    }
}
