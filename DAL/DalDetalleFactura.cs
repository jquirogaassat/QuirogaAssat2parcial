using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DalDetalleFactura : BE.ICrud<BE.DetalleFactura>, BE.IFactura<BE.Factura, BE.DetalleFactura>
    {
        #region singleton
        private DalDetalleFactura()
        {

        }

        private static DalDetalleFactura instancia;

        public static DalDetalleFactura getInstancia()
        {
            if (instancia == null)
            {
                instancia = new DalDetalleFactura();
            }
            return instancia;
        }

        #endregion


        #region ICrud IFactura
        public bool Add(DetalleFactura entAlta)
        {
            return DAL.DAOS.DaoDetalleFactura.getInstancia().Add(entAlta);

        }

        public bool Delete(DetalleFactura entDel)
        {
            return DAL.DAOS.DaoDetalleFactura.getInstancia().Delete(entDel);
        }

        public IList<DetalleFactura> GetAll()
        {
            return DAL.DAOS.DaoDetalleFactura.getInstancia().GetAll();
        }

        public bool Update(DetalleFactura entUpd)
        {
            return DAL.DAOS.DaoDetalleFactura.getInstancia().Update(entUpd);
        }

        public bool Validar(DetalleFactura entVal)
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
            return DAL.DAOS.DaoDetalleFactura.getInstancia().GetDetails(objDet);
            //throw new NotImplementedException();
        }
        //public List<BE.DetalleFactura> GetAllByIdFactura(BE.Factura factura)
        //{
        //    return DAL.DAOS.DaoDetalleFactura.getInstancia().GetByIntIdFactura(factura);
        //}

        public bool AddLine(Factura objFac, DetalleFactura objdet)
        {
            throw new NotImplementedException();
        }

        public DetalleFactura SelectById(DetalleFactura objSelect)
        {
            throw new NotImplementedException();
        }

        public IList<BE.DetalleFactura> GetAllByIdFactura(BE.Factura factura)
        {
            return DAOS.DaoDetalleFactura.getInstancia().GetAllByIdFactura(factura);
        }

       
        #endregion
    }
}
