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
            // get numbers
            int[] _nums = new int[10];
            for (int i = 0; i < _nums.Length; i++)
            {
                do
                {
                    Console.Write($"Number {i}: ");
                } while (!int.TryParse(Console.ReadLine(), out _nums[i]));
            }

            // log number infos
            Numbers nums = new Numbers(_nums);
            Console.WriteLine($"Distinct number count: {nums.CountDistinct()}");
            Console.Write("Enter any number: ");
            Console.WriteLine($"Provided number in string: {nums.EqualToValue(int.Parse(Console.ReadLine()))} times");
        }
    }
}
