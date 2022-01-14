using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuirogaAssat2parcial
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente frmCliente = new FrmCliente();
            frmCliente.MdiParent = this;
            frmCliente.Show();
        }

        private void aBMCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmArticulo frmArticulo = new FrmArticulo();
            frmArticulo.MdiParent = this;
            frmArticulo.Show();
        }

        private void aBMCToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmDetalleFactura frmDetalleFactura = new FrmDetalleFactura();
            frmDetalleFactura.MdiParent = this;
            frmDetalleFactura.Show();
        }

        private void listByIDFactuOrCustToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListarFactura frmListarFactura = new FrmListarFactura();
            frmListarFactura.MdiParent = this;
            frmListarFactura.Show();
        }

        private void searchByIdFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmByidFactura frmByidFactura = new FrmByidFactura();
            frmByidFactura.MdiParent = this;
            frmByidFactura.Show();
        }

        private void buscarPorNombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmByIdCliente frmByIdCliente = new FrmByIdCliente();
            frmByIdCliente.MdiParent= this;
            frmByIdCliente.Show();
        }
    }
}
