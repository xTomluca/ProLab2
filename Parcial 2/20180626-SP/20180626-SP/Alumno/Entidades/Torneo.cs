using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
namespace Entidades
{
    public class Torneo : IEntradaSalida<bool>
    {
        public const int MAX_EQUIPOS_GRUPO = 4;
        private List<Grupo> grupos;
        private string nombre;
        public List<Grupo> Grupos
        {
            get
            {
                return this.grupos;
            }
            set
            {
                this.grupos = value;
            }
        }
        public string Nombre
        {
            set
            {
                this.nombre = value;
            }
            get
            {
                return this.nombre;
            }
        }
        public Torneo()
        { }
        public Torneo(string nombre)
        {
            this.grupos = new List<Grupo>();
            this.nombre = nombre;
        }
        public bool Guardar()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Grupo));
            XmlTextWriter writer;
            try
            {
                foreach(Grupo grupo in this.Grupos)
                {
                    writer = new XmlTextWriter(string.Format("{0}.\\grupo-{1}.xml", Environment.GetFolderPath(Environment.SpecialFolder.Desktop).ToString(),grupo.Grupos.ToString()),Encoding.UTF8);
                    serializer.Serialize(writer,grupo);
                    writer.Close();
                }
                return true;
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        public bool Leer()
        {
            List<string> letras = new List<string>();
            letras.Add("A");
            letras.Add("B");
            letras.Add("C");
            letras.Add("D");
            XmlTextReader xmlTextReader = null;
            XmlSerializer xmlSerializer=null;

            foreach(Grupo g in this.Grupos)
            {
                if(letras.Contains(g.Grupos.ToString()))
                    letras.Remove(g.Grupos.ToString());
            }

            foreach(string letra in letras)
            {
                if(File.Exists(string.Format("{0}\\grupo-{1}.xml", Environment.GetFolderPath(Environment.SpecialFolder.Desktop).ToString(), letra)))
                 try
                 {
                        xmlSerializer = new XmlSerializer(typeof(Grupo));
                        xmlTextReader = new XmlTextReader(string.Format("{0}\\grupo-{1}.xml", Environment.GetFolderPath(Environment.SpecialFolder.Desktop).ToString(), letra));
                        this.grupos.Add((Grupo)xmlSerializer.Deserialize(xmlTextReader));
                 }
                 catch(Exception)
                 {
                        continue;
                 }
                finally
                {
                    if (!(xmlTextReader is null))
                       xmlTextReader.Close();
                 }
            }
            return true;
        }
        public void SimularGrupos()
        {
            foreach(Grupo grupo in this.Grupos)
            {
                grupo.Simular();
            }
        }
    }
}
