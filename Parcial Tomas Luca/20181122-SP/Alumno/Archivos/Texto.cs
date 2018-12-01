using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entidades;

namespace Archivos
{
    public class Texto : IArchivo<Queue<Patente>>
    {
        public void Guardar(string archivo, Queue<Patente> datos)
        {
            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(archivo);
                foreach (Patente p in datos)
                {
                    writer.WriteLine(p.CodigoPatente);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if(!(writer is null))
                    writer.Close();
            }
        }
        public void Leer(string archivo, out Queue<Patente> datos)
        {
            datos = new Queue<Patente>();
            string a;
            StreamReader reader = null;
            try
            {
                reader = new StreamReader(string.Format("{0}\\{1}", Environment.GetFolderPath(Environment.SpecialFolder.Desktop), archivo));
                while (!reader.EndOfStream)
                {
                    Patente p = PatenteStringExtension.ValidarPatente(reader.ReadLine());
                    datos.Enqueue(p);
                }
            }
            catch(PatenteInvalidaException e)
            {
                
            }
            finally
            {
                if (!(reader is null))
                {
                    reader.Close();
                }
            }
        }
    }
}
