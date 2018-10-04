using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mayor : Comensal
    {
        public enum eBebidas 
        {
            Agua,
            Cerveza,
            Vino,
            Gaseosa
        }
        eBebidas _bebida;
        public eBebidas Bebida
        {
            set
            {
                this._bebida = value;
            }
            get
            {
                return this._bebida;
            }
        }

        /*
         Mayor: Clase pública que hereda de Comensal. 
         Operadores: 
         • Dos Mayores serán iguales si comparten nombre y apellido.  
         Contendrá el enumerado eBebidas(Agua,  Cerveza, Vino, Gaseosa)
         Operadores:    
*/      public Mayor(string nombre, string apellido, eBebidas bebida) : base(nombre,apellido)
        {
            this.Bebida = bebida;
        }
        public static explicit operator string(Mayor a)
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat("{0} {1}",a.Mostrar(),a.Bebida.ToString());
            return str.ToString();
        }
        public override string ToString()
        {
            return (string)this;
        }
        /* • Conversión explicita de Mayor a string, retornando todos sus datos.
            Sobreescribir:   • Método ToString() para que publique la información del Mayor.
                             • Método Equals para que reutilice ==. */
        public static bool operator==(Mayor m1, Mayor m2)
        {
            if (m1.Nombre == m1.Nombre && m1.Apellido == m2.Apellido && m1.Bebida == m2.Bebida)
                return true;
            return false;
        }
        public static bool operator !=(Mayor m1, Mayor m2)
        {
            return !(m1 == m2);
        }
        public override bool Equals(object obj)
        {
            if (obj is Mayor)
                if ((Mayor)obj == this)
                    return true;
            return false;
        }

    }
}
