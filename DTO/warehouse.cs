using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Properties
{
    public class warehouse
    {
        private string barcode;
        private int quantity;
        public warehouse()
        {

        }
        public warehouse(string barcode, int quantity)
        {
            this.barcode = barcode;
            this.quantity = quantity;
        }
        public string Barcode { get => barcode; set => barcode = value; }
        public int Quantity { get => quantity; set => quantity = value; }
    }
}
