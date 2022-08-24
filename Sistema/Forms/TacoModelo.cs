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
    public partial class TacoModelo : Form
    {
        public TacoModelo()
        {
            InitializeComponent();
        }

        private void btnbuscartaco_Click(object sender, EventArgs e)
        {
            try
            {
                FTacoModelo objFTacoModelo = new FTacoModelo();
                objFTacoModelo.FidTaco = txttaco.Text;
                objFTacoModelo.BuscarTaco();
                txtdestaco.Text = objFTacoModelo.FdesTaco;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnregistrartaco_Click(object sender, EventArgs e)
        {
            try
            {
                FTacoModelo objFTacoModelo = new FTacoModelo();
                objFTacoModelo.FidTaco = txttaco.Text;
                objFTacoModelo.FdesTaco = txtdestaco.Text;
                objFTacoModelo.RegistrarTaco();
                MessageBox.Show("Taco Registrado ");
                LimpiarForm();
                FillGrid();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnactualizartaco_Click(object sender, EventArgs e)
        {
            try
            {
                FTacoModelo objFTacoModelo = new FTacoModelo();
                objFTacoModelo.FidTaco = txttaco.Text;
                objFTacoModelo.FdesTaco = txtdestaco.Text;
                objFTacoModelo.ActualizarTaco();
                MessageBox.Show("Datos Actualizados ");
                LimpiarForm();
                FillGrid();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void TacoModelo_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void FillGrid()
        {
            try
            {
                FTacoModelo objFTacoModelo = new FTacoModelo();
                DGVTaco.DataSource = objFTacoModelo.ListarTaco();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LimpiarForm()
        {
            txttaco.Text = "";
            txtdestaco.Text = "";
            txttaco.Focus();
        }

        private void DGVHorma_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txttaco_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtdestaco_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
