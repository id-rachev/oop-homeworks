using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SimpleGame
{
    public class Dungeon
    {
        public IList<Wall> walls;           //Refactor 3: Replace the List<> with IList<>
        public Tile[,] Tiles;               //Refactor 2: make Tiles private

        public enum Direction
        {
            North,
            South,
            East,
            West
        }

        public Dungeon(int xMax, int yMax)
        {
            walls = new List<Wall>();
            Tiles = new Tile[xMax, yMax];
            BuildRandomDungeon();
        }

        private void SetAllDungeonSquaresToTiles()
        {
            for (int i = 0; i < Constants.DungeonHeight; i++)
            {
                for (int j = 0; j < Constants.DungeonWidth; j++)
                {
                    Tiles[j, i] = new Tile(i, j);
                }
            }
        }

        private void BuildRandomDungeon()
        {
            SetAllDungeonSquaresToTiles();

            for (int i = 0; i < Constants.DungeonWidth; i++)
            {
                Wall top = new Wall(i, 0);
                walls.Add(top);
                Wall bottom = new Wall(i, Constants.DungeonHeight - 1);
                walls.Add(bottom);
            }

            for (int i = 0; i < Constants.DungeonHeight; i++)
            {
                Wall left = new Wall(0, i);
                walls.Add(left);
                Wall right = new Wall(Constants.DungeonWidth - 1, i);
                walls.Add(right);
            }
        }

        public bool IsOKToMove(Point p)
        {
            return ((p.X > 0 && p.X < Constants.DungeonWidth - 1) && (p.Y < Constants.DungeonHeight - 1 && p.Y > 0));
        }

        internal void AddSword(Sword s)
        {
            Tiles[s.X, s.Y] = s;
        }

        internal void AddMonster(Monster m)
        {
            Tiles[m.X, m.Y] = m;
        }

        internal void AddWalls(Wall w)
        {
            Tiles[w.X, w.Y] = w;
        }

        internal void AddPlayer(Player player)
        {
            Tiles[player.X, player.Y] = player;
        }

        internal Tile GetTile(Point point)
        {
            return Tiles[point.X, point.Y];
        }

        internal void Clear()
        {
            SetAllDungeonSquaresToTiles();
        }
    }
}
