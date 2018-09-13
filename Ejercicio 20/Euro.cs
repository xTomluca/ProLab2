using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    class Euro
    {
        double cantidad;
        private static float cotizRespectoDolar;
        public Euro()
        {
            cotizRespectoDolar = 1.3642F;
        }
        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }
        private Euro(double cantidad, float cotizacion) : this(cantidad)
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
        public static explicit operator Pesos(Euro d)
        {
            Pesos p = new Pesos((d.cantidad * Pesos.GetCotizacion()));
            return p;
        }
        public static explicit operator Dolar(Euro d)
        {
            Dolar e = new Dolar((d.cantidad * Dolar.GetCotizacion()));
            return e;
        }
    }
}
