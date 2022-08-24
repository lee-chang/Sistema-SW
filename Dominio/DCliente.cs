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


namespace Dominio
{
     class DCliente
    {

        string cadenaConexion = "server=DESKTOP-25FAVIP\\SQLEXPRESS;database=SWZICCA;INTEGRATED SECURITY=true;";

        SqlConnection conexion;
        SqlCommand cmd;

        public DataTable dt;
        public SqlDataAdapter da;


        //METODO INSERTAR CLIENTE
        public int registrarCliente(ECliente ecli)
        {
            int insertado = 0;
            conexion = new SqlConnection(cadenaConexion);
            try
            {
                // abrir conexion
                conexion.Open();
                //pasar nombre del procedimiento
                cmd = new SqlCommand("SP_INSERTACLIENTE", conexion);
                cmd.Parameters.AddWithValue("@PCLIENTEID",ecli.FidCliente);
                cmd.Parameters.AddWithValue("@PNOMBRE", ecli.FnombCliente);
                cmd.Parameters.AddWithValue("@PAPELLIDO", ecli.FapelCliente);
                cmd.Parameters.AddWithValue("@PDIRECCION", ecli.FdirCliente);
                cmd.Parameters.AddWithValue("@PEMAIL", ecli.FemailCLiente);
                cmd.Parameters.AddWithValue("@PNROIDENTIDADID",ecli.FnroidenCliente);
                cmd.Parameters.AddWithValue("@PTELEFONO", ecli.FtelfCliente);
                cmd.Parameters.AddWithValue("@PDISTRITOID", ecli.Disid);
               // cmd.Parameters.AddWithValue("@PPROVINCIAID",);
               // cmd.Parameters.AddWithValue("@PDEPARTAMENTOID",);
               cmd.Parameters.AddWithValue("@PTIPOIDENTIDADID",ecli.FtipoidenId);
               
                //reconoce los datos de envio al procedimeinto almacenado
                cmd.CommandType = CommandType.StoredProcedure;
                //ejecutar el procedimiento
                insertado = cmd.ExecuteNonQuery();
                return insertado;
            }
            catch (SqlException ex)
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
