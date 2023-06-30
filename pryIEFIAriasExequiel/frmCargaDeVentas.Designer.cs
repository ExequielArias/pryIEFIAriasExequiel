namespace pryIEFIAriasExequiel
{
    partial class frmCargaDeVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargaDeVentas));
            this.lblVentas = new System.Windows.Forms.Label();
            this.mrcCargaDeVentas = new System.Windows.Forms.GroupBox();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.cmdCargar = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.dtpFechaDeVenta = new System.Windows.Forms.DateTimePicker();
            this.lblFechaDeVenta = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.mrcConsultarProductos = new System.Windows.Forms.GroupBox();
            this.mrcFiltrosDeConsultas = new System.Windows.Forms.GroupBox();
            this.cboFiltroProducto = new System.Windows.Forms.ComboBox();
            this.cmdFiltrar = new System.Windows.Forms.Button();
            this.txtBuscarCantidad = new System.Windows.Forms.TextBox();
            this.optCantidad = new System.Windows.Forms.RadioButton();
            this.optProductos = new System.Windows.Forms.RadioButton();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboProductos = new System.Windows.Forms.ComboBox();
            this.cmdVolver = new System.Windows.Forms.Button();
            this.cmdListado = new System.Windows.Forms.Button();
            this.cmdBorraTodo = new System.Windows.Forms.Button();
            this.mrcCargaDeVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.mrcConsultarProductos.SuspendLayout();
            this.mrcFiltrosDeConsultas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentas.Location = new System.Drawing.Point(191, 9);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(108, 34);
            this.lblVentas.TabIndex = 0;
            this.lblVentas.Text = "Ventas";
            // 
            // mrcCargaDeVentas
            // 
            this.mrcCargaDeVentas.Controls.Add(this.nudCantidad);
            this.mrcCargaDeVentas.Controls.Add(this.cmdCargar);
            this.mrcCargaDeVentas.Controls.Add(this.lblCantidad);
            this.mrcCargaDeVentas.Controls.Add(this.dtpFechaDeVenta);
            this.mrcCargaDeVentas.Controls.Add(this.lblFechaDeVenta);
            this.mrcCargaDeVentas.Controls.Add(this.txtProducto);
            this.mrcCargaDeVentas.Controls.Add(this.lblProducto);
            this.mrcCargaDeVentas.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcCargaDeVentas.Location = new System.Drawing.Point(12, 58);
            this.mrcCargaDeVentas.Name = "mrcCargaDeVentas";
            this.mrcCargaDeVentas.Size = new System.Drawing.Size(462, 159);
            this.mrcCargaDeVentas.TabIndex = 1;
            this.mrcCargaDeVentas.TabStop = false;
            this.mrcCargaDeVentas.Text = "Carga De Ventas";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(107, 54);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(200, 21);
            this.nudCantidad.TabIndex = 7;
            // 
            // cmdCargar
            // 
            this.cmdCargar.Location = new System.Drawing.Point(357, 130);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(99, 23);
            this.cmdCargar.TabIndex = 6;
            this.cmdCargar.Text = "Cargar";
            this.cmdCargar.UseVisualStyleBackColor = true;
            this.cmdCargar.Click += new System.EventHandler(this.cmdCargar_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(7, 56);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(57, 15);
            this.lblCantidad.TabIndex = 4;
            this.lblCantidad.Text = "Cantidad";
            // 
            // dtpFechaDeVenta
            // 
            this.dtpFechaDeVenta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDeVenta.Location = new System.Drawing.Point(107, 81);
            this.dtpFechaDeVenta.Name = "dtpFechaDeVenta";
            this.dtpFechaDeVenta.Size = new System.Drawing.Size(200, 21);
            this.dtpFechaDeVenta.TabIndex = 3;
            // 
            // lblFechaDeVenta
            // 
            this.lblFechaDeVenta.AutoSize = true;
            this.lblFechaDeVenta.Location = new System.Drawing.Point(7, 85);
            this.lblFechaDeVenta.Name = "lblFechaDeVenta";
            this.lblFechaDeVenta.Size = new System.Drawing.Size(94, 15);
            this.lblFechaDeVenta.TabIndex = 2;
            this.lblFechaDeVenta.Text = "Fecha De Venta";
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(107, 27);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(200, 21);
            this.txtProducto.TabIndex = 1;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(7, 30);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(59, 15);
            this.lblProducto.TabIndex = 0;
            this.lblProducto.Text = "Producto";
            // 
            // mrcConsultarProductos
            // 
            this.mrcConsultarProductos.Controls.Add(this.mrcFiltrosDeConsultas);
            this.mrcConsultarProductos.Controls.Add(this.dgvProductos);
            this.mrcConsultarProductos.Controls.Add(this.cboProductos);
            this.mrcConsultarProductos.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcConsultarProductos.Location = new System.Drawing.Point(12, 223);
            this.mrcConsultarProductos.Name = "mrcConsultarProductos";
            this.mrcConsultarProductos.Size = new System.Drawing.Size(462, 388);
            this.mrcConsultarProductos.TabIndex = 2;
            this.mrcConsultarProductos.TabStop = false;
            this.mrcConsultarProductos.Text = "Consultar Productos";
            // 
            // mrcFiltrosDeConsultas
            // 
            this.mrcFiltrosDeConsultas.Controls.Add(this.cboFiltroProducto);
            this.mrcFiltrosDeConsultas.Controls.Add(this.cmdFiltrar);
            this.mrcFiltrosDeConsultas.Controls.Add(this.txtBuscarCantidad);
            this.mrcFiltrosDeConsultas.Controls.Add(this.optCantidad);
            this.mrcFiltrosDeConsultas.Controls.Add(this.optProductos);
            this.mrcFiltrosDeConsultas.Location = new System.Drawing.Point(10, 234);
            this.mrcFiltrosDeConsultas.Name = "mrcFiltrosDeConsultas";
            this.mrcFiltrosDeConsultas.Size = new System.Drawing.Size(439, 134);
            this.mrcFiltrosDeConsultas.TabIndex = 2;
            this.mrcFiltrosDeConsultas.TabStop = false;
            this.mrcFiltrosDeConsultas.Text = "Filtros De Consultas";
            // 
            // cboFiltroProducto
            // 
            this.cboFiltroProducto.FormattingEnabled = true;
            this.cboFiltroProducto.Location = new System.Drawing.Point(72, 54);
            this.cboFiltroProducto.Name = "cboFiltroProducto";
            this.cboFiltroProducto.Size = new System.Drawing.Size(121, 23);
            this.cboFiltroProducto.TabIndex = 4;
            // 
            // cmdFiltrar
            // 
            this.cmdFiltrar.Location = new System.Drawing.Point(175, 94);
            this.cmdFiltrar.Name = "cmdFiltrar";
            this.cmdFiltrar.Size = new System.Drawing.Size(75, 23);
            this.cmdFiltrar.TabIndex = 3;
            this.cmdFiltrar.Text = "Filtrar";
            this.cmdFiltrar.UseVisualStyleBackColor = true;
            this.cmdFiltrar.Click += new System.EventHandler(this.cmdFiltrar_Click);
            // 
            // txtBuscarCantidad
            // 
            this.txtBuscarCantidad.Location = new System.Drawing.Point(234, 54);
            this.txtBuscarCantidad.Name = "txtBuscarCantidad";
            this.txtBuscarCantidad.Size = new System.Drawing.Size(127, 21);
            this.txtBuscarCantidad.TabIndex = 2;
            // 
            // optCantidad
            // 
            this.optCantidad.AutoSize = true;
            this.optCantidad.Location = new System.Drawing.Point(249, 29);
            this.optCantidad.Name = "optCantidad";
            this.optCantidad.Size = new System.Drawing.Size(75, 19);
            this.optCantidad.TabIndex = 1;
            this.optCantidad.Text = "Cantidad";
            this.optCantidad.UseVisualStyleBackColor = true;
            // 
            // optProductos
            // 
            this.optProductos.AutoSize = true;
            this.optProductos.Checked = true;
            this.optProductos.Location = new System.Drawing.Point(57, 29);
            this.optProductos.Name = "optProductos";
            this.optProductos.Size = new System.Drawing.Size(84, 19);
            this.optProductos.TabIndex = 0;
            this.optProductos.TabStop = true;
            this.optProductos.Text = "Productos";
            this.optProductos.UseVisualStyleBackColor = true;
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Fecha,
            this.Producto,
            this.Cantidad});
            this.dgvProductos.Location = new System.Drawing.Point(6, 67);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.Size = new System.Drawing.Size(443, 150);
            this.dgvProductos.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha De Venta";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // cboProductos
            // 
            this.cboProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProductos.FormattingEnabled = true;
            this.cboProductos.Location = new System.Drawing.Point(6, 29);
            this.cboProductos.Name = "cboProductos";
            this.cboProductos.Size = new System.Drawing.Size(443, 23);
            this.cboProductos.TabIndex = 0;
            // 
            // cmdVolver
            // 
            this.cmdVolver.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVolver.Location = new System.Drawing.Point(318, 628);
            this.cmdVolver.Name = "cmdVolver";
            this.cmdVolver.Size = new System.Drawing.Size(75, 23);
            this.cmdVolver.TabIndex = 3;
            this.cmdVolver.Text = "Volver";
            this.cmdVolver.UseVisualStyleBackColor = true;
            this.cmdVolver.Click += new System.EventHandler(this.cmdVolver_Click);
            // 
            // cmdListado
            // 
            this.cmdListado.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdListado.Location = new System.Drawing.Point(399, 628);
            this.cmdListado.Name = "cmdListado";
            this.cmdListado.Size = new System.Drawing.Size(75, 23);
            this.cmdListado.TabIndex = 4;
            this.cmdListado.Text = "Listado";
            this.cmdListado.UseVisualStyleBackColor = true;
            this.cmdListado.Click += new System.EventHandler(this.cmdListado_Click);
            // 
            // cmdBorraTodo
            // 
            this.cmdBorraTodo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBorraTodo.Location = new System.Drawing.Point(12, 628);
            this.cmdBorraTodo.Name = "cmdBorraTodo";
            this.cmdBorraTodo.Size = new System.Drawing.Size(101, 23);
            this.cmdBorraTodo.TabIndex = 5;
            this.cmdBorraTodo.Text = "Borrar Todo";
            this.cmdBorraTodo.UseVisualStyleBackColor = true;
            this.cmdBorraTodo.Click += new System.EventHandler(this.cmdBorraTodo_Click);
            // 
            // frmCargaDeVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(487, 663);
            this.Controls.Add(this.cmdBorraTodo);
            this.Controls.Add(this.cmdListado);
            this.Controls.Add(this.cmdVolver);
            this.Controls.Add(this.mrcConsultarProductos);
            this.Controls.Add(this.mrcCargaDeVentas);
            this.Controls.Add(this.lblVentas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(503, 702);
            this.MinimumSize = new System.Drawing.Size(503, 702);
            this.Name = "frmCargaDeVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.frmCargaDeVentas_Load);
            this.mrcCargaDeVentas.ResumeLayout(false);
            this.mrcCargaDeVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.mrcConsultarProductos.ResumeLayout(false);
            this.mrcFiltrosDeConsultas.ResumeLayout(false);
            this.mrcFiltrosDeConsultas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVentas;
        private System.Windows.Forms.GroupBox mrcCargaDeVentas;
        private System.Windows.Forms.DateTimePicker dtpFechaDeVenta;
        private System.Windows.Forms.Label lblFechaDeVenta;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button cmdCargar;
        private System.Windows.Forms.GroupBox mrcConsultarProductos;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.ComboBox cboProductos;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Button cmdVolver;
        private System.Windows.Forms.GroupBox mrcFiltrosDeConsultas;
        private System.Windows.Forms.Button cmdFiltrar;
        private System.Windows.Forms.TextBox txtBuscarCantidad;
        private System.Windows.Forms.RadioButton optCantidad;
        private System.Windows.Forms.RadioButton optProductos;
        private System.Windows.Forms.ComboBox cboFiltroProducto;
        private System.Windows.Forms.Button cmdListado;
        private System.Windows.Forms.Button cmdBorraTodo;
    }
}