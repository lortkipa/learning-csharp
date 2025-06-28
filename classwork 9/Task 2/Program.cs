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
            // define array by user
            int[] array = GetArray();
            LogArray(array);

            // get shift info
            Console.Write("Enter Shift Number (Negavative For Left Shift): ");
            ShiftArray(array, Convert.ToInt32( Console.ReadLine() ) );

            // log result
            LogArray(array);
        }

        static int[] GetArray()
        {
            // create array
            Console.Write("Array Length: ");
            int[] array = new int[Convert.ToInt32(Console.ReadLine())];

            // fill array
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Enter Array[{i}]: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            // return created array
            return array;
        }

        static void LogArray(int[] array)
        {
            Console.Write("Array: ");
            for (int i = 0; i < array.Length - 1; i++)
            {
                Console.Write($"{array[i]}, ");
            }
            Console.WriteLine($"{array[array.Length - 1]}. ");
        }

        static void ShiftArray(int[] array, int shift)
        {
            // 0 shift means no shift
            if (array.Length == 0) return;

            // we dont want shift to be greater than array length
            shift = shift % array.Length;

            // if shift right
            if (shift > 0)
            {
                for (int s = 0; s < shift; s++)
                {
                    int last = array[array.Length - 1];
                    for (int i = array.Length - 1; i > 0; i--)
                        array[i] = array[i - 1];
                    array[0] = last;
                }
            }
            // if shift left
            else if (shift < 0)
            {
                shift = -shift;
                for (int s = 0; s < shift; s++)
                {
                    int first = array[0];
                    for (int i = 0; i < array.Length - 1; i++)
                        array[i] = array[i + 1];
                    array[array.Length - 1] = first;
                }
            }
        }
    }
}
