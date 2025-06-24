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
            // get array
            Console.Write("Enter Array Length: ");
            int[] array = new int[ Convert.ToInt32( Console.ReadLine() ) ];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Enter Array[{i}]: ");
                array[i] = Convert.ToInt32( Console.ReadLine() );
            }

            // get provided index value and log it on console
            Console.Write("Index Of Value To Get: ");
            int value = GetIndexValue( array, Convert.ToInt32( Console.ReadLine() ) );

            // log result
            if (value == -1)
            {
                Console.WriteLine($"Invalid Index Provided");
            }
            else
            {
                Console.WriteLine($"Value At Provided Index Is {value}");
            }
        }

        static int GetIndexValue(int[] array, int index)
        {
            // check for errors
            if (index < 0 || index >= array.Length)
                return -1;

            // return value of provided index
            return array[index];
        }
    }
}
