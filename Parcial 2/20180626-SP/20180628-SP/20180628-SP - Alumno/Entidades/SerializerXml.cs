using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Xml;
using System.Xml.Serialization;
using Excepciones;

namespace Entidades
{
    public class SerializerXML<T> : IArchivos<T>
    {
        public bool Guardar(string rutaArchivo, T objeto)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                XmlTextWriter writer = new XmlTextWriter(rutaArchivo, Encoding.UTF8);
                serializer.Serialize(writer, objeto);
            }
            catch(Exception e)
            {
                throw new ErrorArchivoException(e.Message);
            }

            return true;
        }
        public T Leer(string rutaArchivo)
        {
            T retorno;
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                XmlTextReader reader = new XmlTextReader(rutaArchivo);
                retorno = (T)serializer.Deserialize(reader);
                reader.Close();
            }
            catch(Exception e)
            {
                throw new ErrorArchivoException(e.Message);
            }

            return retorno;

        }
    }
}
