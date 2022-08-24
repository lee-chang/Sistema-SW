using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Forms
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
