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
            Console.Write("Input a String: ");
            string str = Console.ReadLine();

            Console.Write("Input a substring to be found in the string: ");
            string subStr = Console.ReadLine();

            // find position 
            int pos = CostumIndexOf(str, subStr);

            // log result
            if (pos == -1)
            {
                Console.WriteLine($"Substring \"{subStr}\" Not Found In String \"{str}\"");
            }
            else
            {
                Console.WriteLine($"Substring \"{subStr}\" Found In String \"{str}\" At Position: {pos}");
                Console.WriteLine($"(Using IndexOf()) Substring \"{subStr}\" Found In String \"{str}\" At Position: {str.IndexOf(subStr)}");
            }
        }

        static int CostumIndexOf(string str, string subStr)
        {
            // substr length should be lesser than str and greater than 0
            if (subStr.Length == 0 || subStr.Length > str.Length)
                return -1;

            // find pos of substr in str
            for (int i = 0; i <= str.Length - subStr.Length; i++)
            {
                bool subStrFound = false;

                for (int j = 0; j < subStr.Length; j++)
                {
                    subStrFound = str[i + j] == subStr[j];

                    if (!subStrFound)
                        break;
                }

                if (subStrFound)
                    return i;
            }

            // substr not found, so return -1
            return -1;
        }
    }
}
