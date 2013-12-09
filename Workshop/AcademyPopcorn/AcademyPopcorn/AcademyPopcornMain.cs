using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class AcademyPopcornMain
    {
        const int WorldRows = 23;
        const int WorldCols = 40;
        const int RacketLength = 6;

        static void Initialize(Engine engine)
        {
            int startRow = 3;
            int startCol = 2;
            int endCol = WorldCols - 2;

            for (int i = startCol; i < endCol; i++)
            {
                Block currBlock = new Block(new MatrixCoords(startRow, i));

                engine.AddObject(currBlock);
            }

            for (int row = 2; row < WorldRows; row++)
            {
                IndestructibleBlock leftWallBlock = new IndestructibleBlock(new MatrixCoords(row, 0));
                engine.AddObject(leftWallBlock);
                IndestructibleBlock rightWallBlock = new IndestructibleBlock(new MatrixCoords(row, WorldCols - 1));
                engine.AddObject(rightWallBlock);
            }

            for (int col = 0; col < WorldCols; col++)
            {
                IndestructibleBlock ceilingBlock = new IndestructibleBlock(new MatrixCoords(1, col));
                //IndestructibleBlock.Symbol = ;
                engine.AddObject(ceilingBlock);
            }

            //Ball theBall = new Ball(new MatrixCoords(WorldRows / 2, 0),
            //    new MatrixCoords(-1, 1));

            //engine.AddObject(theBall);

            Ball theMeteoriteBall = new MeteoriteBall(new MatrixCoords(WorldRows / 2, 0), new MatrixCoords(-1, 1), 2);
            engine.AddObject(theMeteoriteBall);

            Racket theRacket = new Racket(new MatrixCoords(WorldRows - 1, WorldCols / 2), RacketLength);

            engine.AddObject(theRacket);
        }

        static void Main(string[] args)
        {
            IRenderer renderer = new ConsoleRenderer(WorldRows, WorldCols);
            IUserInterface keyboard = new KeyboardInterface();

            Engine gameEngine = new Engine(renderer, keyboard);

            keyboard.OnLeftPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketLeft();
            };

            keyboard.OnRightPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketRight();
            };

            Initialize(gameEngine);

            //

            gameEngine.Run();
        }
    }
}
