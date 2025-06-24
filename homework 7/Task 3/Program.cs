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
            // get input
            Console.Write("Enter Text: ");
            string text = Console.ReadLine();

            // ხმოვნები
            int vowelCount = 0;

            // თანხმოვნები
            int consonantCount = 0;

            // find vowels and consonants in the string
            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    if ("aeiou".Contains(char.ToLower(c)))
                        vowelCount++;
                    else
                        consonantCount++;
                }
            }

            // log result
            Console.WriteLine($"The total number of vowel in the string is: {vowelCount}");
            Console.WriteLine($"The total number of consonant in the string is: {consonantCount}");
        }
    }
}
