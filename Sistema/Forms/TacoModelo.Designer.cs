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
            ((System.ComponentModel.ISupportInitialize)(this.DGVTaco)).BeginInit();
            this.SuspendLayout();
            // 
            // btnbuscartaco
            // 
            this.btnbuscartaco.Location = new System.Drawing.Point(511, 52);
            this.btnbuscartaco.Name = "btnbuscartaco";
            this.btnbuscartaco.Size = new System.Drawing.Size(115, 30);
            this.btnbuscartaco.TabIndex = 15;
            this.btnbuscartaco.Text = "Buscar";
            this.btnbuscartaco.UseVisualStyleBackColor = true;
            this.btnbuscartaco.Click += new System.EventHandler(this.btnbuscartaco_Click);
            // 
            // btnactualizartaco
            // 
            this.btnactualizartaco.Location = new System.Drawing.Point(435, 372);
            this.btnactualizartaco.Name = "btnactualizartaco";
            this.btnactualizartaco.Size = new System.Drawing.Size(115, 30);
            this.btnactualizartaco.TabIndex = 14;
            this.btnactualizartaco.Text = "Actualizar";
            this.btnactualizartaco.UseVisualStyleBackColor = true;
            this.btnactualizartaco.Click += new System.EventHandler(this.btnactualizartaco_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Descripcion Taco";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Codigo Taco";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnregistrartaco
            // 
            this.btnregistrartaco.Location = new System.Drawing.Point(231, 372);
            this.btnregistrartaco.Name = "btnregistrartaco";
            this.btnregistrartaco.Size = new System.Drawing.Size(115, 30);
            this.btnregistrartaco.TabIndex = 11;
            this.btnregistrartaco.Text = "Registrar";
            this.btnregistrartaco.UseVisualStyleBackColor = true;
            this.btnregistrartaco.Click += new System.EventHandler(this.btnregistrartaco_Click);
            // 
            // DGVTaco
            // 
            this.DGVTaco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTaco.Location = new System.Drawing.Point(151, 137);
            this.DGVTaco.Name = "DGVTaco";
            this.DGVTaco.Size = new System.Drawing.Size(475, 213);
            this.DGVTaco.TabIndex = 10;
            this.DGVTaco.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVHorma_CellContentClick);
            // 
            // txtdestaco
            // 
            this.txtdestaco.Location = new System.Drawing.Point(231, 84);
            this.txtdestaco.Name = "txtdestaco";
            this.txtdestaco.Size = new System.Drawing.Size(259, 20);
            this.txtdestaco.TabIndex = 9;
            this.txtdestaco.TextChanged += new System.EventHandler(this.txtdestaco_TextChanged);
            // 
            // txttaco
            // 
            this.txttaco.Location = new System.Drawing.Point(231, 37);
            this.txttaco.Name = "txttaco";
            this.txttaco.Size = new System.Drawing.Size(259, 20);
            this.txttaco.TabIndex = 8;
            this.txttaco.TextChanged += new System.EventHandler(this.txttaco_TextChanged);
            // 
            // TacoModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnbuscartaco);
            this.Controls.Add(this.btnactualizartaco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnregistrartaco);
            this.Controls.Add(this.DGVTaco);
            this.Controls.Add(this.txtdestaco);
            this.Controls.Add(this.txttaco);
            this.Name = "TacoModelo";
            this.Text = "TacoModelo";
            this.Load += new System.EventHandler(this.TacoModelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVTaco)).EndInit();
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
    }
}