using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Dominio
{
    public class NCliente
    {

        DCliente nclie = new DCliente();

        //INSERTAR
        public int registrarCliente(ECliente eclie)
        {
            return nclie.registrarCliente(eclie);
        }

        public int actualizarCliente(ECliente eclie)
        {
            return nclie.actualizarCliente(eclie);
        }

        public int buscarCliente(ECliente eclie)
        {
            return nclie.buscarCliente(eclie);
        }

        //listar
        public DataTable listaCliente()
         {
             return nclie.listaCliente();
         }
    }
}