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
            // get user input
            Console.Write("Enter Number: ");
            uint maxNum = Convert.ToUInt32(Console.ReadLine());

            // loop thro 1 to maxNum
            for (uint i = 1; i <= maxNum; i++)
            {
                // calculate cube for current num and log it on console
                Console.WriteLine($"{i} Cubed Is " + Math.Pow(i, 3));

                /*---------------------------------------------
                ######## This And Code Above Are Same #########
                Console.WriteLine($"{i} Cubed Is " + i * i * i);
                ---------------------------------------------0*/
            }
        }
    }
}
