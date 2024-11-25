using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace DL
{
    public class DataProvider
    {
        private readonly SqlConnection connection;

        public DataProvider()
        {

            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"]?.ConnectionString;
            connection = new SqlConnection(connectionString);
        }

        public void Connect()
        {
            if(connection != null && connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void DisConnect()
        {
            if(connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public object MyExecuteScalar(string query)
        {
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = System.Data.CommandType.Text;

            Connect();
            try
            {
                return (cmd.ExecuteScalar());
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
                DisConnect();
            }
        }

        public SqlDataReader MyExecuteReader(string query)
        {
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = System.Data.CommandType.Text;

            Connect();
            try
            {
                return (cmd.ExecuteReader());
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                DisConnect();
            }
        }
    }
}
