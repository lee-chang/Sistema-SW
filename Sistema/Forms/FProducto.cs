using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Forms
{
    internal class FProducto
    {
        ConnectionToSql Cadenaconex = new ConnectionToSql();
        private String idProducto, desProducto, idColeccion, idModelo, idColor, idTalla;
        private float Precioventa;

        private SqlConnection conn;
        private SqlCommand cmd;
        public FProducto()
        {
            conn = new SqlConnection(Cadenaconex.CadenaConexion);
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
                    //float Precioventa = dr.GetFloat(2);
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
