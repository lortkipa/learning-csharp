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
            // get array length
            Console.Write("Enter Array Length: ");
            uint length = Convert.ToUInt32(Console.ReadLine());

            // create array of provided length
            int[] array = new int[length];

            // get input for every element of array
            for (int i = 0; i < length; i++)
            {
                Console.Write($"Enter Number For Array Index {i}: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            // log created array in reversed order
            Console.Write("Array (In Reversed): ");
            for (int i = (int)(length - 1); i > 0; i--)
            {
                Console.Write($"{array[i]}, ");
            }
            Console.WriteLine($"{array[0]}. ");
        }
    }
}
