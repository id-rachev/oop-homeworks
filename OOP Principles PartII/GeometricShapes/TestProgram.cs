using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    class TestProgram
    {
        static void Main()
        {
            Shape[] myShapes = new Shape[]
            {
                new Rectangle(2.4f, 4.5f),
                new Rectangle(4.6f, 3.0f),
                new Triangle(2.0f, 6.4f),
                new Triangle(8.5f, 2.4f),
                new Circle(3.2f),
                new Circle(6.3f),
            };

            foreach (var shape in myShapes)
            {
                Console.WriteLine("{0}'s surface = {1}", shape.GetType().Name, shape.CalculateSurface());
            }
        }
    }
}
