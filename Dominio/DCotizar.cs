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
        public void insertaCotizacion(ECotizar ecot)
        {
            try
            {
                conexion.Open();
                cmd = new SqlCommand("SP_INSERTACOTIZACION", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PCOTIZACIONID", ecot.Cotid);
                cmd.Parameters.AddWithValue("@PFECHA", ecot.Fechaop);
                cmd.Parameters.AddWithValue("@PTOTALITEMS", ecot.Clieid);
                cmd.Parameters.AddWithValue("@PPRECIOTOTAL", ecot.Totalit);
                cmd.Parameters.AddWithValue("@PCLIENTEID", ecot.Precioto);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }


    }

}
