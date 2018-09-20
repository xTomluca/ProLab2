using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ejercicio31
{
    public class puestoAtencion
    {
        private static int numeroActual;
        private Puesto puesto;

        public static int NumeroActual
            {
                get
                {
                    numeroActual += 1;
                    return numeroActual;
                }
            }

        public static bool atender(Cliente auxiliar)
        {
            Thread.Sleep(1000);           
            return true;
        }

        public puestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }

        public enum Puesto
        {
            CajaUno = 1, CajaDos
        }
    }
}
