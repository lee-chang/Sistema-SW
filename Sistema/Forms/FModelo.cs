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
    class FModelo
    {
        ConnectionToSql Cadenaconex = new ConnectionToSql();
        private String idModelo, desModelo,idFam,idPunta,idSubfam,idTaco,idHorma;
        private SqlConnection conn;
        private SqlCommand cmd;
        public FModelo()
        {
            conn = new SqlConnection(Cadenaconex.CadenaConexion);
        }
        public FModelo(String idModelo, String desModelo, String idFam, String idPunta, String idSubfam, String idTaco, String idHorma)
        {
            this.idModelo = idModelo;
            this.desModelo = desModelo;
            this.idFam = idFam;
            this.idPunta = idPunta;
            this.idSubfam = idSubfam;
            this.idTaco = idTaco;
            this.idHorma = idHorma;
            conn = new SqlConnection(Cadenaconex.CadenaConexion);
        }
        public String FidModelo
        {
            get { return this.idModelo; }
            set { this.idModelo = value; }
        }

        public String FdesModelo
        {
            get { return this.desModelo; }
            set { this.desModelo = value; }
        }

        public String FidFam
        {
            get { return this.idFam; }
            set { this.idFam = value; }
        }

        public String FidPunta
        {
            get { return this.idPunta; }
            set { this.idPunta = value; }
        }

        public String FidSubfam
        {
            get { return this.idSubfam; }
            set { this.idSubfam = value; }
        }

        public String FidTaco
        {
            get { return this.idTaco; }
            set { this.idTaco = value; }
        }

        public String FidHorma
        {
            get { return this.idHorma; }
            set { this.idHorma = value; }
        }

        public void RegistrarModelo()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("SP_INSERTAMODELO", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IDMODELO", idModelo);
                cmd.Parameters.AddWithValue("@DESMODELO", desModelo);
                cmd.Parameters.AddWithValue("@IDFAM", idFam);
                cmd.Parameters.AddWithValue("@IDPUNTA", idPunta);
                cmd.Parameters.AddWithValue("@IDSUBFAM", idSubfam);
                cmd.Parameters.AddWithValue("@IDTACO", idTaco);
                cmd.Parameters.AddWithValue("@IDHORMA", idHorma);
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

        public void ActualizarModelo()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("SP_ACTUALIZAMODELO", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IDMODELO", idModelo);
                cmd.Parameters.AddWithValue("@DESMODELO", desModelo);
                cmd.Parameters.AddWithValue("@IDFAM", idFam);
                cmd.Parameters.AddWithValue("@IDPUNTA", idPunta);
                cmd.Parameters.AddWithValue("@IDSUBFAM", idSubfam);
                cmd.Parameters.AddWithValue("@IDTACO", idTaco);
                cmd.Parameters.AddWithValue("@IDHORMA", idHorma);
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


        public void BuscarModelo()
        {
            try
            {
                SqlDataReader dr;
                conn.Open();
                cmd = new SqlCommand("SP_BUSCAMODELO", conn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IDMODELO", idModelo);

                dr = cmd.ExecuteReader();
                if (!dr.HasRows)
                {
                    MessageBox.Show("Modelo no Registrado !!");
                }
                while (dr.Read())
                { 
                    idModelo = dr.GetString(0);
                    desModelo = dr.GetString(1);
                    idFam = dr.GetString(2);
                    idPunta = dr.GetString(5);
                    idSubfam = dr.GetString(3);
                    idTaco = dr.GetString(6);
                    idHorma = dr.GetString(4);
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



        public DataTable ListarModelo()
        {
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter();
                conn.Open();
                cmd = new SqlCommand("SP_LISTAMODELO", conn);
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

