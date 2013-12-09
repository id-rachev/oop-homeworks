using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeamGame
{
    public class FoodForSnake : GameObject
    {


        public FoodForSnake(MatrixCoords topLeft, char[,] body) 
            : base(topLeft, body)
        {
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }
    }
}
