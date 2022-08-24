namespace Presentacion
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.BtnReportes = new FontAwesome.Sharp.IconButton();
            this.BtnAlmacenProductos = new FontAwesome.Sharp.IconButton();
            this.BtnEnvios = new FontAwesome.Sharp.IconButton();
            this.BtnProduccion = new FontAwesome.Sharp.IconButton();
            this.BtnPedidos = new FontAwesome.Sharp.IconButton();
            this.BtnAlmacenMat = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconBtnLogout = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.MenuPedidos = new Presentacion.RJControls.RJDropdownMenu(this.components);
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cotizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprobanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProduccion = new Presentacion.RJControls.RJDropdownMenu(this.components);
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoModeloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.familiaModeloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subfamiliaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoPuntaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoTacoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hormaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tallaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coleccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelContenedor.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.MenuPedidos.SuspendLayout();
            this.MenuProduccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelContenedor.Controls.Add(this.panelChildForm);
            this.panelContenedor.Controls.Add(this.panelMenu);
            this.panelContenedor.Controls.Add(this.panelBarraTitulo);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Margin = new System.Windows.Forms.Padding(2);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1206, 700);
            this.panelContenedor.TabIndex = 0;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelChildForm.Controls.Add(this.pictureBox1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(260, 32);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(946, 668);
            this.panelChildForm.TabIndex = 2;
            this.panelChildForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChildForm_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Sistema.Properties.Resources.favicon;
            this.pictureBox1.Location = new System.Drawing.Point(367, 208);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 228);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.panelMenu.Controls.Add(this.BtnReportes);
            this.panelMenu.Controls.Add(this.BtnAlmacenProductos);
            this.panelMenu.Controls.Add(this.BtnEnvios);
            this.panelMenu.Controls.Add(this.BtnProduccion);
            this.panelMenu.Controls.Add(this.BtnPedidos);
            this.panelMenu.Controls.Add(this.BtnAlmacenMat);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 32);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(260, 668);
            this.panelMenu.TabIndex = 1;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // BtnReportes
            // 
            this.BtnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReportes.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.BtnReportes.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.BtnReportes.IconColor = System.Drawing.SystemColors.ControlLight;
            this.BtnReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnReportes.IconSize = 40;
            this.BtnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReportes.Location = new System.Drawing.Point(2, 408);
            this.BtnReportes.Margin = new System.Windows.Forms.Padding(2);
            this.BtnReportes.Name = "BtnReportes";
            this.BtnReportes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnReportes.Size = new System.Drawing.Size(258, 54);
            this.BtnReportes.TabIndex = 12;
            this.BtnReportes.Text = "Reportes";
            this.BtnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnReportes.UseVisualStyleBackColor = true;
            // 
            // BtnAlmacenProductos
            // 
            this.BtnAlmacenProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAlmacenProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAlmacenProductos.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.BtnAlmacenProductos.IconChar = FontAwesome.Sharp.IconChar.ShoePrints;
            this.BtnAlmacenProductos.IconColor = System.Drawing.SystemColors.ControlLight;
            this.BtnAlmacenProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAlmacenProductos.IconSize = 40;
            this.BtnAlmacenProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAlmacenProductos.Location = new System.Drawing.Point(2, 234);
            this.BtnAlmacenProductos.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAlmacenProductos.Name = "BtnAlmacenProductos";
            this.BtnAlmacenProductos.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnAlmacenProductos.Size = new System.Drawing.Size(258, 54);
            this.BtnAlmacenProductos.TabIndex = 10;
            this.BtnAlmacenProductos.Text = "Almacen Productos";
            this.BtnAlmacenProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAlmacenProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAlmacenProductos.UseVisualStyleBackColor = true;
            // 
            // BtnEnvios
            // 
            this.BtnEnvios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEnvios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEnvios.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.BtnEnvios.IconChar = FontAwesome.Sharp.IconChar.TruckFast;
            this.BtnEnvios.IconColor = System.Drawing.SystemColors.ControlLight;
            this.BtnEnvios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEnvios.IconSize = 40;
            this.BtnEnvios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEnvios.Location = new System.Drawing.Point(2, 350);
            this.BtnEnvios.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEnvios.Name = "BtnEnvios";
            this.BtnEnvios.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnEnvios.Size = new System.Drawing.Size(258, 54);
            this.BtnEnvios.TabIndex = 9;
            this.BtnEnvios.Text = "Envios";
            this.BtnEnvios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEnvios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEnvios.UseVisualStyleBackColor = true;
            // 
            // BtnProduccion
            // 
            this.BtnProduccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProduccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProduccion.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.BtnProduccion.IconChar = FontAwesome.Sharp.IconChar.Industry;
            this.BtnProduccion.IconColor = System.Drawing.SystemColors.ControlLight;
            this.BtnProduccion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnProduccion.IconSize = 40;
            this.BtnProduccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProduccion.Location = new System.Drawing.Point(2, 292);
            this.BtnProduccion.Margin = new System.Windows.Forms.Padding(2);
            this.BtnProduccion.Name = "BtnProduccion";
            this.BtnProduccion.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnProduccion.Size = new System.Drawing.Size(258, 54);
            this.BtnProduccion.TabIndex = 8;
            this.BtnProduccion.Text = "Produccion";
            this.BtnProduccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProduccion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnProduccion.UseVisualStyleBackColor = true;
            this.BtnProduccion.Click += new System.EventHandler(this.BtnProduccion_Click);
            // 
            // BtnPedidos
            // 
            this.BtnPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPedidos.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.BtnPedidos.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.BtnPedidos.IconColor = System.Drawing.SystemColors.ControlLight;
            this.BtnPedidos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnPedidos.IconSize = 40;
            this.BtnPedidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPedidos.Location = new System.Drawing.Point(2, 118);
            this.BtnPedidos.Margin = new System.Windows.Forms.Padding(2);
            this.BtnPedidos.Name = "BtnPedidos";
            this.BtnPedidos.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnPedidos.Size = new System.Drawing.Size(258, 54);
            this.BtnPedidos.TabIndex = 7;
            this.BtnPedidos.Text = "Pedidos";
            this.BtnPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPedidos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPedidos.UseVisualStyleBackColor = true;
            this.BtnPedidos.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // BtnAlmacenMat
            // 
            this.BtnAlmacenMat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAlmacenMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAlmacenMat.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.BtnAlmacenMat.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            this.BtnAlmacenMat.IconColor = System.Drawing.SystemColors.ControlLight;
            this.BtnAlmacenMat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAlmacenMat.IconSize = 40;
            this.BtnAlmacenMat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAlmacenMat.Location = new System.Drawing.Point(2, 176);
            this.BtnAlmacenMat.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAlmacenMat.Name = "BtnAlmacenMat";
            this.BtnAlmacenMat.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnAlmacenMat.Size = new System.Drawing.Size(258, 54);
            this.BtnAlmacenMat.TabIndex = 6;
            this.BtnAlmacenMat.Text = "Almacen Materiales";
            this.BtnAlmacenMat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAlmacenMat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAlmacenMat.UseVisualStyleBackColor = true;
            this.BtnAlmacenMat.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.iconBtnLogout);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 619);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 49);
            this.panel2.TabIndex = 5;
            // 
            // iconBtnLogout
            // 
            this.iconBtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnLogout.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.iconBtnLogout.IconChar = FontAwesome.Sharp.IconChar.ArrowUpFromBracket;
            this.iconBtnLogout.IconColor = System.Drawing.SystemColors.ControlLight;
            this.iconBtnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnLogout.IconSize = 35;
            this.iconBtnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnLogout.Location = new System.Drawing.Point(2, 2);
            this.iconBtnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.iconBtnLogout.Name = "iconBtnLogout";
            this.iconBtnLogout.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconBtnLogout.Rotation = 90D;
            this.iconBtnLogout.Size = new System.Drawing.Size(258, 46);
            this.iconBtnLogout.TabIndex = 11;
            this.iconBtnLogout.Text = "Cerrar Sesión";
            this.iconBtnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnLogout.UseVisualStyleBackColor = true;
            this.iconBtnLogout.Click += new System.EventHandler(this.iconButton6_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 114);
            this.panel1.TabIndex = 4;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.iconPictureBox1.BackgroundImage = global::Sistema.Properties.Resources.zicca1;
            this.iconPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.iconPictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 114;
            this.iconPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(260, 114);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click_1);
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.panelBarraTitulo.Controls.Add(this.title);
            this.panelBarraTitulo.Controls.Add(this.btnRestaurar);
            this.panelBarraTitulo.Controls.Add(this.btnMinimizar);
            this.panelBarraTitulo.Controls.Add(this.btnMaximizar);
            this.panelBarraTitulo.Controls.Add(this.btnCerrar);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarraTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(1206, 32);
            this.panelBarraTitulo.TabIndex = 0;
            this.panelBarraTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBarraTitulo_MouseMove);
            // 
            // title
            // 
            this.title.Dock = System.Windows.Forms.DockStyle.Left;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Margin = new System.Windows.Forms.Padding(0);
            this.title.Name = "title";
            this.title.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.title.Size = new System.Drawing.Size(276, 32);
            this.title.TabIndex = 4;
            this.title.Text = "SISTEMA DE GESTION ZICCA";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(1168, 9);
            this.btnRestaurar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(12, 13);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 3;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1152, 9);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(12, 13);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(1168, 9);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(12, 13);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1184, 9);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(12, 13);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // MenuPedidos
            // 
            this.MenuPedidos.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuPedidos.IsMainMenu = false;
            this.MenuPedidos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.cotizarToolStripMenuItem,
            this.comprobanteToolStripMenuItem});
            this.MenuPedidos.MenuItemHeight = 25;
            this.MenuPedidos.MenuItemTextColor = System.Drawing.Color.Empty;
            this.MenuPedidos.Name = "MenuPedidos";
            this.MenuPedidos.PrimaryColor = System.Drawing.Color.Empty;
            this.MenuPedidos.Size = new System.Drawing.Size(149, 70);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // cotizarToolStripMenuItem
            // 
            this.cotizarToolStripMenuItem.Name = "cotizarToolStripMenuItem";
            this.cotizarToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.cotizarToolStripMenuItem.Text = "Cotizar";
            // 
            // comprobanteToolStripMenuItem
            // 
            this.comprobanteToolStripMenuItem.Name = "comprobanteToolStripMenuItem";
            this.comprobanteToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.comprobanteToolStripMenuItem.Text = "Comprobante";
            // 
            // MenuProduccion
            // 
            this.MenuProduccion.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuProduccion.IsMainMenu = false;
            this.MenuProduccion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productoToolStripMenuItem});
            this.MenuProduccion.MenuItemHeight = 25;
            this.MenuProduccion.MenuItemTextColor = System.Drawing.Color.Empty;
            this.MenuProduccion.Name = "MenuProduccion";
            this.MenuProduccion.PrimaryColor = System.Drawing.Color.Empty;
            this.MenuProduccion.Size = new System.Drawing.Size(181, 48);
            this.MenuProduccion.Opening += new System.ComponentModel.CancelEventHandler(this.MenuProduccion_Opening);
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.modelosToolStripMenuItem,
            this.tallaToolStripMenuItem,
            this.coleccionToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.productoToolStripMenuItem.Text = "Productos";
            this.productoToolStripMenuItem.Click += new System.EventHandler(this.productoToolStripMenuItem_Click);
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo Producto";
            // 
            // modelosToolStripMenuItem
            // 
            this.modelosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoModeloToolStripMenuItem,
            this.familiaModeloToolStripMenuItem,
            this.subfamiliaToolStripMenuItem,
            this.tipoPuntaToolStripMenuItem,
            this.tipoTacoToolStripMenuItem,
            this.hormaToolStripMenuItem});
            this.modelosToolStripMenuItem.Name = "modelosToolStripMenuItem";
            this.modelosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modelosToolStripMenuItem.Text = "Modelos";
            // 
            // nuevoModeloToolStripMenuItem
            // 
            this.nuevoModeloToolStripMenuItem.Name = "nuevoModeloToolStripMenuItem";
            this.nuevoModeloToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoModeloToolStripMenuItem.Text = "Nuevo Modelo";
            this.nuevoModeloToolStripMenuItem.Click += new System.EventHandler(this.nuevoModeloToolStripMenuItem_Click);
            // 
            // familiaModeloToolStripMenuItem
            // 
            this.familiaModeloToolStripMenuItem.Name = "familiaModeloToolStripMenuItem";
            this.familiaModeloToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.familiaModeloToolStripMenuItem.Text = "Familia";
            this.familiaModeloToolStripMenuItem.Click += new System.EventHandler(this.familiaModeloToolStripMenuItem_Click);
            // 
            // subfamiliaToolStripMenuItem
            // 
            this.subfamiliaToolStripMenuItem.Name = "subfamiliaToolStripMenuItem";
            this.subfamiliaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.subfamiliaToolStripMenuItem.Text = "Subfamilia";
            // 
            // tipoPuntaToolStripMenuItem
            // 
            this.tipoPuntaToolStripMenuItem.Name = "tipoPuntaToolStripMenuItem";
            this.tipoPuntaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tipoPuntaToolStripMenuItem.Text = "Tipo Punta";
            // 
            // tipoTacoToolStripMenuItem
            // 
            this.tipoTacoToolStripMenuItem.Name = "tipoTacoToolStripMenuItem";
            this.tipoTacoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tipoTacoToolStripMenuItem.Text = "Tipo Taco";
            this.tipoTacoToolStripMenuItem.Click += new System.EventHandler(this.tipoTacoToolStripMenuItem_Click);
            // 
            // hormaToolStripMenuItem
            // 
            this.hormaToolStripMenuItem.Name = "hormaToolStripMenuItem";
            this.hormaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hormaToolStripMenuItem.Text = "Horma";
            this.hormaToolStripMenuItem.Click += new System.EventHandler(this.hormaToolStripMenuItem_Click_1);
            // 
            // tallaToolStripMenuItem
            // 
            this.tallaToolStripMenuItem.Name = "tallaToolStripMenuItem";
            this.tallaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tallaToolStripMenuItem.Text = "Talla";
            // 
            // coleccionToolStripMenuItem
            // 
            this.coleccionToolStripMenuItem.Name = "coleccionToolStripMenuItem";
            this.coleccionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.coleccionToolStripMenuItem.Text = "Coleccion";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 700);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.panelContenedor.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panelBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.MenuPedidos.ResumeLayout(false);
            this.MenuProduccion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton BtnAlmacenMat;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton BtnProduccion;
        private FontAwesome.Sharp.IconButton BtnPedidos;
        private FontAwesome.Sharp.IconButton BtnReportes;
        private FontAwesome.Sharp.IconButton iconBtnLogout;
        private FontAwesome.Sharp.IconButton BtnAlmacenProductos;
        private FontAwesome.Sharp.IconButton BtnEnvios;
        private RJControls.RJDropdownMenu MenuPedidos;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cotizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprobanteToolStripMenuItem;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private RJControls.RJDropdownMenu MenuProduccion;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modelosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoModeloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem familiaModeloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subfamiliaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoPuntaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoTacoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hormaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tallaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coleccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
    }
}

