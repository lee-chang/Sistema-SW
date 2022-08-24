using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sistema.Forms
{
    internal class FPuntaModelo
    {
        private String idPunta, desPunta;
        private SqlConnection conn;
        private SqlCommand cmd;
        private String Cadenaconex = "SERVER=DESKTOP-DS840MB;DATABASE=swzicca;Integrated Security=SSPI;";
        public FPuntaModelo()
        {
            conn = new SqlConnection(Cadenaconex);
        }
        public FPuntaModelo(String tid, String tdescripcion)
        {
            this.idPunta = tid;
            this.desPunta = tdescripcion;
            conn = new SqlConnection(Cadenaconex);
        }
        public String FidPunta
        {
            get { return this.idPunta; }
            set { this.idPunta = value; }
        }

        public String FdesPunta
        {
            get { return this.desPunta; }
            set { this.desPunta = value; }
        }

        public void RegistrarPunta()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("SP_INSERTAPUNTA", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@IDPUNTA", idPunta);
                cmd.Parameters.AddWithValue("@DESPUNTA", desPunta);
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

        public void ActualizarPunta()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("SP_ACTUALIZAPUNTA", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IDPUNTA", idPunta);
                cmd.Parameters.AddWithValue("@DESPUNTA", desPunta);
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

        public void BuscarPunta()
        {
            try
            {
                SqlDataReader dr;
                conn.Open();
                cmd = new SqlCommand("SP_BUSCAPUNTA", conn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IDPUNTA", idPunta);

                dr = cmd.ExecuteReader();
                if (!dr.HasRows)
                {
                    MessageBox.Show("Punta no Registrada !!");
                }
                while (dr.Read())
                {
                    idPunta = dr.GetString(1);
                    desPunta = dr.GetString(0);
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

        public DataTable ListarPunta()
        {
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter();
                conn.Open();
                cmd = new SqlCommand("SP_LISTAPUNTA", conn);
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

