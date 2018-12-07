using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Entidades
{
    public class UsuarioDAO
    {
        private string cadenaDeConexion;
        private SqlConnection conexion;
        private SqlCommand comando;

        public bool Guardar(Usuario u)
        {
            try
            {
                this.conexion.Open();
                this.comando.Connection = conexion;
                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.CommandText = string.Format("INSERT INTO Usuarios(nombre,clave) VALUES('{0}','{1}')",u.Nombre,u.Clave);
                this.comando.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                if(!(this.conexion is null))
                    this.conexion.Close();
            }
            return true;
        }
        public Usuario Leer(string usuario, string clave)
        {
            SqlDataReader reader;
            try
            {
                this.conexion.Open();
                this.comando.Connection = conexion;
                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.CommandText = "SELECT * FROM Usuarios";
                reader = this.comando.ExecuteReader();
                while(reader.Read())
                {
                    if (reader["nombre"].ToString() == usuario && reader["clave"].ToString() == clave)
                        return new Usuario(reader["nombre"].ToString(), reader["clave"].ToString());
                }
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                if (!(this.conexion is null))
                    this.conexion.Close();
            }
            return null;
        }
        public UsuarioDAO()
        {
            this.cadenaDeConexion = "Data Source=.\\SQLEXPRESS; Initial Catalog = final-20180802; Integrated Security=true";
            this.comando = new SqlCommand();
            this.conexion = new SqlConnection(cadenaDeConexion);
        }
    }
}
