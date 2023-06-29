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
            this.optProducto = new System.Windows.Forms.RadioButton();
            this.optCantidad = new System.Windows.Forms.RadioButton();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cmdFiltrar = new System.Windows.Forms.Button();
            this.cmdVerTodo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.mrcFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListado
            // 
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.mrcFiltros.Controls.Add(this.cmdVerTodo);
            this.mrcFiltros.Controls.Add(this.cmdFiltrar);
            this.mrcFiltros.Controls.Add(this.txtBuscar);
            this.mrcFiltros.Controls.Add(this.optCantidad);
            this.mrcFiltros.Controls.Add(this.optProducto);
            this.mrcFiltros.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcFiltros.Location = new System.Drawing.Point(226, 326);
            this.mrcFiltros.Name = "mrcFiltros";
            this.mrcFiltros.Size = new System.Drawing.Size(240, 147);
            this.mrcFiltros.TabIndex = 2;
            this.mrcFiltros.TabStop = false;
            this.mrcFiltros.Text = "Filtrar";
            // 
            // optProducto
            // 
            this.optProducto.AutoSize = true;
            this.optProducto.Location = new System.Drawing.Point(25, 34);
            this.optProducto.Name = "optProducto";
            this.optProducto.Size = new System.Drawing.Size(77, 19);
            this.optProducto.TabIndex = 0;
            this.optProducto.TabStop = true;
            this.optProducto.Text = "Producto";
            this.optProducto.UseVisualStyleBackColor = true;
            // 
            // optCantidad
            // 
            this.optCantidad.AutoSize = true;
            this.optCantidad.Location = new System.Drawing.Point(153, 34);
            this.optCantidad.Name = "optCantidad";
            this.optCantidad.Size = new System.Drawing.Size(75, 19);
            this.optCantidad.TabIndex = 1;
            this.optCantidad.TabStop = true;
            this.optCantidad.Text = "Cantidad";
            this.optCantidad.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(27, 68);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(193, 21);
            this.txtBuscar.TabIndex = 2;
            // 
            // cmdFiltrar
            // 
            this.cmdFiltrar.Location = new System.Drawing.Point(40, 105);
            this.cmdFiltrar.Name = "cmdFiltrar";
            this.cmdFiltrar.Size = new System.Drawing.Size(75, 23);
            this.cmdFiltrar.TabIndex = 3;
            this.cmdFiltrar.Text = "Filtrar";
            this.cmdFiltrar.UseVisualStyleBackColor = true;
            // 
            // cmdVerTodo
            // 
            this.cmdVerTodo.Location = new System.Drawing.Point(138, 105);
            this.cmdVerTodo.Name = "cmdVerTodo";
            this.cmdVerTodo.Size = new System.Drawing.Size(71, 23);
            this.cmdVerTodo.TabIndex = 4;
            this.cmdVerTodo.Text = "Ver Todo";
            this.cmdVerTodo.UseVisualStyleBackColor = true;
            // 
            // frmListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(680, 485);
            this.Controls.Add(this.mrcFiltros);
            this.Controls.Add(this.lblListado);
            this.Controls.Add(this.dgvListado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListado";
            this.Text = "Listado";
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
    }
}