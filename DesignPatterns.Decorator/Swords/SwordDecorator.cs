using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator.Swords
{
    public class SwordDecorator : ISword
    {
        public ISword Sword { get; set; }
        public SwordDecorator(ISword sword) 
        {
            Sword = sword;
        }
        public virtual int GetDamage() => Sword.GetDamage();
    }
}
