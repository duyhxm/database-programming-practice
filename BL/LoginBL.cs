using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
using DL;

namespace BL
{
    public class LoginBL
    {
        public bool Login(Account acc)
        {
            LoginDL login = new DL.LoginDL();
            try
            {
                if(login.Login(acc) != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(SqlException ex)
            {
                throw ex;
            }
        }
        
    }
}
