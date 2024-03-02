using DesignPatterns.Decorator.Armors;
using DesignPatterns.Decorator.Swords;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator.Players
{
    internal class ArmorPlayerDecorator : PlayerDecorator
    {
        public IArmor Armor { get; set; }
        public ArmorPlayerDecorator(IPlayer player, IArmor armor) : base(player)
        {
            Armor = armor;
        }
        public override int GetTotalDefense() => Player.GetTotalDefense() + Armor.GetDefense();
    }
}
