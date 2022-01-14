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
    public partial class FrmByidFactura : Form
    {
        public FrmByidFactura()
        {
            InitializeComponent();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            BE.Factura fac1 = new BE.Factura();
          

            BE.Factura fac2 = new BE.Factura
            {
                Id = Convert.ToInt32(txt_Idfactura.Text)
            };

            fac1 = BLL.BllFactura.getInstancia().GetById(fac2);
           

            dg_IdFactura.DataSource = BLL.BllDetalleFactura.getInstancia().GetAllByIntIdfactura(fac2);
            lbl_totFactu.Text= Convert.ToString(BLL.BllFactura.getInstancia().GetTotal(fac2));
            
        }
    }
}
