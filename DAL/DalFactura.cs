using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DalFactura : BE.IFactura<BE.Factura, BE.DetalleFactura>, BE.ICrud<BE.Factura>
    {

        #region singleton
        private DalFactura()
        {

        }

        private static DalFactura instancia;

        public static DalFactura getInstancia()
        {
            if (instancia == null)
            {
                instancia = new DalFactura();
            }
            return instancia;
        } 
        #endregion
        public bool Add(Factura entAlta)
        {
            return DAOS.DaoFactura.getInstancia().Add(entAlta); 
        }

        public bool AddLine(Factura objFac, DetalleFactura objdet)
        {
            throw new NotImplementedException();
        }

        public int CantidadProductos(Factura objSub)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Factura entDel)
        {
            throw new NotImplementedException();
        }

        public IList<Factura> GetAll()
        {
            return DAL.DAOS.DaoFactura.getInstancia().GetAll();
        }

        public List<DetalleFactura> GetDetails(Factura objDet)
        {
            throw new NotImplementedException();
        }

        public decimal GetSubtotal(Factura objSub)
        {
            throw new NotImplementedException();
        }

        public decimal GetTotal(Factura objdet)
        {
            throw new NotImplementedException();
        }

        public bool Update(Factura entUpd)
        {
            throw new NotImplementedException();
        }

        public bool Validar(Factura entVal)
        {
            throw new NotImplementedException();
        }

        public Factura SelectById(Factura objSelect)
        {
            throw new NotImplementedException();
            //return DAL.DAOS.DaoFactura.getInstancia().SelectById(objSelect);
        }
        public List<Factura> GetAllByIdCliente(BE.Factura factura)
        {
            return DAL.DAOS.DaoFactura.getInstancia().SelectAllByIntIdCliente(factura);
        }

        public BE.Factura GetAllById (BE.Factura factura)
        {
            return DAOS.DaoFactura.getInstancia().GetAllById(factura);
        }
    }
}
