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
    public partial class Horma : Form
    {
        public Horma()
        {
            InitializeComponent();
        }

        private void DGVHorma_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Horma_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void FillGrid()
        {
            try
            {
                FHorma objFHorma = new FHorma();
               DGVHorma.DataSource = objFHorma.ListarHorma();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LimpiarForm()
        {
            txthorma.Text = "";
            txtdeshorma.Text = "";
            txthorma.Focus();
        }

        private void RegistrarHorma_Click(object sender, EventArgs e)
        {
            try
            {
                FHorma objFHorma = new FHorma();
                objFHorma.FidHorma = txthorma.Text;
                objFHorma.FdescripcionHorma = txtdeshorma.Text;
                objFHorma.RegistrarHorma();
                MessageBox.Show("Horma Registrada ");
                LimpiarForm();
                FillGrid();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        private void btnactualizarhorma_Click(object sender, EventArgs e)
        {
            try
            {
                FHorma objFHorma = new FHorma();
                objFHorma.FidHorma = txthorma.Text;
                objFHorma.FdescripcionHorma = txtdeshorma.Text;
                objFHorma.ActualizarHorma();
                MessageBox.Show("Datos Actualizados ");
                LimpiarForm();
                FillGrid();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        private void btnbuscarhorma_Click(object sender, EventArgs e)
        {
            try
            {
                FHorma objHorma = new FHorma();
                objHorma.FidHorma = txthorma.Text;
                objHorma.BuscarHorma();
                txtdeshorma.Text = objHorma.FdescripcionHorma;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
