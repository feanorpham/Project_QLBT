using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data.SqlClient;
using System.Data;
namespace BUS
{
    public class busLogin
    {
        public dbConnection conn = new dbConnection();
        public DataTable loginUser(userName userName)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "exec LoginUser '" + userName.UserName + "', '" + userName.Password + "'";
            return conn.ExcuteReader(cmd);
        }
    }
}
