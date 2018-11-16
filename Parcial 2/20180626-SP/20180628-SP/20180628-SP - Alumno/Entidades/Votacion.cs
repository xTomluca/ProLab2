using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace Entidades
{

    public class Votacion
    {
    // DEVUELVE UN TIPO DE DATO Y RECIBE PARAMETROS COMO EL EL MANEJADOR
    public delegate void Voto(string senador, Votacion.EVoto voto);
        public enum EVoto { Afirmativo, Negativo, Abstencion, Esperando }

        private string nombreLey;
        private Dictionary<string, EVoto> senadores;
        public event Voto eventoVotoEfectuado;
        private short contadorAfirmativo;
        private short contadorNegativo;
        private short contadorAbstencion;

        public string NombreLey
        {
            get
            {
                return this.nombreLey;
            }
            set
            {
                this.nombreLey = value;
            }
        }
        public Dictionary<string,EVoto> Senadores
        {
            get
            {
                return this.senadores;
            }
        }

        public Voto EventoVotoEfectuado
        {
            get
            {
                return this.EventoVotoEfectuado;
            }
            set
            {
                this.eventoVotoEfectuado = value;
            }
        }

        public short ContadorAfirmativo
        {
            get
            {
                return this.contadorAfirmativo;
            }
            set
            {
                this.contadorAfirmativo = value;
            }
        }

        public short ContadorNegativo
        {
            get
            {
                return this.contadorNegativo;
            }
            set
            {
                this.contadorNegativo = value;
            }
        }
        public short ContadorAbstencion
        {
            get
            {
                return this.contadorAbstencion;
            }
            set
            {
                this.contadorAbstencion = value;
            }
        }
        public Votacion()
        {

        }

        public Votacion(string nombreLey, Dictionary<string, EVoto> senadores)
        {
            this.nombreLey = nombreLey;
            this.senadores = senadores;
        }

        public static void Serializar(Votacion v)
        {

            XmlSerializer serializer = new XmlSerializer(typeof(Votacion));
            XmlTextWriter writer = new XmlTextWriter("Votacion.txt",Encoding.UTF8);
            serializer.Serialize(writer, v);
            writer.Close();

        }



        public void Simular()
        {
            // Reseteo contadores
            this.contadorAbstencion = 0;
            this.contadorAfirmativo = 0;
            this.contadorNegativo = 0;
            // Itero todos los Senadores
            for (int index = 0; index < this.senadores.Count; index++)
            {
                // Duermo el hilo
                System.Threading.Thread.Sleep(2134);

                // Leo el senador actual
                KeyValuePair<string, EVoto> k = this.senadores.ElementAt(index);
                // Generador de número aleatorio
                Random r = new Random(k.Key.ToString().Length + DateTime.Now.Millisecond);
                // Modifico el voto de forma aleatoria
                this.senadores[k.Key] = (EVoto)r.Next(0, 3);

                // Invocar Evento
                EventoVotoEfectuado.Invoke(k.Key,k.Value);
                // Incrementar contadores
                if (k.Value == EVoto.Abstencion)
                    contadorAbstencion++;
                else if (k.Value == EVoto.Afirmativo)
                    this.contadorAfirmativo++;
                else if (k.Value == EVoto.Negativo)
                    contadorNegativo++;
            }
        }
    }
}
