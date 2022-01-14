using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mappers
{
    internal class MpArticulo
    {

        #region singleton
        private MpArticulo()
        {

        }

        private static MpArticulo instancia;

        public static MpArticulo getInstancia()
        {
            if (instancia == null)
            {
                instancia = new MpArticulo();
            }
            return instancia;
        } 
        #endregion

        public List<BE.Articulo> Mapeo (DataSet dataSet)
        {
            List<BE.Articulo> articulos = new List<BE.Articulo>();
           foreach (DataRow item in dataSet.Tables[0].Rows)
            {
                articulos.Add(new BE.Articulo()
                {
                    Id = int.Parse(item["intId"].ToString()),
                    Nombre = item["varNombre"].ToString(),
                    Precio = decimal.Parse(item["decPrecio"].ToString()),
                    Stock = int.Parse(item["intStock"].ToString())
                });
            }
            return articulos;
        }
    }
}
