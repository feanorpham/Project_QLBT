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

namespace BUS
{
    public class busMedicSell
    {
        public dbConnection db = new dbConnection();
        public DataTable getScanOrder(medicine medicine)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "exec getDataMedicineSell '" + medicine.Barcode + "'";
            return db.ExcuteReader(cmd);
        }
        public int insertNewOrder(order order)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO tb_order VALUES(@sumMoney,@dateCreate)";
            cmd.Parameters.AddWithValue("@sumMoney", order.SumMoney);
            cmd.Parameters.AddWithValue("@dateCreate", order.DateCreate);
            return db.ExecuteNoQuery(cmd);
        }
        public int insertNewOrderDetails(orderDetails orderDetails)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO tb_orderDetails VALUES(@idOrder,@barcode,@price,@quantity,@total)";
            cmd.Parameters.AddWithValue("@idOrder", orderDetails.IdOrder);
            cmd.Parameters.AddWithValue("@barcode", orderDetails.Barcode);
            cmd.Parameters.AddWithValue("@price", orderDetails.Price);
            cmd.Parameters.AddWithValue("@quantity", orderDetails.Quantity);
            cmd.Parameters.AddWithValue("@total", orderDetails.Total);
            return db.ExecuteNoQuery(cmd);
        }
        public DataTable getCountIdOrder()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select* from countOrder";
            return db.ExcuteReader(cmd);
        }
        public DataTable getTotalOrder(order order)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "exec getTotalOrder " + order.IdOrder + "";
            return db.ExcuteReader(cmd);
        }
        public DataTable getBillOrderPrint(order order)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "exec getDataBillOrder " + order.IdOrder + "";
            return db.ExcuteReader(cmd);
        }
        public DataTable getBank(userName userName)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "exec getBinBank " + userName.NganHang + "";
            return db.ExcuteReader(cmd);
        }
        public DataTable getQuantity(warehouse wh)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "exec getQuantity '" + wh.Barcode + "'";
            return db.ExcuteReader(cmd);
        }
        public DataTable searchBarcodeInWareHouse(warehouse wh)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "exec getQuantity @barcode";
            cmd.Parameters.AddWithValue("@barcode", wh.Barcode);
            return db.ExcuteReader(cmd);
        }
        public int updateQuantity(warehouse warehouse)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "exec updateQuantity @barcode,@quantity";
            cmd.Parameters.AddWithValue("@barcode", warehouse.Barcode);
            cmd.Parameters.AddWithValue("@quantity", warehouse.Quantity);
            return db.ExecuteNoQuery(cmd);
        }
        public DataTable getOrder()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "exec getOrder";
            return db.ExcuteReader(cmd);
        }
        public DataTable getOrderDt()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "exec getOrderDt";
            return db.ExcuteReader(cmd);
        }
        public int updateOrderDt(orderDetails orderDetails)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE tb_orderDetails SET idOrder = @idOrder, barcode = @barcode, price = @price, quantity = @quantity, total = @total WHERE idOrdDetails = @idOrdDetails";
            cmd.Parameters.AddWithValue("@idOrder", orderDetails.IdOrder);
            cmd.Parameters.AddWithValue("@barcode", orderDetails.Barcode);
            cmd.Parameters.AddWithValue("@price", orderDetails.Price);
            cmd.Parameters.AddWithValue("@quantity", orderDetails.Quantity);
            cmd.Parameters.AddWithValue("@total", orderDetails.Total);
            cmd.Parameters.AddWithValue("@idOrdDetails", orderDetails.IdOrderDetails);
            return db.ExecuteNoQuery(cmd);
        }
        public DataTable getMoneyInOrderDt(order order)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "exec calMoney @idOrder";
            cmd.Parameters.AddWithValue("@idOrder", order.IdOrder);
            return db.ExcuteReader(cmd);
        }
        public int updateOrder(order order)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE tb_order set sumMoney = @sumMoney WHERE idOrder = @idOrder";
            cmd.Parameters.AddWithValue("@sumMoney",order.SumMoney);
            cmd.Parameters.AddWithValue("@idOrder", order.IdOrder);
            return db.ExecuteNoQuery(cmd);
        }
        public int deleteOrderDt(orderDetails order)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM tb_orderDetails WHERE idOrdDetails = '" + order.IdOrderDetails + "'";
            return db.ExecuteNoQuery(cmd);
        }
        public int deleteOrder(order order)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM tb_order WHERE idOrder = '" + order.IdOrder + "'";
            return db.ExecuteNoQuery(cmd);
        }
        public DataTable searchOrder(order order) {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "exec searchOrder @idOrder";
            cmd.Parameters.AddWithValue("@idOrder", order.IdOrder);
            return db.ExcuteReader(cmd);
        }
    }
}
