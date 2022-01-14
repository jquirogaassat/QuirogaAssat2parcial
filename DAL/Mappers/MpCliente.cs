using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL.Mappers
{
    internal class MpCliente
    {
        #region singleton 
        private MpCliente()
        {

        }

        private static MpCliente instancia;

        public static MpCliente getInstancia()
        {
            if (instancia == null)
            {
                instancia = new MpCliente();
            }
            return instancia;
        } 
        #endregion


        public List<BE.Cliente> Mapeo (DataSet dataSet)
        {
            List<BE.Cliente> clientes = new List<BE.Cliente>();

            foreach  (DataRow item in dataSet.Tables[0].Rows )
            {
                clientes.Add(new BE.Cliente()
                {
                    Id= int.Parse(item["intId"].ToString()),
                    nombre = item["varNombre"].ToString(),
                    apellido = item["varApellido"].ToString(),                    
                    direccion = item["varDireccion"].ToString(),
                    telefono = item["varTelefono"].ToString()

                });
            }
            return clientes;
        }
    }
}
