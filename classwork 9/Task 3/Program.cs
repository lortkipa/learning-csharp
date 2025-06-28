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
            // create array
            int[] array = CreateArray(10);

            // print array
            Console.Write("Array Members That are Even And Greater Than 20: ");
            foreach (int element in array)
            {
                if (element % 2 == 0 && element > 20)
                    Console.Write($"{element}, ");
            }
            Console.WriteLine();
        }

        static int[] CreateArray(uint length)
        {
            // create array
            int[] array = new int[length];

            // get input
            for (int i = 0; i < length; i++)
            {
                Console.Write($"Enter Array[{i}]: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            // return created array
            return array;
        }
    }
}
