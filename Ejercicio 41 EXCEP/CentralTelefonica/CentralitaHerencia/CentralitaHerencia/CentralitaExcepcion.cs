using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class CentralitaExcepcion : Exception
    {
        string nombreClase;
        string nombreMetodo;
        public string NombreClase
        {
            get
            {
                return this.nombreClase;
            }
        }
        public string NombreMetodo
        {
            get
            {
                return this.nombreMetodo;
            }
        }
        public CentralitaExcepcion(string mensaje, string clase, string metodo)
        {

        }
        public CentralitaExcepcion(string mensaje, string clase, string metodo,Exception innerException)
        {

        }
    }
}
