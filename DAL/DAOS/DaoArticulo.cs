using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAOS
{
    internal class DaoArticulo : BE.ICrud<BE.Articulo>, BE.IFactura<BE.Factura, BE.DetalleFactura>
    {
        private string connstring = @"Data Source=.\sqlexpress;Initial Catalog=FacturacionLUG;Integrated Security=True";
        private SqlConnection conn;
        private string spInsert = "ProductoInsert";
        private string spUpdate = "ProductoUpdate";
        private string spDelete = "ProductoDelete";
        private string spSelectAll = "ProductoSelectAll";

        private DataSet dataSet;
        private SqlDataAdapter dataAdapter;
        private SqlCommand comm;

        #region singleton
        private DaoArticulo()
        {
            conn = new SqlConnection(connstring);
        }

        private static DaoArticulo instancia;

        public static DaoArticulo getInstancia()
        {
            if (instancia == null)
            {
                instancia = new DaoArticulo();
            }
            return instancia;

        } 
        #endregion
        public bool Add(Articulo entAlta)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@varNombre", entAlta.Nombre));
            parametros.Add(new SqlParameter("@decPrecio ", entAlta.Precio));
            parametros.Add(new SqlParameter("@intStock", entAlta.Stock));

            bool returnValue = SqlHelper.getInstancia(connstring).ExecuteQuery
                (
                spInsert,
                parametros
                );

            return returnValue;


            /*
             @varNombre nvarchar(50),
	@decPrecio decimal(18, 2),
	@intStock int*/
            
        }

        public bool Delete(Articulo entDel)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@intId", entDel.Id));

            bool returnValue = SqlHelper.getInstancia(connstring).ExecuteQuery
                (
                spDelete,
                parametros
                );

            return returnValue;

                /*
                 @intId int
                 */
           
        }

        public IList<Articulo> GetAll()
        {
            //DataSet table = new DataSet();

            //table.Tables.Add(SqlHelper.getInstancia(connstring).ExecuteReader(spSelectAll));

            //return Mappers.MpArticulo.getInstancia().Mapeo(table);
            dataSet = new DataSet("Articulos");
            dataAdapter = new SqlDataAdapter();

            comm = new SqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = spSelectAll;

            dataAdapter.SelectCommand = comm;

            dataAdapter.Fill(dataSet);

            return Mappers.MpArticulo.getInstancia().Mapeo(dataSet);
            //dataSet = new DataSet("Articulos");
            //dataAdapter = new SqlDataAdapter();

            //comm = new SqlCommand();
            //comm.Connection = conn;
            //comm.CommandType = CommandType.StoredProcedure;
            //comm.CommandText = spSelectAll;

            //dataAdapter.SelectCommand = comm;

            //dataAdapter.Fill(dataSet);

            //return Mappers.MpArticulo.getInstancia().Mapeo(dataSet);

        }

        public bool Update(Articulo entUpd)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@intId", entUpd.Id));
            parametros.Add(new SqlParameter("@varNombre", entUpd.Nombre));
            parametros.Add(new SqlParameter("@decPrecio", entUpd.Precio));
            parametros.Add(new SqlParameter("@intStock", entUpd.Stock));


            bool returnValue = SqlHelper.getInstancia(connstring).ExecuteQuery
                (
                spUpdate,
                parametros
                );
            return returnValue;
            /*
              @intId int,
@varNombre nvarchar(50),
@decPrecio decimal(18, 2),
@intStock int
)
             */
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
