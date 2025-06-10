using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // get user input
            Console.Write("Enter Number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Divisors Of {num} Are: ");

            // loop thro 1 to num
            for (int i = 1; i < num; i++)
            {
                // if current number is divisor, log it
                if (num % i == 0)
                {
                    Console.Write($"{i}, ");
                }    
            }

            // num's last divisor is always itself, so log it and start new line
            Console.WriteLine($"{num}.");
        }
    }
}
