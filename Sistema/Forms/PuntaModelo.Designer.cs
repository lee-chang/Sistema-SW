namespace Sistema.Forms
{
    partial class PuntaModelo
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
            this.btnbuscarpunta = new System.Windows.Forms.Button();
            this.btnactualizarpunta = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnregistrarpunta = new System.Windows.Forms.Button();
            this.DGVPunta = new System.Windows.Forms.DataGridView();
            this.txtdespunta = new System.Windows.Forms.TextBox();
            this.txtpunta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPunta)).BeginInit();
            this.SuspendLayout();
            // 
            // btnbuscarpunta
            // 
            this.btnbuscarpunta.Location = new System.Drawing.Point(510, 52);
            this.btnbuscarpunta.Name = "btnbuscarpunta";
            this.btnbuscarpunta.Size = new System.Drawing.Size(115, 30);
            this.btnbuscarpunta.TabIndex = 23;
            this.btnbuscarpunta.Text = "Buscar";
            this.btnbuscarpunta.UseVisualStyleBackColor = true;
            this.btnbuscarpunta.Click += new System.EventHandler(this.btnbuscarpunta_Click);
            // 
            // btnactualizarpunta
            // 
            this.btnactualizarpunta.Location = new System.Drawing.Point(434, 372);
            this.btnactualizarpunta.Name = "btnactualizarpunta";
            this.btnactualizarpunta.Size = new System.Drawing.Size(115, 30);
            this.btnactualizarpunta.TabIndex = 22;
            this.btnactualizarpunta.Text = "Actualizar";
            this.btnactualizarpunta.UseVisualStyleBackColor = true;
            this.btnactualizarpunta.Click += new System.EventHandler(this.btnactualizarpunta_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Descripcion Punta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Codigo Punta";
            // 
            // btnregistrarpunta
            // 
            this.btnregistrarpunta.Location = new System.Drawing.Point(230, 372);
            this.btnregistrarpunta.Name = "btnregistrarpunta";
            this.btnregistrarpunta.Size = new System.Drawing.Size(115, 30);
            this.btnregistrarpunta.TabIndex = 19;
            this.btnregistrarpunta.Text = "Registrar";
            this.btnregistrarpunta.UseVisualStyleBackColor = true;
            this.btnregistrarpunta.Click += new System.EventHandler(this.btnregistrarpunta_Click);
            // 
            // DGVPunta
            // 
            this.DGVPunta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPunta.Location = new System.Drawing.Point(150, 137);
            this.DGVPunta.Name = "DGVPunta";
            this.DGVPunta.Size = new System.Drawing.Size(475, 213);
            this.DGVPunta.TabIndex = 18;
            this.DGVPunta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVPunta_CellContentClick);
            // 
            // txtdespunta
            // 
            this.txtdespunta.Location = new System.Drawing.Point(230, 84);
            this.txtdespunta.Name = "txtdespunta";
            this.txtdespunta.Size = new System.Drawing.Size(259, 20);
            this.txtdespunta.TabIndex = 17;
            // 
            // txtpunta
            // 
            this.txtpunta.Location = new System.Drawing.Point(230, 37);
            this.txtpunta.Name = "txtpunta";
            this.txtpunta.Size = new System.Drawing.Size(259, 20);
            this.txtpunta.TabIndex = 16;
            // 
            // PuntaModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnbuscarpunta);
            this.Controls.Add(this.btnactualizarpunta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnregistrarpunta);
            this.Controls.Add(this.DGVPunta);
            this.Controls.Add(this.txtdespunta);
            this.Controls.Add(this.txtpunta);
            this.Name = "PuntaModelo";
            this.Text = "PuntaModelo";
            this.Load += new System.EventHandler(this.PuntaModelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPunta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbuscarpunta;
        private System.Windows.Forms.Button btnactualizarpunta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnregistrarpunta;
        private System.Windows.Forms.DataGridView DGVPunta;
        private System.Windows.Forms.TextBox txtdespunta;
        private System.Windows.Forms.TextBox txtpunta;
    }
}