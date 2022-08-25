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
    public partial class SubfamiliaModelo : Form
    {
        public SubfamiliaModelo()
        {
            InitializeComponent();
        }

        private void SubfamiliaModelo_Load(object sender, EventArgs e)
        {
            FillGrid();
        }
        private void FillGrid()
        {
            try
            {
                FSubfamiliaModelo objFSubfamiliaModelo = new FSubfamiliaModelo();
                DGVSubfamiliaModelo.DataSource = objFSubfamiliaModelo.ListarSubfamiliaModelos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LimpiarForm()
        {
            txtidSubfamiliaModelo.Text = "";
            txtDesSubfamiliaModelos.Text = "";

            txtidSubfamiliaModelo.Focus();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {

            try
            {
                FSubfamiliaModelo objSubfamiliaModelo = new FSubfamiliaModelo();
                objSubfamiliaModelo.FidSubfamiliaModelo = txtidSubfamiliaModelo.Text;
                objSubfamiliaModelo.FDesSubfamiliaModelos = txtDesSubfamiliaModelos.Text;
                objSubfamiliaModelo.ActualizarSubfamiliaModelo();
                MessageBox.Show("Datos Actualizados ");
                LimpiarForm();
                FillGrid();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {

                FSubfamiliaModelo objSubfamiliaModelo = new FSubfamiliaModelo();
                objSubfamiliaModelo.FidSubfamiliaModelo = txtidSubfamiliaModelo.Text;
                objSubfamiliaModelo.BuscarSubfamiliaModelo();
                txtDesSubfamiliaModelos.Text = objSubfamiliaModelo.FDesSubfamiliaModelos;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void DGVSubfamiliaModelo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                FSubfamiliaModelo objSubfamiliaModelo = new FSubfamiliaModelo();
                objSubfamiliaModelo.FidSubfamiliaModelo = txtidSubfamiliaModelo.Text;
                objSubfamiliaModelo.FDesSubfamiliaModelos = txtDesSubfamiliaModelos.Text;
                objSubfamiliaModelo.RegistrarSubfamiliaModelo();
                MessageBox.Show("SubfamiliaModelo Registrado ");
                LimpiarForm();
                FillGrid();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
