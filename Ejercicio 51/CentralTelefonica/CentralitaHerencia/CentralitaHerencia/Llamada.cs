using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public abstract class Llamada
    {
        protected float duracion;
        protected string nroDistinto;
        protected string nroOrigen;

        public float Duracion
        {
            get
            {
                return duracion;
            }
        }

        public string NroDistinto
        {

            get
            {
                return nroDistinto;
            }
        }

        public string NroOrigen
        {
            get
            {
                return nroOrigen;
            }
        }

        public abstract float CostoLlamada
        {
            get;
        }

        public Llamada(float duracion, string nroDistinto, string nroOrigen)
        {
            this.nroOrigen = nroOrigen;
            this.nroDistinto = nroDistinto;
            this.duracion = duracion;
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            if (llamada1.Duracion > llamada2.Duracion)
                return 1;
            else if(llamada1.Duracion < llamada2.Duracion)
                return -1;
            return 0;
        }
        protected virtual string Mostrar()
        {
            StringBuilder s = new StringBuilder();
            s.AppendFormat("Duracion : {0} Origen: {1} Destino: {2}", this.Duracion,this.NroOrigen,this.NroDistinto);
            return s.ToString();
        }
        public enum tipoLLamada
        {
            Local,
            Provincial,
            Todas
        }

        public static bool operator ==(Llamada l1,Llamada l2)
        {
            if(l1.Equals(l2) && l1.NroDistinto == l2.NroDistinto && l1.NroOrigen == l2.NroOrigen)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Llamada l1,Llamada l2)
        {
            return !(l1 == l2);
        }

    }
}
