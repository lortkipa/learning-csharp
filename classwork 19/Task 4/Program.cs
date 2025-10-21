using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string _color, _name;

            // circle
            Console.WriteLine("---------- Circle ----------");
            Console.Write("Color: "); _color = Console.ReadLine();
            Console.Write("Name: "); _name = Console.ReadLine();
            Console.Write("Radius: ");
            Shape circle = new Circle(_color, _name, double.Parse(Console.ReadLine()));
            circle.Display();
            Console.WriteLine($"Perimeter: {circle.CalculatePerimeter()}. Area: {circle.CalculateArea()}");

            // rectangle
            Console.WriteLine("---------- Rectangle ----------");
            Console.Write("Color: "); _color = Console.ReadLine();
            Console.Write("Name: "); _name = Console.ReadLine();
            Console.Write("Width and Height: ");
            Shape rectangle = new Rectangle(_color, _name, float.Parse(Console.ReadLine()), float.Parse(Console.ReadLine()));
            rectangle.Display();
            Console.WriteLine($"Perimeter: {rectangle.CalculatePerimeter()}. Area: {rectangle.CalculateArea()}");

            // triangle
            Console.WriteLine("---------- Triangle ----------");
            Console.Write("Color: "); _color = Console.ReadLine();
            Console.Write("Name: "); _name = Console.ReadLine();
            Console.Write("A, B and C: ");
            Shape triangle = new Triangle(_color, _name, float.Parse(Console.ReadLine()), float.Parse(Console.ReadLine()), float.Parse(Console.ReadLine()));
            triangle.Display();
            Console.WriteLine($"Perimeter: {triangle.CalculatePerimeter()}. Area: {triangle.CalculateArea()}");
        }
    }
}
