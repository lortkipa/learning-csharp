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
            // get user input
            Console.Write("Enter Intiger Number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // log if number is odd or even
            Console.WriteLine("Entered Number " + number + " Is " + (number % 2 == 0 ? "Odd" : "Even"));
        }
    }
}
