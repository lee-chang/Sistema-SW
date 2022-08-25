using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using AccesoDatos;

namespace Sistema.Forms
{
    internal class FSubfamiliaModelo
    {
        ConnectionToSql Cadenaconex = new ConnectionToSql();
        private String idSubfamiliaModelo, DesSubfamiliaModelos;
        private SqlConnection conn;
        private SqlCommand cmd;
        public FSubfamiliaModelo()
        {
            conn = new SqlConnection(Cadenaconex.CadenaConexion);
        }
        public FSubfamiliaModelo(String idSubfamiliaModelo, String DesSubfamiliaModelos)
        {
            this.idSubfamiliaModelo = idSubfamiliaModelo;
            this.DesSubfamiliaModelos = DesSubfamiliaModelos;
            conn = new SqlConnection(Cadenaconex.CadenaConexion);
        }
        public String FidSubfamiliaModelo
        {
            get { return this.idSubfamiliaModelo; }
            set { this.idSubfamiliaModelo = value; }
        }

        public String FDesSubfamiliaModelos
        {
            get { return this.DesSubfamiliaModelos; }
            set { this.DesSubfamiliaModelos = value; }
        }

        public void RegistrarSubfamiliaModelo()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("SP_REGISTRARSubfamiliaModelo", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pidSubfamiliaModelo", idSubfamiliaModelo);
                cmd.Parameters.AddWithValue("@PDESSUBFAMILIAMODELO", DesSubfamiliaModelos);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void ActualizarSubfamiliaModelo()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("SP_ACTUALIZASubfamiliaModelo", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pidSubfamiliaModelo", idSubfamiliaModelo);
                cmd.Parameters.AddWithValue("@PDESSUBFAMILIAMODELO", DesSubfamiliaModelos);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }


        public void BuscarSubfamiliaModelo()
        {
            try
            {
                SqlDataReader dr;
                conn.Open();
                cmd = new SqlCommand("SP_BUSCASubfamiliaModelo", conn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pidSubfamiliaModelo", idSubfamiliaModelo);

                dr = cmd.ExecuteReader();
                if (!dr.HasRows)
                {
                    MessageBox.Show("SubfamiliaModelo no Registrado !!");
                }
                while (dr.Read())
                {
                    idSubfamiliaModelo = dr.GetString(1);
                    DesSubfamiliaModelos = dr.GetString(0);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public DataTable ListarSubfamiliaModelos()
        {
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter();
                conn.Open();
                cmd = new SqlCommand("SP_LISTASubfamiliaModelo", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                return ds.Tables[0];
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
