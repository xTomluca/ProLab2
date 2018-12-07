using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using Entidades;
namespace Archivos
{
    public class Xml<T> : IArchivo<T>
    {
        public void Guardar(string destino, T dato)
        {
            XmlTextWriter xmlTextWriter = null;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            try
            {
                xmlTextWriter = new XmlTextWriter(destino, Encoding.UTF8);
                xmlSerializer.Serialize(xmlTextWriter, dato);
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                if (!(xmlTextWriter is null))
                    xmlTextWriter.Close();
            }
        }

        public T Leer(string origen)
        {
            XmlTextReader reader = null;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            T t;
            try
            {
                reader = new XmlTextReader(origen);
                t = (T)xmlSerializer.Deserialize(reader);
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                if (!(reader is null))
                    reader.Close();
            }
            return t;
        }
    }
}
