using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    internal class DescuentoClienteVIP : IDescuentoStrategy
    {
        public decimal AplicarDescuento(decimal monto)
        {
            return monto * 0.7m;
        }
    }
}
