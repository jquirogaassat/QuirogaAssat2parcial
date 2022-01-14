using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BllDetalleFactura : BE.IFactura<BE.Factura, BE.DetalleFactura>, BE.ICrud<BE.DetalleFactura>
    {

        #region singleton

        private BllDetalleFactura()
        {

        }

        private static BllDetalleFactura instancia;

        public static BllDetalleFactura getInstancia()
        {
            if (instancia == null)
            {
                instancia = new BllDetalleFactura();
            }
            return instancia;
        }
        #endregion

        #region ICrud, IFactura
        public bool Add(DetalleFactura entAlta)
        {
            return DAL.DalDetalleFactura.getInstancia().Add(entAlta);
        }

        public bool AddLine(Factura objFac, DetalleFactura objdet)
        {
            throw new NotImplementedException();
        }

        public int CantidadProductos(Factura objSub)
        {
            throw new NotImplementedException();
        }

        public bool Delete(DetalleFactura entDel)
        {
            return DAL.DalDetalleFactura.getInstancia().Delete(entDel);
        }

        public IList<DetalleFactura> GetAll()
        {
            return DAL.DalDetalleFactura.getInstancia().GetAll();
        }

        public List<DetalleFactura> GetDetails(Factura objDet)
        {
            return DAL.DalDetalleFactura.getInstancia().GetDetails(objDet);
            //throw new NotImplementedException();
        }
        //public List<BE.DetalleFactura> GetAllByIntIdFactura(BE.Factura factura)
        //{
        //    return DAL.DalDetalleFactura.getInstancia().GetAllByIdFactura(factura);
        //}
        public decimal GetSubtotal(Factura objSub)
        {
            throw new NotImplementedException();
        }

        public decimal GetTotal(Factura objdet)
        {
            throw new NotImplementedException();
        }

        public bool Update(DetalleFactura entUpd)
        {
            return DAL.DalDetalleFactura.getInstancia().Update(entUpd);
        }

        public bool Validar(DetalleFactura entVal)
        {
            throw new NotImplementedException();
        }

        public DetalleFactura SelectById(DetalleFactura objSelect)
        {
            throw new NotImplementedException();
        }

       public IList<BE.DetalleFactura> GetAllByIntIdfactura( BE.Factura factura)
        {
            return DAL.DalDetalleFactura.getInstancia().GetAllByIdFactura(factura);
        }
        #endregion
    }
}
