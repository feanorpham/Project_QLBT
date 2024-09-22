using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class orderDetails
    {
        private int idOrDetails, idOrder, quantity;
        private string barcode;
        private double price, total;
        public orderDetails() { }
        public orderDetails(int idOrDetails, int idOrder, string barcode, double price, int quantity, double total)
        {
            this.idOrDetails = idOrDetails;
            this.idOrder = idOrder;
            this.barcode = barcode;
            this.price = price;
            this.quantity = quantity;
            this.total = total;
        }
        public int IdOrderDetails { get => idOrDetails; set => idOrDetails = value; }
        public int IdOrder { get => idOrder; set => idOrder = value; }
        public string Barcode { get => barcode; set => barcode = value; }
        public double Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public double Total { get => total; set => total = value; }
    }
}
