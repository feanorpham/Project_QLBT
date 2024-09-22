using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class medicine
    {
        private string barcode;
        private string name;
        private double impPrice;
        private double price;
        private int isReatil;
        private DateTime mfgD;
        private DateTime expD;
        private string lesUse;
        private string codeSupplier;
        public medicine(string barcode, string name, double impPrice, double price, int isReatil, DateTime mfgD, DateTime expD, string lesUse, string codeSupplier)
        {
            this.barcode = barcode;
            this.name = name;
            this.impPrice = impPrice;
            this.price = price;
            this.isReatil = isReatil;
            this.mfgD = mfgD;
            this.expD = expD;
            this.lesUse = lesUse;
            this.codeSupplier = codeSupplier;
        }
        public medicine() { }
        public string Barcode { get => barcode; set => barcode = value; }
        public string Name { get => name; set => name = value; }
        public double ImpPrice { get => impPrice; set => impPrice = value; }  
        public double Price { get => price; set => price = value; }
        public int IsReatil { get => isReatil; set => isReatil = value; }
        public DateTime MfgD { get => mfgD; set => mfgD = value; }
        public DateTime ExpD { get => expD; set => expD = value; }
        public string LesUse { get => lesUse; set => lesUse = value; }
        public string CodeSupplier { get => codeSupplier; set => codeSupplier = value; }
        public override string ToString()
        {
            return "Mã vạch: " + barcode + "\nTên: " + name + "\nGiá nhập: " + impPrice + "\nGiá bán: " + price + "\nĐã bán: " + isReatil + "\nNgày sản xuất: " + mfgD + "\nHạn sử dụng: " + expD + "\nLượt dùng: " + lesUse + "\nMã nhà cung cấp: " + codeSupplier;
        }
    }
}
