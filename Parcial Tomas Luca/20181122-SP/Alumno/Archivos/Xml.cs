using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Archivos
{
    public class Xml<T> : IArchivo<T>
    {
        public void Leer(string tabla, out T datos)
        {
            
        }
        public void Guardar(string archivo, T datos)
        {

        }
    }
}
