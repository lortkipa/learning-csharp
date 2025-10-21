using System;
using System.ComponentModel;

namespace Task_4
{
    internal abstract class Shape : IShape
    {
        public string Color { get; }
        public string Name { get; }

        public Shape(string color, string name)
        {
            Color = color;
            Name = name;
        }

        public abstract double CalculateArea();

        public abstract double CalculatePerimeter();

        public virtual void Display()
        {
            Console.WriteLine($"Shape color: {Color}. name: {Name}");
        }
    }

    class Circle : Shape
    {
        public double Radius { get; }

        static double PI = 3.14;

        public Circle(string color, string name, double radius) : base(color, name)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return PI * Radius * Radius;
        }

        public override double CalculatePerimeter()
        {
            return 2 * PI * Radius;
        }

        public override void Display()
        {
            Console.WriteLine($"Shape color: {Color}. name: {Name}. Radius: {Radius}");
        }
    }

    class Rectangle : Shape
    {
        public float Width { get; }
        public float Height { get; }

        public Rectangle(string color, string name, float width, float height) : base(color, name)
        {
            Width = width;
            Height = height;
        }

        public override double CalculateArea()
        {
            return Width * Height;
        }

        public override double CalculatePerimeter()
        {
            return 2 * (Width + Height);
        }

        public override void Display()
        {
            Console.WriteLine($"Shape color: {Color}. name: {Name}. Width: {Width}. Height: {Height}");
        }
    }

    class Triangle : Shape
    {
        public float A { get; }
        public float B { get; }
        public float C { get; }

        public Triangle(string color, string name, float a, float b, float c) : base(color, name)
        {
            A = a;
            B = b;
            C = c;
        }

        public override double CalculateArea()
        {
            double temp = (A + B + C) / 2.0;
            return Math.Sqrt(temp * (temp - A) * (temp - B) * (temp - C));
        }

        public override double CalculatePerimeter()
        {
            return A + B + C;
        }

        public override void Display()
        {
            Console.WriteLine($"Shape color: {Color}. name: {Name}. A: {A}. B: {B}. C: {C}");
        }
    }
}
