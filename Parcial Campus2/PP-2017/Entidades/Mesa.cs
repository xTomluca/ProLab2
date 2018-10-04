using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Mesa
    {
        List<Comensal> comensales;
        static int capacidad;
        int _numero;
        public int Cantidad
        {
            get
            {
                return this.comensales.Count;
            }
        }
        public List<Comensal> Comensales
        {
            get
            {
                return this.comensales;
            }
        }
        public int Numero
        {
            set
            {
                this._numero = value;
            }
            get
            {
                return this._numero;
            }
        }
        static Mesa()
        {
            Mesa.capacidad = 12;
        }
        private Mesa()
        {
            this.comensales = new List<Comensal>();
        }
        public Mesa(int numero) : this()
        {
            this.Numero = numero;
        }
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            foreach(Comensal aux in this.Comensales)
            {
                if(aux is Mayor)
                {
                    str.AppendLine(((Mayor)aux).ToString());
                }
            }
            return str.ToString();
        }
        public static bool operator == (Mesa a, Mesa b)
        {
            if (a.Numero == b.Numero)
                return true;
            return false;
        }
        public static bool operator !=(Mesa a, Mesa b)
        {
            return !(a == b);
        }
        public static Mesa operator +(Mesa a, Menor b)
        {
            if(a.Cantidad < Mesa.capacidad)
            {
                foreach (Comensal aux in a.comensales)
                {
                    if (b.Equals(aux))
                        return a;
                }
                a.comensales.Add(b);
            }
            return a;
        }
        public static Mesa operator +(Mesa a, Mayor b)
        {
            if (a.Cantidad < Mesa.capacidad)
            {
                foreach (Comensal aux in a.comensales)
                {
                    if (b.Equals(aux))
                        return a;
                }
                a.comensales.Add(b);
            }
            return a;
        }
    }
}
