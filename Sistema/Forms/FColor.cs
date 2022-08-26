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
    internal class FColor
    {
        ConnectionToSql Cadenaconex= new ConnectionToSql();

        private String idColor, nomColor;
        private SqlConnection conn;
        private SqlCommand cmd;
        public FColor()
        {
            conn = new SqlConnection(Cadenaconex.CadenaConexion);
        }
        public FColor(String tid, String tnom)
        {
            this.idColor = tid;
            this.nomColor = tnom;

            conn = new SqlConnection(Cadenaconex.CadenaConexion);
        }
        public String FidColor
        {
            get { return this.idColor; }
            set { this.idColor = value; }
        }

        public String FnomColor
        {
            get { return this.nomColor; }
            set { this.nomColor = value; }
        }

        public void RegistrarColor()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("SP_REGISTRARCOLOR", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@IDCOLOR", idColor);
                cmd.Parameters.AddWithValue("@NOMCOLOR", nomColor);
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

        public void ActualizarColor()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("SP_ACTUALIZACOLOR", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IDCOLOR", idColor);
                cmd.Parameters.AddWithValue("@NOMCOLOR", nomColor);
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

        public void BuscarColor()
        {
            try
            {
                SqlDataReader dr;
                conn.Open();
                cmd = new SqlCommand("SP_BUSCACOLOR", conn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IDCOLOR", idColor);

                dr = cmd.ExecuteReader();
                if (!dr.HasRows)
                {
                    MessageBox.Show("Color no Registrado !!");
                }
                while (dr.Read())
                {
                    idColor = dr.GetString(1);
                    nomColor = dr.GetString(0);
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

        public DataTable ListarColor()
        {
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter();
                conn.Open();
                cmd = new SqlCommand("SP_LISTACOLOR", conn);
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

