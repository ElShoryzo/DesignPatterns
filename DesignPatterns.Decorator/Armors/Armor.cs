using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator.Armors
{
    public class Armor : IArmor
    {
        public int Defense { get; set; } 
        public Armor(int defense)
        {
            Defense = defense;
        }
        public int GetDefense() => Defense;
    }
}
