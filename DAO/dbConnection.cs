using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Configuration;
namespace DAO
{
    public class dbConnection
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;
        public SqlConnection con = new SqlConnection(connectionString);
        public SqlConnection getConnection()
        {
            if(con.State == ConnectionState.Closed)
                con.Open();
            return con;
        }
        public int ExecuteNoQuery(SqlCommand cmd)
        {
            cmd.Connection = getConnection();
            int rowsaffected = -1;
            rowsaffected = cmd.ExecuteNonQuery();
            con.Close();
            return rowsaffected;
        }
        public object ExecuteScalar(SqlCommand cmd) { 
            cmd.Connection = getConnection();
            object obj = -1;
            obj = cmd.ExecuteScalar();
            con.Close();
            return obj;
        }
        public DataTable ExcuteReader(SqlCommand cmd)
        {
            cmd.Connection= getConnection();
            SqlDataReader sdr;
            DataTable dt = new DataTable();
            sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            return dt;
        }
        public DataTable ExecuteAdapter(SqlCommand cmd) 
        { 
            cmd.Connection = getConnection();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            dataAdapter.SelectCommand = cmd;
            dataAdapter.Fill(dt);
            return dt;
        }
    }
}
