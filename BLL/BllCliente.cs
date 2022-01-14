using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BllCliente : BE.ICrud<BE.Cliente>
    {
        #region singleton

        private BllCliente()
        {

        }

        private static BllCliente instancia;

        public static BllCliente getInstancia()
        {
            if (instancia == null)
            {
                instancia = new BllCliente();
            }
            return instancia;
        }
        #endregion

        #region ICrud
        public bool Add(Cliente entAlta)
        {
            return DAL.DalCliente.getInstancia().Add(entAlta);
        }

        public bool Delete(Cliente entDel)
        {
            return DAL.DalCliente.getInstancia().Delete(entDel);
        }

        public IList<Cliente> GetAll()
        {
            return DAL.DalCliente.getInstancia().GetAll();
        }

        public bool Update(Cliente entUpd)
        {
            return DAL.DalCliente.getInstancia().Update(entUpd);
        }

        public bool Validar(BE.Cliente entVal)
        {
            throw new NotImplementedException();
        }

        public Cliente SelectById(Cliente objSelect)
        {
            throw new NotImplementedException();
        }

        public IList<BE.Cliente> GetAllByName (BE.Cliente cliente)
        {
            return DAL.DalCliente.getInstancia().GetAllByName(cliente);
        }
        #endregion
    }
}
