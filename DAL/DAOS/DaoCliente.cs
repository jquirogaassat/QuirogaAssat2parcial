using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;

namespace DAL.DAOS
{
    internal class DaoCliente : BE.ICrud<BE.Cliente>
    {
        private string connstring = @"Data Source=.\sqlexpress;Initial Catalog=FacturacionLUG;Integrated Security=True";
        private SqlConnection conn;
        private string spInsert = "ClienteInsert";
        private string spUpdate = "ClienteUpdate";
        private string spDelete = "ClienteDelete";
        private string spSelectAll = "select * from Cliente";
        private string spSelectByName = "ClienteSelectByName";

        private DataSet dataSet;
        private SqlDataAdapter dataAdapter;
        private SqlCommand comm;
    


        #region singleton
        private DaoCliente()
        {
            //DAL.SqlHelper.getInstancia(connstring).connectionstring= new
            conn = new SqlConnection(connstring);
        }

        private static DaoCliente instancia;

        public static DaoCliente getInstancia()
        {
            if (instancia == null)
            {
                instancia = new DaoCliente();
            }
            return instancia;
        } 
        #endregion
        public bool Add(Cliente entAlta)
        {

            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@varNombre", entAlta.nombre));
            parametros.Add(new SqlParameter("@varApellido", entAlta.apellido));
            parametros.Add(new SqlParameter("@varDireccion", entAlta.direccion));
            parametros.Add(new SqlParameter("@varTelefono", entAlta.telefono));

            bool returnValue = SqlHelper.getInstancia(connstring).ExecuteQuery
                (
                spInsert,
                parametros
                );

            //comm.Parameters.AddWithValue(" @varNombre", entAlta.nombre);
            //comm.Parameters.AddWithValue("@varApellido", entAlta.apellido);
            //comm.Parameters.AddWithValue("@varDireccion", entAlta.direccion);
            //comm.Parameters.AddWithValue("@varTelefono", entAlta.telefono);


                /*
                 @varNombre nvarchar(50),
	@varApellido nvarchar(50),
	@varDireccion nvarchar(50),
	@varTelefono nvarchar(50)
                 */

            
            return returnValue;
        }

        public bool Delete(Cliente entDel)
        {

            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@intId", entDel.Id));


            bool returnValue = SqlHelper.getInstancia(connstring).ExecuteQuery
                (
                spDelete,
                parametros
                );
          

            //comm.Parameters.AddWithValue("@intId", entDel.Id);

            //if (conn.State != System.Data.ConnectionState.Open)
            //{
            //    conn.Open();
            //}

            //if (comm.ExecuteNonQuery() > 0)
            //{
            //    returnValue = true;
            //}
            //conn.Close();
            return returnValue;
        
    }

        public IList<Cliente> GetAll()
        {
            dataSet = new DataSet("Clientes");
            dataAdapter = new SqlDataAdapter();

            comm = new SqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = spSelectAll;

            dataAdapter.SelectCommand = comm;

            dataAdapter.Fill(dataSet);

            return Mappers.MpCliente.getInstancia().Mapeo(dataSet);

            //DataSet table = new DataSet();

            //table.Tables.Add(SqlHelper.getInstancia(connstring).ExecuteReader(spSelectAll));

            //return Mappers.MpCliente.getInstancia().Mapeo(table);
        }

        public bool Update(Cliente entUpd)
        {

            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@intId", entUpd.Id));
            parametros.Add(new SqlParameter("@varNombre", entUpd.nombre));
            parametros.Add(new SqlParameter("@varApellido", entUpd.apellido));
            parametros.Add(new SqlParameter("@varDireccion", entUpd.direccion));
            parametros.Add(new SqlParameter("@varTelefono", entUpd.telefono));


            bool returnValue = SqlHelper.getInstancia(connstring).ExecuteQuery
                (
                    spUpdate,
                    parametros
                );

       
            //comm.Parameters.AddWithValue("@intId", entUpd.Id);
            //comm.Parameters.AddWithValue("@varNombre", entUpd.nombre);
            //comm.Parameters.AddWithValue("@varApellido", entUpd.apellido);
            //comm.Parameters.AddWithValue("@varDireccion", entUpd.direccion);
            //comm.Parameters.AddWithValue("@varTelefono", entUpd.telefono);

            //if (conn.State != ConnectionState.Open)
            //{
            //    conn.Open();
            //}

            //if (comm.ExecuteNonQuery()>0)
            //{
            //    returnValue = true;
            //}

            //conn.Close();
            return returnValue;

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
                 

            DataSet table = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            comm = new SqlCommand();
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = spSelectByName;

            comm.Connection = conn;
            comm.Parameters.AddWithValue("@varNombre", cliente.nombre);
            da.SelectCommand = comm;
            da.Fill(table);


            return Mappers.MpCliente.getInstancia().Mapeo(dataSet);
        }
    }
}
