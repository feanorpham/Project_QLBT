using BUS;
using DTO;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
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
    public partial class FormSell : Form
    {
        public userName userName = new userName();
        public DataTable dt = new DataTable();
        public busMedicSell busMedicSell = new busMedicSell();
        public orderDetails orderDetails = new orderDetails();
        public order order = new order();
        public FormSell()
        {
            InitializeComponent();
        }
        public FormSell(userName user, int i)
        {
            InitializeComponent();
            userName = new userName(user.UserName, user.Password, user.STK, user.NganHang, user.NameAcc);
            order.IdOrder = i;
        }
        private void loadCTHD()
        {
            dt = busMedicSell.getOrderDt();
            if (dt.Rows.Count > 0)
            {
                orderDetails orderDt = new orderDetails();
                orderDt.IdOrderDetails = Int32.Parse(dt.Rows[0][0].ToString());
                orderDt.IdOrder = Int32.Parse(dt.Rows[0][1].ToString());
                orderDt.Barcode = dt.Rows[0][2].ToString();
                orderDt.Price = double.Parse(dt.Rows[0][3].ToString());
                orderDt.Quantity = Int32.Parse(dt.Rows[0][4].ToString());
                orderDt.Total = double.Parse(dt.Rows[0][5].ToString());
                dgvCTHD.DataSource = dt;
            }

        }
        private void loadHD()
        {
            dt = busMedicSell.getOrder();
            if (dt.Rows.Count > 0)
                dgvHD.DataSource = dt;
        }

        private void FormSell_Load(object sender, EventArgs e)
        {
            loadCTHD();
            loadHD();
        }

        private void dgvCTHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCTHD.Columns[e.ColumnIndex].Name == "dgvCTHDUpdate")
            {
                if (checkDgvCTHD() == false)
                    MessageBox.Show("Bạn chưa nhập số lượng", "Thông báo");
                else
                {
                    updateOrderDt();
                    MessageBox.Show("Sửa thành công", "Thông báo");
                    FormSell_Load(sender, e);
                }
            }
            else if(dgvCTHD.Columns[e.ColumnIndex].Name == "dgvCTHDDelete")
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    deleteOrderDt();
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    FormSell_Load(sender, e);
                }
            }
        }
        private bool checkDgvCTHD()
        {
            foreach (DataGridViewRow row in dgvCTHD.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value == null || string.IsNullOrWhiteSpace(cell.Value.ToString()))
                        return false;
                }
            }
            return true;
        }
        private void updateOrderDt()
        {
            int i = dgvCTHD.CurrentRow.Index;
            orderDetails orderDetails = new orderDetails();
            orderDetails.IdOrderDetails = Int32.Parse(dgvCTHD.Rows[i].Cells[2].Value.ToString());
            orderDetails.IdOrder = Int32.Parse(dgvCTHD.Rows[i].Cells[3].Value.ToString());
            orderDetails.Barcode = dgvCTHD.Rows[i].Cells[4].Value.ToString();
            orderDetails.Price = double.Parse(dgvCTHD.Rows[i].Cells[5].Value.ToString());
            orderDetails.Quantity = Int32.Parse(dgvCTHD.Rows[i].Cells[6].Value.ToString());
            double total = orderDetails.Price * orderDetails.Quantity;
            orderDetails.Total = total;
            dgvCTHD.Rows.RemoveAt(i);
            busMedicSell.updateOrderDt(orderDetails);
            order.IdOrder = orderDetails.IdOrder;
            sumMoney(order);

        }
        private void sumMoney(order order)
        {
            dt = busMedicSell.getMoneyInOrderDt(order);
            if (dt.Rows.Count > 0) 
            { 
                order order1 = new order();
                order1.IdOrder = order.IdOrder;
                order1.SumMoney = double.Parse(dt.Rows[0][0].ToString());
                busMedicSell.updateOrder(order1);
            }
        }
        private void deleteOrderDt()
        {
            int i = dgvCTHD.CurrentRow.Index;
            orderDetails orderDetails = new orderDetails();
            orderDetails.IdOrderDetails = Int32.Parse(dgvCTHD.Rows[i].Cells[2].Value.ToString());
            busMedicSell.deleteOrderDt(orderDetails);
        }
        private void deleteOrder()
        {
            int i = dgvHD.CurrentRow.Index;
            order order = new order();
            order.IdOrder = Int32.Parse(dgvCTHD.Rows[i].Cells[1].Value.ToString());
            busMedicSell.deleteOrder(order);
        }

        private void dgvHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvHD.Columns[e.ColumnIndex].Name == "dgvHDDelete")
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    deleteOrder();
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    FormSell_Load(sender, e);
                }
            }
        }
    }
}
