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
                cmd.Parameters.AddWithValue("@PCLIENTEID", ecli.FidCliente);
                cmd.Parameters.AddWithValue("@PNOMBRE", ecli.FnombCliente);
                cmd.Parameters.AddWithValue("@PAPELLIDO", ecli.FapelCliente);
                cmd.Parameters.AddWithValue("@PDIRECCION", ecli.FdirCliente);
                cmd.Parameters.AddWithValue("@PEMAIL", ecli.FemailCLiente);
                cmd.Parameters.AddWithValue("@PNROIDENTIDADID", ecli.FnroidenCliente);
                cmd.Parameters.AddWithValue("@PTELEFONO", ecli.FtelfCliente);
                cmd.Parameters.AddWithValue("@PDISTRITOID", ecli.Disid);
                cmd.Parameters.AddWithValue("@PPROVINCIAID", ecli.Provid);
                cmd.Parameters.AddWithValue("@PDEPARTAMENTOID", ecli.Depid);
                cmd.Parameters.AddWithValue("@PTIPOIDENTIDADID", ecli.FtipoidenId);

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

        //METODO ACTUALIZAR CLIENTE
        public int actualizarCliente(ECliente ecli)
        {
            int actualizado = 0;
            conexion = new SqlConnection(cadenaConexion);
            try
            {
                // abrir conexion
                conexion.Open();
                //pasar nombre del procedimiento
                cmd = new SqlCommand("SP_ACTUALIZACLIENTE", conexion);
                cmd.Parameters.AddWithValue("@PCLIENTEID", ecli.FidCliente);
                cmd.Parameters.AddWithValue("@PNOMBRE", ecli.FnombCliente);
                cmd.Parameters.AddWithValue("@PAPELLIDO", ecli.FapelCliente);
                cmd.Parameters.AddWithValue("@PDIRECCION", ecli.FdirCliente);
                cmd.Parameters.AddWithValue("@PEMAIL", ecli.FemailCLiente);
                cmd.Parameters.AddWithValue("@PNROIDENTIDAD", ecli.FnroidenCliente);
                cmd.Parameters.AddWithValue("@PTELEFONO", ecli.FtelfCliente);
                cmd.Parameters.AddWithValue("@PDISTRITOID", ecli.Disid);
                cmd.Parameters.AddWithValue("@PPROVINCIAID", ecli.Provid);
                cmd.Parameters.AddWithValue("@PDEPARTAMENTOID", ecli.Depid);
                cmd.Parameters.AddWithValue("@PTIPOIDENTIDADID", ecli.FtipoidenId);

                //reconoce los datos de envio al procedimeinto almacenado
                cmd.CommandType = CommandType.StoredProcedure;
                //ejecutar el procedimiento
                actualizado = cmd.ExecuteNonQuery();
                return actualizado;
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


        //METODO BUSCAR CLIENTE

        public int buscarCliente(ECliente ecli)
        {
            int buscar = 0;
            conexion = new SqlConnection(cadenaConexion);
            try
            {
                SqlDataReader dr;
                // abrir conexion
                conexion.Open();

                //pasar nombre del procedimiento
                cmd = new SqlCommand("SP_BUSCACLIENTE", conexion);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PCLIENTEID", ecli.FidCliente);

                dr = cmd.ExecuteReader();
                if (!dr.HasRows)
                {
                    MessageBox.Show("Cliente no registrado !!");
                }

                while (dr.Read())
                {
                    ecli.FidCliente = dr.GetString(0);
                    ecli.FtipoidenId = dr.GetString(1);
                    ecli.FnroidenCliente = dr.GetString(2);
                    ecli.FnombCliente = dr.GetString(3);
                    ecli.FapelCliente = dr.GetString(4);
                    ecli.FemailCLiente = dr.GetString(5);
                    ecli.FtelfCliente = dr.GetString(6);
                    ecli.Depid = dr.GetString(7);
                    ecli.Provid = dr.GetString(8);
                    ecli.Disid = dr.GetString(9);
                    ecli.FdirCliente = dr.GetString(10);
                }

                return buscar;

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

        //METODO LISTAR CLIENTE

        public DataTable listaCliente()
        {
            dt = new DataTable();
            conexion = new SqlConnection(cadenaConexion);
            try
            {
                conexion.Open();
                cmd = new SqlCommand("SP_LISTACLIENTE", conexion);
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
