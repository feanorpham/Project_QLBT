using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data.SqlClient;
using System.Data;
using DTO.Properties;
using System.Collections;

namespace BUS.Properties
{
    public class busStockMgn
    {
        public dbConnection db = new dbConnection();

        public DataTable getDataStock()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "exec getDataWh1";
            return db.ExcuteReader(cmd);
        }
        public DataTable getNameMedic()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "exec getNameMedic";
            return db.ExecuteAdapter(cmd);
        }
        public DataTable getInfoSpl()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "exec getInfoSpl";
            return db.ExcuteReader(cmd);
        }
        public DataTable getDataForOrderWh(medicine medicine)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "exec getDataForOrderWh N'" + medicine.Name + "'";
            return db.ExcuteReader(cmd);
        }
        public int insertOrderWh(orderStock orderStock) 
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO tb_orderWh values(@sumMoney,@dateCreate)";
            cmd.Parameters.AddWithValue("sumMoney", orderStock.SumMoney);
            cmd.Parameters.AddWithValue("dateCreate", orderStock.DateCreate);
            return db.ExecuteNoQuery(cmd);
        }
        public int insertOrderDtWh(orderDetailsStock order)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO tb_orderDetailsWh values(@idOrderWh,@barcode,@codeSpl,@impPrice,@quantity,@total)";
            cmd.Parameters.AddWithValue("@idOrderWh", order.IdOrderWh);
            cmd.Parameters.AddWithValue("@barcode", order.Barcode);
            cmd.Parameters.AddWithValue("@codeSpl", order.CodeSpl);
            cmd.Parameters.AddWithValue("@impPrice", order.ImpPrice);
            cmd.Parameters.AddWithValue("@quantity", order.Quantity);
            cmd.Parameters.AddWithValue("@total", order.Total);
            return db.ExecuteNoQuery(cmd);
        }
        public DataTable getCountId()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "exec getCountOrderWh";
            return db.ExcuteReader(cmd);
        }
        public DataTable getWh()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "exec getWh";
            return db.ExcuteReader(cmd);
        }
        public DataTable searchWh()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "exec searchWh";
            return db.ExcuteReader(cmd);
        }
        public DataTable checkBarcodeInWareHouse(warehouse warehouse)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "exec searchBarcodeInWareHouse @barcode";
            cmd.Parameters.AddWithValue("@barcode", warehouse.Barcode);
            return db.ExcuteReader(cmd);
        }
        public DataTable getSumQuantity(warehouse warehouse) {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "exec getQuantity @barcode";
            cmd.Parameters.AddWithValue("@barcode", warehouse.Barcode);
            return db.ExcuteReader(cmd);
        }
        public int updateWh(warehouse warehouse)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "exec updateQuantity @barcode,@quantity";
            cmd.Parameters.AddWithValue("@barcode", warehouse.Barcode);
            cmd.Parameters.AddWithValue("@quantity", warehouse.Quantity);
            return db.ExecuteNoQuery(cmd);
        }
        public int insertWh(warehouse warehouse) {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into tb_warehouse values(@barcode,@quantity)";
            cmd.Parameters.AddWithValue("@barcode", warehouse.Barcode);
            cmd.Parameters.AddWithValue("@quantity", warehouse.Quantity);
            return db.ExecuteNoQuery(cmd);
        }
        public DataTable getInpBillWh(orderStock orderStock) {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "exec getInputBill @idOrderWh";
            cmd.Parameters.AddWithValue("@idOrderWh", orderStock.IdOrderWh);
            return db.ExcuteReader(cmd);
        }
        public DataTable getIdOrderWh()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "exec getIdOrderWh";
            return db.ExcuteReader(cmd);
        }
        public DataTable getOrderDtWh()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "exec getOrderDtWh";
            return db.ExcuteReader(cmd);
        }
        public DataTable getOrderWh()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "exec getOrderWh";
            return db.ExcuteReader(cmd);
        }
        public DataTable getCalMoney(orderStock stock)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "exec calMoney1 @idOrderWh";
            cmd.Parameters.AddWithValue("@idOrderWh", stock.IdOrderWh);
            return db.ExcuteReader(cmd);
        }
        public int updateOrderDtWh(orderDetailsStock order)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE tb_orderDetailsWh SET idOrderWh = @idOrderWh, barcode = @barcode, codeSpl = @codeSpl, impPrice = @impPrice, quantity = @quantity, total = @total WHERE idOrderDtWh = @idOrderDtWh";
            cmd.Parameters.AddWithValue("@idOrderWh", order.IdOrderWh);
            cmd.Parameters.AddWithValue("@barcode", order.Barcode);
            cmd.Parameters.AddWithValue("@codeSpl", order.CodeSpl);
            cmd.Parameters.AddWithValue("@impPrice", order.ImpPrice);
            cmd.Parameters.AddWithValue("@quantity", order.Quantity);
            cmd.Parameters.AddWithValue("@total", order.Total);
            cmd.Parameters.AddWithValue("@idOrderDtWh", order.IdOrderDtWh);
            return db.ExecuteNoQuery(cmd);
        }
        public int updateOrderWh(orderStock stock) {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE tb_orderWh SET sumMoney = @sumMoney WHERE idOrderWh = @idOrderWh";
            cmd.Parameters.AddWithValue("@sumMoney", stock.SumMoney);
            cmd.Parameters.AddWithValue("@idOrderWh", stock.IdOrderWh);
            return db.ExecuteNoQuery(cmd);
        }
        public int deleteOrderDtWh(orderDetailsStock order)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM tb_orderDetailsWh WHERE idOrderDtWh = @idOrderDtWh";
            cmd.Parameters.AddWithValue("@idOrderDtWh", order.IdOrderDtWh);
            return db.ExecuteNoQuery(cmd);
        }
        public int deleteOrderWh(orderStock order)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM tb_orderWh WHERE idOrderWh = @idOrderWh";
            cmd.Parameters.AddWithValue("@idOrderWh", order.IdOrderWh);
            return db.ExecuteNoQuery(cmd);
        }
        public DataTable searchOrderWh(orderStock order)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "exec searchOrderWh @idOrderWh";
            cmd.Parameters.AddWithValue("@idOrderWh", order.IdOrderWh);
            return db.ExcuteReader(cmd);
        }
    }
}
