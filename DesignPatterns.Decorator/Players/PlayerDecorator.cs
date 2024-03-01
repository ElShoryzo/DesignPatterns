using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Decorator.Swords;

namespace DesignPatterns.Decorator.Players
{
    public class PlayerDecorator : IPlayer
    {
        public IPlayer Player { get; set; }
        public PlayerDecorator(IPlayer player)
        {
            Player = player;
        }
        // Las implementaciones en el decorator deben de ser virtuales porque se debe de poder modificar su comportamiento con override
        public virtual int GetRemainingHP() => Player.GetRemainingHP(); 
        public virtual void AttackPlayer(IPlayer enemy) => Player.AttackPlayer(enemy);

        public virtual void Defend(int incomingAttack) => Player.Defend(incomingAttack);

        public virtual int GetTotalDamage() => Player.GetTotalDamage();

        public virtual int GetTotalDefense() => Player.GetTotalDefense();
    }
}
