using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Dominio
{
    public class NDepartamento
    {

        DDepartamento ndep = new Dominio.DDepartamento();

        //listar
        public DataTable listaDepartamento()
        {
            return ndep.listaDepartamento();
        }
    }
}
