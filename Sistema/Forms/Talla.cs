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
    public partial class Talla : Form
    {
        public Talla()
        {
            InitializeComponent();
        }

        private void Talla_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void FillGrid()
        {
            try
            {
                FTalla objFTalla = new FTalla();
                DGVColor.DataSource = objFTalla.ListarTalla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LimpiarForm()
        {
            txttalla.Text = "";
            txtnumtalla.Text = "";
            txttalla.Focus();
        }

        private void DGVColor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnbuscartalla_Click(object sender, EventArgs e)
        {
            try
            {
                FTalla objFTalla = new FTalla();
                objFTalla.FidTalla = txttalla.Text;
                objFTalla.BuscarTalla();
                txtnumtalla.Text = objFTalla.FnumTalla;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnregistrartalla_Click(object sender, EventArgs e)
        {
            try
            {
                FTalla objFTalla = new FTalla();
                objFTalla.FidTalla = txttalla.Text;
                objFTalla.FnumTalla = txtnumtalla.Text;
                objFTalla.RegistrarTalla();
                MessageBox.Show("Talla Registrada ");
                LimpiarForm();
                FillGrid();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnactualizartalla_Click(object sender, EventArgs e)
        {
            try
            {
                FTalla objFTalla = new FTalla();
                objFTalla.FidTalla = txttalla.Text;
                objFTalla.FnumTalla = txtnumtalla.Text;
                objFTalla.ActualizarTalla();
                MessageBox.Show("Datos Actualizados ");
                LimpiarForm();
                FillGrid();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
    
}
