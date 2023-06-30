namespace pryIEFIAriasExequiel
{
    partial class frmCargaDeProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargaDeProductos));
            this.cmdVolver = new System.Windows.Forms.Button();
            this.lblProductos = new System.Windows.Forms.Label();
            this.mrcCargaDeProductos = new System.Windows.Forms.GroupBox();
            this.cmdCargar = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFechaRegistro = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.mrcConsultaDeProductos = new System.Windows.Forms.GroupBox();
            this.dgvConsultas = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboConsultas = new System.Windows.Forms.ComboBox();
            this.cmdListado = new System.Windows.Forms.Button();
            this.cmdBorraTodo = new System.Windows.Forms.Button();
            this.mrcCargaDeProductos.SuspendLayout();
            this.mrcConsultaDeProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdVolver
            // 
            this.cmdVolver.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVolver.Location = new System.Drawing.Point(147, 388);
            this.cmdVolver.Name = "cmdVolver";
            this.cmdVolver.Size = new System.Drawing.Size(110, 27);
            this.cmdVolver.TabIndex = 0;
            this.cmdVolver.Text = "Volver";
            this.cmdVolver.UseVisualStyleBackColor = true;
            this.cmdVolver.Click += new System.EventHandler(this.cmdVolver_Click);
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductos.Location = new System.Drawing.Point(115, 9);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(159, 34);
            this.lblProductos.TabIndex = 1;
            this.lblProductos.Text = "Productos";
            // 
            // mrcCargaDeProductos
            // 
            this.mrcCargaDeProductos.Controls.Add(this.cmdCargar);
            this.mrcCargaDeProductos.Controls.Add(this.dtpFecha);
            this.mrcCargaDeProductos.Controls.Add(this.lblFechaRegistro);
            this.mrcCargaDeProductos.Controls.Add(this.txtProducto);
            this.mrcCargaDeProductos.Controls.Add(this.lblProducto);
            this.mrcCargaDeProductos.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcCargaDeProductos.Location = new System.Drawing.Point(12, 46);
            this.mrcCargaDeProductos.Name = "mrcCargaDeProductos";
            this.mrcCargaDeProductos.Size = new System.Drawing.Size(361, 144);
            this.mrcCargaDeProductos.TabIndex = 2;
            this.mrcCargaDeProductos.TabStop = false;
            this.mrcCargaDeProductos.Text = "Carga De Productos";
            // 
            // cmdCargar
            // 
            this.cmdCargar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCargar.Location = new System.Drawing.Point(280, 115);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(75, 23);
            this.cmdCargar.TabIndex = 4;
            this.cmdCargar.Text = "Cargar";
            this.cmdCargar.UseVisualStyleBackColor = true;
            this.cmdCargar.Click += new System.EventHandler(this.cmdCargar_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(109, 70);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 21);
            this.dtpFecha.TabIndex = 3;
            // 
            // lblFechaRegistro
            // 
            this.lblFechaRegistro.AutoSize = true;
            this.lblFechaRegistro.Location = new System.Drawing.Point(13, 70);
            this.lblFechaRegistro.Name = "lblFechaRegistro";
            this.lblFechaRegistro.Size = new System.Drawing.Size(92, 15);
            this.lblFechaRegistro.TabIndex = 2;
            this.lblFechaRegistro.Text = "Fecha Registro";
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(109, 29);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(200, 21);
            this.txtProducto.TabIndex = 1;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(13, 32);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(59, 15);
            this.lblProducto.TabIndex = 0;
            this.lblProducto.Text = "Producto";
            // 
            // mrcConsultaDeProductos
            // 
            this.mrcConsultaDeProductos.Controls.Add(this.dgvConsultas);
            this.mrcConsultaDeProductos.Controls.Add(this.cboConsultas);
            this.mrcConsultaDeProductos.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcConsultaDeProductos.Location = new System.Drawing.Point(12, 196);
            this.mrcConsultaDeProductos.Name = "mrcConsultaDeProductos";
            this.mrcConsultaDeProductos.Size = new System.Drawing.Size(361, 188);
            this.mrcConsultaDeProductos.TabIndex = 3;
            this.mrcConsultaDeProductos.TabStop = false;
            this.mrcConsultaDeProductos.Text = "Consulta De Productos";
            // 
            // dgvConsultas
            // 
            this.dgvConsultas.AllowUserToDeleteRows = false;
            this.dgvConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Producto,
            this.Fecha});
            this.dgvConsultas.Location = new System.Drawing.Point(6, 49);
            this.dgvConsultas.Name = "dgvConsultas";
            this.dgvConsultas.ReadOnly = true;
            this.dgvConsultas.Size = new System.Drawing.Size(349, 126);
            this.dgvConsultas.TabIndex = 1;
            this.dgvConsultas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha Registro";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // cboConsultas
            // 
            this.cboConsultas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboConsultas.FormattingEnabled = true;
            this.cboConsultas.Location = new System.Drawing.Point(46, 20);
            this.cboConsultas.Name = "cboConsultas";
            this.cboConsultas.Size = new System.Drawing.Size(277, 23);
            this.cboConsultas.TabIndex = 0;
            // 
            // cmdListado
            // 
            this.cmdListado.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdListado.Location = new System.Drawing.Point(263, 388);
            this.cmdListado.Name = "cmdListado";
            this.cmdListado.Size = new System.Drawing.Size(110, 27);
            this.cmdListado.TabIndex = 4;
            this.cmdListado.Text = "Listado";
            this.cmdListado.UseVisualStyleBackColor = true;
            this.cmdListado.Click += new System.EventHandler(this.cmdListado_Click);
            // 
            // cmdBorraTodo
            // 
            this.cmdBorraTodo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBorraTodo.Location = new System.Drawing.Point(12, 388);
            this.cmdBorraTodo.Name = "cmdBorraTodo";
            this.cmdBorraTodo.Size = new System.Drawing.Size(101, 27);
            this.cmdBorraTodo.TabIndex = 6;
            this.cmdBorraTodo.Text = "Borrar Todo";
            this.cmdBorraTodo.UseVisualStyleBackColor = true;
            this.cmdBorraTodo.Click += new System.EventHandler(this.cmdBorraTodo_Click);
            // 
            // frmCargaDeProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(390, 438);
            this.Controls.Add(this.cmdBorraTodo);
            this.Controls.Add(this.cmdListado);
            this.Controls.Add(this.mrcConsultaDeProductos);
            this.Controls.Add(this.mrcCargaDeProductos);
            this.Controls.Add(this.lblProductos);
            this.Controls.Add(this.cmdVolver);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(406, 477);
            this.MinimumSize = new System.Drawing.Size(406, 477);
            this.Name = "frmCargaDeProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.frmCargaDeProductos_Load);
            this.mrcCargaDeProductos.ResumeLayout(false);
            this.mrcCargaDeProductos.PerformLayout();
            this.mrcConsultaDeProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdVolver;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.GroupBox mrcCargaDeProductos;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFechaRegistro;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Button cmdCargar;
        private System.Windows.Forms.GroupBox mrcConsultaDeProductos;
        private System.Windows.Forms.ComboBox cboConsultas;
        private System.Windows.Forms.DataGridView dgvConsultas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.Button cmdListado;
        private System.Windows.Forms.Button cmdBorraTodo;
    }
}