using BUS.Properties;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_a
{
    public partial class FormStock : Form
    {
        public busStockMgn busStockMgn = new busStockMgn();
        public DataTable dt = new DataTable();
        public orderStock orderStock = new orderStock();
        public orderDetailsStock orderDetailsStock = new orderDetailsStock();
        public FormStock()
        {
            InitializeComponent();
        }

        private void FormStock_Load(object sender, EventArgs e)
        {
            loadCTPN();
            loadPN();
        }
        private void loadCTPN()
        {
            dt = busStockMgn.getOrderDtWh();
            if (dt.Rows.Count > 0)
                dgvCTPN.DataSource = dt;
        }
        private void loadPN()
        {
            dt = busStockMgn.getOrderWh();
            if (dt.Rows.Count > 0)
                dgvPN.DataSource = dt;
        }
        private bool checkDgvCTPN()
        {
            foreach (DataGridViewRow row in dgvCTPN.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value == null || string.IsNullOrWhiteSpace(cell.Value.ToString()))
                        return false;
                }
            }
            return true;
        }
        private void updateOrderDtWh()
        {
            int i = dgvCTPN.CurrentRow.Index;
            orderDetailsStock.IdOrderDtWh = Int16.Parse(dgvCTPN.Rows[i].Cells[2].Value.ToString());
            orderDetailsStock.IdOrderWh = Int16.Parse(dgvCTPN.Rows[i].Cells[3].Value.ToString());
            orderDetailsStock.Barcode = dgvCTPN.Rows[i].Cells[4].Value.ToString();
            orderDetailsStock.CodeSpl = dgvCTPN.Rows[i].Cells[5].Value.ToString();
            orderDetailsStock.ImpPrice = double.Parse(dgvCTPN.Rows[i].Cells[6].Value.ToString());
            orderDetailsStock.Quantity = Int16.Parse(dgvCTPN.Rows[i].Cells[7].Value.ToString());
            double total = orderDetailsStock.ImpPrice * orderDetailsStock.Quantity;
            orderDetailsStock.Total = total;
            dgvCTPN.Rows.RemoveAt(i);
            busStockMgn.updateOrderDtWh(orderDetailsStock);
            orderStock.IdOrderWh = orderDetailsStock.IdOrderWh;
            sumMoney(orderStock);

        }
        private void sumMoney(orderStock orderStock)
        {
            dt = busStockMgn.getCalMoney(orderStock);
            if (dt.Rows.Count > 0)
            {
                orderStock orderStock1 = new orderStock();
                orderStock1.IdOrderWh = orderStock.IdOrderWh;
                orderStock1.SumMoney = double.Parse(dt.Rows[0][0].ToString());
                busStockMgn.updateOrderWh(orderStock1);

            }
        }
        private void dgvCTPN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCTPN.Columns[e.ColumnIndex].Name == "dgvCTPNUpdate")
            {
                if (checkDgvCTPN() == false)
                    MessageBox.Show("Bạn chưa nhập số lượng", "Thông báo");
                else
                {
                    updateOrderDtWh();
                    MessageBox.Show("Sửa thành công", "Thông báo");
                    FormStock_Load(sender, e);
                }
            }
            else if(dgvCTPN.Columns[e.ColumnIndex].Name == "dgvCTPNDelete")
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    deleteOrderDtWh();
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    FormStock_Load(sender, e);
                }
            }
        }
        private void deleteOrderDtWh()
        {
            int i = dgvCTPN.CurrentRow.Index;
            orderDetailsStock order = new orderDetailsStock();
            order.IdOrderDtWh = Int16.Parse(dgvCTPN.Rows[i].Cells[2].Value.ToString());
            busStockMgn.deleteOrderDtWh(order);
        }
        private void deleteOrderWh()
        {
            int i = dgvPN.CurrentRow.Index;
            orderStock order = new orderStock();
            order.IdOrderWh = Int16.Parse(dgvPN.Rows[i].Cells[1].Value.ToString());
            busStockMgn.deleteOrderWh(order);
        }

        private void dgvPN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPN.Columns[e.ColumnIndex].Name == "dgvPNDelete")
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    deleteOrderWh();
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    FormStock_Load(sender, e);
                }
            }
        }
    }
}
