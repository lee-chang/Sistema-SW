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
    class FDetalleCotizar
    {
        ConnectionToSql Cadenaconex = new ConnectionToSql();

        private SqlConnection conn;
        private SqlCommand cmd;

        public FDetalleCotizar()
        {
            conn = new SqlConnection(Cadenaconex.CadenaConexion);
        }

        public FDetalleCotizar(String tcotid, String tprodid, String tdetalle, int tcant, float tpreunit, float tsubt)
        {
            this.cotid = tcotid;
            this.prodid = tprodid;
            this.detalle = tdetalle;
            this.cant = tcant;
            this.preunit = tpreunit;
            this.subt = tsubt;

            conn = new SqlConnection(Cadenaconex.CadenaConexion);
        }

        private String cotid, prodid, detalle;
        private int cant;
        private float preunit, subt;

        public string Cotid
        {
            get { return cotid; }
            set { cotid = value; }
        }

        public String Prodid
        {
            get { return prodid; }
            set { prodid = value; }
        }

        public String Detalle
        {
            get { return detalle; }
            set { detalle = value; }
        }

        public int Cant
        {
            get { return cant; }
            set { cant = value; }
        }

        public float Preunit
        {
            get { return preunit; }
            set { preunit = value; }
        }

        public float Subt
        {
            get { return subt; }
            set { subt = value; }
        }

        public void RegistrarDetalleFactura()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("SP_INSERTA_DETALLECOTIZACION", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PCOTIZACIONID", Cotid);
                cmd.Parameters.AddWithValue("@PPRODUCTOID", Prodid);
                cmd.Parameters.AddWithValue("@PDETALLES", Detalle);
                cmd.Parameters.AddWithValue("@PCANTIDAD", Cant);
                cmd.Parameters.AddWithValue("@PPRECIOUNIT", Preunit);
                cmd.Parameters.AddWithValue("@PSUBTOTAL", Subt);
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


    }
}
