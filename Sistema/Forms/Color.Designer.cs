namespace Sistema.Forms
{
    partial class Color
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
            this.btnbuscarcolor = new System.Windows.Forms.Button();
            this.btnactualizarcolor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnregistrarcolor = new System.Windows.Forms.Button();
            this.DGVColor = new System.Windows.Forms.DataGridView();
            this.txtnomcolor = new System.Windows.Forms.TextBox();
            this.txtcolor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVColor)).BeginInit();
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
            this.iconCerrar.Location = new System.Drawing.Point(506, 19);
            this.iconCerrar.Name = "iconCerrar";
            this.iconCerrar.Size = new System.Drawing.Size(24, 24);
            this.iconCerrar.TabIndex = 41;
            this.iconCerrar.TabStop = false;
            // 
            // btnbuscarcolor
            // 
            this.btnbuscarcolor.Location = new System.Drawing.Point(415, 80);
            this.btnbuscarcolor.Name = "btnbuscarcolor";
            this.btnbuscarcolor.Size = new System.Drawing.Size(115, 30);
            this.btnbuscarcolor.TabIndex = 40;
            this.btnbuscarcolor.Text = "Buscar";
            this.btnbuscarcolor.UseVisualStyleBackColor = true;
            this.btnbuscarcolor.Click += new System.EventHandler(this.btnbuscarcolor_Click);
            // 
            // btnactualizarcolor
            // 
            this.btnactualizarcolor.Location = new System.Drawing.Point(339, 399);
            this.btnactualizarcolor.Name = "btnactualizarcolor";
            this.btnactualizarcolor.Size = new System.Drawing.Size(115, 30);
            this.btnactualizarcolor.TabIndex = 39;
            this.btnactualizarcolor.Text = "Actualizar";
            this.btnactualizarcolor.UseVisualStyleBackColor = true;
            this.btnactualizarcolor.Click += new System.EventHandler(this.btnactualizarcolor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Nombre Color";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Codigo Color";
            // 
            // btnregistrarcolor
            // 
            this.btnregistrarcolor.Location = new System.Drawing.Point(135, 399);
            this.btnregistrarcolor.Name = "btnregistrarcolor";
            this.btnregistrarcolor.Size = new System.Drawing.Size(115, 30);
            this.btnregistrarcolor.TabIndex = 36;
            this.btnregistrarcolor.Text = "Registrar";
            this.btnregistrarcolor.UseVisualStyleBackColor = true;
            this.btnregistrarcolor.Click += new System.EventHandler(this.btnregistrarcolor_Click);
            // 
            // DGVColor
            // 
            this.DGVColor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVColor.Location = new System.Drawing.Point(35, 158);
            this.DGVColor.Name = "DGVColor";
            this.DGVColor.RowHeadersWidth = 51;
            this.DGVColor.Size = new System.Drawing.Size(495, 213);
            this.DGVColor.TabIndex = 35;
            // 
            // txtnomcolor
            // 
            this.txtnomcolor.Location = new System.Drawing.Point(161, 108);
            this.txtnomcolor.Name = "txtnomcolor";
            this.txtnomcolor.Size = new System.Drawing.Size(224, 20);
            this.txtnomcolor.TabIndex = 34;
            // 
            // txtcolor
            // 
            this.txtcolor.Location = new System.Drawing.Point(161, 65);
            this.txtcolor.Name = "txtcolor";
            this.txtcolor.Size = new System.Drawing.Size(224, 20);
            this.txtcolor.TabIndex = 33;
            // 
            // Color
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 450);
            this.Controls.Add(this.iconCerrar);
            this.Controls.Add(this.btnbuscarcolor);
            this.Controls.Add(this.btnactualizarcolor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnregistrarcolor);
            this.Controls.Add(this.DGVColor);
            this.Controls.Add(this.txtnomcolor);
            this.Controls.Add(this.txtcolor);
            this.Name = "Color";
            this.Text = "Color";
            this.Load += new System.EventHandler(this.Color_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconCerrar;
        private System.Windows.Forms.Button btnbuscarcolor;
        private System.Windows.Forms.Button btnactualizarcolor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnregistrarcolor;
        private System.Windows.Forms.DataGridView DGVColor;
        private System.Windows.Forms.TextBox txtnomcolor;
        private System.Windows.Forms.TextBox txtcolor;
    }
}