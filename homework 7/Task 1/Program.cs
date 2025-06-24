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
            // get input
            Console.Write("Enter Text: ");
            string text = Console.ReadLine();

            // add emty spaces after every character
            text = string.Join(" ", text.ToCharArray());

            // log result
            Console.WriteLine($"Result Text: {text}");
        }
    }
}
