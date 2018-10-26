using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inteface
{
    public class GuardarTexto<T, V> : IGuardar<T, V>
    {
        /* b. El método Guardar simplemente retornará True.
        c. El método Leer retornará la leyenda "Texto Leído" para GuardarTexto y "Objeto Leído"
        para Serializar. Se deberá utilizar Convert.ChangeType (investigar).*/

        bool IGuardar<T, V>.Guardar(T obj)
        {
            return true;
        }

        V IGuardar<T, V>.leer()
        {
            string texto = "Texto Leido";
            
            V retorno = (V)Convert.ChangeType(texto, typeof(V));
            return retorno;
        }
    }
}
