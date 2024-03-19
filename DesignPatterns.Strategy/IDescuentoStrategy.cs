using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    internal interface IDescuentoStrategy
    {
        decimal AplicarDescuento(decimal monto);
    }
}
