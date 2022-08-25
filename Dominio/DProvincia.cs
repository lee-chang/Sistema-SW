using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Agregando las Librerias
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using AccesoDatos;

namespace Dominio
{
    class DProvincia
    {

        ConnectionToSql conn = new ConnectionToSql();

        SqlConnection conexion;
        SqlCommand cmd;

        public DataTable dt;
        public SqlDataAdapter da;


        //metodo para listar region
        public DataTable listaProvincia(string depid)
        {
            dt = new DataTable();
            conexion = new SqlConnection(conn.CadenaConexion);
            try
            {
                conexion.Open();
                cmd = new SqlCommand("SP_BUSCAPROVINCIA", conexion);
                cmd.Parameters.AddWithValue("@PDEPARTAMENTOID", depid);
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
