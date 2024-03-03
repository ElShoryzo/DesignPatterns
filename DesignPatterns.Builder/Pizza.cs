using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    internal class Pizza
    {
        public List<string> Ingredients { get; set; }
        public Pizza()
        {
            Ingredients = new List<string>();
        }
        public override string ToString()
        {
            return string.Join(", ", Ingredients);
        }
    }
}
