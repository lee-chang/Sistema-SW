using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace Sistema
{
    class FCliente
    {
        private String cliID, nombCli, apellCli, dirCli, tipoidenid,nroidenCli,emailCli,telfCli,depID,provid,distid;
        private SqlConnection conn;
        private SqlCommand cmd;
        string cadenaConexion = "server=DESKTOP-25FAVIP\\SQLEXPRESS;database=SWZICCA;Integrated Security = true;";
        public FCliente()
        {
            conn = new SqlConnection(cadenaConexion);
        }
        public FCliente(String tid,String tnombre, String tapell, String tdir, String ttipiden, String tnroiden, string temail, string ttelf,string tdepid, string tprovid, string tdistid)
        {
            this.cliID = tid;
            this.apellCli = tapell;
            this.nombCli = tnombre;
            this.dirCli = tdir;
            this.tipoidenid = ttipiden;
            this.nroidenCli = tnroiden;
            this.emailCli = temail;
            this.telfCli = ttelf;
            this.depID = tdepid;
            this.provid = tprovid;
            this.distid = tdistid;

            conn = new SqlConnection(cadenaConexion);
        }
        public String FidCliente
        {
            get { return this.cliID; }
            set { this.cliID = value; }
        }
        public String FapelCliente
        {
            get { return this.apellCli; }
            set { this.apellCli = value; }
        }

        public String FnombCliente
        {
            get { return this.nombCli; }
            set { this.nombCli = value; }
        }

        public String FdirCliente
        {
            get { return this.dirCli; }
            set { this.dirCli = value; }
        }
        public String FtipoidenId
        {
            get { return this.tipoidenid; }
            set { this.tipoidenid = value; }
        }

        public String FnroidenCliente
        {
            get { return this.nroidenCli; }
            set { this.nroidenCli = value; }
        }

        public String FtelfCliente
        {
            get { return this.telfCli; }
            set { this.telfCli = value; }
        }

        public String FemailCLiente
        {
            get { return this.emailCli; }
            set { this.emailCli = value; }
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
   
