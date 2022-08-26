using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace Sistema.Forms
{
    public partial class Cotizar : Form
    {
        private int fila;
        private double stotal;
        private DataTable dt = new DataTable();

        DProducto objProd = new DProducto();

        public Cotizar()
        {
            InitializeComponent();
        }

        private void Cotizar_Load(object sender, EventArgs e)
        {
            fila = 0;
            stotal = 0;
        }


        private void iconCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtclientid_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
