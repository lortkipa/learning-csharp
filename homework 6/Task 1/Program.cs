using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        static void StartTask(int count)
        {
            Console.WriteLine($"---------------------{count}--------------------");
        }
        static void Main(string[] args)
        {
            #region Task 1
            StartTask(1);
            {
                // array length fixed (already written in homework)
                int arrayLength = 5;

                // create 1d array
                int[] array = new int[arrayLength];

                // fill array
                for (int i = 0; i < arrayLength; i++)
                {
                    Console.Write($"Enter Array Element {i + 1}: ");
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }

                // bubble sort
                for (int i = 0; i < array.Length - 1; i++)
                {
                    for (int j = 0; j < array.Length - 1 - i; j++)
                    {
                        if (array[j] > array[j + 1])
                        {
                            int temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;
                        }
                    }
                }

                // log sorted array
                Console.Write("Sorted Array: ");
                for (int i = 0; i < array.Length - 1; i++)
                {
                    Console.Write($"{array[i]}, ");
                }
                Console.WriteLine($"{array[array.Length - 1]}.");

            }
            #endregion

            #region Task 2
            StartTask(2);
            {
                // get 1d array length
                Console.Write("Enter Array Length: ");
                int arrayLength = Convert.ToInt32(Console.ReadLine());

                // create 1d array
                float[] array = new float[arrayLength];

                // fill array
                for (int i = 0; i < arrayLength; i++)
                {
                    Console.Write($"Enter Array Element {i}: ");
                    array[i] = Convert.ToSingle(Console.ReadLine());
                }

                // calculate sum
                float sum = 0;
                foreach (float element in array)
                {
                    sum += element;
                }

                // calculate average
                float average = sum / arrayLength;

                // log result
                Console.WriteLine($"Average Of Every Element: {average}");
            }
            #endregion

            #region Task 2
            StartTask(2);
            {
                int[][] jaggedArray = new int[][]
                {
                    new int[]{ 1, 2, 3 },
                    new int[]{ 4, 5, 6, 7, 8 },
                    new int[]{ 6, 7, 8, 9, 2 }
                };

                // get wich number to find
                Console.Write("Enter Element Value (Intiger) To Find: ");
                int findNum = Convert.ToInt32(Console.ReadLine());

                int findCount = 0;

                // loop jagged array
                foreach (int[] array in jaggedArray)
                {
                    // loop array inside jagged array
                    foreach(int element in array)
                    {
                        // if provided element is found, increase its find count
                        if (element == findNum)
                        {
                            findCount++;
                        }
                    }
                }

                // log result
                Console.WriteLine($"Value {findNum} Founded {findCount} Times!");
            }
            #endregion
        }
    }
}
