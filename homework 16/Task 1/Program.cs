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
            // triangle
            {
                Console.WriteLine("---------------Triangle---------------");

                // ესე ვაკეთებ რო ყველა field-ი ავტომატურად მივიღო და ბევრი არ ვწერო
                double[] fields = new double[4];
                string[] fieldNames = new string[4] { "Side 1", "Side 2", "Side 3", "Height" };
                bool isValid;

                for (int i = 0; i < fields.Length; i++)
                {
                    do
                    {
                        Console.Write($"{fieldNames[i]}: ");
                    } while (!double.TryParse(Console.ReadLine(), out fields[i]));
                }

                Shape triangle = new Triangle(fields[0], fields[1], fields[2], fields[3], out isValid);
                if (isValid)
                {
                    Console.WriteLine($"Perimeter: {triangle.CalculatePerimeter()}, Area: {triangle.CalculateArea()}.");
                }
                else
                {
                    Console.WriteLine("ERROR: Invalid Triangle Sides!");
                }
            }

            // circle
            {
                Console.WriteLine("---------------Circle---------------");

                double radius;

                do
                {
                    Console.Write("Radius: ");
                } while (!double.TryParse(Console.ReadLine(), out radius));

                Shape circle = new Circle(radius);
                Console.WriteLine($"Perimeter: {circle.CalculatePerimeter()}, Area: {circle.CalculateArea()}.");
            }

            // square
            {
                Console.WriteLine("---------------Square---------------");

                double side;

                do
                {
                    Console.Write("Side: ");
                } while (!double.TryParse(Console.ReadLine(), out side));

                Shape circle = new Square(side);
                Console.WriteLine($"Perimeter: {circle.CalculatePerimeter()}, Area: {circle.CalculateArea()}.");
            }
        }
    }
}
