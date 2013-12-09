using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGame
{
    public class SimpleBattle : IBattle
    {
        private Player player;
        private IList<Monster> monsters;

        public SimpleBattle(Player player, IList<Monster> monsters)
        {
            this.player = player;
            this.monsters = monsters;
        }

        public string Fight()
        {
            Monster monster = monsters.OrderBy(m => m.Hits).FirstOrDefault();//get the monster with the most hits
            if (player.Inventory.Any<Sword>())
            {
                player.Attack(monster);
                return Constants.PlayerKillsMonsterText;
            }
            else
            {
                monster.Attack(player);
                return Constants.MonsterKillsPlayerText;
            }
        }
    }
}
