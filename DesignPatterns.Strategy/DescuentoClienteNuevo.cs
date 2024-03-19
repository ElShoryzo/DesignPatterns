using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    internal class DescuentoClienteNuevo : IDescuentoStrategy
    {
        public decimal AplicarDescuento(decimal monto)
        {
            return monto * 0.9m;
        }
    }
}
