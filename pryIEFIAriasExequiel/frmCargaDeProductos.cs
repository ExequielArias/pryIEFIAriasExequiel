﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryIEFIAriasExequiel
{
    public partial class frmCargaDeProductos : Form
    {
        string[,] MatrizProductos = new string[10, 4];
        int fila = 0;
        frmListado Listado = new frmListado(); 

        public frmCargaDeProductos()
        {
            InitializeComponent();
            txtProducto.Focus(); 
        }

        private void cmdVolver_Click(object sender, EventArgs e)
        { 
            this.Hide();
            frmPrincipal principal = new frmPrincipal();
            principal.ShowDialog(); 
        }

        private void frmCargaDeProductos_Load(object sender, EventArgs e)
        {
           
        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            if (txtProducto.Text != "")
            {
                if (dtpFecha.Value < DateTime.Today)
                {
                    MessageBox.Show("Indique una fecha actual o posterior a la de hoy", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                    int n = dgvConsultas.Rows.Add();
                    dgvConsultas.Rows[n].Cells[0].Value = "";  
                    dgvConsultas.Rows[n].Cells[1].Value = txtProducto.Text;
                    dgvConsultas.Rows[n].Cells[2].Value = dtpFecha.Text;
                    Listado.MatrizProductos[fila, 0] = (fila + 1).ToString();
                    Listado.MatrizProductos[fila, 1] = dtpFecha.Text;
                    Listado.MatrizProductos[fila, 2] = txtProducto.Text;
                    fila++;
                }
            }
            else
            {
                MessageBox.Show("Agregue un Producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
            cboConsultas.Items.Add(txtProducto.Text);   
        }

        private void cboConsultas_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmdListado_Click(object sender, EventArgs e)
        {
            Listado.ShowDialog(); 
        }

        private void cmdBorraTodo_Click(object sender, EventArgs e)
        {
            dgvConsultas.Rows.Clear(); 
        }
    }
}
