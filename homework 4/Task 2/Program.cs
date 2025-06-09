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
            // get user input
            Console.Write("Enter Number: ");
            uint maxNum = Convert.ToUInt32(Console.ReadLine());

            // define sum
            uint sum = 0;

            // loop thro 1 to maxNum
            for (uint i = 1; i <= maxNum; i++)
            {
                // update sum
                sum += i;
            }

            // log sum
            Console.WriteLine($"Sum From 1 To {maxNum} Is {sum}");
        }
    }
}
