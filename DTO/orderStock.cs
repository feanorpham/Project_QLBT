using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class orderStock
    {
        private int idOrderWh;
        private double sumMoney;
        private DateTime dateCreate;
        public orderStock() { }
        public orderStock(int idOrderWh, double sumMoney, DateTime dateCreate)
        {
            this.idOrderWh = idOrderWh;
            this.sumMoney = sumMoney;
            this.dateCreate = dateCreate;
        }
        public int IdOrderWh { get => idOrderWh; set => idOrderWh = value; }
        public double SumMoney { get => sumMoney; set => sumMoney = value; }
        public DateTime DateCreate { get => dateCreate; set => dateCreate = value; }
    }
}
