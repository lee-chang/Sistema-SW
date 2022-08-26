namespace Sistema.Forms
{
    partial class Horma
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
            this.txthorma = new System.Windows.Forms.TextBox();
            this.txtdeshorma = new System.Windows.Forms.TextBox();
            this.DGVHorma = new System.Windows.Forms.DataGridView();
            this.RegistrarHorma = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnactualizarhorma = new System.Windows.Forms.Button();
            this.btnbuscarhorma = new System.Windows.Forms.Button();
            this.iconCerrar = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVHorma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // txthorma
            // 
            this.txthorma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthorma.Location = new System.Drawing.Point(326, 120);
            this.txthorma.Name = "txthorma";
            this.txthorma.Size = new System.Drawing.Size(400, 22);
            this.txthorma.TabIndex = 0;
            this.txthorma.TextChanged += new System.EventHandler(this.txthorma_TextChanged);
            // 
            // txtdeshorma
            // 
            this.txtdeshorma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdeshorma.Location = new System.Drawing.Point(326, 163);
            this.txtdeshorma.Name = "txtdeshorma";
            this.txtdeshorma.Size = new System.Drawing.Size(400, 22);
            this.txtdeshorma.TabIndex = 1;
            this.txtdeshorma.TextChanged += new System.EventHandler(this.txtdeshorma_TextChanged);
            // 
            // DGVHorma
            // 
            this.DGVHorma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVHorma.Location = new System.Drawing.Point(93, 233);
            this.DGVHorma.Name = "DGVHorma";
            this.DGVHorma.RowHeadersWidth = 51;
            this.DGVHorma.Size = new System.Drawing.Size(835, 249);
            this.DGVHorma.TabIndex = 2;
            this.DGVHorma.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVHorma_CellContentClick);
            // 
            // RegistrarHorma
            // 
            this.RegistrarHorma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrarHorma.Location = new System.Drawing.Point(276, 534);
            this.RegistrarHorma.Name = "RegistrarHorma";
            this.RegistrarHorma.Size = new System.Drawing.Size(123, 57);
            this.RegistrarHorma.TabIndex = 3;
            this.RegistrarHorma.Text = "Registrar";
            this.RegistrarHorma.UseVisualStyleBackColor = true;
            this.RegistrarHorma.Click += new System.EventHandler(this.RegistrarHorma_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Codigo Horma";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descripcion Horma";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnactualizarhorma
            // 
            this.btnactualizarhorma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualizarhorma.Location = new System.Drawing.Point(660, 534);
            this.btnactualizarhorma.Name = "btnactualizarhorma";
            this.btnactualizarhorma.Size = new System.Drawing.Size(123, 57);
            this.btnactualizarhorma.TabIndex = 6;
            this.btnactualizarhorma.Text = "Actualizar";
            this.btnactualizarhorma.UseVisualStyleBackColor = true;
            this.btnactualizarhorma.Click += new System.EventHandler(this.btnactualizarhorma_Click);
            // 
            // btnbuscarhorma
            // 
            this.btnbuscarhorma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscarhorma.Location = new System.Drawing.Point(839, 120);
            this.btnbuscarhorma.Name = "btnbuscarhorma";
            this.btnbuscarhorma.Size = new System.Drawing.Size(123, 57);
            this.btnbuscarhorma.TabIndex = 7;
            this.btnbuscarhorma.Text = "Buscar";
            this.btnbuscarhorma.UseVisualStyleBackColor = true;
            this.btnbuscarhorma.Click += new System.EventHandler(this.btnbuscarhorma_Click);
            // 
            // iconCerrar
            // 
            this.iconCerrar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.iconCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconCerrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconCerrar.IconChar = FontAwesome.Sharp.IconChar.X;
            this.iconCerrar.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCerrar.IconSize = 24;
            this.iconCerrar.Location = new System.Drawing.Point(36, 25);
            this.iconCerrar.Name = "iconCerrar";
            this.iconCerrar.Size = new System.Drawing.Size(24, 24);
            this.iconCerrar.TabIndex = 32;
            this.iconCerrar.TabStop = false;
            this.iconCerrar.Click += new System.EventHandler(this.iconCerrar_Click);
            // 
            // Horma
            // 
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1058, 724);
            this.Controls.Add(this.iconCerrar);
            this.Controls.Add(this.btnbuscarhorma);
            this.Controls.Add(this.btnactualizarhorma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RegistrarHorma);
            this.Controls.Add(this.DGVHorma);
            this.Controls.Add(this.txtdeshorma);
            this.Controls.Add(this.txthorma);
            this.Name = "Horma";
            this.Load += new System.EventHandler(this.Horma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVHorma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txthorma;
        private System.Windows.Forms.TextBox txtdeshorma;
        private System.Windows.Forms.DataGridView DGVHorma;
        private System.Windows.Forms.Button RegistrarHorma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnactualizarhorma;
        private System.Windows.Forms.Button btnbuscarhorma;
        private FontAwesome.Sharp.IconPictureBox iconCerrar;
    }
}