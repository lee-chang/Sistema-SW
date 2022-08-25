using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Forms
{
    public partial class FamiliaModelo : Form
    {
        public FamiliaModelo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {

                FFamiliaModelo objFamiliamodelo = new FFamiliaModelo();
                objFamiliamodelo.FidFamiliamodelo = txtidFamiliamodelo.Text;
                objFamiliamodelo.BuscarFamiliamodelo();
                txtDesFamiliamodelos.Text = objFamiliamodelo.FDesFamiliamodelos;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                FFamiliaModelo objFamiliamodelo = new FFamiliaModelo();
                objFamiliamodelo.FidFamiliamodelo = txtidFamiliamodelo.Text;
                objFamiliamodelo.FDesFamiliamodelos = txtDesFamiliamodelos.Text;
                objFamiliamodelo.RegistrarFamiliamodelo();
                MessageBox.Show("Familiamodelo Registrado ");
                LimpiarForm();
                FillGrid();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                FFamiliaModelo objFamiliamodelo = new FFamiliaModelo();
                objFamiliamodelo.FidFamiliamodelo = txtidFamiliamodelo.Text;
                objFamiliamodelo.FDesFamiliamodelos = txtDesFamiliamodelos.Text;
                objFamiliamodelo.ActualizarFamiliamodelo();
                MessageBox.Show("Datos Actualizados ");
                LimpiarForm();
                FillGrid();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        private void FamiliaModelo_Load(object sender, EventArgs e)
        {
            FillGrid();
        }
        private void FillGrid()
        {
            try
            {
                FFamiliaModelo objFFamiliamodelo = new FFamiliaModelo();
                DGVFamiliamodelo.DataSource = objFFamiliamodelo.ListarFamiliamodelos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LimpiarForm()
        {
            txtidFamiliamodelo.Text = "";
            txtDesFamiliamodelos.Text = "";

            txtidFamiliamodelo.Focus();
        }

    }
}
