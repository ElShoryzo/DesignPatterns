using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator.Swords
{
    public class SharpnessSwordDecorator : SwordDecorator
    {
        public SharpnessSwordDecorator(ISword sword) : base(sword) { }
        public override int GetDamage() => Sword.GetDamage() + 1;
    }
}
