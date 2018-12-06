using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public class DiscoElectronico : Almacenador, IAlmacenable<Archivo,List<Archivo>>
    {
        public List<Archivo> archivosGuardados;

        public List<Archivo> ArchivosGuardados
        {
            set
            {
                this.archivosGuardados = value;
            }
            get
            {
                return this.archivosGuardados;
            }
        }
        private DiscoElectronico() : base(5)
        {
            this.ArchivosGuardados = new List<Archivo>();
        }
        public DiscoElectronico(int capacidad) : this()
        {
            this.Capacidad = capacidad;

            this.ArchivosGuardados = this.Leer("Archivo");
        }

        public bool Guardar(Archivo archivo)
        {
            string strConnection = "Data Source =.\\SQLEXPRESS; Initial Catalog= final-20180802; Integrated Security = True";
            SqlConnection connection = null;
            SqlCommand command = new SqlCommand();

            try
            {
                connection = new SqlConnection(strConnection);
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                connection.Open();
                command.CommandText = string.Format("INSERT INTO Archivo(nombre,contenido) VALUES('{0}','{1}')",archivo.Nombre,archivo.Contenido);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                if (!(connection is null))
                    connection.Close();
            }
            return true;
        }

        public List<Archivo> Leer(string tabla)
        {
            SqlConnection connection = null;
            SqlCommand sql = new SqlCommand();
            SqlDataReader reader;
            List<Archivo> archivos = new List<Archivo>();
            try
            {
                string strConnection = "Data Source= .\\SQLEXPRESS; Initial Catalog = final-20180802; Integrated Security = True";
                connection = new SqlConnection(strConnection);
                connection.Open();
                sql.Connection = connection;
                sql.CommandText = string.Format("Select * from {0}", tabla);
                reader = sql.ExecuteReader();
                while(reader.Read())
                {
                    if(this.Capacidad>0)
                        archivos = this + new Archivo(reader["nombre"].ToString(),reader["contenido"].ToString());
                    else
                        break;
                }

            }
            catch(Exception e)
            {
                if (!(connection is null))
                    connection.Close();
                throw e;
            }
            return archivos;
        }
        public override void MostrarArchivo()
        {
            foreach(Archivo a in this.archivosGuardados)
            {
                System.Threading.Thread.Sleep(1000);
                this.DispararEvento(a);
            }
        }

        public static List<Archivo> operator +(DiscoElectronico d,Archivo a)
        {
            if (d.Capacidad > 0)
            {
                d.archivosGuardados.Add(a);
                d.Capacidad--;
            }
            else
                throw new Exception("El disco está lleno!");
            return d.archivosGuardados;
        }
        //b.El método Guardar deberá insertar un archivo en la base de datos.
        //c.El método Leer recibirá el nombre de la tabla a consultar. 
        /////Deberá leer y retornar todos los archivos de la base de datos.
        //d.Tanto en Leer como en Guardar capturar y relanzar las excepciones.
        //e.El método MostrarArchivos por el momento sólo deberá recorrer la lista de archivos y por cada uno simular un retardo de 5 segundos.
        //f.Agregar un constructor en el cual se deberá 
        //cargar la lista a partir de los datos guardados en la base.
        //g.Sobrecargar el operador + para agregar un archivo a la lista siempre 
        ////y cuando no supere la capacidad, 
        ////caso contrario lanzará una excepción con el mensaje "El disco está lleno!".
    }
}
