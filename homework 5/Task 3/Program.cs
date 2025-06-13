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
            // get array size
            Console.Write("Enter Array Row Count: ");
            uint row = Convert.ToUInt32(Console.ReadLine());
            Console.Write("Enter Array Row Column: ");
            uint column = Convert.ToUInt32(Console.ReadLine());

            // create both array
            int[,] array1 = new int[row, column];
            int[,] array2 = new int[row, column];

            // fill first array from input
            for (uint i = 0; i < row; i++)
            {
                for (uint j = 0; j < column; j++)
                {
                    Console.Write($"Enter Array1 Element [{i},{j}]: ");
                    array1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // fill second array from input
            for (uint i = 0; i < row; i++)
            {
                for (uint j = 0; j < column; j++)
                {
                    Console.Write($"Enter Array2 Element [{i},{j}]: ");
                    array2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // create new array where sum will be stored
            int[,] sum = new int[row, column];

            // calculate sum
            for (uint i = 0; i < row; i++)
            {
                for (uint j = 0; j < column; j++)
                {
                    sum[i, j] = array1[i, j] + array2[i, j];
                }
            }

            // log sum to console
            Console.WriteLine("-------------------- Sum Of Array1 And Array2 --------------------");
            for (uint i = 0; i < row; i++)
            {
                for (uint j = 0; j < column; j++)
                {
                    Console.Write($"{sum[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
