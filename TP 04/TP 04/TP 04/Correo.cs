using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Entidades
{
    public class Correo : IMostrar<List<Paquete>>
    {
        List<Thread> mockPaquetes;
        List<Paquete> paquetes;

        public List<Paquete> Paquetes
        {
            get
            {
                return this.paquetes;
            }
            set
            {
                this.paquetes = value;
            }
        }

        public Correo()
        {
            this.mockPaquetes = new List<Thread>();
            this.Paquetes = new List<Paquete>();
        }

        public void FinEntregas()
        {
            foreach(Thread t in mockPaquetes)
            {
                if (t.IsAlive)
                    t.Abort();
            }
        }

        public string MostrarDatos(IMostrar<List<Paquete>> elementos)
        {
            StringBuilder str = new StringBuilder();

            List<Paquete> provisorio = (List<Paquete>)((Correo)elementos).Paquetes;

            foreach (Paquete p in provisorio)
            {
                str.AppendLine(string.Format("{0} para {1} ({2})", p.TrackingID, p.DireccionEntrega, p.Estado.ToString()));
            }
            return str.ToString();
        }
        public static Correo operator +(Correo c, Paquete p)
        {
            foreach (Paquete aux in c.Paquetes)
            {
                if (aux == p)
                    throw new TrackingIdRepetidoException("Paquete repetido!");
            }
            c.Paquetes.Add(p);
            Thread thread = new Thread(p.MockCicloDeVida);
            c.mockPaquetes.Add(thread);
            thread.Start();
            return c;
        }
    }
}
