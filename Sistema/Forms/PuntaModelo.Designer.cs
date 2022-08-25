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
            this.btnbuscarpunta.Location = new System.Drawing.Point(410, 47);
            this.btnbuscarpunta.Margin = new System.Windows.Forms.Padding(4);
            this.btnbuscarpunta.Name = "btnbuscarpunta";
            this.btnbuscarpunta.Size = new System.Drawing.Size(153, 37);
            this.btnbuscarpunta.TabIndex = 23;
            this.btnbuscarpunta.Text = "Buscar";
            this.btnbuscarpunta.UseVisualStyleBackColor = true;
            this.btnbuscarpunta.Click += new System.EventHandler(this.btnbuscarpunta_Click);
            // 
            // btnactualizarpunta
            // 
            this.btnactualizarpunta.Location = new System.Drawing.Point(410, 450);
            this.btnactualizarpunta.Margin = new System.Windows.Forms.Padding(4);
            this.btnactualizarpunta.Name = "btnactualizarpunta";
            this.btnactualizarpunta.Size = new System.Drawing.Size(153, 37);
            this.btnactualizarpunta.TabIndex = 22;
            this.btnactualizarpunta.Text = "Actualizar";
            this.btnactualizarpunta.UseVisualStyleBackColor = true;
            this.btnactualizarpunta.Click += new System.EventHandler(this.btnactualizarpunta_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Descripcion Punta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Codigo Punta";
            // 
            // btnregistrarpunta
            // 
            this.btnregistrarpunta.Location = new System.Drawing.Point(40, 450);
            this.btnregistrarpunta.Margin = new System.Windows.Forms.Padding(4);
            this.btnregistrarpunta.Name = "btnregistrarpunta";
            this.btnregistrarpunta.Size = new System.Drawing.Size(153, 37);
            this.btnregistrarpunta.TabIndex = 19;
            this.btnregistrarpunta.Text = "Registrar";
            this.btnregistrarpunta.UseVisualStyleBackColor = true;
            this.btnregistrarpunta.Click += new System.EventHandler(this.btnregistrarpunta_Click);
            // 
            // DGVPunta
            // 
            this.DGVPunta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPunta.Location = new System.Drawing.Point(40, 144);
            this.DGVPunta.Margin = new System.Windows.Forms.Padding(4);
            this.DGVPunta.Name = "DGVPunta";
            this.DGVPunta.RowHeadersWidth = 51;
            this.DGVPunta.Size = new System.Drawing.Size(523, 262);
            this.DGVPunta.TabIndex = 18;
            this.DGVPunta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVPunta_CellContentClick);
            // 
            // txtdespunta
            // 
            this.txtdespunta.Location = new System.Drawing.Point(175, 104);
            this.txtdespunta.Margin = new System.Windows.Forms.Padding(4);
            this.txtdespunta.Name = "txtdespunta";
            this.txtdespunta.Size = new System.Drawing.Size(197, 22);
            this.txtdespunta.TabIndex = 17;
            this.txtdespunta.TextChanged += new System.EventHandler(this.txtdespunta_TextChanged);
            // 
            // txtpunta
            // 
            this.txtpunta.Location = new System.Drawing.Point(175, 47);
            this.txtpunta.Margin = new System.Windows.Forms.Padding(4);
            this.txtpunta.Name = "txtpunta";
            this.txtpunta.Size = new System.Drawing.Size(197, 22);
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
            this.iconPictureBox1.IconSize = 30;
            this.iconPictureBox1.Location = new System.Drawing.Point(532, 9);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(31, 30);
            this.iconPictureBox1.TabIndex = 24;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // PuntaModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 513);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.btnbuscarpunta);
            this.Controls.Add(this.btnactualizarpunta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnregistrarpunta);
            this.Controls.Add(this.DGVPunta);
            this.Controls.Add(this.txtdespunta);
            this.Controls.Add(this.txtpunta);
            this.Margin = new System.Windows.Forms.Padding(4);
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