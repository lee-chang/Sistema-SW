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
        NTipoIden ntipoiden = new NTipoIden();

        NCliente nclie = new NCliente();
        ECliente eclie = new ECliente();


        string depid;
        string tipoideid, tipoidenid;
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

        public void CargarTipoIdentificacion()
        {
            cbxtipoid.DisplayMember = "Descripcion";
            cbxtipoid.ValueMember = "TipoIdentidadID";
            cbxtipoid.DataSource = ntipoiden.listaTipoIden(tipoidenid);
        }

        public Cliente()
        {
            InitializeComponent();
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
            CargarTipoIdentificacion();
            DGVCliente.DataSource = nclie.listaCliente();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            r = comboBox3.SelectedValue.ToString();
            proid = r;
            CargarDistrito(proid);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            eclie.FidCliente = txtclientid.Text;
            eclie.FtipoidenId = cbxtipoid.SelectedValue.ToString();
            eclie.Depid = comboBox2.SelectedValue.ToString();
            eclie.Provid = comboBox3.SelectedValue.ToString();
            eclie.Disid = comboBox4.SelectedValue.ToString();
            eclie.FnombCliente = txtnombre.Text;
            eclie.FapelCliente = txtapellido.Text;
            eclie.FemailCLiente = txtemail.Text;
            eclie.FdirCliente = txtdir.Text;
            eclie.FtelfCliente = txttelefono.Text;
            eclie.FnroidenCliente = txtnroiden.Text;

            int resultado = nclie.registrarCliente(eclie);
            if (resultado > 0)
            {
                MessageBox.Show("Datos Guardados Correctamente", "Datos Laboratorio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiarCajas();
                FillGrid();
            }
        }

        public void limpiarCajas()
        {
            txtclientid.Text = "";
            txtnombre.Text = "";
            txtapellido.Text = "";
            txtnroiden.Text = "";
            txtemail.Text = "";
            txttelefono.Text = "";
            txtdir.Text = "";
            cbxtipoid.SelectedValue = "1";
            comboBox2.SelectedValue = "1";
            comboBox3.SelectedValue = "1";
            comboBox4.SelectedValue= "1";

        }

        private void iconCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCajas();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            eclie.FidCliente = txtclientid.Text;
            eclie.FtipoidenId = cbxtipoid.SelectedValue.ToString();
            eclie.Depid = comboBox2.SelectedValue.ToString();
            eclie.Provid = comboBox3.SelectedValue.ToString();
            eclie.Disid = comboBox4.SelectedValue.ToString();
            eclie.FnombCliente = txtnombre.Text;
            eclie.FapelCliente = txtapellido.Text;
            eclie.FemailCLiente = txtemail.Text;
            eclie.FdirCliente = txtdir.Text;
            eclie.FtelfCliente = txttelefono.Text;
            eclie.FnroidenCliente = txtnroiden.Text;

            int resultado = nclie.actualizarCliente(eclie);
            if (resultado > 0)
            {
                MessageBox.Show("Datos Actualizados Correctamente", "Datos Laboratorio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiarCajas();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            eclie.FidCliente = txtclientid.Text;

            int resultado = nclie.buscarCliente(eclie);
            if (resultado > 0)
            {
                 limpiarCajas();
            }
            else
            {
                cbxtipoid.SelectedValue = eclie.FtipoidenId;
                comboBox2.SelectedValue = eclie.Depid;
                comboBox3.SelectedValue = eclie.Provid;
                comboBox4.SelectedValue = eclie.Disid;
                txtnombre.Text = eclie.FnombCliente;
                txtapellido.Text = eclie.FapelCliente;
                txtemail.Text = eclie.FemailCLiente;
                txtdir.Text = eclie.FdirCliente;
                txttelefono.Text = eclie.FtelfCliente;
                txtnroiden.Text = eclie.FnroidenCliente;
                FillGrid();
            }
        }

        private void cbxtipoid_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipoideid = cbxtipoid.SelectedValue.ToString();
            tipoidenid = tipoideid;
            CargarProvincia(tipoidenid);
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FillGrid()
        {
            try
            {
                DGVCliente.DataSource = nclie.listaCliente();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
