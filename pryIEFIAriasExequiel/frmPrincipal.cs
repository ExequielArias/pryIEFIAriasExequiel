using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryIEFIAriasExequiel
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void cmdProductos_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCargaDeProductos CargaDeProductos = new frmCargaDeProductos();
            CargaDeProductos.ShowDialog();   
        }

        private void cmdVentas_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            frmCargaDeVentas CargaDeVentas = new frmCargaDeVentas();
            CargaDeVentas.ShowDialog();
        }
    }
}
