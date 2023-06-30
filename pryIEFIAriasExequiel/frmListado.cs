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
    public partial class frmListado : Form
    {
      public string[,] MatrizProductos = new string[10, 4];
        public frmListado()
        {
            InitializeComponent();
        }

        private void cmdVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal principal = new frmPrincipal();
            principal.ShowDialog(); 
        }

        private void cmdFiltrar_Click(object sender, EventArgs e)
        {
            dgvListado.Rows.Clear();
            if (optProducto.Checked)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (MatrizProductos[i, 2] == cboFiltroProducto.Text)
                    {
                        dgvListado.Rows.Add(MatrizProductos[i, 0], MatrizProductos[i, 1], MatrizProductos[i, 2], MatrizProductos[i, 3]);
                    }
                }
            }
            else
            {
                for (int i = 0; i < 10; i++)
                {
                    if (MatrizProductos[i, 3] == txtBuscar.Text)
                    {
                        dgvListado.Rows.Add(MatrizProductos[i, 0], MatrizProductos[i, 1], MatrizProductos[i, 2], MatrizProductos[i, 3]);
                    }
                }
            }
        }

        private void frmListado_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                if (MatrizProductos[i, 2] != null)
                {
                    if (cboFiltroProducto.Items.Contains(MatrizProductos[i, 2]) == false)
                    {
                        cboFiltroProducto.Items.Add(MatrizProductos[i, 2]); 
                    }
                }
            }
        }

        private void cmdVerTodo_Click(object sender, EventArgs e)
        {
            dgvListado.Rows.Clear(); 
            for (int i = 0; i < 10; i++)
            {
                if (MatrizProductos[i, 2] != null) 
                {
                    dgvListado.Rows.Add(MatrizProductos[i, 0], MatrizProductos[i, 1], MatrizProductos[i, 2], MatrizProductos[i, 3]);
                }
            }

        }

        private void cmdBorrar_Click(object sender, EventArgs e)
        {
            dgvListado.Rows.Clear(); 
        }
    }
}
