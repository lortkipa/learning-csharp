using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create string array
            Console.Write("Enter String Count: ");
            string[] array = new string[ Convert.ToInt32(Console.ReadLine()) ];

            // get strings
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Enter Array[{i}]: ");
                array[i] = Console.ReadLine();
            }

            // log strings
            Console.WriteLine("----------String Wich Ends With \"ing\" And It's Length Is Greater Than 5-----------");
            foreach (string str in array)
            {
                if (str.Length > 5 && str.EndsWith("ing"))
                {
                    Console.WriteLine($"{str}");
                }
            }
        }
    }
}
