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
            Console.Write("Enter String: ");
            string str = Console.ReadLine();

            Console.Write("Input The String To Search: ");
            string searchStr = Console.ReadLine();

            Console.Write("Input The String To Insert: ");
            string insertStr = Console.ReadLine();

            // find position of search string
            int insertPos = str.IndexOf(searchStr);

            // check if string is found
            if (insertPos == -1)
            {
                Console.WriteLine($"Can't Find \"{searchStr}\" In \"{str}\"");
                return;
            }

            // insert string
            str = str.Insert(insertPos, insertStr);

            // log result
            Console.WriteLine($"Result String: {str}");
        }
    }
}
