using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // get input and translate to char array (so it can be sorted)
            Console.Write("Enter Text: ");
            char[] textArr = Console.ReadLine().ToCharArray();

            // bubble sort
            for (int i = 0; i < textArr.Length - 1; i++)
            {
                for (int j = 0; j < textArr.Length - i - 1; j++)
                {
                    if (textArr[j] > textArr[j + 1])
                    {
                        char temp = textArr[j];
                        textArr[j] = textArr[j + 1];
                        textArr[j + 1] = temp;
                    }
                }
            }

            // log result
            Console.WriteLine($"Sorted Text: {new string(textArr)}");
        }
    }
}
