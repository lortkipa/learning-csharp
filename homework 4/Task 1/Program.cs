using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // define sum
            byte sum = 0;

            // loop thro 0 to 10
            for (byte i = 0; i <= 10; i++)
            {
                // update sum
                sum += i;
            }

            // log sum to the console
            Console.WriteLine($"Sum From 0 To 10 Is {sum}");
        }
    }
}
