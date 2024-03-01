using DesignPatterns.Decorator.Swords;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator.Players
{
    public class SwordPlayerDecorator : PlayerDecorator
    {
        public ISword Sword { get; set; }
        public SwordPlayerDecorator(IPlayer player, ISword sword) : base(player) 
        {
            Sword = sword;
        }
        // En caso de crear una nueva implementacion con override de un metodo, se debe de crear una nueva implementacion de otros metodos que utilicen dicho metodo,
        // en este caso, se crea una nueva implementacion de AttackPlayer debido a que cambio la implementacion de GetTotalDamage, la cual es necesaria para AttackPlayer
        public override void AttackPlayer(IPlayer enemy) => enemy.Defend(GetTotalDamage());
        public override int GetTotalDamage() => Player.GetTotalDamage() + Sword.GetDamage();
    }
}
