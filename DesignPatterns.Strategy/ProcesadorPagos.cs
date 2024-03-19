using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    internal class ProcesadorPagos
    {
        private IDescuentoStrategy _descuentoStrategy;

        public ProcesadorPagos(IDescuentoStrategy descuentoStrategy)
        {
            _descuentoStrategy = descuentoStrategy;
        }

        public decimal ProcesarPago(decimal monto)
        {
            return _descuentoStrategy.AplicarDescuento(monto);
        }
    }
}
