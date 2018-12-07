using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    [Serializable]
    [XmlInclude(typeof(PasajeAvion))]
    [XmlInclude(typeof(PasajeMicro))]
    public abstract class Pasaje
    {
        private Pasajero pasajero;
        private string origen;
        private string destino;
        private float precio;
        private DateTime fecha;

        public Pasaje(string origen, string destino, Pasajero pasajero, float precio, DateTime fecha)
        {
            this.origen = origen;
            this.destino = destino;
            this.pasajero = pasajero;
            this.precio = precio;
            this.fecha = fecha;
        }

        public Pasaje()
        { }

        public static bool operator ==(Pasaje p1, Pasaje p2)
        {
            return (p1.Origen == p2.Origen && p1.Destino == p2.Destino && p1.Pasajero.Dni == p2.Pasajero.Dni && p1.Fecha == p2.Fecha);
        }

        public static bool operator !=(Pasaje p1, Pasaje p2)
        {
            return !(p1 == p2);
        }

        public abstract float PrecioFinal
        {
            get;
        }


        public Pasajero Pasajero { get => pasajero; set => pasajero = value; }
        public string Origen { get => origen; set => origen = value; }
        public string Destino { get => destino; set => destino = value; }
        public float Precio { get => precio; set => precio = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }

        public virtual string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("Origen: {0}\n", this.Origen);
            stringBuilder.AppendFormat("Destino: {0}\n", this.Destino);
            stringBuilder.AppendFormat("Fecha: {0}\n", this.Fecha.ToString());
            stringBuilder.AppendFormat("Pasajero: {0}\n", this.Pasajero.ToString());
            stringBuilder.AppendFormat("Precio: {0}\n", this.Precio);
            stringBuilder.AppendFormat("PrecioFinal: {0}\n", this.PrecioFinal);

            return stringBuilder.ToString();
        }
    }
}
