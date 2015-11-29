using System;

namespace Shapes
{
    class Rhombus : BasicShape
    {
        public Rhombus(int width, int height) : base(width, height)
        {
        }

        public override double CalculateArea()
        {
            return (this.Width * this.Height) / 2;
        }

        public override double CalculatePerimeter()
        {
            double a = Math.Sqrt((this.Width * this.Width) + (this.Height * this.Height));
            return 4 * a;
        }
    }
}
