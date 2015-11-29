using System;

namespace Shapes
{
    class Circle : IShape
    {
        private const double Pi = 3.14159265359;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius { get; set; }

        public double CalculateArea()
        {
            return Pi * Math.Pow(this.Radius, 2);
        }

        public double CalculatePerimeter()
        {
            return 2 * Pi * this.Radius;
        }
    }
}
