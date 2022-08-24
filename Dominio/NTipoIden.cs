using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Dominio
{
    public class NTipoIden
    {

        DTipoIden ntipoiden = new DTipoIden();

        //listar
        public DataTable listaTipoIden(string tipoidenid)
        {
            return ntipoiden.listaTipoIden();
        }
    }
}
