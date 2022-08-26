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
    class EProducto
    {
        ConnectionToSql Cadenaconex = new ConnectionToSql();
        private String idProducto, desProducto, idColeccion, idModelo, idColor, idTalla;
        private float Precioventa;

        private SqlConnection conn;
        private SqlCommand cmd;
        public EProducto()
        {
            conn = new SqlConnection(Cadenaconex.CadenaConexion);
        }
        public EProducto(String idProducto, String desProducto, float Precioventa, String idColeccion, String idModelo, String idColor, String idTalla)
        {
            this.idProducto = idProducto;
            this.desProducto = desProducto;
            this.Precioventa = Precioventa;
            this.idColeccion = idColeccion;
            this.idModelo = idModelo;
            this.idColor = idColor;
            this.idTalla = idTalla;
            conn = new SqlConnection(Cadenaconex.CadenaConexion);
        }
        public String FidProducto
        {
            get { return this.idProducto; }
            set { this.idProducto = value; }
        }

        public String FdesProducto
        {
            get { return this.desProducto; }
            set { this.desProducto = value; }
        }

        public float FPrecioventa
        {
            get { return this.Precioventa; }
            set { this.Precioventa = value; }
        }

        public String FidColeccion
        {
            get { return this.idColeccion; }
            set { this.idColeccion = value; }
        }

        public String FidModelo
        {
            get { return this.idModelo; }
            set { this.idModelo = value; }
        }

        public String FidColor
        {
            get { return this.idColor; }
            set { this.idColor = value; }
        }

        public String FidTalla
        {
            get { return this.idTalla; }
            set { this.idTalla = value; }
        }

        public void RegistrarProducto()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("SP_REGISTRARPRODUCTO", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IDPRODUCTO", idProducto);
                cmd.Parameters.AddWithValue("@DESPRODUCTO", desProducto);
                cmd.Parameters.AddWithValue("@PRECIOVENTA", Precioventa);
                cmd.Parameters.AddWithValue("@IDCOLECCION", idColeccion);
                cmd.Parameters.AddWithValue("@IDMODELO", idModelo);
                cmd.Parameters.AddWithValue("@IDCOLOR", idColor);
                cmd.Parameters.AddWithValue("@IDTALLA", idTalla);
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

        public void ActualizarProducto()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("SP_ACTUALIZAPRODUCTO", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IDPRODUCTO", idProducto);
                cmd.Parameters.AddWithValue("@DESPRODUCTO", desProducto);
                cmd.Parameters.AddWithValue("@PRECIOVENTA", Precioventa);
                cmd.Parameters.AddWithValue("@IDCOLECCION", idColeccion);
                cmd.Parameters.AddWithValue("@IDMODELO", idModelo);
                cmd.Parameters.AddWithValue("@IDCOLOR", idColor);
                cmd.Parameters.AddWithValue("@IDTALLA", idTalla);
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


        public void BuscarProducto()
        {
            try
            {
                SqlDataReader dr;
                conn.Open();
                cmd = new SqlCommand("SP_BUSCAPRODUCTO", conn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IDPRODUCTO", idProducto);

                dr = cmd.ExecuteReader();
                if (!dr.HasRows)
                {
                    MessageBox.Show("Producto no Registrado !!");
                }
                while (dr.Read())
                {
                    idProducto = dr.GetString(0);
                    desProducto = dr.GetString(1);
                    float Precioventa = dr.GetFloat(2);
                    idColeccion = dr.GetString(3);
                    idModelo = dr.GetString(4);
                    idColor = dr.GetString(5);
                    idTalla = dr.GetString(6);
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



        public DataTable ListarProducto()
        {
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter();
                conn.Open();
                cmd = new SqlCommand("SP_LISTAPRODUCTO", conn);
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
