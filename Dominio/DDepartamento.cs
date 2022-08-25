using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Agregando las Librerias
using System.Data;
using System.Data.SqlClient;
using AccesoDatos;

namespace Dominio
{
    class DDepartamento
    {

        ConnectionToSql conn = new ConnectionToSql();

        SqlConnection conexion;
        SqlCommand cmd;

        public DataTable dt;
        public SqlDataAdapter da;


        //metodo para listar pais
        public DataTable listaDepartamento()
        {
            dt = new DataTable();
            conexion = new SqlConnection(conn.CadenaConexion);
            try
            {
                conexion.Open();
                cmd = new SqlCommand("SP_BUSCADEPARTAMENTO", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                //enviado la consulta a sqldataadapter
                da = new SqlDataAdapter(cmd);
                //llenar datos al dataTable
                da.Fill(dt);

                return dt;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                conexion.Close();
            }

        }

    }
}
