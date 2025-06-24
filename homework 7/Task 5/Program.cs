using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // get input
            Console.Write("Enter Text: ");
            string text = Console.ReadLine();

            Console.Write("Position To Start Extraction: ");
            int newStringStart = Convert.ToInt32(Console.ReadLine());

            Console.Write("Length Of Substring: ");
            int newStringLength = Convert.ToInt32(Console.ReadLine());

            // create new string based on provided info
            char[] newStrChar = new char[newStringLength];
            for (int i = 0; i < newStringLength; i++)
            {
                newStrChar[i] = text[i + newStringStart];
            }

            // log result
            Console.WriteLine($"Text With Standart Substring: {text.Substring(newStringStart, newStringLength)}");
            Console.WriteLine($"Text With Costum Substring: {new string(newStrChar)}");
        }
    }
}
