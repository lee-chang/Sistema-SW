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
    public partial class Coleccion : Form
    {
        public Coleccion()
        {
            InitializeComponent();
        }

        private void Coleccion_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void FillGrid()
        {
            try
            {
                FColeccion objFColeccion = new FColeccion();
                DGVColeccion.DataSource = objFColeccion.ListarCol();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LimpiarForm()
        {
            txtcoleccion.Text = "";
            txtnomcoleccion.Text = "";
            txtcoleccion.Focus();
        }

        private void btnbuscarcol_Click(object sender, EventArgs e)
        {
            try
            {
                FColeccion objFColeccion = new FColeccion();
                objFColeccion.FidCol = txtcoleccion.Text;
                objFColeccion.BuscarCol();
                txtnomcoleccion.Text = objFColeccion.FnomCol;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnregistrarcol_Click(object sender, EventArgs e)
        {
            try
            {
                FColeccion objFColeccion = new FColeccion();
                objFColeccion.FidCol = txtcoleccion.Text;
                objFColeccion.FnomCol = txtnomcoleccion.Text;
                objFColeccion.RegistrarCol();
                MessageBox.Show("Coleccion Registrada ");
                LimpiarForm();
                FillGrid();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnactualizarcol_Click(object sender, EventArgs e)
        {
            try
            {
                FColeccion objFColeccion = new FColeccion();
                objFColeccion.FidCol = txtcoleccion.Text;
                objFColeccion.FnomCol = txtnomcoleccion.Text;
                objFColeccion.ActualizarCol();
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
