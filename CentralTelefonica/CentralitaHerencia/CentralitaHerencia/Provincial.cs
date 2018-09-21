using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Provincial : Llamada
    {
        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }
        protected Franja franjaHoraria;

        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        private float CalcularCosto()
        {
            if (this.franjaHoraria == Franja.Franja_1)
                return this.duracion * 0.99F;
            if (this.franjaHoraria == Franja.Franja_2)
                return this.duracion * 1.25F;
            //if (this.franjaHoraria == Franja.Franja_3)
                return this.duracion * 0.66F;
        }
        public string Mostrar()
        {
            string aux = this.Mostrar();
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat("{0} {1} {2}", aux, CostoLlamada,franjaHoraria);
            return builder.ToString();
        }
        public Provincial(Franja miFranja, Llamada llamada) : base(llamada.Duracion, llamada.NroDistinto, llamada.NroOrigen)
        {
            this.franjaHoraria = miFranja;
        }
        public Provincial(string origen, Franja miFranja, float duracion, string destino) : this(miFranja, new Llamada(duracion, destino, origen))
        {

        }
    }
}
