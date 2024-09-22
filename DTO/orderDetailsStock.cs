using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class orderDetailsStock
    {
        private int idOrderDtWh;
        private int idOrderWh;
        private string barcode;
        private string codeSpl;
        private double impPrice;
        private int quantity;
        private double total;
        public orderDetailsStock() { }
        public orderDetailsStock(int idOrderDtWh, int idOrderWh, string barcode, string codeSpl, double impPrice,int quantity, double total)
        {
            this.idOrderDtWh = idOrderDtWh;
            this.idOrderWh = idOrderWh;
            this.barcode = barcode;
            this.codeSpl = codeSpl;
            this.impPrice = impPrice;
            this.quantity = quantity;
            this.total = total;
        }
        public int IdOrderDtWh { get => idOrderDtWh; set => idOrderDtWh = value; }
        public int IdOrderWh { get => idOrderWh; set => idOrderWh = value; }
        public string Barcode { get => barcode; set => barcode = value; }
        public string CodeSpl { get => codeSpl; set => codeSpl = value; }
        public double ImpPrice { get => impPrice; set => impPrice = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public double Total { get => total; set => total = value; }
    }
}
