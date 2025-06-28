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
            GetVariable("A", out int a);
            GetVariable("B", out int b);
            GetVariable("C", out int c);

            // calculate discriminate
            int D = GetDiscriminat(a, b, c);
            Console.WriteLine($"Discriminat Is {D}");

            // calculate x
            if (D < 0)
            {
                Console.WriteLine("There Is Not Answer.");
            }
            else if (D == 0)
            {
                CalculateX(a, b, c, D, out double x1, out double x2);
                Console.WriteLine($"X1 and X2 are same: {x1}");
            }
            else
            {
                CalculateX(a, b, c, D, out double x1, out double x2);
                Console.WriteLine($"X1 Is: {x1}");
                Console.WriteLine($"X2 Is: {x2}");
            }
        }

        static void GetVariable(string varName, out int variable)
        {
            // log
            Console.Write($"Enter {varName}: ");

            // get input
            variable = Convert.ToInt32(Console.ReadLine());
        }

        static int GetDiscriminat(int a, int b, int c)
        {
            // calculate and return D
            return (b * b) - (4 * a * c);
        }

        static void CalculateX(int a, int b, int c, int D, out double x1, out double x2)
        {
            x1 = (-b + Math.Sqrt( ((b * b) - (4 * a * c)) / 2 * a ));
            x2 = (-b - Math.Sqrt( ((b * b) - (4 * a * c)) / 2 * a ));
        }
    }
}
