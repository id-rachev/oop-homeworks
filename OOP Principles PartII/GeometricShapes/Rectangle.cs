using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeometricShapes
{
    public class Rectangle : Shape
    {
        public Rectangle(float width, float height)
            : base(width, height)
        {
        }

        public override float CalculateSurface()
        {
            float surface = this.Width * this.Height;
            return surface;
        }
    }
}
