using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // get input
            Console.Write("Enter Text: ");
            string str = Console.ReadLine();

            // split string into array of words
            string[] words = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // store info here
            int wordCount = words.Length;
            string longestWord = "";
            int wordInUpperCaseCount = 0;

            // get info
            foreach (string word in words)
            {
                if (char.IsUpper(word[0]))
                    wordInUpperCaseCount++;

                if (word.Length > longestWord.Length)
                    longestWord = word;
            }

            // log info
            Console.WriteLine($"Words: {wordCount}");
            Console.WriteLine($"Longest Word: {longestWord}");
            Console.WriteLine($"Word In Upper Letter: {wordInUpperCaseCount}");
        }
    }
}
