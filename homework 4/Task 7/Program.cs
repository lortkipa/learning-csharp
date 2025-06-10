using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // get number
            Console.Write("Enter Number: ");
            uint number = Convert.ToUInt32(Console.ReadLine());

            // keep track of last 1 numbers
            uint a = 0;
            uint b = 1;

            // loop tho 1 to number
            for (uint i = 0; i < number; i++)
            {
                // log fibanochi number
                Console.Write($"{a}, ");

                // calculate next number of fibanochi
                uint nextNum = a + b;

                // track last 2 numbers
                a = b;
                b = nextNum;
            }

            // log last number of fibanochi 
            Console.WriteLine($"{a}. ");
        }
    }
}
