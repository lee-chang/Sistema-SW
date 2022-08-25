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
    public partial class PuntaModelo : Form
    {
        public PuntaModelo()
        {
            InitializeComponent();
        }

        private void btnbuscarpunta_Click(object sender, EventArgs e)
        {
            try
            {
                FPuntaModelo objFPuntaModelo = new FPuntaModelo();
                objFPuntaModelo.FidPunta = txtpunta.Text;
                objFPuntaModelo.BuscarPunta();
                txtdespunta.Text = objFPuntaModelo.FdesPunta;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnregistrarpunta_Click(object sender, EventArgs e)
        {
            try
            {
                FPuntaModelo objFPuntaModelo = new FPuntaModelo();
                objFPuntaModelo.FidPunta = txtpunta.Text;
                objFPuntaModelo.FdesPunta = txtdespunta.Text;
                objFPuntaModelo.RegistrarPunta();
                MessageBox.Show("Punta Registrada ");
                LimpiarForm();
                FillGrid();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnactualizarpunta_Click(object sender, EventArgs e)
        {
            try
            {
                FPuntaModelo objFPuntaModelo = new FPuntaModelo();
                objFPuntaModelo.FidPunta = txtpunta.Text;
                objFPuntaModelo.FdesPunta = txtdespunta.Text;
                objFPuntaModelo.ActualizarPunta();
                MessageBox.Show("Datos Actualizados ");
                LimpiarForm();
                FillGrid();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void PuntaModelo_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void FillGrid()
        {
            try
            {
                FPuntaModelo objFPuntaModelo = new FPuntaModelo();
                DGVPunta.DataSource = objFPuntaModelo.ListarPunta();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LimpiarForm()
        {
            txtpunta.Text = "";
            txtdespunta.Text = "";
            txtpunta.Focus();
        }
        private void DGVPunta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtpunta_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdespunta_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
