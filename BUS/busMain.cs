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
    public class busMain
    {
        public dbConnection db = new dbConnection();
        public DataTable sreachName(medicine medicine)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "exec searchName N'%" + medicine.Name + "%'";
            return db.ExcuteReader(cmd);
        }
        public DataTable getMedicData()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "exec getDataMedic";
            return db.ExcuteReader(cmd);
        }
    }
}
