using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        double cantidad;
        private static float cotizRespectoDolar;
        private Euro()
        {
            cotizRespectoDolar = 1.3642F;
        }
        public Euro(double cantidad) : this()
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
        public static explicit operator Pesos(Euro e)
        {
            Pesos p = new Pesos(((e.GetCantidad() * Euro.GetCotizacion()) * Pesos.GetCotizacion()));
            return p;
        }
        public static explicit operator Dolar(Euro e)
        {
            Dolar d = new Dolar((e.GetCantidad() * Euro.GetCotizacion()));
            return d;
        }
		public static bool operator !=(Euro e, Dolar d)
		{
			return !(e == d);
		}
		public static bool operator !=(Euro e, Pesos p)
		{
			return !(e == p);
		}
		public static bool operator !=(Euro e1, Euro e2)
		{
			return !(e1 == e2);
		}
		public static bool operator ==(Euro e, Dolar d)
		{
			if (e.GetCantidad() == (d.GetCantidad() / Euro.GetCotizacion()))
				return true;
			return false;
		}
		public static bool operator ==(Euro e, Pesos p)
		{
			if(e.GetCantidad() == ((p.GetCantidad()/Pesos.GetCotizacion())/Euro.GetCotizacion()))
				return true;
			return false;
		}
		public static bool operator ==(Euro e1, Euro e2)
		{
			if (e1.GetCantidad() == e2.GetCantidad())
				return true;
			return false;
		}



	}
}
