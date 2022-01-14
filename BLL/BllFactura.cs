using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BllFactura : BE.IFactura<BE.Factura, BE.DetalleFactura>, BE.ICrud<BE.Factura>
    {
        #region singleton

        private BllFactura()
        {

        }

        private static BllFactura instancia;

        public static BllFactura getInstancia()
        {
            if (instancia == null)
            {
                instancia = new BllFactura();
            }
            return instancia;
        } 
        #endregion
        public bool Add(Factura entAlta)
        {
            return DAL.DalFactura.getInstancia().Add(entAlta);
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
            return DAL.DalFactura.getInstancia().GetAll();
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
            IList<BE.Articulo> articulo = new List<BE.Articulo>();
            IList<BE.DetalleFactura> detalleFacturas = new List<BE.DetalleFactura>();

            int a, b;

            articulo = DAL.DalArticulo.getInstancia().GetAll();
            detalleFacturas = DAL.DalDetalleFactura.getInstancia().GetDetails(objdet);

            decimal sub = 0;
            decimal tot = 0;

            a = detalleFacturas.Count - 1;
            b = articulo.Count - 1;

            for (int i = 0; i <=a; i++)
            {
                for (int h = 0; h <=b; h++)
                {
                    if (detalleFacturas[i].IdArticulo== articulo[h].Id)
                    {
                        sub = detalleFacturas[i].Cantidad * articulo[h].Precio;
                    }
                }
                tot = tot + sub;
            }
            return tot;

           // throw new NotImplementedException();
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

            //return DAL.DalFactura.getInstancia().SelectById(objSelect);


           throw new NotImplementedException();
        }

        public List<Factura> GetAllByIdCliente(BE.Factura factura)
        {
            return DAL.DalFactura.getInstancia().GetAllByIdCliente(factura);
        }


        public BE.Factura GetById(BE.Factura factura)
        {
            return DAL.DalFactura.getInstancia().GetAllById(factura);
        }
        
    }
}
