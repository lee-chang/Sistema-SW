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
            ((System.ComponentModel.ISupportInitialize)(this.DGVHorma)).BeginInit();
            this.SuspendLayout();
            // 
            // txthorma
            // 
            this.txthorma.Location = new System.Drawing.Point(236, 57);
            this.txthorma.Name = "txthorma";
            this.txthorma.Size = new System.Drawing.Size(259, 20);
            this.txthorma.TabIndex = 0;
            // 
            // txtdeshorma
            // 
            this.txtdeshorma.Location = new System.Drawing.Point(236, 104);
            this.txtdeshorma.Name = "txtdeshorma";
            this.txtdeshorma.Size = new System.Drawing.Size(259, 20);
            this.txtdeshorma.TabIndex = 1;
            // 
            // DGVHorma
            // 
            this.DGVHorma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVHorma.Location = new System.Drawing.Point(156, 157);
            this.DGVHorma.Name = "DGVHorma";
            this.DGVHorma.Size = new System.Drawing.Size(475, 213);
            this.DGVHorma.TabIndex = 2;
            this.DGVHorma.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVHorma_CellContentClick);
            // 
            // RegistrarHorma
            // 
            this.RegistrarHorma.Location = new System.Drawing.Point(236, 392);
            this.RegistrarHorma.Name = "RegistrarHorma";
            this.RegistrarHorma.Size = new System.Drawing.Size(115, 30);
            this.RegistrarHorma.TabIndex = 3;
            this.RegistrarHorma.Text = "Registrar";
            this.RegistrarHorma.UseVisualStyleBackColor = true;
            this.RegistrarHorma.Click += new System.EventHandler(this.RegistrarHorma_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Codigo Horma";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descripcion Horma";
            // 
            // btnactualizarhorma
            // 
            this.btnactualizarhorma.Location = new System.Drawing.Point(440, 392);
            this.btnactualizarhorma.Name = "btnactualizarhorma";
            this.btnactualizarhorma.Size = new System.Drawing.Size(115, 30);
            this.btnactualizarhorma.TabIndex = 6;
            this.btnactualizarhorma.Text = "Actualizar";
            this.btnactualizarhorma.UseVisualStyleBackColor = true;
            this.btnactualizarhorma.Click += new System.EventHandler(this.btnactualizarhorma_Click);
            // 
            // btnbuscarhorma
            // 
            this.btnbuscarhorma.Location = new System.Drawing.Point(516, 72);
            this.btnbuscarhorma.Name = "btnbuscarhorma";
            this.btnbuscarhorma.Size = new System.Drawing.Size(115, 30);
            this.btnbuscarhorma.TabIndex = 7;
            this.btnbuscarhorma.Text = "Buscar";
            this.btnbuscarhorma.UseVisualStyleBackColor = true;
            this.btnbuscarhorma.Click += new System.EventHandler(this.btnbuscarhorma_Click);
            // 
            // Horma
            // 
            this.ClientSize = new System.Drawing.Size(867, 471);
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
    }
}