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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
        //    dg_vista.Columns.Add("Id", "Id");
        //    dg_vista.Columns.Add("Nombre", "Nombre");
        //    dg_vista.Columns.Add("Apellido", "Apellido");
        //    dg_vista.Columns.Add("Direccion", "Direccion");
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                BLL.BllCliente.getInstancia().Add(new BE.Cliente()
                {
                    nombre = txt_nombre.Text,
                    apellido = txt_apellido.Text,
                    direccion = txt_direccion.Text,
                    telefono = txt_telefono.Text

                });
                MessageBox.Show("Usuario creado exitosamente");
               
                txt_apellido.Clear();
                txt_nombre.Clear();
                txt_direccion.Clear();
                txt_telefono.Clear();
                dg_vista.DataSource = BLL.BllCliente.getInstancia().GetAll();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
           
            
            try
            {
                BLL.BllCliente.getInstancia().Delete(new BE.Cliente()
                {
                    Id = int.Parse(txt_eliminar.Text)
                    
                }) ;
                MessageBox.Show("Usuario eliminado");
                dg_vista.DataSource = BLL.BllCliente.getInstancia().GetAll();
                txt_eliminar.Clear();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            dg_vista.DataSource= BLL.BllCliente.getInstancia().GetAll();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                BLL.BllCliente.getInstancia().Update(new BE.Cliente()

                {
                    Id= int.Parse(txt_actid.Text),
                    nombre= txt_nombre.Text,
                    apellido = txt_apellido.Text,
                    direccion = txt_direccion.Text,
                    telefono = txt_telefono.Text
                });
                MessageBox.Show("Usuario actualizado exitosamente");
                txt_apellido.Clear();
                txt_nombre.Clear();
                txt_direccion.Clear();
                txt_telefono.Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dg_vista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
