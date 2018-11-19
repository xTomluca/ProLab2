using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace TP_04
{
    static class GuardarString
    {
        public static bool Guardar(this string texto, string archivo)
        {
            try
            {
                StreamWriter writer = new StreamWriter(archivo, true);
                writer.WriteLine(texto);
                writer.Close();
            }
            catch(Exception)
            {

            }
            return false;
        }
    }
}
