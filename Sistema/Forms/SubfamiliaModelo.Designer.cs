namespace Sistema.Forms
{
    partial class SubfamiliaModelo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.DGVSubfamiliaModelo = new System.Windows.Forms.DataGridView();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.txtDesSubfamiliaModelos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtidSubfamiliaModelo = new System.Windows.Forms.TextBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSubfamiliaModelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnRegistrar);
            this.groupBox1.Controls.Add(this.DGVSubfamiliaModelo);
            this.groupBox1.Controls.Add(this.BtnBuscar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BtnActualizar);
            this.groupBox1.Controls.Add(this.txtDesSubfamiliaModelos);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtidSubfamiliaModelo);
            this.groupBox1.Location = new System.Drawing.Point(13, 63);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(597, 374);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Subfamilia";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRegistrar.Location = new System.Drawing.Point(30, 328);
            this.BtnRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(100, 28);
            this.BtnRegistrar.TabIndex = 22;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // DGVSubfamiliaModelo
            // 
            this.DGVSubfamiliaModelo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVSubfamiliaModelo.Location = new System.Drawing.Point(30, 151);
            this.DGVSubfamiliaModelo.Margin = new System.Windows.Forms.Padding(4);
            this.DGVSubfamiliaModelo.Name = "DGVSubfamiliaModelo";
            this.DGVSubfamiliaModelo.RowHeadersWidth = 51;
            this.DGVSubfamiliaModelo.Size = new System.Drawing.Size(511, 154);
            this.DGVSubfamiliaModelo.TabIndex = 21;
            this.DGVSubfamiliaModelo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVSubfamiliaModelo_CellContentClick);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(441, 29);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(100, 28);
            this.BtnBuscar.TabIndex = 20;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descripcion";
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnActualizar.Location = new System.Drawing.Point(441, 328);
            this.BtnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(100, 28);
            this.BtnActualizar.TabIndex = 16;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // txtDesSubfamiliaModelos
            // 
            this.txtDesSubfamiliaModelos.Location = new System.Drawing.Point(168, 84);
            this.txtDesSubfamiliaModelos.Margin = new System.Windows.Forms.Padding(4);
            this.txtDesSubfamiliaModelos.Name = "txtDesSubfamiliaModelos";
            this.txtDesSubfamiliaModelos.Size = new System.Drawing.Size(373, 22);
            this.txtDesSubfamiliaModelos.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Codigo\r\nSubfamilia Modelo";
            // 
            // txtidSubfamiliaModelo
            // 
            this.txtidSubfamiliaModelo.Location = new System.Drawing.Point(168, 35);
            this.txtidSubfamiliaModelo.Margin = new System.Windows.Forms.Padding(4);
            this.txtidSubfamiliaModelo.Name = "txtidSubfamiliaModelo";
            this.txtidSubfamiliaModelo.Size = new System.Drawing.Size(213, 22);
            this.txtidSubfamiliaModelo.TabIndex = 11;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.iconPictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.X;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 30;
            this.iconPictureBox1.Location = new System.Drawing.Point(579, 13);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(31, 30);
            this.iconPictureBox1.TabIndex = 19;
            this.iconPictureBox1.TabStop = false;
            // 
            // SubfamiliaModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 450);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "SubfamiliaModelo";
            this.Text = "SubfamiliaModelo";
            this.Load += new System.EventHandler(this.SubfamiliaModelo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSubfamiliaModelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.TextBox txtDesSubfamiliaModelos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtidSubfamiliaModelo;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.DataGridView DGVSubfamiliaModelo;
        private System.Windows.Forms.Button BtnRegistrar;
    }
}