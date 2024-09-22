using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class order
    {
        private int idOrder;
        private double sumMoney;
        private DateTime dateCreate;
        public order() { }
        public order(int idOrder, double sumMoney, DateTime dateCreate)
        {
            this.idOrder = idOrder;
            this.sumMoney = sumMoney;
            this.dateCreate = dateCreate;
        }
        public int IdOrder { get => idOrder; set => idOrder = value; }
        public double SumMoney { get => sumMoney; set => sumMoney = value; }
        public DateTime DateCreate { get => dateCreate; set => dateCreate = value; }
    }
}
