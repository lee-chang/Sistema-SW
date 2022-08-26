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


    }
}
