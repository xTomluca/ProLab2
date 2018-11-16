using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Xml;
using System.Xml.Serialization;
namespace Entidades
{
    public class SerializerXML<T> : IArchivos<T>
    {
        bool IArchivos<T>.Guardar(string rutaArchivo, T objeto)
        {

            return true;
        }
        T IArchivos<T>.Leer(string rutaArchivo)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            XmlTextReader reader = new XmlTextReader(rutaArchivo);
            T retorno = (T)serializer.Deserialize(reader);
            reader.Close();

            return retorno;

        }
    }
}
