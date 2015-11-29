using System;

namespace Shapes
{
    class MainProgram
    {
        static void Main()
        {
            IShape[] shapes = { new Circle(5), new Rectangle(5, 10), new Rhombus(5, 10)};

            foreach (var shape in shapes)
            {
                Console.WriteLine("Type: {0}, Area: {1:F2}, Perimeter: {2:F2}", shape.GetType().Name, shape.CalculateArea(), shape.CalculatePerimeter());
            }
        }
    }
}
