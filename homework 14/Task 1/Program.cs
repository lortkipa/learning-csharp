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
            // create triangle
            double temp;
            Triangle triangle = new Triangle();
            do
            {
                Console.Write("Enter Side A: ");
            } while (!double.TryParse(Console.ReadLine(), out temp));
            triangle.A = temp;
            do
            {
                Console.Write("Enter Side B: ");
            } while (!double.TryParse(Console.ReadLine(), out temp));
            triangle.B = temp;
            do
            {
                Console.Write("Enter Side C: ");
            } while (!double.TryParse(Console.ReadLine(), out temp));
            triangle.C = temp;

            // if triangle is valid, log info. if its not, log error message
            if (triangle.IsTriangleValid())
            {
                Console.WriteLine($"Perimeter Of Triangle: {triangle.Perimeter()}");
                Console.WriteLine($"Area Of Triangle: {triangle.Area()}");
            }
            else
            {
                Console.WriteLine("This Is Not Valid Triangle");
            }
        }
    }
}
