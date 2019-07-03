using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace ChepeauDAL
{
    public abstract class Base
    {
        private SqlDataAdapter adapter;
        private SqlConnection conn;
        public Base()
        {
            
            string conString = ConfigurationManager.ConnectionStrings["ChepeauDatabase"].ConnectionString;
            conn = new SqlConnection(conString);
            adapter = new SqlDataAdapter();

        }

        protected SqlConnection OpenConnection()
        {
            if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
            {
                conn.Open();
            }
            return conn;
        }

        private void CloseConnection()
        {
            conn.Close();
        }

        /* For Insert/Update/Delete Queries with transaction */
        protected void ExecuteEditTranQuery(String query, SqlParameter[] sqlParameters, SqlTransaction sqlTransaction)
        {
            SqlCommand command = new SqlCommand(query, conn, sqlTransaction);
            try
            {
                command.Parameters.AddRange(sqlParameters);
                adapter.InsertCommand = command;
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                //Print.ErrorLog(e);
                throw;
            }
        }

        /* For Insert/Update/Delete Queries */
        protected void ExecuteEditQuery(String query, SqlParameter[] sqlParameters)
        {
            SqlCommand command = new SqlCommand();

            try
            {
                command.Connection = OpenConnection();
                command.CommandText = query;
                command.Parameters.AddRange(sqlParameters);
                adapter.InsertCommand = command;
                command.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                // Print.ErrorLog(e);
                throw;
            }
            finally
            {
                CloseConnection();
            }
        }



        /* For Select Queries */
        protected DataTable ExecuteSelectQuery(String query, params SqlParameter[] sqlParameters)
        {
            SqlCommand command = new SqlCommand();
            DataTable dataTable;
            DataSet dataSet = new DataSet();

            try
            {
                command.Connection = OpenConnection();
                command.CommandText = query;
                command.Parameters.AddRange(sqlParameters);
                command.ExecuteNonQuery();
                adapter.SelectCommand = command;
                adapter.Fill(dataSet);
                dataTable = dataSet.Tables[0];
            }
            catch (SqlException e)
            {
                // Print.ErrorLog(e);
                return null;
                throw;
            }
            finally
            {
                CloseConnection();
            }
            return dataTable;
        }
        //returns specific int value from database using query
            protected int GetValue(String query, params SqlParameter[] sqlParameters)
        {
            SqlCommand command = new SqlCommand();
            DataTable dataTable;
            DataSet dataSet = new DataSet();
            int value;
            try
            {
                command.Connection = OpenConnection();
                command.CommandText = query;
                command.Parameters.AddRange(sqlParameters);
                value = Convert.ToInt32(command.ExecuteScalar());
                adapter.SelectCommand = command;
                adapter.Fill(dataSet);
                dataTable = dataSet.Tables[0];
            }
            catch (SqlException e)
            {
                // Print.ErrorLog(e);
                
                throw;
            }
            finally
            {
                CloseConnection();
            }
            return value;
        }
    }
}
