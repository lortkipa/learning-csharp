using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create array
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Element {i}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            // get element
            Console.Write("Access element at index: ");
            int el = AccessArrayElement(arr, 5);
            Console.WriteLine($"Element value: {AccessArrayElement(arr, int.Parse(Console.ReadLine()))}");
        }

        public static int AccessArrayElement(int[] array, int index)
        {
            try
            {
                int element = array[index];
                return element;
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("--------------------- IndexOutOfRangeException ---------------------");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.Source);
                return 0;
            }
        }
    }
}
