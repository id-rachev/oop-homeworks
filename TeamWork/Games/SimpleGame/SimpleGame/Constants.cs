using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SimpleGame
{
    public static class Constants
    {
        public readonly static int DungeonHeight = 20;
        public readonly static int DungeonWidth = 50;
        public readonly static int NumberOfSwords = 10;
        public readonly static int MonsterDamage = 2;
        public readonly static int NumberOfMonsters = 3;
        public readonly static int StartingHitPoints = 10;

        public readonly static string TileImage = ".";
        public readonly static string WallImage = "#";
        public readonly static string PlayerImage = "@";
        public readonly static string SwordImage = "s";
        public readonly static string StepsImage = "S";
        public readonly static string MonsterImage = "M";
        public readonly static string CursorImage = ">";

        public readonly static ConsoleColor MonsterColor = ConsoleColor.Blue;
        public readonly static ConsoleColor PlayerColor = ConsoleColor.Gray;
        public readonly static ConsoleColor WallColor = ConsoleColor.DarkCyan;
        public readonly static ConsoleColor SwordColor = ConsoleColor.Yellow;
        public readonly static ConsoleColor TileColor = ConsoleColor.White;

        public readonly static string InvalidCommandText = "That is not a valid command";
        public readonly static string OKCommandText = "OK";
        public readonly static string InvalidMoveText = "That is not a valid move";
        public readonly static string IntroductionText = "Welcome to the dungeon - grab a sword kill the monster(s) win the game";
        public readonly static string PlayerWinsText = "Player kills monster and wins";
        public readonly static string MonsterWinsText = "Monster wins";
        public readonly static string NoHelpText = "No help text";
        public readonly static string PlayerKillsMonsterText = "Player kills a monster";
        public readonly static string MonsterKillsPlayerText = "Monster kills a player";

        public enum Direction { N, S, E, W, Unknown };
    }
}
