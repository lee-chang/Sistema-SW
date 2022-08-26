using FontAwesome.Sharp;
using Sistema;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            MenuPedidos.IsMainMenu = true;
            MenuProduccion.IsMainMenu = true;
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            LoadUserData();
        }

        private void LoadUserData()
        {

        }

        #region Funcionalidades del formulario
        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.panelContenedor.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas salir la aplicacion?", "Warning",
     MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            Application.Exit();
        }
        //Capturar posicion y tamaño antes de maximizar para restaurar
        int lx, ly;
        int sw, sh;
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }

        private void panelBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelformularios_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseas cerrar la aplicacion?", "Warning",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseas cerrar la aplicacion?", "Warning",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Quieres cerrar sesion?", "Warning",
MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            MenuPedidos.Show(BtnPedidos, BtnPedidos.Width, 0);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Sistema.Forms.Cliente());
        }


        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconPictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void BtnProduccion_Click(object sender, EventArgs e)
        {
            MenuProduccion.Show(BtnProduccion, BtnProduccion.Width, 0);
        }

        private void infToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevoModeloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Sistema.Forms.Modelo());
        }

        private void familiaModeloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Sistema.Forms.FamiliaModelo());
        }
        private void hormaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MenuProduccion_Opening(object sender, CancelEventArgs e)
        {

        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void hormaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Sistema.Forms.Horma());
        }

        private void tipoTacoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Sistema.Forms.TacoModelo());
        }

        private void tipoPuntaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Sistema.Forms.PuntaModelo());
        }

        private void cotizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Sistema.Forms.Cotizar());
        }

        private void subfamiliaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Sistema.Forms.SubfamiliaModelo());
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Sistema.Forms.Color());
        }

        private void tallaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Sistema.Forms.Talla());
        }

        private void coleccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Sistema.Forms.Coleccion());
        }
        #endregion
        //METODO PARA ABRIR FORMULARIOS DENTRO DEL PANEL
        private Form activeForm = null;
        private void OpenChildForm(Form ChildForm)
        {

            if (activeForm != null) { activeForm.Close(); }
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock= DockStyle.Fill;
            panelChildForm.Controls.Add(ChildForm);
            panelChildForm.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }
    }
}
