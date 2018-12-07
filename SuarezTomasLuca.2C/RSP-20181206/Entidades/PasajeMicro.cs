using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{

    public class PasajeMicro : Pasaje
    {
        Servicio tipoServicio;

        public override float PrecioFinal
        {
            get
            {
                if (this.tipoServicio == Servicio.SemiCama)
                    return (this.Precio + (this.Precio * 0.10F));
                else if (this.tipoServicio == Servicio.Ejecutivo)
                    return (this.Precio + (this.Precio * 0.20F));
                else
                    return this.Precio;
            }
        }

        public override string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat(base.Mostrar());
            stringBuilder.AppendFormat("Tipo de servicio : {0}\n", this.tipoServicio);
            return stringBuilder.ToString();
        }

        public PasajeMicro()
        {

        }

        public PasajeMicro(string origen, string destino, Pasajero pasajero, float precio, DateTime fecha,Servicio tipoServicio) : base(origen,destino,pasajero,precio,fecha)
        {
            this.tipoServicio = tipoServicio;
        }
    }
}
