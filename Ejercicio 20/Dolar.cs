using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    class Dolar
    {
        private double cantidad;
        private static float cotizRespectoDolar;
        private Dolar()
        {
            cotizRespectoDolar = 1F;
        }
        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }
        private Dolar(double cantidad, float cotizacion) : this(cantidad)
        {
            cotizRespectoDolar = cotizacion;
        }
        public double GetCantidad()
        {
            return this.cantidad;
        }
        public static float GetCotizacion()
        {
            return cotizRespectoDolar;
        }
        public static explicit operator Pesos(Dolar d)
        {
            Pesos p = new Pesos((d.GetCantidad() * Pesos.GetCotizacion()));
            return p;
        }
        public static explicit operator Euro(Dolar d)
        {
            Euro e = new Euro((d.cantidad / Euro.GetCotizacion()));
            return e;
        }
    }
}
