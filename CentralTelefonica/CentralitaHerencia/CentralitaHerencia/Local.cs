using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Local : Llamada
    {
        protected float costo;
        public float CostoLlamada
        {
            get
            {
                return costo;
            }
        }
        private float CalcularCosto()
        {
            return CostoLlamada * Duracion;
        }
        public Local(Llamada llamada, float costo) : base(llamada.Duracion, llamada.NroDistinto, llamada.NroOrigen)
        {
            this.costo = costo;
        }
        public Local(string origen,float duracion, string destino, float costo) : this(new Llamada(duracion,destino,origen),costo)
        {

        }
        public string Mostrar()
        {
            string aux = this.Mostrar();
            StringBuilder auxBuilder = new StringBuilder();
            auxBuilder.AppendFormat("{0} Costro: {1}", aux, this.CostoLlamada);
            return auxBuilder.ToString();
        }

    }
}
