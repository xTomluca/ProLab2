using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Entidades
{
    class GrupoDAO
    {
        public SqlConnection sqlConnection;
        public SqlCommand command;

        public GrupoDAO()
        {
            sqlConnection = new SqlConnection("Data Source = .\\SQLEXPRESS; Initial Catalog = mundial-sp-2018; Integrated Security = True");
            command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = sqlConnection;
        }

    }
}
