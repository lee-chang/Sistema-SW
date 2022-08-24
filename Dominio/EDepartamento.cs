using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class EDepartamento
    {
        private string depid;
        private string depnombre;

        public string Depid
        {
            get { return depid; }
            set {depid = value; }
        }
       
        public string Depnombre
        {
            get { return depnombre; }
            set { depnombre = value; }
        }
    }
}
