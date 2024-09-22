using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using BUS;
using BUS.Properties;
using DTO;
using DTO.Properties;
namespace Project_a
{
    public partial class FormStockMgn : Form
    {
        public busStockMgn busStockMgn = new busStockMgn();
        public warehouse warehouse = new warehouse();
        public orderStock orderStock = new orderStock();
        public orderDetailsStock orderDetailsStock = new orderDetailsStock();
        public DataTable dt = new DataTable();
        public List<orderDetailsStock> list = new List<orderDetailsStock>();
        public medicine medicine = new medicine();
        public userName userName = new userName();
        int count = 0;
        int quantity;
        bool check;
        int total;
        public FormStockMgn(userName user)
        {
            InitializeComponent();
            txtbSoPhieuNhap.Enabled = false;
            txtbDonGia.Enabled = false;
            txtbTSTN.Enabled = false;
            dgvThongKe.Enabled = false;
            userName = new userName(user.UserName, user.Password, user.STK, user.NganHang, user.NameAcc);
            labHello.Text = "Xin chào, " + userName.NameAcc;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm(userName);
            mainForm.Show();
            this.Hide();
        }

        private void FormStockMgn_Load(object sender, EventArgs e)
        {
            getInfoMedic();
            dt = busStockMgn.getCountId();
            if(dt.Rows.Count > 0)
            {
                count = int.Parse(dt.Rows[0][0].ToString());
                count += 1;
                txtbSoPhieuNhap.Text = count.ToString();
            }
            getDataStock();
        }
        private void getDataStock()
        {
            dt = busStockMgn.getWh();
            if(dt.Rows.Count > 0)
            {
                dgvThongKe.DataSource = dt;
            }
        }
        private void btnMedicMgn_Click(object sender, EventArgs e)
        {
            FormMediMgn formMedicMgn = new FormMediMgn(userName);
            formMedicMgn.Show();
            this.Hide();
        }
        private void getInfoMedic()
        {
            dt = busStockMgn.getNameMedic();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    cmbTenThuoc.Items.Add(dr["nameMedic"].ToString());
                }
            }
        }
        private void cmbTenThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            medicine.Name = cmbTenThuoc.SelectedItem.ToString();
            dt = busStockMgn.getDataForOrderWh(medicine);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    txtbDonGia.Text = dr["impPrice"].ToString();
                    orderDetailsStock.Barcode = dr["barcode"].ToString();
                    orderDetailsStock.CodeSpl = dr["codeSpl"].ToString();
                }
            }
        }
        private void sumMoney()
        {
            double sum = 0;
            for (int i = 0; i < dgvCTPN.Rows.Count; i++)
            {
                sum += Convert.ToInt32(dgvCTPN.Rows[i].Cells[6].Value);
            }
            txtbTSTN.Text = sum.ToString();
        }
        private void addDgv(string barcode, string codeSpl, int quantity, double impPrice)
        {
            double sum = 0;
            sum = double.Parse(quantity.ToString()) * impPrice;
            dgvCTPN.Rows.Add(txtbSoPhieuNhap.Text, barcode, cmbTenThuoc.SelectedItem.ToString(), codeSpl, impPrice, quantity, sum);
            sumMoney();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isNotNull() == true)
                MessageBox.Show("Vui lòng nhập số lượng thuốc cần nhập", "Thông báo");
            else
            {
                orderDetailsStock.ImpPrice = double.Parse(txtbDonGia.Text);
                orderDetailsStock.Quantity = Int32.Parse(txtbSoLuong.Text);
                addDgv(orderDetailsStock.Barcode, orderDetailsStock.CodeSpl, orderDetailsStock.Quantity, orderDetailsStock.ImpPrice);
                MessageBox.Show("Thông chi tiết phiếu nhập thành công", "Thông báo");
                txtbDonGia.Text = "";
                txtbSoLuong.Text = "";
                dgvCTPN.Refresh();
            }
        }
        private bool isNotNull()
        {
            return (string.IsNullOrWhiteSpace(txtbSoLuong.Text)) ? true : false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvCTPN.Rows.Count == 0 || string.IsNullOrWhiteSpace(txtbSoPhieuNhap.Text))
                MessageBox.Show("Chưa nhập đủ thông tin", "Thông báo");
            else
            {
                insertOrderStock();
                insertOrderDtStock();
                insertWh();
                MessageBox.Show("Lưu thông tin phiếu nhập thành công", "Thông báo");
                dgvCTPN.Rows.Clear();
                orderStock.IdOrderWh = Int32.Parse(txtbSoPhieuNhap.Text);
                txtbSoPhieuNhap.Text = "";
                txtbDonGia.Text = "";
                txtbSoLuong.Text = "";
                txtbTSTN.Text = "";
                cmbTenThuoc.Items.Clear();
                FormStockMgn_Load(sender, e);
            }
        }
        private void insertOrderStock()
        {
            orderStock order = new orderStock();
            order.SumMoney = double.Parse(txtbTSTN.Text);
            order.DateCreate = DateTime.Now;
            busStockMgn.insertOrderWh(order);
        }
        private void insertOrderDtStock()
        {
            for (int i = 0; i < dgvCTPN.Rows.Count; i++)
            {
                orderDetailsStock order = new orderDetailsStock();
                order.IdOrderWh = int.Parse(txtbSoPhieuNhap.Text);
                order.Barcode = dgvCTPN.Rows[i].Cells[1].Value.ToString();
                order.CodeSpl = dgvCTPN.Rows[i].Cells[3].Value.ToString();
                order.ImpPrice = double.Parse(dgvCTPN.Rows[i].Cells[4].Value.ToString());
                order.Quantity = int.Parse(dgvCTPN.Rows[i].Cells[5].Value.ToString());
                order.Total = double.Parse(dgvCTPN.Rows[i].Cells[6].Value.ToString());
                busStockMgn.insertOrderDtWh(order);
            }
        }
        private void insertWh()
        {
            for (int i = 0; i < dgvCTPN.Rows.Count; i++) { 
                warehouse warehouse = new warehouse();
                warehouse.Barcode = dgvCTPN.Rows[i].Cells[1].Value.ToString();
                warehouse.Quantity = int.Parse(dgvCTPN.Rows[i].Cells[5].Value.ToString());
                dt = busStockMgn.checkBarcodeInWareHouse(warehouse);
                if (dt.Rows.Count > 0) 
                {
                    int quantity = calculateQuantity(warehouse.Quantity, warehouse.Barcode);
                    warehouse.Quantity = quantity;
                    busStockMgn.updateWh(warehouse);
                }
                else 
                    busStockMgn.insertWh(warehouse);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labDate.Text = DateTime.Now.ToString();
        }

        private void dgvCTPN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCTPN.Columns[e.ColumnIndex].Name == "dgvUpdate")
            {
                if (isCheckValuesDgvCTPN() == false)
                {
                    MessageBox.Show("Chưa nhập đủ dữ liệu", "Thông báo");
                }
                else
                {
                    updateDgvCTPN();
                    MessageBox.Show("Sửa hóa đơn thành công", "Thông báo");
                    dgvCTPN.Refresh();
                }
            }
            else if (dgvCTPN.Columns[e.ColumnIndex].Name == "dgvDelete")
            {
                int i = dgvCTPN.CurrentRow.Index;
                dgvCTPN.Rows.RemoveAt(i);
                MessageBox.Show("Xóa thành công", "Thông báo");
                dgvCTPN.Refresh();
                sumMoney();
            }
        }
        private void updateDgvCTPN()
        {
            int i = dgvCTPN.CurrentRow.Index;
            orderDetailsStock order = new orderDetailsStock();
            order.IdOrderWh = int.Parse(txtbSoPhieuNhap.Text);
            order.Barcode = dgvCTPN.Rows[i].Cells[1].Value.ToString();
            order.CodeSpl = dgvCTPN.Rows[i].Cells[3].Value.ToString();
            order.ImpPrice = double.Parse(dgvCTPN.Rows[i].Cells[4].Value.ToString());
            order.Quantity = int.Parse(dgvCTPN.Rows[i].Cells[5].Value.ToString());
            double total = order.ImpPrice * order.Quantity;
            order.Total = total;
            dgvCTPN.Rows.RemoveAt(i);
            updateBill(order.Barcode, order.CodeSpl, order.Quantity, order.ImpPrice, total);
        }
        private bool isCheckValuesDgvCTPN()
        {
            foreach (DataGridViewRow row in dgvCTPN.Rows)
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value == null || string.IsNullOrWhiteSpace(cell.Value.ToString()))
                        return false;
                }
            return true;
        }
        private void updateBill(string barcode, string codeSpl, int quantity, double impPrice, double sum)
        {
            dgvCTPN.Rows.Add(txtbSoPhieuNhap.Text, barcode, cmbTenThuoc.SelectedItem.ToString(), codeSpl, impPrice, quantity, sum);
            sumMoney();
        }
        private int getQuantity(string barcode)
        {
           warehouse.Barcode = barcode;
           dt = busStockMgn.getSumQuantity(warehouse);
           if(dt.Rows.Count > 0)
                return Int32.Parse(dt.Rows[0][1].ToString());
            else return -1;
        }
        private int calculateQuantity(int impquantity, string barcode)
        {
            if(getQuantity(barcode) > 0)
                return getQuantity(barcode) + impquantity;
            else if(getQuantity(barcode) == 0)
                return 0 + impquantity;
            else return 0;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            FormPrintInput formPrint = new FormPrintInput(userName, orderStock);
            formPrint.Show();
        }

        private void btnPhieuNhap_Click(object sender, EventArgs e)
        {
            FormStock form = new FormStock();
            form.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtbSreach.Text == null || string.IsNullOrWhiteSpace(txtbSreach.Text) == true)
                MessageBox.Show("Hãy nhập số phiếu nhập cần tìm", "Thông báo");
            else
            {
                orderStock.IdOrderWh = Int16.Parse(txtbSreach.Text);
                dt = busStockMgn.searchOrderWh(orderStock);
                if (dt.Rows.Count > 0)
                {
                    FormPrintInput form = new FormPrintInput(userName, orderStock);
                    form.Show();
                }
                else
                    MessageBox.Show("Không tìm thấy phiếu nhập", "Thông báo");
            }
        }
    }
}
