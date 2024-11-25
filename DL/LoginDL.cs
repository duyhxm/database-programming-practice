using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace DL
{
    public class LoginDL: DataProvider
    {
        public object Login(Account acc)
        {
            string username = acc.getUsername();
            string password = acc.getPassword();

            string query = $"SELECT * FROM Users WHERE UserName = '{username}' AND Password = '{password}'";

            Connect();
            try
            {
                return MyExecuteScalar(query);
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
    }
}
