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
            // get input
            Console.Write("Enter Character: ");
            char c = Convert.ToChar(Console.ReadLine());

            // check if char is letter
            if (char.IsLetter(c))
            {
                // log if char is upper or lowercase
                Console.WriteLine($"'{c}' Is " + (char.IsUpper(c) ? "Upper" : "Lower") + "case");
            }
            else
            {
                Console.WriteLine($"'{c}' Is Not Letter");
            }
        }
    }
}
