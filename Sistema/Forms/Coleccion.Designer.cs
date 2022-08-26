namespace Sistema.Forms
{
    partial class Coleccion
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
            this.iconCerrar = new FontAwesome.Sharp.IconPictureBox();
            this.btnbuscarcol = new System.Windows.Forms.Button();
            this.btnactualizarcol = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnregistrarcol = new System.Windows.Forms.Button();
            this.DGVColeccion = new System.Windows.Forms.DataGridView();
            this.txtnomcoleccion = new System.Windows.Forms.TextBox();
            this.txtcoleccion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVColeccion)).BeginInit();
            this.SuspendLayout();
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
            this.iconCerrar.Location = new System.Drawing.Point(610, 14);
            this.iconCerrar.Name = "iconCerrar";
            this.iconCerrar.Size = new System.Drawing.Size(24, 24);
            this.iconCerrar.TabIndex = 41;
            this.iconCerrar.TabStop = false;
            // 
            // btnbuscarcol
            // 
            this.btnbuscarcol.Location = new System.Drawing.Point(519, 52);
            this.btnbuscarcol.Name = "btnbuscarcol";
            this.btnbuscarcol.Size = new System.Drawing.Size(115, 30);
            this.btnbuscarcol.TabIndex = 40;
            this.btnbuscarcol.Text = "Buscar";
            this.btnbuscarcol.UseVisualStyleBackColor = true;
            this.btnbuscarcol.Click += new System.EventHandler(this.btnbuscarcol_Click);
            // 
            // btnactualizarcol
            // 
            this.btnactualizarcol.Location = new System.Drawing.Point(443, 394);
            this.btnactualizarcol.Name = "btnactualizarcol";
            this.btnactualizarcol.Size = new System.Drawing.Size(115, 30);
            this.btnactualizarcol.TabIndex = 39;
            this.btnactualizarcol.Text = "Actualizar";
            this.btnactualizarcol.UseVisualStyleBackColor = true;
            this.btnactualizarcol.Click += new System.EventHandler(this.btnactualizarcol_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Nombre Coleccion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Codigo Coleccion";
            // 
            // btnregistrarcol
            // 
            this.btnregistrarcol.Location = new System.Drawing.Point(239, 394);
            this.btnregistrarcol.Name = "btnregistrarcol";
            this.btnregistrarcol.Size = new System.Drawing.Size(115, 30);
            this.btnregistrarcol.TabIndex = 36;
            this.btnregistrarcol.Text = "Registrar";
            this.btnregistrarcol.UseVisualStyleBackColor = true;
            this.btnregistrarcol.Click += new System.EventHandler(this.btnregistrarcol_Click);
            // 
            // DGVColeccion
            // 
            this.DGVColeccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVColeccion.Location = new System.Drawing.Point(139, 153);
            this.DGVColeccion.Name = "DGVColeccion";
            this.DGVColeccion.RowHeadersWidth = 51;
            this.DGVColeccion.Size = new System.Drawing.Size(495, 213);
            this.DGVColeccion.TabIndex = 35;
            // 
            // txtnomcoleccion
            // 
            this.txtnomcoleccion.Location = new System.Drawing.Point(265, 103);
            this.txtnomcoleccion.Name = "txtnomcoleccion";
            this.txtnomcoleccion.Size = new System.Drawing.Size(224, 20);
            this.txtnomcoleccion.TabIndex = 34;
            // 
            // txtcoleccion
            // 
            this.txtcoleccion.Location = new System.Drawing.Point(265, 60);
            this.txtcoleccion.Name = "txtcoleccion";
            this.txtcoleccion.Size = new System.Drawing.Size(224, 20);
            this.txtcoleccion.TabIndex = 33;
            // 
            // Coleccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.iconCerrar);
            this.Controls.Add(this.btnbuscarcol);
            this.Controls.Add(this.btnactualizarcol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnregistrarcol);
            this.Controls.Add(this.DGVColeccion);
            this.Controls.Add(this.txtnomcoleccion);
            this.Controls.Add(this.txtcoleccion);
            this.Name = "Coleccion";
            this.Text = "Coleccion";
            this.Load += new System.EventHandler(this.Coleccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVColeccion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconCerrar;
        private System.Windows.Forms.Button btnbuscarcol;
        private System.Windows.Forms.Button btnactualizarcol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnregistrarcol;
        private System.Windows.Forms.DataGridView DGVColeccion;
        private System.Windows.Forms.TextBox txtnomcoleccion;
        private System.Windows.Forms.TextBox txtcoleccion;
    }
}