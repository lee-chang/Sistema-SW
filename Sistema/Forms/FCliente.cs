using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Sistema
{
    class FCliente
    {
        private String idCliente, apelCliente, nombCliente, dirCliente, tipCliente;
        private SqlConnection conn;
        private SqlCommand cmd;
        private String Cadenaconex = "server=DESKTOP-25FAVIP\\SQLEXPRESS;database=SWZICCA;Integrated Security=true;";
        public FCliente()
        {
            conn = new SqlConnection(Cadenaconex);
        }
        public FCliente(String tid, String tapel, String tnombre, String tdir, String ttip)
        {
            this.idCliente = tid;
            this.apelCliente = tapel;
            this.nombCliente = tnombre;
            this.dirCliente = tdir;
            this.dirCliente = ttip;
            conn = new SqlConnection(Cadenaconex);
        }
        public String FidCliente
        {
            get { return this.idCliente; }
            set { this.idCliente = value; }
        }
        public String FapelCliente
        {
            get { return this.apelCliente; }
            set { this.apelCliente = value; }
        }

        public String FnombCliente
        {
            get { return this.nombCliente; }
            set { this.nombCliente = value; }
        }

        public String FdirCliente
        {
            get { return this.dirCliente; }
            set { this.dirCliente = value; }
        }
        public String FtipCliente
        {
            get { return this.tipCliente; }
            set { this.tipCliente = value; }
        }

        public void RegistrarCliente()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("SP_INSERTACLIENTE", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pidcliente", idCliente);
                cmd.Parameters.AddWithValue("@papelcliente", apelCliente);
                cmd.Parameters.AddWithValue("@pnombcliente", nombCliente);
                cmd.Parameters.AddWithValue("@pdircliente", dirCliente);
                cmd.Parameters.AddWithValue("@ptipcliente", tipCliente);
                cmd.ExecuteNonQuery();
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

        public void ActualizarCliente()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("SP_ACTUALIZACLIENTE", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pidcliente", idCliente);
                cmd.Parameters.AddWithValue("@papelcliente", apelCliente);
                cmd.Parameters.AddWithValue("@pnombcliente", nombCliente);
                cmd.Parameters.AddWithValue("@pdircliente", dirCliente);
                cmd.Parameters.AddWithValue("@ptipcliente", tipCliente);
                cmd.ExecuteNonQuery();
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



        public void BuscarCliente()
        {
            try
            {
                SqlDataReader dr;
                conn.Open();
                cmd = new SqlCommand("SP_BUSCACLIENTE", conn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pidcliente", idCliente);

                dr = cmd.ExecuteReader();
                if (!dr.HasRows)
                {
                    MessageBox.Show("Cliente no Registrado !!");
                }
                while (dr.Read())
                {
                    idCliente = dr.GetString(0);
                    apelCliente = dr.GetString(1);
                    nombCliente = dr.GetString(2);
                    dirCliente = dr.GetString(3);
                    tipCliente = dr.GetString(4);
                }

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



        public DataTable ListarCliente()
        {
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter();
                conn.Open();
                cmd = new SqlCommand("SP_LISTACLIENTE", conn);
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

