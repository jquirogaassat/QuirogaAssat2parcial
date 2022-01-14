using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DalArticulo : BE.ICrud<BE.Articulo>, BE.IFactura<BE.Factura,BE.DetalleFactura>
    {


        #region singleton 
        private DalArticulo()
        {

        }
        private static DalArticulo instancia;

        public static DalArticulo getInstancia()
        {
            if (instancia == null)
            {
                instancia = new DalArticulo();
            }
            return instancia;
        } 
        #endregion
        public bool Add(Articulo entAlta)
        {
            return DAL.DAOS.DaoArticulo.getInstancia().Add(entAlta);
        }

        public bool Delete(Articulo entDel)
        {
            return DAL.DAOS.DaoArticulo.getInstancia().Delete(entDel);
        }

        public IList<Articulo> GetAll()
        {
            return DAL.DAOS.DaoArticulo.getInstancia().GetAll();
        }

        public bool Update(Articulo entUpd)
        {
            return DAL.DAOS.DaoArticulo.getInstancia().Update(entUpd);
        }

        public bool Validar(Articulo entVal)
        {
            throw new NotImplementedException();
        }

        public Articulo SelectById(Articulo objSelect)
        {
            throw new NotImplementedException();
        }

        public decimal GetTotal(Factura objdet)
        {
            throw new NotImplementedException();
        }

        public decimal GetSubtotal(Factura objSub)
        {
            throw new NotImplementedException();
        }

        public int CantidadProductos(Factura objSub)
        {
            throw new NotImplementedException();
        }

        public List<DetalleFactura> GetDetails(Factura objDet)
        {
            throw new NotImplementedException();
        }

        public bool AddLine(Factura objFac, DetalleFactura objdet)
        {
            throw new NotImplementedException();
        }
    }
}
