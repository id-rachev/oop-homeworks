using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SimpleGame
{
    public class Sword : Tile
    {
        public Sword(Point p)
        {
            ImageCharacter = Constants.SwordImage;
            this.Color = Constants.SwordColor;
            X = p.X;
            Y = p.Y;
        }
    }
}
