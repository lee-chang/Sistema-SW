using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Agregando las Librerias
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Net.Sockets;
using System.Windows;
using AccesoDatos;

namespace Dominio
{
    internal class DCotizar
    {

        ConnectionToSql conn = new ConnectionToSql();

        SqlConnection conexion;
        SqlCommand cmd;

        public DataTable dt;
        public SqlDataAdapter da;

        //METODO INSERTAR COTIZACION
    }

}
