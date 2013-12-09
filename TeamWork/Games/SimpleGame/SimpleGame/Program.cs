using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SimpleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            DungeonGameManager dungeonGameManager = new DungeonGameManager();
            string displayText = Constants.IntroductionText;
            while (dungeonGameManager.IsGameActive)
            {
                dungeonGameManager.DrawDungeon();
                DrawDisplayText(displayText);
                displayText = dungeonGameManager.ExecuteCommand(Console.ReadKey());
            }
            dungeonGameManager.DrawDungeon();
            ConcludeGame(dungeonGameManager.PlayerHasWon.Value);
        }

        private static void DrawDisplayText(string displayText)
        {
            Console.WriteLine(displayText);
            Console.Write(Constants.CursorImage);
        }

        private static void ConcludeGame(bool hasPlayerWon)
        {
            string gameConclusionText = (hasPlayerWon) ? Constants.PlayerWinsText : Constants.MonsterWinsText;
            Console.WriteLine(gameConclusionText);
            Console.ReadLine();
        }
    }
}
