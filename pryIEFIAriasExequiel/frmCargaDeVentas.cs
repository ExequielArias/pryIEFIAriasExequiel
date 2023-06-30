using System;
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
    public partial class frmCargaDeVentas : Form
    {
        string[,] MatrizProductos = new string[10, 4];
        int fila = 0;
        frmListado Listado = new frmListado();  
        public frmCargaDeVentas()
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

        private void frmCargaDeVentas_Load(object sender, EventArgs e)
        {

        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            if (txtProducto.Text != "")
            {
                if (dtpFechaDeVenta.Value < DateTime.Today)
                {
                    MessageBox.Show("Indique una fecha actual o posterior a la de hoy", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MatrizProductos[fila, 0] = (fila + 1).ToString();
                    MatrizProductos[fila, 1] = dtpFechaDeVenta.Text;
                    MatrizProductos[fila, 2] = txtProducto.Text;
                    MatrizProductos[fila, 3] = nudCantidad.Text;
                    Listado.MatrizProductos[fila, 0] = (fila + 1).ToString();
                    Listado.MatrizProductos[fila, 1] = dtpFechaDeVenta.Text;
                    Listado.MatrizProductos[fila, 2] = txtProducto.Text;
                    Listado.MatrizProductos[fila, 3] = nudCantidad.Text;
                    dgvProductos.Rows.Add(MatrizProductos[fila, 0], MatrizProductos[fila, 1], MatrizProductos[fila, 2], MatrizProductos[fila, 3]);
                    fila++; 
                }
            }
            else
            {
                MessageBox.Show("Agregue un Producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cboProductos.Items.Add(txtProducto.Text);
            cboFiltroProducto.Items.Add(txtProducto.Text); 

        }

        private void cmdFiltrar_Click(object sender, EventArgs e)
        {

            dgvProductos.Rows.Clear(); 
            if (optProductos.Checked)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (MatrizProductos[i, 2] == cboFiltroProducto.Text) 
                    {
                        dgvProductos.Rows.Add(MatrizProductos[i, 0], MatrizProductos[i, 1], MatrizProductos[i, 2], MatrizProductos[i, 3]);
                    }
                }
            }
            else
            {
                for (int i = 0; i < 10; i++)
                {
                    if (MatrizProductos[i, 3] == txtBuscarCantidad.Text)
                    {
                        dgvProductos.Rows.Add(MatrizProductos[i, 0], MatrizProductos[i, 1], MatrizProductos[i, 2], MatrizProductos[i, 3]);
                    }
                }
            }

        }

        private void cmdListado_Click(object sender, EventArgs e)
        {
            Listado.ShowDialog(); 
        }
    }
}
