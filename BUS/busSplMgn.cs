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
    public class busSplMgn
    {
        public dbConnection db = new dbConnection();
        public DataTable getDatSpl()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "exec getDataSpl";
            return db.ExcuteReader(cmd);
        }
        public DataTable selectSpl(supplier supplier)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "exec searchSpl '" + supplier.CodeSupplier + "'";
            return db.ExcuteReader(cmd);
        }
        public int insertSpl(supplier supplier)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO tb_supplier values (@codeSpl,@nameSpl)";
            cmd.Parameters.AddWithValue("@codeSpl", supplier.CodeSupplier);
            cmd.Parameters.AddWithValue("@nameSpl", supplier.NameSupplier);
            return db.ExecuteNoQuery(cmd);
        }
        public int updateSpl(supplier supplier) {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE tb_supplier set nameSpl = @nameSpl where codeSpl = @codeSpl";
            cmd.Parameters.AddWithValue("@codeSpl", supplier.CodeSupplier);
            cmd.Parameters.AddWithValue("@nameSpl", supplier.NameSupplier);
            return db.ExecuteNoQuery(cmd);
        }
        public int deleteSpl(supplier supplier)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM tb_supplier WHERE codeSpl = '" + supplier.CodeSupplier + "'";
            return db.ExecuteNoQuery(cmd);
        }
        public DataTable isExistCodeSpl(supplier supplier)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "exec isExistCodeSpl '" + supplier.CodeSupplier + "'";
            return db.ExcuteReader(cmd);
        }
    }
}
