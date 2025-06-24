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
            // get input
            Console.Write("Enter Text: ");
            string str = Console.ReadLine();

            // get and log reslt
            Console.WriteLine($"Word Count: {CountStringWords(str)}");
        }

        static int CountStringWords(string str)
        {
            // start counting form zero
            int words = 0;

            // count the words
            bool inWord = false;
            foreach (char c in str)
            {
                if (char.IsWhiteSpace(c))
                {
                    inWord = false;
                }
                else if (!inWord)
                {
                    words++;
                    inWord = true;
                }
            }

            // return counted words
            return words;
        }

    }
}
