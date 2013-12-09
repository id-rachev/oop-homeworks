using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeamGame
{
    public class SnakeHead : GameObject
    {
        public new const string CollisionGroupString = "SnakeHead";

        public static char[,] myManBody = new char[,] { {'1'} };

        public SnakeHead(MatrixCoords topLeft)
            : base(topLeft,new char[,]{{'O'}})
        {
        }



        public void MoveUp()
        {
            this.topLeft.Row--;
        }

        public void MoveDown()
        {
            this.topLeft.Row++;
        }

        public void MoveLeft()
        {
            this.topLeft.Col--;
        }

        public void MoveRight()
        {
            this.topLeft.Col++;
        }

        public override string GetCollisionGroupString()
        {
            return SnakeHead.CollisionGroupString;
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "block" || otherCollisionGroupString == SnakeHead.CollisionGroupString || otherCollisionGroupString == "ball";
        }

        public override void Update()
        {
            
        }
    }
}
