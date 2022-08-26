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
    public partial class Color : Form
    {
        public Color()
        {
            InitializeComponent();
        }

        private void Color_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void FillGrid()
        {
            try
            {
                FColor objFColor = new FColor();
                DGVColor.DataSource = objFColor.ListarColor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LimpiarForm()
        {
            txtcolor.Text = "";
            txtnomcolor.Text = "";
            txtcolor.Focus();
        }

        private void btnbuscarcolor_Click(object sender, EventArgs e)
        {
            try
            {
                FColor objColor = new FColor();
                objColor.FidColor = txtcolor.Text;
                objColor.BuscarColor();
                txtnomcolor.Text = objColor.FnomColor;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnregistrarcolor_Click(object sender, EventArgs e)
        {
            try
            {
                FColor objFColor = new FColor();
                objFColor.FidColor = txtcolor.Text;
                objFColor.FnomColor = txtnomcolor.Text;
                objFColor.RegistrarColor();
                MessageBox.Show("Color Registrado ");
                LimpiarForm();
                FillGrid();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnactualizarcolor_Click(object sender, EventArgs e)
        {
            try
            {
                FColor objFColor = new FColor();
                objFColor.FidColor = txtcolor.Text;
                objFColor.FnomColor = txtnomcolor.Text;
                objFColor.ActualizarColor();
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
