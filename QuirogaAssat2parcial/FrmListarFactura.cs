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
    public partial class FrmListarFactura : Form
    {
        public FrmListarFactura()
        {
            InitializeComponent();
        }

        private void FrmListarFactura_Load(object sender, EventArgs e)
        {
            dg_listadoClientes.DataSource = BLL.BllCliente.getInstancia().GetAll();
            //dg_ListadoFactura.DataSource= BLL.BllFactura.getInstancia().
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                BE.Factura factura = new BE.Factura();
                {
                    factura.IdCliente= Convert.ToInt32(dg_listadoClientes.CurrentRow.Cells[0].Value);
                }

                dg_ListadoFactura.DataSource = BLL.BllFactura.getInstancia().GetAllByIdCliente(factura);

              

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dg_ListadoFactura_SelectionChanged(object sender, EventArgs e)
        {

            BE.Factura factura = new BE.Factura
            {
                Id = Convert.ToInt32(dg_ListadoFactura.CurrentRow.Cells[0].Value)
            };

            dg_DetallesFactura.DataSource = BLL.BllDetalleFactura.getInstancia().GetDetails(factura);
            //dg_DetallesFactura.DataSource = BLL.BllDetalleFactura.getInstancia().GetAllByIntIdFactura(factura);

            lbl_tot.Text = Convert.ToString(BLL.BllFactura.getInstancia().GetTotal(factura));
        }
    }
}
