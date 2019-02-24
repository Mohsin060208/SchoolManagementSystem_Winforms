using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;

namespace Database
{
    public class DbClient
    {
        private static DbClient _dbClient;
        //This field holds the sql connection
        private SqlConnection _sqlConnection;
        private string _strConnection = string.Empty;

        private DbClient()
        {
            this._strConnection = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
            this._sqlConnection = new SqlConnection(this._strConnection);
        }

        /// <summary>
        /// This fucntion will check if the object of DbClient exists then return it
        /// Otherwise create the object and then return it
        /// </summary>
        /// <returns></returns>
        public static DbClient CreateDbClient()
        {
            if (_dbClient == null)
            {
                _dbClient = new DbClient();
            }
            return _dbClient;
        }
        public SqlConnection Connection
        {
            get
            {
                return this._sqlConnection;
            }
        }

        #region Helper Methods
        public SqlCommand CreateSqlCommand(string commandText, List<SqlParameter> parameters = null, CommandType commandType = CommandType.Text)
        {
            try
            {
                SqlCommand command = new SqlCommand(commandText, this.Connection);
                command.CommandType = commandType;

                if (parameters != null && parameters.Count > 0)
                {
                    for (int i = 0; i < parameters.Count; i++)
                    {
                        command.Parameters.Add(parameters[i]);
                    }
                }
                return command;
            }
            catch (Exception)
            {
                throw;
            }
        }
        //public void InvokeReader(string query, Action<SqlDataReader> resultHandler)
        //{
        //    try
        //    {
        //    var command = this.CreateSqlCommand(query);
        //    command.Connection.Open();
        //    using (var reader = command.ExecuteReader())
        //    {
        //        resultHandler(reader);
        //        command.Connection.Close();
        //    }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}

        public void InvokeParametersWithDataReader(string query, List<SqlParameter> parameters, Action<DataTable> resultHandler)
        {
            var command = this.CreateSqlCommand(query, parameters);
            try
            {
                    command.Connection.Open();
                    using (DataTable datatable = new DataTable())
                    {
                        using (SqlDataAdapter dataadapter = new SqlDataAdapter(command))
                        {
                            dataadapter.Fill(datatable);
                        }
                        resultHandler(datatable);
                    }
                }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally{
                        command.Connection.Close();
            }
        }
        public void InvokeParameters(string query, List<SqlParameter> parameters)
        {
            var command = this.CreateSqlCommand(query,parameters);
            try
            {
                command.Connection.Open();
                command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                command.Connection.Close();
            }
        }
        public void InvokeDataReader(string query, Action<DataTable> resultHandler)
        {
            try
            {
                using (var command = this.CreateSqlCommand(query))
                {
                    command.Connection.Open();
                    using (DataTable datatable = new DataTable())
                    {
                        using (SqlDataAdapter dataadapter = new SqlDataAdapter(command))
                        {
                            dataadapter.Fill(datatable);
                        }
                        resultHandler(datatable);
                        command.Connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void InvokeUpdate(string query)
        {
            try
            {
            var command = this.CreateSqlCommand(query);
            command.Connection.Open();
            command.ExecuteNonQuery();
            command.Connection.Close();
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        //public DataTable GetDataTable(SqlCommand command)
        //{
        //    try
        //    {
        //        DataTable datatable = new DataTable();
        //        using (command)
        //        {
        //            using (SqlDataAdapter dataadapter = new SqlDataAdapter(command))
        //            {
        //                dataadapter.Fill(datatable);
        //            }
        //        }
        //        return datatable;
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}
        //public DataSet GetDataSet(SqlCommand command)
        //{
        //    try
        //    {
        //        DataSet dataset = new DataSet();
        //        using (command)
        //        {
        //            using (SqlDataAdapter dataadapter = new SqlDataAdapter(command))
        //            {
        //                dataadapter.Fill(dataset);
        //            }
        //        }
        //        return dataset;
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}
        //public int ExecuteNonQuery(SqlCommand command)
        //{
        //    try
        //    {
        //        int affectedRows = 0;
        //        using (command)
        //        {
        //            command.Connection.Open();
        //            affectedRows = command.ExecuteNonQuery();
        //        }
        //        return affectedRows;
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //    finally
        //    {
        //        command.Connection.Close();
        //    }
        //}
        //public object ExecuteScalar(SqlCommand command)
        //{
        //    try
        //    {
        //        object result = null;
        //        using (command)
        //        {
        //            command.Connection.Open();
        //            result = command.ExecuteScalar();
        //        }
        //        return result;
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //    finally
        //    {
        //        command.Connection.Close();
        //    }
        //}
        #endregion
    }
}