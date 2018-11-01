using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Ejercicio_57
{
    public class Persona
    {
        string nombre;
        string apellido;
        public string Nombre { get { return this.nombre; } set { this.nombre = value; } }
        public string Apellido { get { return this.apellido; } set { this.apellido = value; } }
        public Persona() { }
        public Persona(string nombre, string apellido) : this()
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
        public static void Guardar(Persona persona)
        {
            XmlTextWriter writer;
            XmlSerializer serializer;
            writer = new XmlTextWriter("ArchivoXml.xml",Encoding.UTF8);
            serializer = new XmlSerializer(typeof(Persona));
            serializer.Serialize(writer, persona);
            writer.Close();
        }
        public static Persona Leer()
        {
            XmlTextReader reader;
            XmlSerializer serializer = new XmlSerializer(typeof(Persona));
            reader = new XmlTextReader("ArchivoXml.xml");
            Persona aux;
            aux = (Persona)serializer.Deserialize(reader);
            return aux;
        }
        public override string ToString()
        {
            Persona a = Persona.Leer();
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("Nombre : {0} {1}",a.Apellido, a.nombre);
            return stringBuilder.ToString();
        }
    }
}
