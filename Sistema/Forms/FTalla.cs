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
    internal class FTalla
    {
        ConnectionToSql Cadenaconex= new ConnectionToSql();

        private String idTalla, numTalla;
        private SqlConnection conn;
        private SqlCommand cmd;
        public FTalla()
        {
            conn = new SqlConnection(Cadenaconex.CadenaConexion);
        }
        public FTalla(String tid, String tnum)
        {
            this.idTalla = tid;
            this.numTalla = tnum;

            conn = new SqlConnection(Cadenaconex.CadenaConexion);
        }
        public String FidTalla
        {
            get { return this.idTalla; }
            set { this.idTalla = value; }
        }

        public String FnumTalla
        {
            get { return this.numTalla; }
            set { this.numTalla = value; }
        }

        public void RegistrarTalla()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("SP_INSERTATALLA", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@IDTALLA", idTalla);
                cmd.Parameters.AddWithValue("@NUMTALLA", numTalla);
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

        public void ActualizarTalla()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("SP_ACTUALIZATALLA", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IDTALLA", idTalla);
                cmd.Parameters.AddWithValue("@NUMTALLA", numTalla);
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

        public void BuscarTalla()
        {
            try
            {
                SqlDataReader dr;
                conn.Open();
                cmd = new SqlCommand("SP_BUSCATALLA", conn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IDTALLA", idTalla);

                dr = cmd.ExecuteReader();
                if (!dr.HasRows)
                {
                    MessageBox.Show("Talla no Registrada !!");
                }
                while (dr.Read())
                {
                    idTalla = dr.GetString(0);
                    numTalla = dr.GetString(1);
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

        public DataTable ListarTalla()
        {
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter();
                conn.Open();
                cmd = new SqlCommand("SP_LISTATALLA", conn);
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

