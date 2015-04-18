using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shapes
{
    class Program
    {
        static void Main()
        {
            Shapess[] someShapes =
            {
                new Triangle(10,20),
                new Triangle(4,5),
                new Rectangle(10,20),
                new Rectangle(4,5),
                new Circle(3),
                new Circle(5),
            };
            foreach (var shape in someShapes)
            {
                Console.WriteLine(shape.CalculateSurface());
            }
        }
    }
}