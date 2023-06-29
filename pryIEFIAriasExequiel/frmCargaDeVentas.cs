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
                    int n = dgvProductos.Rows.Add();
                    dgvProductos.Rows[n].Cells[0].Value = "";
                    dgvProductos.Rows[n].Cells[1].Value = dtpFechaDeVenta.Text;
                    dgvProductos.Rows[n].Cells[2].Value = txtProducto.Text;
                    dgvProductos.Rows[n].Cells[3].Value = nudCantidad.Text; 
                }
            }
            else
            {
                MessageBox.Show("Agregue un Producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cboProductos.Items.Add(txtProducto.Text);

        }

        private void cmdFiltrar_Click(object sender, EventArgs e)
        {
            if (optCantidad.Checked) 
            {

            }
        }
    }
}
