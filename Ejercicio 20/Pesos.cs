using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    class Pesos
    {
        double cantidad;
        private static float cotizRespectoDolar;
        private Pesos()
        {
            cotizRespectoDolar = 0.5698F;
        }
        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Pesos(double cantidad, float cotizacion) : this(cantidad)
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
        public static explicit operator Dolar(Pesos d)
        {
            Dolar p = new Dolar((d.cantidad / Dolar.GetCotizacion()));
            return p;
        }
        public static explicit operator Euro(Pesos d)
        {
            Euro e = new Euro((d.cantidad / Euro.GetCotizacion()));
            return e;
        }
    }
}
