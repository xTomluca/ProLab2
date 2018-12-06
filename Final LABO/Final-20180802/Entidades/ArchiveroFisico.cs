using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //Deberá heredar de Almacenador e implementar IAlmacenable.
    //Crear un constructor que reciba y asigne el/los atributos de la misma.
    //El método MostrarArchivos lanzará una excepción del tipo NotImplementedException.
    //El método Guardar deberá guardar un objeto de tipo archivo en un archivo de texto en la ubicación definida en el atributo pathArchivos.
    //El método Leer recibirá el nombre de un archivo y deberá retornar su contenido.
    //Tanto en Leer como en Guardar capturar y relanzar las excepciones.
    public class ArchiveroFisico : Almacenador,IAlmacenable<Archivo,string>
    {
        private string pathArchivos;
        public string PathArchivos
        {
            set
            {
                this.pathArchivos = value;
            }
            get
            {
                return this.pathArchivos;
            }
        }

        public ArchiveroFisico(string pathArchivos, int capacidad) : base(capacidad)
        {
            this.PathArchivos = pathArchivos;
        }

        public bool Guardar(Archivo a)
        {
            StreamWriter writer=null;
            try
            {
                writer = new StreamWriter(string.Format("{0}\\{1}",Environment.GetFolderPath(Environment.SpecialFolder.Desktop),this.PathArchivos), true);
                writer.WriteLine(a.ToString());
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                if (!(writer is null))
                    writer.Close();
            }
            return true;
        }
        public string Leer(string path)
        {
            StreamReader reader = null;
            string leido;
            try
            {
                reader = new StreamReader(string.Format("{0}\\{1}", Environment.GetFolderPath(Environment.SpecialFolder.Desktop), path));
                leido = reader.ReadToEnd();
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
            return leido;
        }
        public override void MostrarArchivo()
        {
            throw new NotImplementedException();
        }
    }
}
