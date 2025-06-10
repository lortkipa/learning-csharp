using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // get user input
            Console.Write("Enter Number: ");
            uint maxNum = Convert.ToUInt32(Console.ReadLine());

            // store sum here
            uint sum = 0;

            // loop thro 1 to maxNum
            for (uint i = 1; i <= maxNum; i++)
            {
                // if number is odd, add to sum
                if (i  % 2 == 1)
                {
                    sum += i;
                }
            }

            // log result
            Console.WriteLine($"Sum Of Odd Numbers From 1 To {maxNum} Is {sum}");
        }
    }
}
