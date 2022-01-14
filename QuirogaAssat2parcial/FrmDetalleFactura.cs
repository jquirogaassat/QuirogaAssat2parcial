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
    public partial class FrmDetalleFactura : Form
    {
        
        public FrmDetalleFactura()
        {
            InitializeComponent();            

        }

        private void FrmDetalleFactura_Load(object sender, EventArgs e)
        {
            dg_cliente.DataSource = BLL.BllCliente.getInstancia().GetAll();
            dg_articulo.DataSource = BLL.BllArticulo.getInstancia().GetAll();
            
        }

        private void btn_cargarArticulo_Click(object sender, EventArgs e)
        {
            try
            {
                decimal a, b, subtotal ;
                
                
                decimal acumulador = 0;
                string aux = "0";

                a = decimal.Parse(txt_cantidad.Text);
                b = decimal.Parse(Convert.ToString(dg_articulo[1, dg_articulo.CurrentRow.Index].Value));
                subtotal = a * b;



                dg_detalleFac.Rows.Add(new string[]
                {

                Convert.ToString(dg_articulo[3,dg_articulo.CurrentRow.Index].Value),// producto
                Convert.ToString(txt_cantidad.Text),//cantidad
                Convert.ToString(dg_articulo[1,dg_articulo.CurrentRow.Index].Value),// precio
                Convert.ToString(a*b),// subtotal
                 
                  }) ;

                //foreach (DataGridViewRow row in dg_detalleFac.Rows)
                //{
                //    acumulador = (acumulador + (a * b));

                //}

               aux = lbl_prueba.Text;
               acumulador = Convert.ToDecimal(aux)+subtotal;
               lbl_prueba.Text = Convert.ToString(acumulador);//125
               
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }

        }

        private void btn_generarFactura_Click(object sender, EventArgs e)
        {
            try
            {   

                BE.Factura factura = new BE.Factura
                {
                    
                    IdCliente = Convert.ToInt32(dg_cliente.CurrentRow.Cells[0].Value),
                    Fecha= DateTime.Now
                    
                };
                List<BE.DetalleFactura> detalle = new List<BE.DetalleFactura>();
                



                foreach (DataGridViewRow row in dg_detalleFac.Rows)
                {
                    BE.DetalleFactura detalleFactura = new BE.DetalleFactura();
                    detalleFactura.IdArticulo = Convert.ToInt32(row.Cells[0].Value);
                    detalleFactura.Cantidad = Convert.ToInt32(row.Cells[1].Value);
                    detalle.Add(detalleFactura);
                    
                }

                foreach ( BE.DetalleFactura  det in detalle)
                {
                    factura.Detalles = detalle;
                }

              //  factura.Detalles = detalle;
                
                if (BLL.BllFactura.getInstancia().Add(factura))
                {
                    MessageBox.Show("Factura exitosa");
                    dg_detalleFac.DataSource = "";
                    txt_cantidad.Clear();
                }
                else
                {
                    MessageBox.Show("error");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


           
        }
    }
}
