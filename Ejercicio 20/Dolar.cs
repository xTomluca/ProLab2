using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar
    {
        private double cantidad;
        private static float cotizRespectoDolar;
        private Dolar()
        {
            cotizRespectoDolar = 1F;
        }
        public Dolar(double cantidad) : this()
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
            Euro e = new Euro((d.GetCantidad() / Euro.GetCotizacion()));
            return e;
        }
		public static implicit operator Dolar(double d)
		{
			Dolar aux = new Dolar(d);
			return aux;
		}
		public static bool operator !=(Dolar d, Euro e)
		{
			return !(d == e);
		}
		public static bool operator ==(Dolar d, Euro e)
		{
			if (d.GetCantidad() == (e.GetCantidad() * Euro.GetCotizacion()))
				return true;
			return false;
		}
		public static bool operator !=(Dolar d, Pesos p)
		{
			return !(d==p);
		}
		public static bool operator ==(Dolar d, Pesos p)
		{
			if (d.GetCantidad() == (p.GetCantidad()/Pesos.GetCotizacion()))
				return true;
			return false;
		}
		public static bool operator !=(Dolar d1, Dolar d2)
		{
			return !(d1.GetCantidad() == d2.GetCantidad());
		}
		public static bool operator ==(Dolar d1, Dolar d2)
		{
			if (d1.GetCantidad() == d2.GetCantidad())
				return true;
			return false;
		}
		public static Dolar operator -(Dolar d, Euro e)
		{
			Dolar aux = new Dolar(d.GetCantidad() - (e.GetCantidad() * Euro.GetCotizacion()));
			return aux;
		}
		public static Dolar operator -(Dolar d, Pesos p)
		{
			Dolar aux = new Dolar(d.GetCantidad() - (p.GetCantidad() / Pesos.GetCotizacion()));
			return aux;
		}
		public static Dolar operator +(Dolar d, Euro e)
		{
			Dolar aux = new Dolar(d.GetCantidad() + (e.GetCantidad() * Euro.GetCotizacion()));
			return aux;
		}
		public static Dolar operator +(Dolar d, Pesos p)
		{
			Dolar aux = new Dolar(d.GetCantidad() + (p.GetCantidad() / Pesos.GetCotizacion()));
			return aux;
		}
	}
}
