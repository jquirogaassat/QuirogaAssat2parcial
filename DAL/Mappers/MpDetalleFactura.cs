using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;

namespace DAL.Mappers
{
    internal class MpDetalleFactura
    {
        #region singleton 
        private MpDetalleFactura()
        {

        }

        private static MpDetalleFactura instancia;

        public static MpDetalleFactura getInstancia()
        {
            if (instancia == null)
            {
                instancia = new MpDetalleFactura();
            }

            return instancia;
        } 
        #endregion

        public  List<BE.DetalleFactura> Mapeo(DataSet dataset)
        {
            List<BE.DetalleFactura> detalleFacturas= new List<BE.DetalleFactura>();

            foreach( DataRow item in dataset.Tables[0].Rows)
            {
                detalleFacturas.Add(new BE.DetalleFactura()
                {
                    Id = int.Parse(item["intId"].ToString()),
                    IdArticulo = int.Parse(item["intIdProducto"].ToString()),
                    IdFactura = int.Parse(item["intIdFactura"].ToString()),
                    Cantidad = int.Parse(item["intCantidad"].ToString())


                });
            }
            return detalleFacturas;

        }
    }
}
