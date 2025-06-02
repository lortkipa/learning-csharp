using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // get first number
            Console.Write("Number 1: ");
            float num1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("---------------------");

            // get second number
            Console.Write("Number 2: ");
            float num2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("---------------------");

            // calculate and log
            Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));
            Console.WriteLine(num1 + " - " + num2 + " = " + (num1 - num2));
            Console.WriteLine(num1 + " * " + num2 + " = " + (num1 * num2));
            Console.WriteLine(num1 + " / " + num2 + " = " + (num1 / num2));
        }
    }
}
