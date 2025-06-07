using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // get user birth year
            Console.Write("Enter Your Birth Year: ");
            ushort year = Convert.ToUInt16(Console.ReadLine());

            // store chinese year here
            string chineseYear = "";

            // check for errors
            if (year < 1912)
                Console.WriteLine("[ERROR]: Can't Figure Out Year Less Then 1912.");

            // figure out chinese year
            if ((year - 1912) % 12 == 0)
                chineseYear = "Rat";
            else if ((year - 1913) % 12 == 0)
                chineseYear = "Ox";
            else if ((year - 1914) % 12 == 0)
                chineseYear = "Tiger";
            else if ((year - 1915) % 12 == 0)
                chineseYear = "Rabbit";
            else if ((year - 1916) % 12 == 0)
                chineseYear = "Dragon";
            else if ((year - 1917) % 12 == 0)
                chineseYear = "Snake";
            else if ((year - 1918) % 12 == 0)
                chineseYear = "Horse";
            else if ((year - 1919) % 12 == 0)
                chineseYear = "Sheep";
            else if ((year - 1920) % 12 == 0)
                chineseYear = "Monkey";
            else if ((year - 1921) % 12 == 0)
                chineseYear = "Rooster";
            else if ((year - 1922) % 12 == 0)
                chineseYear = "Dog";
            else if ((year - 1923) % 12 == 0)
                chineseYear = "Pig";
            else
            {
                // log errors
                Console.WriteLine("[ERROR]: Can't Figure Out Year " + year + ".");

                // exit program
                return;
            }

            // log users chinese year
            Console.WriteLine(year + " Was " + chineseYear + " Year.");
        }
    }
}
