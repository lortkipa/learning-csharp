using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Task_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // get input
            Console.Write("Enter Text: ");
            string str = Console.ReadLine().ToLower();

            Console.Write("Enter Word To Look For: ");
            string word = Console.ReadLine().ToLower();

            // get word count
            int count = str.Split(new string[]{word}, StringSplitOptions.None).Length - 1;

            // log result
            Console.WriteLine($"Word \"{word}\" Is Written {count} Times In Provided Text");
        }
    }
}
