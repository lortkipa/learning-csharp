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
            Console.Write("Enter String: ");
            string str = Console.ReadLine();

            // get and log result
            Console.WriteLine($"Reversed String: {ReverseString(str)}");
        }

        static string ReverseString(string str)
        {
            // store result here
            char[] charArr = str.ToCharArray();

            // reverse the string
            for (int i = 0; i < charArr.Length / 2; i++)
            {
                char temp = charArr[i];
                charArr[i] = charArr[charArr.Length - i - 1];
                charArr[charArr.Length - i - 1] = temp;
            }

            // return result
            return new string(charArr);

            /*
             * we could just use str.Reverse() function
             */
        }
    }
}
