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
    public partial class Producto : Form
    {
        FProducto objFProducto = new FProducto();
        FTalla objFTalla = new FTalla();
        FColeccion objFColeccion = new FColeccion();
        FColor objFColor = new FColor();
        FModelo objFModelo = new FModelo();

        public Producto()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                objFProducto.FidProducto = txtidProducto.Text;
                objFProducto.BuscarProducto();
                txtDesProducto.Text = objFProducto.FdesProducto;

                //float precio = objFProducto.FPrecioventa;
                txtpventa.Text = objFProducto.FPrecioventa;     
                cbxTalla.SelectedValue = objFProducto.FidTalla;
                cbxColec.SelectedValue = objFProducto.FidColeccion;
                cbxColor.SelectedValue = objFProducto.FidColor;
                cbxMod.SelectedValue = objFProducto.FidModelo;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        private void Producto_Load(object sender, EventArgs e)
        {
            FillGrid();

            CargarModelo();
            CargarTalla();
            CargarColeccion();
            CargarColor();

        }

        private void FillGrid()
        {
            try
            {
                DGVProducto.DataSource = objFProducto.ListarProducto();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void CargarTalla()
        {
            cbxTalla.DataSource = objFTalla.ListarTalla();
            cbxTalla.DisplayMember = "Numero";
            cbxTalla.ValueMember = "TallaID";


        }

        public void CargarColeccion()
        {
            cbxColec.DataSource = objFColeccion.ListarCol();
            cbxColec.DisplayMember = "Nombrecoleccion";
            cbxColec.ValueMember = "ColeccionID";
            
        }


        public void CargarColor()
        {
            cbxColor.DataSource = objFColor.ListarColor();
            cbxColor.DisplayMember = "Nombcolor";
            cbxColor.ValueMember = "ColorID";
        }

        public void CargarModelo()
        {
            cbxMod.DataSource = objFModelo.ListarModelo();
            cbxMod.DisplayMember = "Descripcion";
            cbxMod.ValueMember = "ModeloID";
        }

        private void LimpiarForm()
        {
            txtidProducto.Text = "";
            txtDesProducto.Text = "";
            txtpventa.Text = "";
            txtidProducto.Focus();
        }


        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                FProducto objFProducto = new FProducto();
                objFProducto.FidProducto = txtidProducto.Text;
                objFProducto.FdesProducto = txtDesProducto.Text;
                //float precio;
                //string precioventa = txtpventa.Text;
                //precio = float.Parse(precioventa);
                //objFProducto.FPrecioventa = precio;
                objFProducto.FPrecioventa = txtpventa.Text;
                objFProducto.FidTalla = cbxTalla.SelectedValue.ToString();
                objFProducto.FidColeccion = cbxColec.SelectedValue.ToString();
                objFProducto.FidColor = cbxColor.SelectedValue.ToString();
                objFProducto.FidModelo = cbxMod.SelectedValue.ToString();
                objFProducto.ActualizarProducto();
                MessageBox.Show("Datos Actualizados ");
                LimpiarForm();
                FillGrid();
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
                FProducto objFProducto = new FProducto();
                objFProducto.FidProducto = txtidProducto.Text;
                objFProducto.FdesProducto = txtDesProducto.Text;
                //float precio;
                //string precioventa = txtpventa.Text;
                //precio = float.Parse(precioventa);
                //objFProducto.FPrecioventa =precio;
                objFProducto.FPrecioventa = txtpventa.Text;
                objFProducto.FidTalla = cbxTalla.SelectedValue.ToString();
                objFProducto.FidColeccion = cbxColec.SelectedValue.ToString();
                objFProducto.FidColor = cbxColor.SelectedValue.ToString();
                objFProducto.FidModelo = cbxMod.SelectedValue.ToString();
                objFProducto.RegistrarProducto();
                MessageBox.Show("Producto Registrado");
                LimpiarForm();
                FillGrid();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        private void txtidProducto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
