using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{ 
    public enum Servicio { Comun, SemiCama, Ejecutivo }

    public class PasajeAvion : Pasaje
    {
        int cantidadEscalas;

        public override float PrecioFinal
        {
            get
            {
                if (cantidadEscalas == 1)
                    return (this.Precio - (this.Precio * 0.10F));
                else if (cantidadEscalas == 2)
                    return (this.Precio - (this.Precio * 0.20F));
                else if (cantidadEscalas > 2)
                    return (this.Precio - (this.Precio * 0.30F));
                else
                    return this.Precio;
            }
        }

        public override string  Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat(base.Mostrar());
            stringBuilder.AppendFormat("Cantidad escalas: {0}\n", this.cantidadEscalas);
            return stringBuilder.ToString();
        }

        public PasajeAvion() : base()
        {
        }

        public PasajeAvion(string origen,string destino, Pasajero pasajero, float precio,DateTime fecha, int cantidadEscalas) : base(origen,destino,pasajero,precio,fecha)
        {
            this.cantidadEscalas = cantidadEscalas;
        }
    }
}
