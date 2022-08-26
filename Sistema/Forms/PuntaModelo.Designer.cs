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
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPunta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnbuscarpunta
            // 
            this.btnbuscarpunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscarpunta.Location = new System.Drawing.Point(789, 70);
            this.btnbuscarpunta.Name = "btnbuscarpunta";
            this.btnbuscarpunta.Size = new System.Drawing.Size(133, 53);
            this.btnbuscarpunta.TabIndex = 23;
            this.btnbuscarpunta.Text = "Buscar";
            this.btnbuscarpunta.UseVisualStyleBackColor = true;
            this.btnbuscarpunta.Click += new System.EventHandler(this.btnbuscarpunta_Click);
            // 
            // btnactualizarpunta
            // 
            this.btnactualizarpunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualizarpunta.Location = new System.Drawing.Point(611, 619);
            this.btnactualizarpunta.Name = "btnactualizarpunta";
            this.btnactualizarpunta.Size = new System.Drawing.Size(134, 55);
            this.btnactualizarpunta.TabIndex = 22;
            this.btnactualizarpunta.Text = "Actualizar";
            this.btnactualizarpunta.UseVisualStyleBackColor = true;
            this.btnactualizarpunta.Click += new System.EventHandler(this.btnactualizarpunta_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Descripcion Punta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Codigo Punta";
            // 
            // btnregistrarpunta
            // 
            this.btnregistrarpunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistrarpunta.Location = new System.Drawing.Point(286, 619);
            this.btnregistrarpunta.Name = "btnregistrarpunta";
            this.btnregistrarpunta.Size = new System.Drawing.Size(146, 55);
            this.btnregistrarpunta.TabIndex = 19;
            this.btnregistrarpunta.Text = "Registrar";
            this.btnregistrarpunta.UseVisualStyleBackColor = true;
            this.btnregistrarpunta.Click += new System.EventHandler(this.btnregistrarpunta_Click);
            // 
            // DGVPunta
            // 
            this.DGVPunta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPunta.Location = new System.Drawing.Point(79, 208);
            this.DGVPunta.Name = "DGVPunta";
            this.DGVPunta.RowHeadersWidth = 51;
            this.DGVPunta.Size = new System.Drawing.Size(843, 326);
            this.DGVPunta.TabIndex = 18;
            this.DGVPunta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVPunta_CellContentClick);
            // 
            // txtdespunta
            // 
            this.txtdespunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdespunta.Location = new System.Drawing.Point(302, 124);
            this.txtdespunta.Name = "txtdespunta";
            this.txtdespunta.Size = new System.Drawing.Size(397, 22);
            this.txtdespunta.TabIndex = 17;
            this.txtdespunta.TextChanged += new System.EventHandler(this.txtdespunta_TextChanged);
            // 
            // txtpunta
            // 
            this.txtpunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpunta.Location = new System.Drawing.Point(302, 61);
            this.txtpunta.Name = "txtpunta";
            this.txtpunta.Size = new System.Drawing.Size(400, 22);
            this.txtpunta.TabIndex = 16;
            this.txtpunta.TextChanged += new System.EventHandler(this.txtpunta_TextChanged);
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
            this.iconPictureBox1.IconSize = 23;
            this.iconPictureBox1.Location = new System.Drawing.Point(999, 7);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(23, 24);
            this.iconPictureBox1.TabIndex = 24;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // PuntaModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1058, 724);
            this.Controls.Add(this.iconPictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
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
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}