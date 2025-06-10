using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // get number of rows
            Console.Write("Enter Number Of Rows In Floyd's Triangle: ");
            uint rows = Convert.ToUInt32(Console.ReadLine());

            // loop thro 1 to rows
            for (uint i = 1; i <= rows; i++)
            {
                // loop thro j to i
                for (uint j = 1; j <= i; j++)
                {
                    // calculate if there should be logged 0 or 1 and log it on console
                    Console.Write($"{((i + j) % 2 == 1 ? 0 : 1)} ");
                }

                // start new line
                Console.WriteLine();
            }
        }
    }
}
