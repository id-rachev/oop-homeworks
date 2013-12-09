using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeometricShapes
{
    public abstract class Shape
    {
        private float width;
        private float height;

        public Shape(float width, float height)
        {
            this.Width = width;
            this.Height = height;
        }

        public float Width
        {
            get
            {
                return this.width;
            }
            protected set
            {
                this.width = value;
            }
        }

        public float Height
        {
            get
            {
                return this.height;
            }
            protected set
            {
                this.height = value;
            }
        }

        public abstract float CalculateSurface();
    }
}
