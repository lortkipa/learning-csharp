using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // get input
            Console.Write("Enter Text: ");
            string str = Console.ReadLine();

            // get data
            GetStringData(str, out int letters, out int numbers, out int other);

            // print data
            PrintStringData(str, letters, numbers, other);
        }

        static void GetStringData(string str, out int letters, out int numbers, out int other)
        {
            // zero out data
            letters = 0;
            numbers = 0;
            other = 0;

            // find out character data and increase its count
            foreach (char c in str)
            {
                if (char.IsLetter(c))
                    letters++;
                else if (char.IsNumber(c))
                    numbers++;
                else
                    other++;
            }
        }

        static void PrintStringData(string str, int letters, int numbers, int other)
        {
            Console.WriteLine($"\"{str}\" Data -> letter: {letters}. number: {numbers}. Other: {other}");
        }
    }
}
