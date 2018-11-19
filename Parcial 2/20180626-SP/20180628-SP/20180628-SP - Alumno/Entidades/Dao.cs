using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Entidades
{
    public class Dao : IArchivos<Votacion>
    {
        public Votacion Leer(string rutaArchivo)
        {
            throw new NotImplementedException();
        }
        public bool Guardar(string rutaArchivo, Votacion obj)
        {
            SqlConnection sql = new SqlConnection();
            SqlCommand command = new SqlCommand();
            try
            {
                sql.ConnectionString = rutaArchivo;
                sql.Open();
                command.Connection = sql;
                command.CommandType = CommandType.Text;
                string nombre = "Tomas Luca Suarez";
                command.CommandText = string.Format("INSERT INTO Votaciones (abstenciones,afirmativos,negativos,nombreLey,nombreAlumno) VALUES('{0}','{1}','{2}','{3}','{4}')", obj.ContadorAbstencion, obj.ContadorAfirmativo, obj.ContadorNegativo, obj.NombreLey, nombre);
                command.ExecuteNonQuery();
                sql.Close();
            }
            
            catch (Exception e)
            {
                throw e;
            }
            return true;
        }
    }
}
