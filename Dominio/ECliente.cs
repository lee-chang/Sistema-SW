using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class ECliente
    {
        private String cliID, nombCli, apellCli, dirCli, tipoidenid, nroidenCli, emailCli, telfCli, distid;

        public String FidCliente
        {
            get { return this.cliID; }
            set { this.cliID = value; }
        }
        public String FapelCliente
        {
            get { return this.apellCli; }
            set { this.apellCli = value; }
        }

        public String FnombCliente
        {
            get { return this.nombCli; }
            set { this.nombCli = value; }
        }

        public String FdirCliente
        {
            get { return this.dirCli; }
            set { this.dirCli = value; }
        }
        public String FtipoidenId
        {
            get { return this.tipoidenid; }
            set { this.tipoidenid = value; }
        }

        public String FnroidenCliente
        {
            get { return this.nroidenCli; }
            set { this.nroidenCli = value; }
        }

        public String FtelfCliente
        {
            get { return this.telfCli; }
            set { this.telfCli = value; }
        }

        public String FemailCLiente
        {
            get { return this.emailCli; }
            set { this.emailCli = value; }
        }

        public String Disid
        {
            get { return distid; }
            set { distid = value; }
        }


    }
}
