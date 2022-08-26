using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using AccesoDatos;
using Dominio;

namespace Sistema.Forms
{
    class FCotizar
    {
        ConnectionToSql Cadenaconex = new ConnectionToSql();

        private SqlConnection conn;
        private SqlCommand cmd;

        public FCotizar()
        {
            conn = new SqlConnection(Cadenaconex.CadenaConexion);
        }

        public FCotizar(String tcotid, String tclieid, int ttotalit, float tprecioto, DateTime tfechaop)
        {
            this.cotid = tcotid;
            this.clieid = tclieid;
            this.totalit = ttotalit;
            this.precioto = tprecioto;
            this.fechaop = tfechaop;

            conn = new SqlConnection(Cadenaconex.CadenaConexion);
        }

        private string cotid;
        private string clieid;
        private int totalit;
        private float precioto;
        private DateTime fechaop;

        public string Cotid
        {
            get { return cotid; }
            set { cotid = value; }
        }

        public string Clieid
        {
            get { return clieid; }
            set { clieid = value; }
        }

        public int Totalit
        {
            get { return totalit; }
            set { totalit = value; }
        }

        public float Precioto
        {
            get { return precioto; }
            set { precioto = value; }
        }

        public DateTime Fechaop
        {
            get { return fechaop; }
            set { fechaop = value; }

        }

        //METODO INSERTAR COTIZACION
        public void insertaCotizacion()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("SP_INSERTACOTIZACION", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PCOTIZACIONID", Cotid);
                cmd.Parameters.AddWithValue("@PFECHA", Fechaop);
                cmd.Parameters.AddWithValue("@PTOTALITEMS", Clieid);
                cmd.Parameters.AddWithValue("@PPRECIOTOTAL", Totalit);
                cmd.Parameters.AddWithValue("@PCLIENTEID", Precioto);
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
    }
}
