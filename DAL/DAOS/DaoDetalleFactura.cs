using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BE;
using System.Data;
using System.Data.Sql;

namespace DAL.DAOS
{
    internal class DaoDetalleFactura : BE.ICrud<BE.DetalleFactura>, BE.IFactura<BE.Factura,BE.DetalleFactura>
    {
        private string connString = @"Data Source=.\sqlexpress;Initial Catalog=FacturacionLUG;Integrated Security=True";
        private SqlConnection conn;
        private string spInsert = "DetalleFacturaInsert";
        private string spUpdate = "DetalleFacturaUpdate";
        private string spDelete = "DetalleFacturaDelete";
        private string spSelectAll = "DetalleFacturaSelectAll";
        private string spSelectById = "DetalleFacturaSelectAllByIntIdFactura";
        private SqlCommand comm;
        //private SqlDataReader dataReader;
        //private DataSet dataSet;
        //private SqlDataAdapter dataAdapter;



        #region singleton
        private DaoDetalleFactura()
        {
            conn = new SqlConnection(connString);
        }

        private static DaoDetalleFactura instancia;

        public static DaoDetalleFactura getInstancia()
        {
            if (instancia == null)
            {
                instancia = new DaoDetalleFactura();
            }
            return instancia;
        } 
        #endregion

        public bool Add(DetalleFactura entAlta)
        {
           

            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@intIdProducto", entAlta.Id));
            parametros.Add(new SqlParameter("@intIdFactura", entAlta.IdFactura));
            parametros.Add(new SqlParameter("@intCantidad", entAlta.Cantidad));

            bool returnValue = SqlHelper.getInstancia(connString).ExecuteQuery
                (
                    spInsert,
                    parametros
                );

            //comm.Parameters.AddWithValue("@intIdProducto", entAlta.Id);
            //comm.Parameters.AddWithValue("@intIdFactura", entAlta.IdFactura);
            //comm.Parameters.AddWithValue("@intCantidad", entAlta.Cantidad);


            
            return returnValue;
            /*@intIdProducto int,
@intIdFactura int,
@intCantidad int*/
        }


        public bool Add(DetalleFactura entAlta,Factura factura)
        {


            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@intIdProducto", entAlta.IdArticulo));
            parametros.Add(new SqlParameter("@intIdFactura", factura.Id));
            parametros.Add(new SqlParameter("@intCantidad", entAlta.Cantidad));

            bool returnValue = SqlHelper.getInstancia(connString).ExecuteQuery
                (
                    spInsert,
                    parametros
                );

              return returnValue;

        }

        public bool Update(DetalleFactura entUpd)
        {

            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@intId", entUpd.Id));
            parametros.Add(new SqlParameter("@intIdProducto", entUpd.IdArticulo));
            parametros.Add(new SqlParameter("@intIdFactura", entUpd.IdFactura));
            parametros.Add(new SqlParameter("@intCantidad", entUpd.Cantidad));

            bool returnValue = SqlHelper.getInstancia(connString).ExecuteQuery
                (
                spUpdate,
                parametros
                );
            


            //comm.Parameters.AddWithValue("@intId", entUpd.Id);
            //comm.Parameters.AddWithValue("@intIdProducto", entUpd.IdArticulo);
            //comm.Parameters.AddWithValue("@intIdFactura", entUpd.IdFactura);
            //comm.Parameters.AddWithValue("@intCantidad", entUpd.Cantidad);


          
            return returnValue;

            /*@intId int,
	@intIdProducto int,
	@intIdFactura int,
	@intCantidad int*/
        }

        public bool Delete(DetalleFactura entDel)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@intId", entDel.Id));

            bool returnValue = SqlHelper.getInstancia(connString).ExecuteQuery
                (
                spDelete,
                parametros
                );
            

            //comm.Parameters.AddWithValue("@intId", entDel.Id);

           

            return returnValue;
        }

        public IList<DetalleFactura> GetAll()
        {
            DataSet table = new DataSet();

            table.Tables.Add(SqlHelper.getInstancia(connString).ExecuteReader(spSelectAll));

            return Mappers.MpDetalleFactura.getInstancia().Mapeo(table);
        }

        public bool Validar(DetalleFactura entVal)
        {
            throw new NotImplementedException();
        }

        public DetalleFactura SelectById(DetalleFactura objSelect)
        {
            throw new NotImplementedException();
        }

      //  public List<BE.DetalleFactura> GetByIntIdFactura (BE.Factura factura)
        //{
            //DataSet dataSet = new DataSet();
            //SqlDataAdapter dataAdapter = new SqlDataAdapter();

            //comm = new SqlCommand();
            //comm.CommandType = CommandType.StoredProcedure;
            //comm.CommandText = "DetalleFacturaSelectAllByIntIdFactura";
            //conn = new SqlConnection(connString);


            //comm.Connection = conn;
            //comm.Parameters.AddWithValue("@intIdFactura", factura.Id);

            //dataAdapter.SelectCommand = comm;
            //dataAdapter.Fill(dataSet);

            //return Mappers.MpDetalleFactura.getInstancia().Mapeo(dataSet);
        //}
        public List<DetalleFactura> GetDetails(Factura objDet)
        {
            DataSet dataSet = new DataSet();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();

            comm = new SqlCommand();
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = "DetalleFacturaSelectAllByIntIdFactura";
            conn = new SqlConnection(connString);


            comm.Connection = conn;
            comm.Parameters.AddWithValue("@intIdFactura", objDet.Id);

            dataAdapter.SelectCommand = comm;
            dataAdapter.Fill(dataSet);

            return Mappers.MpDetalleFactura.getInstancia().Mapeo(dataSet);
           // throw new NotImplementedException();
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

        public bool AddLine(Factura objFac, DetalleFactura objdet)
        {
            throw new NotImplementedException();
        }


        public IList<BE.DetalleFactura> GetAllByIdFactura(BE.Factura factura)
        {
            DataSet dataSet = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            comm = new SqlCommand();
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = spSelectById;
            comm.Connection = conn;

            comm.Parameters.AddWithValue("@intIdFactura", factura.Id);

            da.SelectCommand = comm;
            da.Fill(dataSet);

            return Mappers.MpDetalleFactura.getInstancia().Mapeo(dataSet);
        }
    }
}
