using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Ejercicio_31
{
    class PuestoAtencion
    {
        static int numeroActual;
        private Puesto puesto;

        int NumeroActual
        {
            get
            {
                numeroActual += 1; 
                return numeroActual;
            }
        }
        public bool Atender(Cliente clie)
        {
            Thread.Sleep(1000);
            return true;
        }
        private PuestoAtencion()
        {
           numeroActual = 0;
        }
        PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }
        public enum Puesto
        {
            CajaUno = 1, 
            CajaDos = 2
        }
    }
}
