using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace Archivos
{
    public class Sql:IArchivo<Queue<Patente>>
    {
        SqlCommand comando;
        SqlConnection conexion;

        public void Guardar(string tabla, Queue<Patente> datos)
        {

        }

        public void Leer(string tabla, out Queue<Patente> datos)
        {
            datos = new Queue<Patente>();
        }

        public Sql()
        {
            string connection = "Data Source= .\\SQLEXPRESS; Initial Catalog = "
        }
    }
}
