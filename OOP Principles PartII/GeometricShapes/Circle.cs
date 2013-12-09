using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeometricShapes
{
    public class Circle : Shape
    {
        public Circle(float width)
            : this(width, 0)
        {
        }

        public Circle(float width, float height)
            : base(width, height)
        {
            this.Height = width; // must be kept equal to width
        }

        public override float CalculateSurface()
        {
            float radius = (this.Width / 2);
            float surface = ((float)Math.PI * radius * radius);
            return surface;
        }
    }
}
