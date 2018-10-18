using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        List<Llamada> listaDeLlamadas;
        string razonSocial;
        public float GananciasPorLocal
        {
            get
            {
                return this.CalcularGanancia(Llamada.tipoLLamada.Local);
            }
        }
        public float GananciasPorProvincial
        {
            get
            {
                return this.CalcularGanancia(Llamada.tipoLLamada.Provincial);
            }
        }
        public float GananciasPorTotal
        {
            get
            {
                return this.CalcularGanancia(Llamada.tipoLLamada.Todas);
            }
        }
        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }
        private float CalcularGanancia(Llamada.tipoLLamada tipo)
        {
            float retornoLocal = 0;
            float retornoProvincial = 0;
            float retornoTotal = 0;

            for(int i=0;i<Llamadas.Count;i++)
            {
                if ((tipo == Local.tipoLLamada.Local || tipo == Local.tipoLLamada.Todas) && Llamadas[i] is Local)
                {
                    Local aux = (Local)Llamadas[i];
                    retornoLocal += aux.CostoLlamada;
                    retornoTotal += aux.CostoLlamada;
                }
                if ((tipo == Local.tipoLLamada.Provincial || tipo == Local.tipoLLamada.Todas) && Llamadas[i] is Provincial)
                {
                    Provincial aux = (Provincial)Llamadas[i];
                    retornoProvincial += aux.CostoLlamada;
                    retornoTotal += aux.CostoLlamada;
                }
            }

            if (tipo == Llamada.tipoLLamada.Local)
                return retornoLocal;
            else if (tipo == Llamada.tipoLLamada.Provincial)
                return retornoProvincial;
            else
                return retornoTotal;
        }
        public Centralita()
        {
            listaDeLlamadas = new List<Llamada>();
        }
        public Centralita(string razonSocial) : this()
        {
            this.razonSocial = razonSocial;
        }
        public string Mostrar()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat("Razon Social : {0} Ganancia Total: {1}  Ganancia Local : {2} Ganancia Provincia: {3}\n", this.razonSocial, GananciasPorTotal, GananciasPorLocal, GananciasPorProvincial);
            foreach(Llamada llamada in Llamadas)
            {
                builder.AppendLine(llamada.ToString());
                /*if(llamada is Local)
                {
                    Local aux = (Local)llamada;
                    builder.AppendLine(aux.Mostrar());
                }
                else if(llamada is Provincial)
                {
                    Provincial aux = (Provincial)llamada;
                    builder.AppendLine(aux.Mostrar());
                }*/
            }
            return builder.ToString();
        }
        public void OrdenarLlamadas()
        {
            this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            this.listaDeLlamadas.Add(nuevaLlamada);
        }
        public static bool operator ==(Centralita c, Llamada llamada)
        {
            foreach(Llamada aux in c.listaDeLlamadas)
            {
                if (aux == llamada)
                    return true;
            }
            return false;
        }
        public static bool operator!=(Centralita c, Llamada llamada)
        {
            return !(c == llamada);
        }
        public static Centralita operator +(Centralita c, Llamada nuevaLlamada)
        {
            /*if (c == nuevaLlamada)
            {
                if(nuevaLlamada is Local)
                    throw new CentralitaExcepcion("ERROR","Local", "Agregar");
                if (nuevaLlamada is Provincial)
                    throw new CentralitaExcepcion("ERROR", "Provincia", "Agregar");

            }
            c.AgregarLlamada(nuevaLlamada);
            return c;*/
            if (c == nuevaLlamada)
            {
                if (nuevaLlamada is Local)
                    throw new CentralitaExcepcion("ERROR", "Local", "Agregar");
                if (nuevaLlamada is Provincial)
                    throw new CentralitaExcepcion("ERROR", "Provincia", "Agregar");
            }
            c.AgregarLlamada(nuevaLlamada);
            return c;
        }
    }
}
