using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Agregando las Librerias
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace Dominio
{

    class DDistrito
    {
        string cadenaConexion = "server=DESKTOP-25FAVIP\\SQLEXPRESS ; database=SWZICCA ; INTEGRATED SECURITY = true";

        SqlConnection conexion;
        SqlCommand cmd;

        public DataTable dt;
        public SqlDataAdapter da;


        //metodo para listar provincia
        public DataTable listaDistrito(string provid)
        {
            dt = new DataTable();
            conexion = new SqlConnection(cadenaConexion);
            try
            {
                conexion.Open();
                cmd = new SqlCommand("SP_BUSCADISTRITO", conexion);
                cmd.Parameters.AddWithValue("@PPROVINCIAID", provid);
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
