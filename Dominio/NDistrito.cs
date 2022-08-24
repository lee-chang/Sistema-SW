using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Dominio
{
    public class NDistrito
    {

        DDistrito ndist = new DDistrito();

        //listar
        public DataTable listaDistrito(string provid)
        {
            return ndist.listaDistrito(provid);
        }

    }
}
