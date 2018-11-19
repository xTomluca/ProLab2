using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TP_04
{
    public class Paquete : IMostrar<Paquete>
    {
        public delegate void DelegatoEstado(Object obj, EventArgs args); 
        string direccionEntrega;
        EEstado estado;
        string trackingID;
        public event DelegatoEstado InformaEstado;

        public enum EEstado
        {
            Ingresado,
            EnViaje,
            Entregado
        }

        public string DireccionEntrega
        {
            get
            {
                return this.direccionEntrega;
            }
            set
            {
                this.direccionEntrega = value;
            }
        }

        public string TrackingID
        {
            get
            {
                return this.trackingID;
            }
            set
            {
                this.trackingID = value;
            }
        }

        public EEstado Estado
        {
            get
            {
                return this.estado;
            }
            set
            {
                this.estado = value;
            }
        }

        public void MockCicloDeVida()
        {
            while (this.Estado != EEstado.Entregado)
            {
                Thread.Sleep(240);
                InformaEstado.Invoke(this,null);
                this.Estado++;
            }
            if(this.Estado==EEstado.Entregado)
            {
                try
                {
                    PaqueteDAO.Insertar(this);
                }
                catch(Exception e)
                {
                    throw e;
                }
            }
        }

        public string MostrarDatos(IMostrar<Paquete> elemento)
        {
            Paquete p = (Paquete)elemento;
            return string.Format("{0} para {1}", p.TrackingID, p.DireccionEntrega);
        }

        public static bool operator !=(Paquete p1, Paquete p2)
        {
            return !(p1 == p2);
        }

        public static bool operator ==(Paquete p1, Paquete p2)
        {
            if (p1.TrackingID == p2.TrackingID)
                return true;
            return false;
        }
        public Paquete(string direccionEntrega, string trackingID)
        {
            this.DireccionEntrega = direccionEntrega;
            this.TrackingID = trackingID;
        }
        public override string ToString()
        {
            return this.MostrarDatos(this);
        }

    }
}
