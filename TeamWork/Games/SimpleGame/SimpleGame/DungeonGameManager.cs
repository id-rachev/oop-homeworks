using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGame
{
    public class DungeonGameManager
    {
        private Dungeon dungeon;
        private Player player;           //Refactor 3 player is private
        private IList<Monster> monsters; //Refactor 4 IList
        private IList<Sword> swords;     //Refactor 4 IList
        private bool playerAlive;
        private static Random random;

        public DungeonGameManager()
        {
            random = new Random();
            playerAlive = true;
            dungeon = new Dungeon(Constants.DungeonWidth, Constants.DungeonHeight);
            player = new Player(GetValidRandomPoint());
            player.CreatureDeadEvent += new Creature.CreatureDeadHandler(player_CreatureDeadEvent);
            monsters = new List<Monster>();
            swords = new List<Sword>();

            for (int i = 0; i < Constants.NumberOfMonsters; i++)
            {
                Monster monster = new Monster(GetValidRandomPoint());
                monster.CreatureDeadEvent += new Creature.CreatureDeadHandler(monster_CreatureDeadEvent);
                monsters.Add(monster);
            }

            for (int i = 0; i < Constants.NumberOfSwords; i++)
            {
                Sword sword = new Sword(GetValidRandomPoint());
                swords.Add(sword);
            }
        }

        public void DrawDungeon()
        {
            SetAllDungeonObjectsToTiles();
            DrawToConsole();
        }

        void monster_CreatureDeadEvent(object sender)
        {
            monsters.Remove((Monster)sender);
        }

        void player_CreatureDeadEvent(object sender)
        {
            //IsGameActive = false;
            playerAlive = false;
        }

        //Refactor 7:Replace that crazy name of valid move
        private Point GetValidRandomPoint()
        {
            Point p;
            do
            {
                p = new Point(random.Next(Constants.DungeonWidth), random.Next(Constants.DungeonWidth));
            }
            while (!dungeon.IsOKToMove(p));
            return p;
        }

        void player_CreatureDeadEvent()
        {
            playerAlive = false;
        }

        public bool? PlayerHasWon
        {
            get { return playerAlive && !IsGameActive; }
        }

        public bool IsGameActive
        {
            //Refactor 5:the alive monster count is now just the monster count as
            //we now remove the monster form the collection when they die
            get { return (player.Hits > 0 && monsters.Count() > 0); }
        }

        public string ExecuteCommand(ConsoleKeyInfo command)
        {
            StringBuilder commandResult = new StringBuilder(ProcessCommand(command));
            commandResult.Append(ProcessMonsters());
            SetAllDungeonObjectsToTiles();
            return commandResult.ToString();
        }

        private string ProcessMonsters()
        {
            if (monsters.Count() > 0)
            {
                MoveMonsters();
                return FightMonstersOnPlayersTile();
            }
            return string.Empty;
        }

        private string FightMonstersOnPlayersTile()
        {
            var monstersInBattle = monsters.Where(m => m.X == player.X && m.Y == player.Y).ToList();
            string outputText = string.Empty;

            if (monstersInBattle.Count() > 0)
            {
                SimpleBattle battle = new SimpleBattle(player, monstersInBattle);
                outputText = battle.Fight();
            }

            return outputText;
        }

        private void MoveMonsters()
        {
            monsters.ToList().ForEach(m =>
            {
                Point currentPlayerLocation = new Point(player.X, player.Y);
                m.MoveToPlayer(currentPlayerLocation);
            });
        }

        private void SetAllDungeonObjectsToTiles()
        {
            dungeon.Clear();
            swords.ToList().ForEach(s => dungeon.AddSword(s));
            monsters.ToList().ForEach(m => dungeon.AddMonster(m));
            dungeon.walls.ToList().ForEach(w => dungeon.AddWalls(w));
            dungeon.AddPlayer(player);
        }

        public string ProcessCommand(ConsoleKeyInfo command)
        {
            string output = string.Empty;
            switch (command.Key)
            {
                case ConsoleKey.UpArrow:
                case ConsoleKey.DownArrow:
                case ConsoleKey.RightArrow:
                case ConsoleKey.LeftArrow:
                    output = GetNewLocation(command, player);
                    break;
                case ConsoleKey.F1:
                    output = Constants.NoHelpText;
                    break;
            }

            return output;
        }

        private string GetNewLocation(ConsoleKeyInfo command, Player player)
        {
            Constants.Direction direction = GetDirectionFromConsoleKey(command);
            Point newPoint = player.Move(direction);

            if (dungeon.IsOKToMove(newPoint))
            {
                player.X = newPoint.X;
                player.Y = newPoint.Y;
                if (dungeon.GetTile(newPoint) is Sword && player.Inventory.Count == 0)
                {
                    Sword sword = (Sword)dungeon.GetTile(newPoint);
                    player.Inventory.Add(sword);
                    swords.Remove(sword);
                }
                return Constants.OKCommandText;
            }
            else
                return Constants.InvalidMoveText;
        }

        public Constants.Direction GetDirectionFromConsoleKey(ConsoleKeyInfo command)
        {
            Constants.Direction direction = Constants.Direction.Unknown;
            switch (command.Key)
            {
                case ConsoleKey.UpArrow:
                    direction = Constants.Direction.N;
                    break;
                case ConsoleKey.DownArrow:
                    direction = Constants.Direction.S;
                    break;
                case ConsoleKey.RightArrow:
                    direction = Constants.Direction.E;
                    break;
                case ConsoleKey.LeftArrow:
                    direction = Constants.Direction.W;
                    break;
            }
            return direction;
        }

        public void DrawToConsole()
        {
            Console.Clear();
            for (int i = 0; i < Constants.DungeonHeight; i++)
            {
                for (int j = 0; j < Constants.DungeonWidth; j++)
                {
                    Console.ForegroundColor = dungeon.Tiles[j, i].Color;
                    Console.Write(dungeon.Tiles[j, i].ImageCharacter);
                }
                Console.WriteLine();
            }
        }
    }
}
