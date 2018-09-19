using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
	public class Pesos
	{
		double cantidad;
		private static float cotizRespectoDolar;
		private Pesos()
		{
			cotizRespectoDolar = 17.55F;
		}
		public Pesos(double cantidad) : this()
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
		public static explicit operator Dolar(Pesos p)
		{
			Dolar d = new Dolar(p.GetCantidad() / Pesos.GetCotizacion());
			return d;
		}
		public static explicit operator Euro(Pesos p)
		{
			Euro e = new Euro((p.GetCantidad() / Pesos.GetCotizacion()) / Euro.GetCotizacion());
			return e;
		}
		public static implicit operator Pesos(double d)
		{
			Pesos aux = new Pesos(d);
			return aux;
		}
		public static bool operator !=(Pesos p, Dolar d)
		{
			return !(p == d);
		}
		public static bool operator ==(Pesos p, Dolar d)
		{
			if (p.GetCantidad() == (d.GetCantidad() * Dolar.GetCotizacion()))
			{
				return true;
			}
			return false;
		}
		public static bool operator !=(Pesos p, Euro e)
		{
			return !(p == e);
		}
		public static bool operator ==(Pesos p, Euro e)
		{
			if (p.GetCantidad() == ((e.GetCantidad() * Euro.GetCotizacion()) * Pesos.GetCotizacion()))
				return true;
			return false;
		}
		public static bool operator !=(Pesos p1, Pesos p2)
		{
			return !(p1 == p2);
		}
		public static bool operator ==(Pesos p1, Pesos p2)
		{
			if (p1.GetCantidad() == p2.GetCantidad())
				return true;
			return false;
		}
		public static Pesos operator -(Pesos p, Dolar d)
		{
			Pesos aux = new Pesos(p.GetCantidad() - (d.GetCantidad() * Pesos.GetCotizacion()));
			return aux;
		}
		public static Pesos operator +(Pesos p, Dolar d)
		{
			Pesos aux = new Pesos(p.GetCantidad() + (d.GetCantidad() * Pesos.GetCotizacion()));
			return aux;
		}
		public static Pesos operator -(Pesos p, Euro e)
		{
			Pesos aux = new Pesos(p.GetCantidad() - (e.GetCantidad() * Euro.GetCotizacion() * Pesos.GetCotizacion()));
			return aux;
		}
		public static Pesos operator +(Pesos p, Euro e)
		{
			Pesos aux = new Pesos(p.GetCantidad() + (e.GetCantidad() * Euro.GetCotizacion() * Pesos.GetCotizacion()));
			return aux;
		}
	}
}
