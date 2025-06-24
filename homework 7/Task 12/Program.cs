using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12
{
    internal class Program
    {
        static void Main()
        {
            // get inputs
            Console.Write("Enter First String: ");
            string str1 = Console.ReadLine();

            Console.Write("Enter Second String: ");
            string str2 = Console.ReadLine();

            // find if strings have common ending
            string commonEnding = FindCommonEnding(str1, str2);

            // log result
            Console.WriteLine("Common Ending Between Two Strings: " +
                (commonEnding == "" ? "No Common Ending" : commonEnding));
        }

        static string FindCommonEnding(string str1, string str2)
        {
            // get last indexes
            int i = str1.Length - 1;
            int j = str2.Length - 1;

            // store result here
            string result = "";

            // if characters are common ending, add to result, else - quit loop
            while (i >= 0 && j >= 0 && str1[i] == str2[j])
            {
                result = str1[i] + result;
                i--;
                j--;
            }

            return result;
        }
    }
}
