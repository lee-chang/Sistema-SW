using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ECotizar
    {
        private string cotid;
        private string clieid;
        private int totalit;
        private float precioto;
        private DateTime fechaop;

        public string Cotid
        {
            get { return cotid; }
            set { cotid = value; }
        }

        public string Clieid
        {
            get { return clieid; }
            set { clieid = value; }
        }

        public int Totalit
        {
            get { return totalit; }
            set { totalit = value; }
        }
        
        public float Precioto
        {
            get { return precioto; }
            set { precioto = value; }
        }

        public DateTime Fechaop
        {
            get { return fechaop; }
            set { fechaop = value; }
        }
    }
}
