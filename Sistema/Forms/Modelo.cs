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
        public Modelo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

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

        private void Modelo_Load(object sender, EventArgs e)
        {
            FHorma objFHorma = new FHorma();
            FPuntaModelo objFPuntaModelo = new FPuntaModelo();
            FTacoModelo objFTacoModelo = new FTacoModelo();
            FFamiliaModelo objFFamiliaModelo = new FFamiliaModelo();
            FSubfamiliaModelo objFSubfamiliaModelo = new FSubfamiliaModelo();
            comboBox2.DataSource = objFHorma.ListarHorma();
            comboBox2.DisplayMember = "HormaID";
            comboBox2.ValueMember = "HormaID";


            comboBox3.DataSource = objFPuntaModelo.ListarPunta();
            comboBox3.DisplayMember = "PuntamodeloID";
            comboBox3.ValueMember = "PuntamodeloID";


            comboBox5.DataSource = objFTacoModelo.ListarTaco();
            comboBox5.DisplayMember = "TacoModID";
            comboBox5.ValueMember = "TacoModID";

            comboBox4.DataSource = objFSubfamiliaModelo.ListarSubfamiliaModelos();
            comboBox4.DisplayMember = "SubfamiliamodID";
            comboBox4.ValueMember = "SubfamiliamodID";

            comboBox1.DataSource = objFFamiliaModelo.ListarFamiliamodelos();
            comboBox1.DisplayMember = "FamiliamodeloID";
            comboBox1.ValueMember = "FamiliamodeloID";
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
    }
}
