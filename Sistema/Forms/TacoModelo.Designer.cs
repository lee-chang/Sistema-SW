namespace Sistema.Forms
{
    partial class TacoModelo
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
            this.btnbuscartaco = new System.Windows.Forms.Button();
            this.btnactualizartaco = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnregistrartaco = new System.Windows.Forms.Button();
            this.DGVTaco = new System.Windows.Forms.DataGridView();
            this.txtdestaco = new System.Windows.Forms.TextBox();
            this.txttaco = new System.Windows.Forms.TextBox();
            this.iconCerrar = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTaco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnbuscartaco
            // 
            this.btnbuscartaco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscartaco.Location = new System.Drawing.Point(730, 89);
            this.btnbuscartaco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnbuscartaco.Name = "btnbuscartaco";
            this.btnbuscartaco.Size = new System.Drawing.Size(172, 66);
            this.btnbuscartaco.TabIndex = 15;
            this.btnbuscartaco.Text = "Buscar";
            this.btnbuscartaco.UseVisualStyleBackColor = true;
            this.btnbuscartaco.Click += new System.EventHandler(this.btnbuscartaco_Click);
            // 
            // btnactualizartaco
            // 
            this.btnactualizartaco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualizartaco.Location = new System.Drawing.Point(617, 567);
            this.btnactualizartaco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnactualizartaco.Name = "btnactualizartaco";
            this.btnactualizartaco.Size = new System.Drawing.Size(176, 74);
            this.btnactualizartaco.TabIndex = 14;
            this.btnactualizartaco.Text = "Actualizar";
            this.btnactualizartaco.UseVisualStyleBackColor = true;
            this.btnactualizartaco.Click += new System.EventHandler(this.btnactualizartaco_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(142, 152);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Descripcion Taco";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Codigo Taco";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnregistrartaco
            // 
            this.btnregistrartaco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistrartaco.Location = new System.Drawing.Point(274, 567);
            this.btnregistrartaco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnregistrartaco.Name = "btnregistrartaco";
            this.btnregistrartaco.Size = new System.Drawing.Size(170, 74);
            this.btnregistrartaco.TabIndex = 11;
            this.btnregistrartaco.Text = "Registrar";
            this.btnregistrartaco.UseVisualStyleBackColor = true;
            this.btnregistrartaco.Click += new System.EventHandler(this.btnregistrartaco_Click);
            // 
            // DGVTaco
            // 
            this.DGVTaco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTaco.Location = new System.Drawing.Point(166, 224);
            this.DGVTaco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DGVTaco.Name = "DGVTaco";
            this.DGVTaco.Size = new System.Drawing.Size(716, 301);
            this.DGVTaco.TabIndex = 10;
            this.DGVTaco.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVHorma_CellContentClick);
            // 
            // txtdestaco
            // 
            this.txtdestaco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdestaco.Location = new System.Drawing.Point(301, 146);
            this.txtdestaco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtdestaco.Name = "txtdestaco";
            this.txtdestaco.Size = new System.Drawing.Size(386, 22);
            this.txtdestaco.TabIndex = 9;
            this.txtdestaco.TextChanged += new System.EventHandler(this.txtdestaco_TextChanged);
            // 
            // txttaco
            // 
            this.txttaco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttaco.Location = new System.Drawing.Point(301, 86);
            this.txttaco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txttaco.Name = "txttaco";
            this.txttaco.Size = new System.Drawing.Size(386, 22);
            this.txttaco.TabIndex = 8;
            this.txttaco.TextChanged += new System.EventHandler(this.txttaco_TextChanged);
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
            this.iconCerrar.Location = new System.Drawing.Point(47, 38);
            this.iconCerrar.Name = "iconCerrar";
            this.iconCerrar.Size = new System.Drawing.Size(24, 24);
            this.iconCerrar.TabIndex = 51;
            this.iconCerrar.TabStop = false;
            // 
            // TacoModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1058, 724);
            this.Controls.Add(this.iconCerrar);
            this.Controls.Add(this.btnbuscartaco);
            this.Controls.Add(this.btnactualizartaco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnregistrartaco);
            this.Controls.Add(this.DGVTaco);
            this.Controls.Add(this.txtdestaco);
            this.Controls.Add(this.txttaco);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TacoModelo";
            this.Text = "TacoModelo";
            this.Load += new System.EventHandler(this.TacoModelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVTaco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbuscartaco;
        private System.Windows.Forms.Button btnactualizartaco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnregistrartaco;
        private System.Windows.Forms.DataGridView DGVTaco;
        private System.Windows.Forms.TextBox txtdestaco;
        private System.Windows.Forms.TextBox txttaco;
        private FontAwesome.Sharp.IconPictureBox iconCerrar;
    }
}