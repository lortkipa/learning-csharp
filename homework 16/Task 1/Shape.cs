namespace Task_1
{
    internal abstract class Shape
    {
        public abstract double CalculatePerimeter();
        public abstract double CalculateArea();
    }

    internal class Triangle : Shape
    {
        private double _a, _b, _c, _height;

        public Triangle(double a, double b, double c, double height, out bool isValid)
        {
            _a = a;
            _b = b;
            _c = c;
            _height = height;

            if (a + b > c && a + c > b && b + c > a && a > 0 && b > 0 && c > 0 && height > 0)
                isValid = true;
            else
                isValid = false;
        }

        public override double CalculatePerimeter()
        {
            return _a + _b + _c;
        }
        public override double CalculateArea()
        {
            return _height * _b / 2;
        }
    }
    internal class Square : Shape
    {
        private double _side;

        public Square(double side)
        {
            _side = side;
        }

        public override double CalculatePerimeter()
        {
            return _side * 4;
        }
        public override double CalculateArea()
        {
            return _side * _side;
        }
    }
    internal class Circle : Shape
    {
        public static double PI = 3.14;

        private double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public override double CalculatePerimeter()
        {
            return 2 * Circle.PI * _radius;
        }
        public override double CalculateArea()
        {
            return Circle.PI * _radius * _radius;
        }
    }
}
