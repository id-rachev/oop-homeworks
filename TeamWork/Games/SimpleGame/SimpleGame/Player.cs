using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SimpleGame
{
    public class Player : Creature
    {
        public Player(Point p)
        {
            ImageCharacter = Constants.PlayerImage;
            Color = Constants.PlayerColor;
            Inventory = new List<Sword>();
            X = p.X;
            Y = p.Y;
            Hits = Constants.StartingHitPoints;
        }

        //Refactor 6: Encapsulate the move action within the player class 
        public Point Move(Constants.Direction direction)
        {
            Point newPoint = new Point(X, Y);
            switch (direction)
            {
                case Constants.Direction.N:
                    newPoint.Y -= 1;
                    break;
                case Constants.Direction.S:
                    newPoint.Y += 1;
                    break;
                case Constants.Direction.E:
                    newPoint.X += 1;
                    break;
                case Constants.Direction.W:
                    newPoint.X -= 1;
                    break;
            }
            return newPoint;
        }

        public IList<Sword> Inventory { get; set; }
    }

}
