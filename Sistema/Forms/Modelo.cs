﻿using Dominio;
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
    public partial class Modelo : Form
    {
        
        FModelo objFModelo = new FModelo();

        FHorma objFHorma = new FHorma();
        FPuntaModelo objFPuntaModelo = new FPuntaModelo();
        FTacoModelo objFTacoModelo = new FTacoModelo();
        FFamiliaModelo objFFamiliaModelo = new FFamiliaModelo();
        FSubfamiliaModelo objFSubfamiliaModelo = new FSubfamiliaModelo();

        public Modelo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                objFModelo.FidModelo = txtmodelo.Text;
                objFModelo.BuscarModelo();
                txtdesmodelo.Text = objFModelo.FdesModelo;
                comboBox1.SelectedValue = objFModelo.FidFam;
                comboBox2.SelectedValue = objFModelo.FidHorma;
                comboBox3.SelectedValue = objFModelo.FidPunta;
                comboBox4.SelectedValue = objFModelo.FidSubfam;
                comboBox5.SelectedValue = objFModelo.FidTaco;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Familia

        }

        public void CargarFamiliaModelo()
        {
            comboBox1.DisplayMember = "Nombfamilia";
            comboBox1.ValueMember = "FamiliamodeloID";
            comboBox1.DataSource = objFFamiliaModelo.ListarFamiliamodelos();
        }

        public void CargarHorma()
        {
            comboBox2.DisplayMember = "Descripcion";
            comboBox2.ValueMember = "HormaID";
            comboBox2.DataSource = objFHorma.ListarHorma();
        }

        public void CargarPunta()
        {
            comboBox3.DisplayMember = "Descripcion";
            comboBox3.ValueMember = "PuntamodeloID";
            comboBox3.DataSource = objFPuntaModelo.ListarPunta();
        }


        public void CargarTaco()
        {            
            comboBox5.DisplayMember = "Descripcion";
            comboBox5.ValueMember = "TacoModID";
            comboBox5.DataSource = objFTacoModelo.ListarTaco();
        }

        public void CargarSubFam()
        { 
            comboBox4.DisplayMember = "Descripcion";
            comboBox4.ValueMember = "SubfamiliamodID";
            comboBox4.DataSource = objFSubfamiliaModelo.ListarSubfamiliaModelos();
        }

    private void Modelo_Load(object sender, EventArgs e)
        {
            FillGrid();

            CargarFamiliaModelo();
            CargarSubFam();
            CargarHorma();
            CargarPunta();
            CargarTaco();

        }
        private void FillGrid()
        {
            try
            {
                DGVModelo.DataSource = objFModelo.ListarModelo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LimpiarForm()
        {
            txtmodelo.Text = "";
            txtdesmodelo.Text = "";
            txtmodelo.Focus();
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Punta
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Horma
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Taco
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            //SubFamilia
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                FModelo objFModelo = new FModelo();
                objFModelo.FidModelo = txtmodelo.Text;
                objFModelo.FdesModelo = txtdesmodelo.Text;
                objFModelo.FidFam = comboBox1.SelectedValue.ToString();
                objFModelo.FidHorma = comboBox2.SelectedValue.ToString();
                objFModelo.FidPunta = comboBox3.SelectedValue.ToString();
                objFModelo.FidSubfam = comboBox4.SelectedValue.ToString();
                objFModelo.FidTaco = comboBox5.SelectedValue.ToString();
                objFModelo.RegistrarModelo();
                MessageBox.Show("Modelo Registrado");
                LimpiarForm();
                FillGrid();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                FModelo objFModelo = new FModelo();
                objFModelo.FidModelo = txtmodelo.Text;
                objFModelo.FdesModelo = txtdesmodelo.Text;
                objFModelo.FidFam = comboBox1.SelectedValue.ToString();
                objFModelo.FidHorma = comboBox2.SelectedValue.ToString();
                objFModelo.FidPunta = comboBox3.SelectedValue.ToString();
                objFModelo.FidSubfam = comboBox4.SelectedValue.ToString();
                objFModelo.FidTaco = comboBox5.SelectedValue.ToString();
                objFModelo.ActualizarModelo();
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
