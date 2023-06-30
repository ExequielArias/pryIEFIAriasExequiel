namespace pryIEFIAriasExequiel
{
    partial class frmListado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListado));
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.lblListado = new System.Windows.Forms.Label();
            this.mrcFiltros = new System.Windows.Forms.GroupBox();
            this.cmdVerTodo = new System.Windows.Forms.Button();
            this.cmdFiltrar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.optCantidad = new System.Windows.Forms.RadioButton();
            this.optProducto = new System.Windows.Forms.RadioButton();
            this.cmdVolver = new System.Windows.Forms.Button();
            this.cboFiltroProducto = new System.Windows.Forms.ComboBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.mrcFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListado
            // 
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Fecha,
            this.Producto,
            this.Cantidad});
            this.dgvListado.Location = new System.Drawing.Point(12, 46);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.Size = new System.Drawing.Size(656, 273);
            this.dgvListado.TabIndex = 0;
            // 
            // lblListado
            // 
            this.lblListado.AutoSize = true;
            this.lblListado.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListado.Location = new System.Drawing.Point(12, 9);
            this.lblListado.Name = "lblListado";
            this.lblListado.Size = new System.Drawing.Size(119, 34);
            this.lblListado.TabIndex = 1;
            this.lblListado.Text = "Listado";
            // 
            // mrcFiltros
            // 
            this.mrcFiltros.Controls.Add(this.cboFiltroProducto);
            this.mrcFiltros.Controls.Add(this.cmdVerTodo);
            this.mrcFiltros.Controls.Add(this.cmdFiltrar);
            this.mrcFiltros.Controls.Add(this.txtBuscar);
            this.mrcFiltros.Controls.Add(this.optCantidad);
            this.mrcFiltros.Controls.Add(this.optProducto);
            this.mrcFiltros.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcFiltros.Location = new System.Drawing.Point(163, 326);
            this.mrcFiltros.Name = "mrcFiltros";
            this.mrcFiltros.Size = new System.Drawing.Size(303, 147);
            this.mrcFiltros.TabIndex = 2;
            this.mrcFiltros.TabStop = false;
            this.mrcFiltros.Text = "Filtrar";
            // 
            // cmdVerTodo
            // 
            this.cmdVerTodo.Location = new System.Drawing.Point(178, 105);
            this.cmdVerTodo.Name = "cmdVerTodo";
            this.cmdVerTodo.Size = new System.Drawing.Size(71, 23);
            this.cmdVerTodo.TabIndex = 4;
            this.cmdVerTodo.Text = "Ver Todo";
            this.cmdVerTodo.UseVisualStyleBackColor = true;
            this.cmdVerTodo.Click += new System.EventHandler(this.cmdVerTodo_Click);
            // 
            // cmdFiltrar
            // 
            this.cmdFiltrar.Location = new System.Drawing.Point(68, 105);
            this.cmdFiltrar.Name = "cmdFiltrar";
            this.cmdFiltrar.Size = new System.Drawing.Size(75, 23);
            this.cmdFiltrar.TabIndex = 3;
            this.cmdFiltrar.Text = "Filtrar";
            this.cmdFiltrar.UseVisualStyleBackColor = true;
            this.cmdFiltrar.Click += new System.EventHandler(this.cmdFiltrar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(174, 57);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(123, 21);
            this.txtBuscar.TabIndex = 2;
            // 
            // optCantidad
            // 
            this.optCantidad.AutoSize = true;
            this.optCantidad.Location = new System.Drawing.Point(174, 34);
            this.optCantidad.Name = "optCantidad";
            this.optCantidad.Size = new System.Drawing.Size(75, 19);
            this.optCantidad.TabIndex = 1;
            this.optCantidad.Text = "Cantidad";
            this.optCantidad.UseVisualStyleBackColor = true;
            // 
            // optProducto
            // 
            this.optProducto.AutoSize = true;
            this.optProducto.Checked = true;
            this.optProducto.Location = new System.Drawing.Point(25, 34);
            this.optProducto.Name = "optProducto";
            this.optProducto.Size = new System.Drawing.Size(77, 19);
            this.optProducto.TabIndex = 0;
            this.optProducto.TabStop = true;
            this.optProducto.Text = "Producto";
            this.optProducto.UseVisualStyleBackColor = true;
            // 
            // cmdVolver
            // 
            this.cmdVolver.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVolver.Location = new System.Drawing.Point(593, 450);
            this.cmdVolver.Name = "cmdVolver";
            this.cmdVolver.Size = new System.Drawing.Size(75, 23);
            this.cmdVolver.TabIndex = 3;
            this.cmdVolver.Text = "Volver";
            this.cmdVolver.UseVisualStyleBackColor = true;
            this.cmdVolver.Click += new System.EventHandler(this.cmdVolver_Click);
            // 
            // cboFiltroProducto
            // 
            this.cboFiltroProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltroProducto.FormattingEnabled = true;
            this.cboFiltroProducto.Location = new System.Drawing.Point(25, 57);
            this.cboFiltroProducto.Name = "cboFiltroProducto";
            this.cboFiltroProducto.Size = new System.Drawing.Size(128, 23);
            this.cboFiltroProducto.TabIndex = 5;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 150;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 150;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.Width = 170;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 150;
            // 
            // frmListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(680, 485);
            this.Controls.Add(this.cmdVolver);
            this.Controls.Add(this.mrcFiltros);
            this.Controls.Add(this.lblListado);
            this.Controls.Add(this.dgvListado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListado";
            this.Text = "Listado";
            this.Load += new System.EventHandler(this.frmListado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.mrcFiltros.ResumeLayout(false);
            this.mrcFiltros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.Label lblListado;
        private System.Windows.Forms.GroupBox mrcFiltros;
        private System.Windows.Forms.Button cmdVerTodo;
        private System.Windows.Forms.Button cmdFiltrar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.RadioButton optCantidad;
        private System.Windows.Forms.RadioButton optProducto;
        private System.Windows.Forms.Button cmdVolver;
        private System.Windows.Forms.ComboBox cboFiltroProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
    }
}