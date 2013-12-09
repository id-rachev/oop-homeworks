using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SimpleGame
{
    public class Monster : Creature
    {
        public Monster(Point p)
        {
            ImageCharacter = Constants.MonsterImage;
            Color = Constants.MonsterColor;
            X = p.X;
            Y = p.Y;
            Hits = Constants.StartingHitPoints;
        }

        //REFACTOR CHANGE 13:MoveMonsterToPlayer. The monster should be in charge of where it moves.
        public void MoveToPlayer(Point playerLocation)
        {
            Point move = new Point(X, Y);
            if (X > 0 && X < Constants.DungeonWidth && (X != playerLocation.X))
                X += (X > playerLocation.X) ? -1 : 1;

            if ((Y > 0 && Y < Constants.DungeonHeight) && (Y != playerLocation.Y))
                Y += (Y > playerLocation.Y) ? -1 : 1;

        }
    }
}
