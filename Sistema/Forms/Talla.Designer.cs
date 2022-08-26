namespace Sistema.Forms
{
    partial class Talla
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
            this.btnbuscartalla = new System.Windows.Forms.Button();
            this.btnactualizartalla = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnregistrartalla = new System.Windows.Forms.Button();
            this.DGVColor = new System.Windows.Forms.DataGridView();
            this.txtnumtalla = new System.Windows.Forms.TextBox();
            this.txttalla = new System.Windows.Forms.TextBox();
            this.iconCerrar = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnbuscartalla
            // 
            this.btnbuscartalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscartalla.Location = new System.Drawing.Point(649, 61);
            this.btnbuscartalla.Name = "btnbuscartalla";
            this.btnbuscartalla.Size = new System.Drawing.Size(140, 58);
            this.btnbuscartalla.TabIndex = 49;
            this.btnbuscartalla.Text = "Buscar";
            this.btnbuscartalla.UseVisualStyleBackColor = true;
            this.btnbuscartalla.Click += new System.EventHandler(this.btnbuscartalla_Click);
            // 
            // btnactualizartalla
            // 
            this.btnactualizartalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualizartalla.Location = new System.Drawing.Point(578, 574);
            this.btnactualizartalla.Name = "btnactualizartalla";
            this.btnactualizartalla.Size = new System.Drawing.Size(142, 58);
            this.btnactualizartalla.TabIndex = 48;
            this.btnactualizartalla.Text = "Actualizar";
            this.btnactualizartalla.UseVisualStyleBackColor = true;
            this.btnactualizartalla.Click += new System.EventHandler(this.btnactualizartalla_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(242, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 47;
            this.label2.Text = "Numero Talla";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 46;
            this.label1.Text = "Codigo Talla";
            // 
            // btnregistrartalla
            // 
            this.btnregistrartalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistrartalla.Location = new System.Drawing.Point(305, 574);
            this.btnregistrartalla.Name = "btnregistrartalla";
            this.btnregistrartalla.Size = new System.Drawing.Size(144, 58);
            this.btnregistrartalla.TabIndex = 45;
            this.btnregistrartalla.Text = "Registrar";
            this.btnregistrartalla.UseVisualStyleBackColor = true;
            this.btnregistrartalla.Click += new System.EventHandler(this.btnregistrartalla_Click);
            // 
            // DGVColor
            // 
            this.DGVColor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVColor.Location = new System.Drawing.Point(249, 163);
            this.DGVColor.Name = "DGVColor";
            this.DGVColor.RowHeadersWidth = 51;
            this.DGVColor.Size = new System.Drawing.Size(495, 382);
            this.DGVColor.TabIndex = 44;
            this.DGVColor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVColor_CellContentClick);
            // 
            // txtnumtalla
            // 
            this.txtnumtalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumtalla.Location = new System.Drawing.Point(371, 103);
            this.txtnumtalla.Name = "txtnumtalla";
            this.txtnumtalla.Size = new System.Drawing.Size(224, 22);
            this.txtnumtalla.TabIndex = 43;
            // 
            // txttalla
            // 
            this.txttalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttalla.Location = new System.Drawing.Point(371, 60);
            this.txttalla.Name = "txttalla";
            this.txttalla.Size = new System.Drawing.Size(224, 22);
            this.txttalla.TabIndex = 42;
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
            this.iconCerrar.Location = new System.Drawing.Point(44, 25);
            this.iconCerrar.Name = "iconCerrar";
            this.iconCerrar.Size = new System.Drawing.Size(24, 24);
            this.iconCerrar.TabIndex = 50;
            this.iconCerrar.TabStop = false;
            // 
            // Talla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1058, 724);
            this.Controls.Add(this.iconCerrar);
            this.Controls.Add(this.btnbuscartalla);
            this.Controls.Add(this.btnactualizartalla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnregistrartalla);
            this.Controls.Add(this.DGVColor);
            this.Controls.Add(this.txtnumtalla);
            this.Controls.Add(this.txttalla);
            this.Name = "Talla";
            this.Text = "Talla";
            this.Load += new System.EventHandler(this.Talla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconCerrar;
        private System.Windows.Forms.Button btnbuscartalla;
        private System.Windows.Forms.Button btnactualizartalla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnregistrartalla;
        private System.Windows.Forms.DataGridView DGVColor;
        private System.Windows.Forms.TextBox txtnumtalla;
        private System.Windows.Forms.TextBox txttalla;
    }
}