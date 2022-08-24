using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema;
using Dominio;

namespace Sistema.Forms
{
    public partial class Cliente : Form
    {
        NDepartamento ndep = new NDepartamento();
        NProvincia nprov = new NProvincia();
        NDistrito ndist = new NDistrito();

        string depid;
        string r;

        string deid, proid;

        public void CargarDepartamento()
        {
            comboBox2.DisplayMember = "Descripcion";
            comboBox2.ValueMember = "DepartamentoID";
            comboBox2.DataSource = ndep.listaDepartamento();
        }

        public void CargarProvincia(string depid)
        {
            comboBox3.DisplayMember = "Descripcion";
            comboBox3.ValueMember = "ProvinciaID";
            comboBox3.DataSource = nprov.listaProvincia(depid);


        }

        public void CargarDistrito(string provid)
        {
            comboBox4.DisplayMember = "Descripcion";
            comboBox4.ValueMember = "DistritoID";
            comboBox4.DataSource = ndist.listaDistrito(provid);
        }

        public Cliente()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            deid = comboBox2.SelectedValue.ToString();
            depid = deid;
            CargarProvincia(depid);
        }
        

        private void Cliente_Load(object sender, EventArgs e)
        {
            CargarDepartamento();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            r = comboBox3.SelectedValue.ToString();
            proid = r;
            CargarDistrito(proid);
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
