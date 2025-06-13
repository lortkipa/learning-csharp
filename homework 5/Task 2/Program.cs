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
            // get array size
            Console.Write("Array Row Count: ");
            uint rows = Convert.ToUInt32(Console.ReadLine());
            Console.Write("Array Row Column: ");
            uint columns = Convert.ToUInt32(Console.ReadLine());

            // create array
            uint[,] array = new uint[rows, columns];

            // loop rows
            for (uint row = 0; row < rows; row++)
            {
                // loop columns
                for (uint column = 0; column < columns; column++)
                {
                    // get user input
                    Console.Write($"Enter Array [{row},{column}]: ");
                    array[row, column] = Convert.ToUInt32(Console.ReadLine());
                }
            }

            // print multi-dimensional array
            Console.WriteLine("--------------------Multi-Dimensional Array--------------------");
            for (uint row = 0; row < rows; row++)
            {
                for (uint column = 0; column < columns; column++)
                {
                    Console.Write($"{array[row, column]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
