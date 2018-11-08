using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Ejercicio_60
{
    public class Connection
    {
        SqlConnection sqlConnection;
        SqlCommand command;
        public SqlConnection Conexion 
        {
            get
            {
                return this.sqlConnection;
            }
        }
        public SqlCommand Comando
        {
            get
            {
                return this.command;
            }
        }
        public Connection(string comando)
        {
            this.sqlConnection = new SqlConnection("DataSource=LAB3PC25;Initial Catalog = AdventureWorks2012; Integrated Security = True");
            this.Conexion.Open();
            this.command = new SqlCommand();
            this.command.CommandType = System.Data.CommandType.Text;
            this.command.Connection = this.Conexion;
        }
        public void Insert(string tabla, string columna,string valor)
        {
            this.Comando.CommandText = string.Format("INSERT INTO {0}({1})VALUES('{2}')",tabla,columna,valor);
            this.Comando.ExecuteNonQuery();
            this.Conexion.Close();
        }
        public void 


    }
}
