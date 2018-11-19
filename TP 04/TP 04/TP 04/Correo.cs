using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace TP_04
{
    public class Correo
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

        }

        public void FinEntregas()
        {

        }

        public string MostrarDatos(IMostrar<List<Paquete>> elementos)
        {
            return "";
        }
        public static Correo operator +(Correo c, Paquete p)
        {
            return new Correo();
        }
    }
}
