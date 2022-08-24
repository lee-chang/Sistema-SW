using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    internal class ETipoIden
    {
        private string tipoideid;
        private string tipoidenombre;

        public string Tipoideid
        {
            get { return tipoideid; }
            set { tipoideid = value; }
        }

        public string Tipoidenombre
        {
            get { return tipoidenombre; }
            set { tipoidenombre = value; }
        }
    }
}