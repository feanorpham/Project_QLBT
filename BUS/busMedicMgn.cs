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
    public class busMedicMgn
    {
        public dbConnection dbConnection = new dbConnection();
        public DataTable selectMedic(medicine medicine)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "exec searchMedic '" + medicine.Barcode + "'";
            return dbConnection.ExcuteReader(cmd);
        }
        public DataTable getDataMedic()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "exec getDataMedic";
            return dbConnection.ExcuteReader(cmd);
        }
        public int insertMedic(medicine medicine)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO tb_medicine VALUES(@barcode,@nameMedic,@impPrice,@price,@isReatil,@mfgD,@expD,@lesUse,@codeSpl)";
            cmd.Parameters.AddWithValue("@barcode", medicine.Barcode);
            cmd.Parameters.AddWithValue("@nameMedic", medicine.Name);
            cmd.Parameters.AddWithValue("@impPrice", medicine.ImpPrice);
            cmd.Parameters.AddWithValue("@price", medicine.Price);
            cmd.Parameters.AddWithValue("@isReatil", medicine.IsReatil);
            cmd.Parameters.AddWithValue("@mfgD", medicine.MfgD);
            cmd.Parameters.AddWithValue("@expD", medicine.ExpD);
            cmd.Parameters.AddWithValue("@lesUse", medicine.LesUse);
            cmd.Parameters.AddWithValue("@codeSpl", medicine.CodeSupplier);
            return dbConnection.ExecuteNoQuery(cmd);
        }
        public int updateMedic(medicine medicine) {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE tb_medicine set nameMedic = @nameMedic, impPrice = @impPrice, price = @price," +
                "isReatil = @isReatil, mfgD = @mfgD, expD = @expD, lesUse = @lesUse, codeSpl = @codeSpl WHERE barcode = @barcode";
            cmd.Parameters.AddWithValue("@barcode", medicine.Barcode);
            cmd.Parameters.AddWithValue("@nameMedic", medicine.Name);
            cmd.Parameters.AddWithValue("@impPrice", medicine.ImpPrice);
            cmd.Parameters.AddWithValue("@price", medicine.Price);
            cmd.Parameters.AddWithValue("@isReatil", medicine.IsReatil);
            cmd.Parameters.AddWithValue("@mfgD", medicine.MfgD);
            cmd.Parameters.AddWithValue("@expD", medicine.ExpD);
            cmd.Parameters.AddWithValue("@lesUse", medicine.LesUse);
            cmd.Parameters.AddWithValue("@codeSpl", medicine.CodeSupplier);
            return dbConnection.ExecuteNoQuery(cmd);
        }
        public int deleteMedic(medicine medicine) {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM tb_medicine WHERE barcode = '" + medicine.Barcode + "'";
            return dbConnection.ExecuteNoQuery(cmd);
        }
        public DataTable isExistBarcode(medicine medicine)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "exec isExistBarcode '" + medicine.Barcode + "'";
            return dbConnection.ExcuteReader(cmd);
        }
    }
}
