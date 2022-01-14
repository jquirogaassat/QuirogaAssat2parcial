using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mappers
{
    internal class MpFactura
    {
        #region singleton
        private MpFactura()
        {

        }

        private static MpFactura instancia;
        public static MpFactura getInstancia()
        {
            if (instancia == null)
            {
                instancia = new MpFactura();
            }
            return instancia;
        }
        #endregion


        public List<BE.Factura> Mapeo(DataSet dataset)
        {
            List<BE.Factura> detalleFacturas = new List<BE.Factura>();

            foreach (DataRow item in dataset.Tables[0].Rows)
            {
                detalleFacturas.Add(new BE.Factura()
                {
                    Id = int.Parse(item["intId"].ToString()),
                    Fecha= DateTime.Parse(item["datFecha"].ToString()),
                    IdCliente = int.Parse(item["intIdCliente"].ToString()),
                   


                });
            }
            return detalleFacturas;


        }
    }
}
