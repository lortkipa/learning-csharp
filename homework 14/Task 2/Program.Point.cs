using System;

namespace Task_2
{
    internal partial class Program
    {
        struct Point
        {
            // properties
            public double X { get; set; }
            public double Y { get; set; }

            // methods
            public Point(double x, double y)
            {
                X = x;
                Y = y;
            }
            public double DistanceTo(Point p)
            {
                double dx = X - p.X;
                double dy = Y - p.Y;
                return Math.Sqrt(dx * dx + dy * dy);
            }
        }
    }
}
