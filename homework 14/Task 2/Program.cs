using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            double temp_x;
            double temp_y;

            // declare points
            Point p1;
            Point p2;

            // create point 1
            do
            {
                Console.Write("Enter Point 1 X: ");
            } while (!double.TryParse(Console.ReadLine(), out temp_x));
            do
            {
                Console.Write("Enter Point 1 Y: ");
            } while (!double.TryParse(Console.ReadLine(), out temp_y));
            p1 = new Point(temp_x, temp_y);

            // create point 2
            do
            {
                Console.Write("Enter Point 2 X: ");
            } while (!double.TryParse(Console.ReadLine(), out temp_x));
            do
            {
                Console.Write("Enter Point 2 Y: ");
            } while (!double.TryParse(Console.ReadLine(), out temp_y));
            p2 = new Point(temp_x, temp_y);

            // print distance
            Console.WriteLine($"Distance Between Point 1 And Point 2: {p1.DistanceTo(p2)}");
        }
    }
}
