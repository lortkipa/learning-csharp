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
            // get input
            Console.Write("Enter Text: ");
            string str = Console.ReadLine();

            Console.Write("Enter SubString: ");
            string subStr = Console.ReadLine();

            // check if subStr is in str
            bool substringFound = str.Contains(subStr);

            // log result
            Console.WriteLine($"Substring \"{subStr}\" " + (substringFound ? "Is" : "is not") + $" Found In String \"{str}\"");
        }
    }
}
