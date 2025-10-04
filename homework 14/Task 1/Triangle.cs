using System;

namespace Task_1
{
    internal class Triangle
    {
        // fields
        private double _a;
        private double _b;
        private double _c;

        // properties
        public double A
        {
            get { return _a; }
            set
            {
                _a = value;
                IsTriangleValid();
            }
        }
        public double B
        {
            get { return _b; }
            set
            {
                _b = value;
                IsTriangleValid();
            }
        }
        public double C
        {
            get { return _c; }
            set
            {
                _c = value;
                IsTriangleValid();
            }
        }

        // methods
        public bool IsTriangleValid()
        {
            // check if triangle is valid acording to all sides
            if (_a == 0 || _b == 0 || _c == 0)
            {
                return false;
            }
            else if (!(_a + _b > _c && _b + _c > _a && _a + _c > _b))
            {
                return false;
            }

            return true;
        }
        public double Perimeter()
        {
            return _a + _b + _c;
        }
        public double Area()
        {
            double p = (_a + _b + _c) / 2;
            return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
        }

    }
}
