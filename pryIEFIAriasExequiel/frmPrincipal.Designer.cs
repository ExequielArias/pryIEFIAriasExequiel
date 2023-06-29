namespace pryIEFIAriasExequiel
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.cmdProductos = new System.Windows.Forms.Button();
            this.cmdVentas = new System.Windows.Forms.Button();
            this.cmdListado = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ptbVentas = new System.Windows.Forms.PictureBox();
            this.ptbProducto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdProductos
            // 
            this.cmdProductos.BackColor = System.Drawing.Color.Black;
            this.cmdProductos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdProductos.ForeColor = System.Drawing.Color.White;
            this.cmdProductos.Location = new System.Drawing.Point(23, 26);
            this.cmdProductos.Name = "cmdProductos";
            this.cmdProductos.Size = new System.Drawing.Size(194, 52);
            this.cmdProductos.TabIndex = 0;
            this.cmdProductos.Text = "Productos";
            this.cmdProductos.UseVisualStyleBackColor = false;
            this.cmdProductos.Click += new System.EventHandler(this.cmdProductos_Click);
            // 
            // cmdVentas
            // 
            this.cmdVentas.BackColor = System.Drawing.Color.Black;
            this.cmdVentas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVentas.ForeColor = System.Drawing.Color.White;
            this.cmdVentas.Location = new System.Drawing.Point(23, 84);
            this.cmdVentas.Name = "cmdVentas";
            this.cmdVentas.Size = new System.Drawing.Size(194, 52);
            this.cmdVentas.TabIndex = 1;
            this.cmdVentas.Text = "Ventas";
            this.cmdVentas.UseVisualStyleBackColor = false;
            this.cmdVentas.Click += new System.EventHandler(this.cmdVentas_Click);
            // 
            // cmdListado
            // 
            this.cmdListado.BackColor = System.Drawing.Color.Black;
            this.cmdListado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdListado.ForeColor = System.Drawing.Color.White;
            this.cmdListado.Location = new System.Drawing.Point(23, 142);
            this.cmdListado.Name = "cmdListado";
            this.cmdListado.Size = new System.Drawing.Size(194, 52);
            this.cmdListado.TabIndex = 4;
            this.cmdListado.Text = "Listado";
            this.cmdListado.UseVisualStyleBackColor = false;
            this.cmdListado.Click += new System.EventHandler(this.cmdListado_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = global::pryIEFIAriasExequiel.Properties.Resources.imagen_de_fonde_de_pag_principal;
            this.pictureBox1.Location = new System.Drawing.Point(36, 151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // ptbVentas
            // 
            this.ptbVentas.BackColor = System.Drawing.Color.Black;
            this.ptbVentas.Image = global::pryIEFIAriasExequiel.Properties.Resources.Icono_de_Numbers;
            this.ptbVentas.Location = new System.Drawing.Point(36, 94);
            this.ptbVentas.Name = "ptbVentas";
            this.ptbVentas.Size = new System.Drawing.Size(31, 31);
            this.ptbVentas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbVentas.TabIndex = 3;
            this.ptbVentas.TabStop = false;
            // 
            // ptbProducto
            // 
            this.ptbProducto.BackColor = System.Drawing.Color.Black;
            this.ptbProducto.Image = global::pryIEFIAriasExequiel.Properties.Resources.Icono_de_productos;
            this.ptbProducto.Location = new System.Drawing.Point(36, 37);
            this.ptbProducto.Name = "ptbProducto";
            this.ptbProducto.Size = new System.Drawing.Size(31, 31);
            this.ptbProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbProducto.TabIndex = 2;
            this.ptbProducto.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(239, 224);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmdListado);
            this.Controls.Add(this.ptbVentas);
            this.Controls.Add(this.ptbProducto);
            this.Controls.Add(this.cmdVentas);
            this.Controls.Add(this.cmdProductos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdProductos;
        private System.Windows.Forms.Button cmdVentas;
        private System.Windows.Forms.PictureBox ptbProducto;
        private System.Windows.Forms.PictureBox ptbVentas;
        private System.Windows.Forms.Button cmdListado;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}