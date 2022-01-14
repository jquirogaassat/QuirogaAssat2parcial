using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace DAL
{
    public class SqlHelper
    {

        private SqlConnection conn;
        private DataSet dataSet;
        private SqlCommand comm;
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;
        private SqlDataReader dataReader;


        public string connectionstring { get; private set; }

        private SqlHelper(string connStr)
        {
            this.connectionstring = connStr;
        }

        private static SqlHelper instancia;

        public static SqlHelper getInstancia(string connString)
        {
            if (instancia == null)
            {
                instancia = new SqlHelper(connString);
            }
            return instancia;
        }

        // aqui hacemos la logica para el update, delete o insert

        #region Executequery query
        public bool ExecuteQuery(string query)
        {
            bool returnValue = false;

            try
            {
                using (conn = new SqlConnection(this.connectionstring))
                {
                    using (comm = new SqlCommand())
                    {
                        comm.CommandType = CommandType.Text;
                        comm.CommandText = query;
                        comm.Connection = conn;

                        conn.Open();

                        if (comm.ExecuteNonQuery() > 0)
                        {
                            returnValue = true;
                        }
                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return returnValue;
        }

        #endregion


        #region ExecuteQuery storeProcedure and List sqlparameter
        public bool ExecuteQuery(string storeporcedure, List<SqlParameter> parametros)
        {
            bool returnValue = false;
            try
            {
                using (conn = new SqlConnection(this.connectionstring))
                {
                    using (comm = new SqlCommand())
                    {
                        comm.CommandType = CommandType.StoredProcedure;
                        comm.Connection = conn;
                        comm.CommandText = storeporcedure;


                        if (parametros != null)
                        {
                            foreach (SqlParameter parameter in parametros)
                            {
                                comm.Parameters.Add(parameter);
                            }
                        }
                        conn.Open();

                        if (comm.ExecuteNonQuery() > 0)
                        {
                            returnValue = true;
                        }

                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return returnValue;
        }

        #endregion



        #region ExecuteQuery storeProcedure, List sqlparameter and params parametros array
        public bool ExecuteQuery(string storePorcedure, List<SqlParameter> parametros, params SqlParameter[] parametrosArray)
        {
            bool returnValue = false;


            try
            {
                using (conn = new SqlConnection(this.connectionstring))
                {
                    using (comm = new SqlCommand())
                    {
                        comm.CommandType = CommandType.StoredProcedure;
                        comm.Connection = conn;
                        comm.CommandText = storePorcedure;

                        if (parametros != null)
                        {
                            foreach (SqlParameter parameter in parametros)
                            {
                                comm.Parameters.Add(parameter);
                            }
                        }

                        if (parametrosArray != null)
                        {
                            comm.Parameters.Clear();
                            comm.Parameters.AddRange(parametrosArray);
                        }

                        conn.Open();

                        if (comm.ExecuteNonQuery() > 0)
                        {
                            returnValue = true;
                        }
                        conn.Close();
                    }

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }


            return returnValue;


        }
        #endregion



        public DataTable ExecuteReader(string query)
        {
            //USO ADO DESCONECTADO
            dataSet = new DataSet();

            using (conn = new SqlConnection(this.connectionstring))
            {
                using (comm = new SqlCommand())
                {
                    dataAdapter = new SqlDataAdapter();

                    comm.CommandText = query;
                    comm.CommandType = CommandType.Text;
                    comm.Connection = conn;

                    dataAdapter.SelectCommand = comm;

                    dataAdapter.Fill(dataSet);
                }
            }

            return dataSet.Tables[0];

        }


        public DataTable ExecuteReader(string storeProcedure, List<SqlParameter> parameter)
        {
            dataSet = new DataSet();

            using (conn = new SqlConnection(this.connectionstring))
            {
                using (comm = new SqlCommand())
                {
                    dataAdapter = new SqlDataAdapter();

                    comm.CommandText = storeProcedure;
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Connection = conn;

                    if (parameter != null)
                    {
                        comm.Parameters.AddRange(parameter.ToArray());
                    }
                    dataAdapter.SelectCommand = comm;

                    dataAdapter.Fill(dataSet);
                }
            }

            return dataSet.Tables[0];

        }



        public DataTable ExecuteReader(string storeProcedure, List<SqlParameter> parameter, params SqlParameter[] paramSqlParametros)
        {
            dataSet = new DataSet();

            using (conn = new SqlConnection(this.connectionstring))
            {
                using (comm = new SqlCommand())
                {
                    dataAdapter = new SqlDataAdapter();

                    comm.CommandText = storeProcedure;
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Connection = conn;

                    if (parameter != null)
                    {
                        comm.Parameters.AddRange(parameter.ToArray());
                    }

                    if (paramSqlParametros != null)
                    {
                        comm.Parameters.Clear();
                        comm.Parameters.AddRange(paramSqlParametros);
                    }

                    dataAdapter.SelectCommand = comm;

                    dataAdapter.Fill(dataSet);

                }
            }

            return dataSet.Tables[0];
        }


    }
}

