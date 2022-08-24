using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class EProvincia
    {
        private string provid;
        private string provnombre;
        private string depid;

        public string Provid
        {
            get { return provid; }
            set { provid = value; }
        }
        

        public string Provnombre
        {
            get { return provnombre; }
            set { provnombre = value; }
        }
       

        public string Depid
        {
            get { return depid; }
            set { depid = value; }
        }
    }
}
