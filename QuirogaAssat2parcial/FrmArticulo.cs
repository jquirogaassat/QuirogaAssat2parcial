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
    public partial class FrmArticulo : Form
    {
        public FrmArticulo()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                BLL.BllArticulo.getInstancia().Add(new BE.Articulo()
                {
                    Nombre = txt_nombre.Text,
                    Precio = int.Parse(txt_precio.Text),
                    Stock = int.Parse(txt_cantidad.Text)

                });
                MessageBox.Show("Producto dado de alta");

                dg_vista.DataSource = BLL.BllArticulo.getInstancia().GetAll();
                txt_cantidad.Clear();
                txt_nombre.Clear();
                txt_precio.Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                BLL.BllArticulo.getInstancia().Update(new BE.Articulo()
                {
                    Id = int.Parse(txt_actId.Text),
                    Nombre = txt_actnombre.Text,
                    Precio = int.Parse(txt_actprecio.Text),
                    Stock= int.Parse(txt_actcantidad.Text)
                });
                MessageBox.Show("Articulo actualizado");
                txt_cantidad.Clear();
                txt_nombre.Clear();
                txt_precio.Clear();
                dg_vista.DataSource = BLL.BllArticulo.getInstancia().GetAll();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            dg_vista.DataSource = BLL.BllArticulo.getInstancia().GetAll();
        }

        private void FrmArticulo_Load(object sender, EventArgs e)
        {

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                BLL.BllArticulo.getInstancia().Delete(new BE.Articulo()
                {
                    Id = int.Parse(txt_eliminar.Text)

                });
                MessageBox.Show("Articulo eliminado");
                dg_vista.DataSource = BLL.BllArticulo.getInstancia().GetAll();
                txt_eliminar.Clear();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
    }
