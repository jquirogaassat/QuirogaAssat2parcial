using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BllArticulo : BE.ICrud<BE.Articulo>, BE.IFactura<BE.Factura,BE.DetalleFactura>
    {
        #region singleton
        private BllArticulo()
        {

        }

        private static BllArticulo instancia;

        public static BllArticulo getInstancia()
        {
            if (instancia == null)
            {
                instancia = new BllArticulo();
            }
            return instancia;
        } 
        #endregion

        public bool Add(Articulo entAlta)
        {
            return DAL.DalArticulo.getInstancia().Add(entAlta);
        }

        public bool Delete(Articulo entDel)
        {
            return DAL.DalArticulo.getInstancia().Delete(entDel);
        }

        public IList<Articulo> GetAll()
        {
            return DAL.DalArticulo.getInstancia().GetAll();
        }

        public bool Update(Articulo entUpd)
        {
            return DAL.DalArticulo.getInstancia().Update(entUpd);
        }

       public bool Validar(BE.Articulo entVal)
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
