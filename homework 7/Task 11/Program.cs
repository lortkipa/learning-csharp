using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // get string from user
            Console.Write("Enter String: ");
            string str = Console.ReadLine();

            // push char in the result string if its not there already
            StringBuilder result = new StringBuilder();
            foreach (char c in str)
            {
                if (!result.ToString().Contains(c))
                    result.Append(c);
            }

            // log result
            Console.WriteLine($"Result String: {result}");
        }
    }
}
