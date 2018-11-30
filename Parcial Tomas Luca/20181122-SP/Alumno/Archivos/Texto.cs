using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;

namespace Archivos
{
    public class Texto : IArchivo<Queue<Patente>>
    {
        public void Guardar(string archivo, Queue<Patente> datos)
        {

        }
        public void Leer(string archivo, out Queue<Patente> datos)
        {
            datos = new Queue<Patente>();
        }
    }
}
