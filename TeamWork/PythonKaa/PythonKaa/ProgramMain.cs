using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamGame
{
    class ProgramMain
    {
        //Declaring Our World
        const int WorldRows = 25;
        const int WorldCols = 50;

        static void Initialize(Engine engine)
        {
            int startRow = 5;
            int startCol = 2;
            int endCol = WorldCols - 2;
            int endRow = WorldRows - 2;

            //NorthWall
            for (int i = startCol; i < endCol; i++)
            {
                IndestructableWall currBlock = new IndestructableWall(new MatrixCoords(startRow, i));

                engine.AddObject(currBlock);
            }

            //RightWall
            for (int i = startRow; i < endRow; i++)
            {
                IndestructableWall currBlock = new IndestructableWall(new MatrixCoords(i, endCol));

                engine.AddObject(currBlock);
            }

            //SouthWall
            for (int i = startCol; i < endCol; i++)
            {
                IndestructableWall currBlock = new IndestructableWall(new MatrixCoords(endRow, i));

                engine.AddObject(currBlock);
            }

            //LeftWall
            for (int i = startRow; i < endRow; i++)
            {
                IndestructableWall currBlock = new IndestructableWall(new MatrixCoords(i, startCol));

                engine.AddObject(currBlock);
            }

            SnakeHead myMan = new SnakeHead(new MatrixCoords(12, 12));
            engine.AddObject(myMan);
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

            keyboard.OnUpPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketUp();
            };

            keyboard.OnDownPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketDown();
            };

            Initialize(gameEngine);

            gameEngine.Run();
        }
    }
}
