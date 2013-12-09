using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SimpleGame
{
    public class Wall : Tile
    {
        public Wall(int x, int y)
            : base(x, y)
        {
            ImageCharacter = Constants.WallImage;
            this.Color = Constants.WallColor;
        }
    }  
}
