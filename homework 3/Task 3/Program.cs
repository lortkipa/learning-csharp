using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // get user input
            Console.Write("Enter Intiger Number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // calculate pow and log to console
            Console.WriteLine("The Pow Of " + number + " Is " + Math.Pow(number, 2));
        }
    }
}
