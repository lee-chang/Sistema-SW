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
    internal class FHorma
    {
        private String idHorma, descripcionHorma;
        private SqlConnection conn;
        private SqlCommand cmd;
        private String Cadenaconex = "Data Source=DESKTOP-25FAVIP\\SQLEXPRESS;Initial Catalog=SWZICCA;Integrated Security=true;I;";
        public FHorma()
        {
            conn = new SqlConnection(Cadenaconex);
        }
        public FHorma(String tid, String tdescripcion)
        {
            this.idHorma = tid;
            this.descripcionHorma = tdescripcion;

            conn = new SqlConnection(Cadenaconex);
        }
        public String FidHorma
        {
            get { return this.idHorma; }
            set { this.idHorma = value; }
        }

        public String FdescripcionHorma
        {
            get { return this.descripcionHorma; }
            set { this.descripcionHorma = value; }
        }

        public void RegistrarHorma()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("SP_INSERTAHORMA", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@pidhorma", idHorma);
                cmd.Parameters.AddWithValue("@pdescripcionhorma", descripcionHorma);
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

        public void ActualizarHorma()
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("SP_ACTUALIZAHORMA", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pidhorma", idHorma);
                cmd.Parameters.AddWithValue("@pdescripcionhorma", descripcionHorma);
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

        public void BuscarHorma()
        {
            try
            {
                SqlDataReader dr;
                conn.Open();
                cmd = new SqlCommand("SP_BUSCAHORMA", conn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pidhorma", idHorma);

                dr = cmd.ExecuteReader();
                if (!dr.HasRows)
                {
                    MessageBox.Show("Horma no Registrada !!");
                }
                while (dr.Read())
                {
                    idHorma = dr.GetString(0);
                    descripcionHorma = dr.GetString(1);
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

      /*  public DataTable ListarHorma()
        {
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter();
                conn.Open();
                cmd = new SqlCommand("SP_LISTAHORMA", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                return ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();

            }
        }*/
    }

}

