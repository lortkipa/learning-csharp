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
            string str = Console.ReadLine();

            // manipulate string
            str = InsertSpaces(str);

            // log result
            Console.WriteLine($"New String: \"{str}\"");
        }
        static string InsertSpaces(string str)
        {
            // after every char, space is inserted, so its size should be X2
            char[] chars = new char[str.Length * 2];

            // insert space after every char
            for (int i = 0; i < chars.Length; i += 2)
            {
                chars[i] = str[i / 2];
                chars[i + 1] = ' ';
            }

            // return result
            return new string(chars);
        }
    }
}
