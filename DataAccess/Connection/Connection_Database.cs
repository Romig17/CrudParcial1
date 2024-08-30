using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess.Connection
{
    //Esta es la cadena de conexion
    public class Connection_Database
    {
        private SqlConnection c = new SqlConnection("Data Source=CC1PC15-16;Initial Catalog=CRUD_N_CAPAS;Integrated Security=True;");
        
        public SqlConnection OpenConnection() //Abre la cadena de conexion
        {
            if (c.State == ConnectionState.Closed) c.Open();
            return c;
        }

        public SqlConnection CloseConnection() //Cierra la cadena de conexion
        {
            if (c.State == ConnectionState.Open) c.Close();
            return c;
        }
    }
}
