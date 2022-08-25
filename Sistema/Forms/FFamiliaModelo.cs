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
    class FFamiliaModelo
    {
        ConnectionToSql Cadenaconex = new ConnectionToSql();
        private String idFamiliamodelo, DesFamiliamodelos;
        private SqlConnection conn;
        private SqlCommand cmd;
        public FFamiliaModelo()
        {
            conn = new SqlConnection(Cadenaconex.CadenaConexion);
        }
        public FFamiliaModelo(String idFamiliamodelo, String DesFamiliamodelos)
        {
            this.idFamiliamodelo = idFamiliamodelo;
            this.DesFamiliamodelos = DesFamiliamodelos;
            conn = new SqlConnection(Cadenaconex.CadenaConexion);
        }
        public String FidFamiliamodelo
        {
            get { return this.idFamiliamodelo; }
            set { this.idFamiliamodelo = value; }
        }

        public String FDesFamiliamodelos
        {
            get { return this.DesFamiliamodelos; }
            set { this.DesFamiliamodelos = value; }
        }

        public void RegistrarFamiliamodelo()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("SP_REGISTRARFamiliamodelo", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pidFamiliamodelo", idFamiliamodelo);
                cmd.Parameters.AddWithValue("@PDESFAMILIAMODELO", DesFamiliamodelos);
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

        public void ActualizarFamiliamodelo()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("SP_ACTUALIZAFamiliamodelo", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pidFamiliamodelo", idFamiliamodelo);
                cmd.Parameters.AddWithValue("@PDESFAMILIAMODELO", DesFamiliamodelos);
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


        public void BuscarFamiliamodelo()
        {
            try
            {
                SqlDataReader dr;
                conn.Open();
                cmd = new SqlCommand("SP_BUSCAFamiliamodelo", conn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pidFamiliamodelo", idFamiliamodelo);

                dr = cmd.ExecuteReader();
                if (!dr.HasRows)
                {
                    MessageBox.Show("Familiamodelo no Registrado !!");
                }
                while (dr.Read())
                {
                    idFamiliamodelo = dr.GetString(1);
                    DesFamiliamodelos = dr.GetString(0);
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



        public DataTable ListarFamiliamodelos()
        {
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter();
                conn.Open();
                cmd = new SqlCommand("SP_LISTAFamiliamodelo", conn);
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

