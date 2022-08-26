using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AccesoDatos
{
    public class ConnectionToSql
    {
        private readonly string connectionString;

        private String cadenaConexion;
        public ConnectionToSql()
        {
            connectionString = "Server=DESKTOP-25FAVIP\\SQLEXPRESS;Database=swzicca;Integrated Security=true;";
            cadenaConexion = connectionString;
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public String CadenaConexion
        { 
            get { return this.cadenaConexion; }
        }

    }
}
