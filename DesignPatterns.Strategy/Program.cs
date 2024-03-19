namespace DesignPatterns.Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var monto = 100m;
            ProcesadorPagos procesador = new(new DescuentoClienteVIP());
            var montoConDescuento = procesador.ProcesarPago(monto);
            System.Console.WriteLine($"Total a pagar con descuento aplicado cliente VIP: {montoConDescuento}");
            // OUTPUT:
            /*
             *  Monto con descuento cliente VIP: 70
             */

            procesador = new(new DescuentoClienteFrecuente());
            montoConDescuento = procesador.ProcesarPago(monto);
            System.Console.WriteLine($"Total a pagar con descuento aplicado cliente frecuente: {montoConDescuento}");
            // OUTPUT:
            /*
             *  Monto con descuento cliente frecuente: 80
             */

            procesador = new(new DescuentoClienteNuevo());
            montoConDescuento = procesador.ProcesarPago(monto);
            System.Console.WriteLine($"Total a pagar con descuento aplicado cliente nuevo: {montoConDescuento}");
            // OUTPUT:
            /*
             *  Monto con descuento cliente nuevo: 90
             */
        }
    }
}
