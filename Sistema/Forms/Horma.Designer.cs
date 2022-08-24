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
            this.RegistrarHorma.Location = new System.Drawing.Point(374, 390);
            this.RegistrarHorma.Name = "RegistrarHorma";
            this.RegistrarHorma.Size = new System.Drawing.Size(75, 23);
            this.RegistrarHorma.TabIndex = 3;
            this.RegistrarHorma.Text = "Registrar";
            this.RegistrarHorma.UseVisualStyleBackColor = true;
            this.RegistrarHorma.Click += new System.EventHandler(this.RegistrarHorma_Click);
            // 
            // Horma
            // 
            this.ClientSize = new System.Drawing.Size(867, 471);
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
    }
}