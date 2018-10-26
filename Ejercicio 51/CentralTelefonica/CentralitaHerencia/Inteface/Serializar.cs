using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inteface
{
    public class Serializar<S, V> : IGuardar<S, V>
    {

        /* b. El método Guardar simplemente retornará True.
        c. El método Leer retornará la leyenda "Texto Leído" para GuardarTexto y "Objeto Leído"
        para Serializar. Se deberá utilizar Convert.ChangeType (investigar).*/

        bool IGuardar<S, V>.Guardar(S obj)
        {
            return true;
        }

        V IGuardar<S, V>.leer()
        {
            string texto = "objeto Leido";

            V retorno = (V)Convert.ChangeType(texto, typeof(V));
            return retorno;
        }
    }
}
