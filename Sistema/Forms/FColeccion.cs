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
    internal class FColeccion
    {
        ConnectionToSql Cadenaconex= new ConnectionToSql();

        private String idCol, nomCol;
        private SqlConnection conn;
        private SqlCommand cmd;
        public FColeccion()
        {
            conn = new SqlConnection(Cadenaconex.CadenaConexion);
        }
        public FColeccion(String tid, String tnom)
        {
            this.idCol = tid;
            this.nomCol = tnom;

            conn = new SqlConnection(Cadenaconex.CadenaConexion);
        }
        public String FidCol
        {
            get { return this.idCol; }
            set { this.idCol = value; }
        }

        public String FnomCol
        {
            get { return this.nomCol; }
            set { this.nomCol = value; }
        }

        public void RegistrarCol()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("SP_INSERTACOL", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@IDCOL", idCol);
                cmd.Parameters.AddWithValue("@NOMCOL", nomCol);
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

        public void ActualizarCol()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("SP_ACTUALIZACOL", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IDCOL", idCol);
                cmd.Parameters.AddWithValue("@NOMCOL", nomCol);
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

        public void BuscarCol()
        {
            try
            {
                SqlDataReader dr;
                conn.Open();
                cmd = new SqlCommand("SP_BUSCACOL", conn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IDCOL", idCol);

                dr = cmd.ExecuteReader();
                if (!dr.HasRows)
                {
                    MessageBox.Show("Coleccion no Registrada !!");
                }
                while (dr.Read())
                {
                    idCol = dr.GetString(1);
                    nomCol = dr.GetString(0);
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

        public DataTable ListarCol()
        {
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter();
                conn.Open();
                cmd = new SqlCommand("SP_LISTACOL", conn);
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

