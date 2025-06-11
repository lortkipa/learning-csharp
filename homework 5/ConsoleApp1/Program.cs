using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region SubTask 1
            {
                Console.WriteLine("-------------------- 1 --------------------");

                // create array
                int[] array = new int[] { 1, 5, 7, 3 };

                // create new arr where array will be stored but in reverse
                int[] reverseArray = new int[array.Length];

                // reverse array and store result in 'reverseArray'
                for (int i = 0; i < array.Length; i++)
                {
                    reverseArray[reverseArray.Length - i - 1] = array[i];
                }

                // log array
                Console.Write("Array: ");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"{array[i]} ");
                }
                Console.WriteLine();

                // log reversed array
                Console.Write("Reversed Array: ");
                for (int i = 0; i < reverseArray.Length; i++)
                {
                    Console.Write($"{reverseArray[i]} ");
                }
                Console.WriteLine();
            }
            #endregion

            #region SubTask 2
            {
                Console.WriteLine("-------------------- 2 --------------------");

                // create array
                int[] array = new int[] { 1, 5, 1, 6, 4, 4, 5, 9, 6, 9, 7, 9 };

                // log array
                Console.Write("Array: ");
                for (int i = 0; i < array.Length - 1; i++)
                {
                    Console.Write($"{array[i]}, ");
                }
                Console.WriteLine($"{array[array.Length - 1]}. ");

                // new array to track wich elements where already looked up
                bool[] states = new bool[array.Length];

                // loop array
                for (int i = 0; i < array.Length; i++)
                {
                    // if current element was already looked up, skip it
                    if (states[i])
                        continue;

                    // track dublicates of current element (i)
                    int dublicates = 0;

                    // loop array (from current num)
                    for (int j = i; j < array.Length; j++)
                    {
                        // if dublicate is found, increase dublicated count and update state
                        if (array[i] == array[j])
                        {
                            dublicates++;
                            states[j] = true;
                        }
                    }

                    // log current num stats
                    Console.WriteLine($"Element {array[i]} Count: {dublicates}");
                }
            }
            #endregion

            #region SubTask 3
            {
                Console.WriteLine("-------------------- 3 --------------------");

                // create array
                int[] array = new int[] { 4, 3, 8, 6, 1 };

                // log array
                Console.Write("Array: ");
                for (int i = 0; i < array.Length - 1; i++)
                {
                    Console.Write($"{array[i]}, ");
                }
                Console.WriteLine($"{array[array.Length - 1]}. ");

                /*---------- sort ----------*/
                // Array.Sort(array); we can do this instead of costum bubble sort

                /*---------- bubble sort ----------*/
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array.Length; j++)
                    {
                        if (array[i] < array[j])
                        {
                            int temp = array[i];
                            array[i] = array[j];
                            array[j] = temp;
                        }
                    }
                }

                // log sorted array
                Console.Write("Sorted Array: ");
                for (int i = 0; i < array.Length - 1; i++)
                {
                    Console.Write($"{array[i]}, ");
                }
                Console.WriteLine($"{array[array.Length - 1]}. ");
            }
            #endregion
        }
    }
}
