using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada
    {
        protected float costo;
        public override float CostoLlamada
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
        public Local(string origen,float duracion, string destino, float costo) : base(duracion,destino,origen)
        {
            this.costo = costo;
        }
        protected override string Mostrar()
        {
            StringBuilder auxBuilder = new StringBuilder();
            auxBuilder.AppendFormat("{0} Costo Llamada: {1}", base.Mostrar(), this.CostoLlamada);
            return auxBuilder.ToString();
        }
        public override bool Equals(object obj)
        {
            if (obj.GetType() == typeof(Local))
                return true;
            return false;
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
