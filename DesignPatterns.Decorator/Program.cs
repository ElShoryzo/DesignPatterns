using DesignPatterns.Decorator.Players;
using DesignPatterns.Decorator.Swords;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var player1 = GetPlayer1();
            var player2 = GetPlayer2();
            while (player1.GetRemainingHP() > 0 && player2.GetRemainingHP() > 0)
            {
                player1.AttackPlayer(player2);
                player2.AttackPlayer(player1);
            }
        }
        public static IPlayer GetPlayer1()
        {
            return new Player(Guid.NewGuid(), "Player 1", 100, 3, 6);
        }
        public static IPlayer GetPlayer2()
        {
            var player = new Player(Guid.NewGuid(), "Player 2", 20, 2, 2);
            var sword = new Sword(10);
            var enchantedSword = new SharpnessSwordDecorator(sword);
            var equippedPlayer = new SwordPlayerDecorator(player, enchantedSword);
            return equippedPlayer;
        }
    }
}
