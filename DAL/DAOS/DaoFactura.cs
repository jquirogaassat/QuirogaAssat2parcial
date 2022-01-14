using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;


namespace DAL.DAOS
{
    internal class DaoFactura : BE.ICrud<BE.Factura>
    {
      
        private string connstring = @"Data Source=.\sqlexpress;Initial Catalog=FacturacionLUG;Integrated Security=True";
        private SqlConnection conn ;
        private string spInsert = "FacturaInsert";
        private string spUpdate = "FacturaUpdate";
        private string spDelete = "FacturaDelete";
        private string spSelectAll = "FacturaSelectAll";
        private string spSelectAllById = "FacturaSelectAllByIntIdCliente";
        private string spSelectByIdFactu = "FacturaSelect";

        private SqlCommand comm;
       
        
        

        #region singleton

        private DaoFactura()
        {

        }

        private static DaoFactura instancia;

        public static DaoFactura getInstancia()
        {
            if (instancia == null)
            {
                instancia = new DaoFactura();
            }
            return instancia;
        } 
        #endregion
        public bool Add(Factura entAlta)
        {

            bool returnValue = false;
            List<SqlParameter> parametros = new List<SqlParameter>();

            parametros.Add(new SqlParameter("@datFecha", entAlta.Fecha));
            parametros.Add(new SqlParameter("@intIdCliente", entAlta.IdCliente));

            returnValue = SqlHelper.getInstancia(connstring).ExecuteQuery
                  (
                  spInsert,
                  parametros
                  );

            foreach (BE.DetalleFactura item in entAlta.Detalles)
            {
                 
                entAlta.Id = this.GetLastId();
                DAOS.DaoDetalleFactura.getInstancia().Add(item, entAlta);
            }


            return returnValue;

                /*
                 * @datFecha datetime,
	@intIdCliente i
                 */
            
        }

        public bool Delete(Factura entDel)
        {

            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@intId", entDel.Id));

            bool returnValue = SqlHelper.getInstancia(connstring).ExecuteQuery
                (
                spDelete,
                parametros
                );
            return returnValue;
           
        }

        public IList<Factura> GetAll()
        {
             DataSet table = new DataSet();

            table.Tables.Add(SqlHelper.getInstancia(connstring).ExecuteReader(spSelectAll));

            return Mappers.MpFactura.getInstancia().Mapeo(table);
        }

        public bool Update(Factura entUpd)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@intId", entUpd.Id));
            parametros.Add(new SqlParameter("@datFecha", entUpd.Fecha));
            parametros.Add(new SqlParameter("@intIdCliente", entUpd.IdCliente));

            bool returnValue = SqlHelper.getInstancia(connstring).ExecuteQuery
                (
                spUpdate,
                parametros
                );
            return returnValue;
          
        }

        public bool Validar(Factura entVal)
        {
            throw new NotImplementedException();
        }

        private int GetLastId()
        {
            comm = new SqlCommand();
            conn = new SqlConnection(connstring);
            comm.Connection = conn;
            comm.CommandText = "select max(intID) from Factura";
            comm.CommandType = CommandType.Text;

            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }


            int result = int.Parse(comm.ExecuteScalar().ToString());

            return result;

        }

        public List<Factura> SelectById(Factura objSelect)
        {
            
            throw new NotImplementedException();
        }

        public List<BE.Factura> SelectAllByIntIdCliente(BE.Factura factura)
        {
            DataSet table = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            comm = new SqlCommand();
            conn = new SqlConnection(connstring);
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = spSelectAllById;

            comm.Connection = conn;

            comm.Parameters.AddWithValue("@intIdCliente", factura.IdCliente);

            da.SelectCommand = comm;

            da.Fill(table);


            return Mappers.MpFactura.getInstancia().Mapeo(table);
        }

        public BE.Factura GetAllById( BE.Factura factura)
        {
            IList<BE.Factura> Factu = new List<BE.Factura>();
            BE.Factura factura1 = new BE.Factura();
            DataSet table = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            comm = new SqlCommand();
            conn = new SqlConnection(connstring);
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = spSelectByIdFactu;

            comm.Connection = conn;
            comm.Parameters.AddWithValue("@intId", factura.Id);
            da.SelectCommand = comm;
            da.Fill(table);

            Factu = Mappers.MpFactura.getInstancia().Mapeo(table);
            factura1 = Factu[0];

            return factura1;
        }
    }
}
