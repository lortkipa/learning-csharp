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
            // create matrix 3x3 matrix
            int[,] matrix = new int[3,3];

            // get input
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"Matrix[{i},{j}]: ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }

            // print whole matrix
            Console.WriteLine("-----------Matrix-----------");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i,j]}, ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // calculate sum
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                }
            }
            Console.WriteLine($"Sum Of Every Element In 3X3 Matrix Is: {sum}");

            // calculate average
            double average = (double)sum / (matrix.GetLength(0) * matrix.GetLength(1));
            Console.WriteLine($"Average Of Every Element In 3X3 Matrix Is: {average}");
        }
    }
}
