using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeometricShapes
{
    public class Triangle : Shape
    {
        public Triangle(float width, float height)
            : base(width, height)
        {
        }

        public override float CalculateSurface()
        {
            float surface = ((this.Width * this.Height) / 2);
            return surface;
        }
    }
}
