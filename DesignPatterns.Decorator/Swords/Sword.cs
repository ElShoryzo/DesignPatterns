using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator.Swords
{
    public class Sword : ISword
    {
        public int Attack { get; private set; }
        public Sword(int attack)
        {
            Attack = attack;
        }
        public int GetDamage() => Attack;
    }
}
