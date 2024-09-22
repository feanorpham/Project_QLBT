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
    public class BusThongKe
    {
        public dbConnection db = new dbConnection();
        public DataTable getMedicImp()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "exec medicImp";
            return db.ExcuteReader(cmd);
        }
        public DataTable getMedicSell()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "exec medicSell";
            return db.ExcuteReader(cmd);
        }
        public DataTable getMedicDay()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "exec totalMedicDay";
            return db.ExcuteReader(cmd);
        }
        public DataTable getTotalMonth(int month)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "exec totalMedicMonth @month";
            cmd.Parameters.AddWithValue("@month", month);
            return db.ExcuteReader(cmd);
        }
        public DataTable countMonthSell(int month)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "exec countMonthSell @month";
            cmd.Parameters.AddWithValue("@month", month);
            return db.ExcuteReader(cmd);
        }
        public DataTable countMonthImp(int month)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "exec countMonthImp @month";
            cmd.Parameters.AddWithValue("@month", month);
            return db.ExcuteReader(cmd);
        }
    }
}
