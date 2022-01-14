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
    public partial class FrmByIdCliente : Form
    {
        public FrmByIdCliente()
        {
            InitializeComponent();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {

            try
            {

                IList<BE.Cliente> clientes = new List<BE.Cliente>();
                BE.Cliente clienteBuscado = new BE.Cliente()
                {
                    nombre = txt_nombre.ToString()
                };
                BE.Cliente clienteEncontrado = new BE.Cliente();
                //IList<BE.Factura> facturas = new List<BE.Factura>();
                
                

                clientes = BLL.BllCliente.getInstancia().GetAll();

               // clienteBuscado.nombre = txt_nombre.ToString();
                //clienteEncontrado = clienteBuscado;
                //int jj = facturas.Count - 1;
                foreach (var item in clientes)
                {
                    if ( txt_nombre.Text == item.nombre)
                    {
                        clienteEncontrado = clienteBuscado;
                    }
                }

                //clienteEncontrado = BLL.BllCliente.getInstancia().GetAllByName();
                //BE.Factura factura = new BE.Factura();
                //{
                //    factura.IdCliente = Convert.ToInt32(dg_cliente.CurrentRow.Cells[0].Value);
                //}

                dg_cliente.DataSource = BLL.BllCliente.getInstancia().GetAllByName(clienteEncontrado);
                //dg_facturas.DataSource = BLL.BllFactura.getInstancia().GetAllByIdCliente(facturas);
            }
            catch (Exception)
            {

                throw;
            }
           
        }
    }
}
