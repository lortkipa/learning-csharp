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
            // get array
            Console.Write("Enter Array Length: ");
            int[] array = new int[Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Enter Array[{i}]: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            // calculate result
            int sum = GetArraySum(out int min, out int max, out float average, array);

            // log result
            Console.WriteLine($"Sum: {sum}. Min: {min}. Max: {max}. Average: {average}.");
        }

        static int GetArraySum(out int min, out int max, out float average, params int[] arr)
        {
            // calculate sum
            int sum = 0;
            foreach (int num in arr)
                sum += num;

            // find miminum
            min = arr[0];
            foreach (int num in arr)
                if (min > num)
                    min = num;

            // find maximum
            max = arr[0];
            foreach (int num in arr)
                if (max < num)
                    max = num;

            // calculate average
            average = sum / arr.Length;

            // return sum
            return sum;
        }
    }
}
