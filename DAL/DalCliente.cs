using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DalCliente : BE.ICrud<BE.Cliente>
    {

        #region singleton
        private DalCliente()
        {

        }

        private static DalCliente instancia;

        public static DalCliente getInstancia()
        {
            if (instancia == null)
            {
                instancia = new DalCliente();
            }
            return instancia;
        } 
        #endregion
        public bool Add(Cliente entAlta)
        {
            return DAL.DAOS.DaoCliente.getInstancia().Add(entAlta);
        }

        public bool Delete(Cliente entDel)
        {
            return DAL.DAOS.DaoCliente.getInstancia().Delete(entDel);
        }

        public IList<Cliente> GetAll()
        {
            return DAL.DAOS.DaoCliente.getInstancia().GetAll();
        }

        public bool Update(Cliente entUpd)
        {
            return DAL.DAOS.DaoCliente.getInstancia().Update(entUpd);
        }

        public bool Validar(Cliente entVal)
        {
            throw new NotImplementedException();
        }

        public Cliente SelectById(Cliente objSelect)
        {
            throw new NotImplementedException();
        }

        public IList<BE.Cliente> GetAllByName (BE.Cliente cliente)
        {
            return DAOS.DaoCliente.getInstancia().GetAllByName(cliente);
        }
    }
}
