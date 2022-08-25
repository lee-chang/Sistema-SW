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
    internal class FTacoModelo
    {
        ConnectionToSql Cadenaconex = new ConnectionToSql();

        private String idTaco, desTaco;
        private SqlConnection conn;
        private SqlCommand cmd;
        public FTacoModelo()
        {
            conn = new SqlConnection(Cadenaconex.CadenaConexion);
        }
        public FTacoModelo(String tid, String tdescripcion)
        {
            this.idTaco = tid;
            this.desTaco = tdescripcion;

            conn = new SqlConnection(Cadenaconex.CadenaConexion);
        }
        public String FidTaco
        {
            get { return this.idTaco; }
            set { this.idTaco = value; }
        }

        public String FdesTaco
        {
            get { return this.desTaco; }
            set { this.desTaco = value; }
        }

        public void RegistrarTaco()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("SP_INSERTATACO", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@IDTACO", idTaco);
                cmd.Parameters.AddWithValue("@DESTACO", desTaco);
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

        public void ActualizarTaco()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("SP_ACTUALIZATACO", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IDTACO", idTaco);
                cmd.Parameters.AddWithValue("@DESTACO", desTaco);
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

        public void BuscarTaco()
        {
            try
            {
                SqlDataReader dr;
                conn.Open();
                cmd = new SqlCommand("SP_BUSCATACO", conn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IDTACO", idTaco);

                dr = cmd.ExecuteReader();
                if (!dr.HasRows)
                {
                    MessageBox.Show("Taco no Registrado !!");
                }
                while (dr.Read())
                {
                    idTaco = dr.GetString(1);
                    desTaco = dr.GetString(0);
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

        public DataTable ListarTaco()
        {
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter();
                conn.Open();
                cmd = new SqlCommand("SP_LISTATACO", conn);
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

