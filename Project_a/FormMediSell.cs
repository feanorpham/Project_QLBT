using DTO;
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
using AForge.Video.DirectShow;
using AForge.Video;
using ZXing;
using DTO;
using BUS;
using DTO.Properties;
using BUS.Properties;
namespace Project_a
{
    public partial class FormMediSell : Form
    {
        private static int count = 0;
        public order order = new order();
        public userName userName = new userName();
        public medicine medicine = new medicine();
        public warehouse warehouse = new warehouse();
        public FilterInfoCollection filter;
        public VideoCaptureDevice captureDevice;
        public Bitmap bitmap = null;
        public busMedicSell busMedicSell = new busMedicSell();
        public DataTable dt = new DataTable();
        int i;
        double priceIsRetails;
        int countSHD = 0;
        public FormMediSell(userName user)
        {
            InitializeComponent();
            txtbBarcode.Enabled = false;
            txtbTenThuoc.Enabled = false;
            txtbDonGia.Enabled = false;
            dtpNSX.Enabled = false;
            dtpNHH.Enabled = false;
            txtbSoHoaDon.Enabled = false;
            txtbTSTD.Enabled = false;
            txtTonKho.Enabled = false;
            userName = new userName(user.UserName, user.Password, user.STK, user.NganHang, user.NameAcc);
            lbHello.Text = "Xin chào, " + userName.NameAcc;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm(userName);
            mainForm.Show();
            this.Hide();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            labDate.Text = DateTime.Now.ToString();
        }
        private void CaptureDevice_NewFrame(Object sender, NewFrameEventArgs e)
        {
            bitmap = (Bitmap)e.Frame.Clone();
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            captureDevice = new VideoCaptureDevice(filter[0].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (bitmap != null)
            {
                BarcodeReader reader = new BarcodeReader();
                Result result = reader.Decode(bitmap);
                if (result != null)
                {
                    medicine.Barcode = result.ToString();
                    dt = new DataTable();
                    dt = busMedicSell.getScanOrder(medicine);
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Tìm thấy thuốc", "Thông báo");
                        importMedicSell(dt);
                        if (Int32.Parse(txtTonKho.Text) <= 0)
                            MessageBox.Show("Hàng hóa đã hết");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thuốc, nếu là thuốc mới hãy thêm vào csdl", "Thông báo");
                        clearInfo();
                    }
                }
            }
        }
        private void importMedicSell(DataTable dt)
        {
            txtbBarcode.Text = dt.Rows[0][0].ToString();
            txtbTenThuoc.Text = dt.Rows[0][1].ToString();
            txtbDonGia.Text = dt.Rows[0][2].ToString();
            dtpNSX.Text = dt.Rows[0][4].ToString();
            dtpNHH.Text = dt.Rows[0][5].ToString();
            txtTonKho.Text = dt.Rows[0][6].ToString();
        }
        private void clearInfo()
        {
            txtbBarcode.Text = "";
            txtbTenThuoc.Text = "";
            txtbDonGia.Text = "";
            txtbSoLuong.Text = "";
            txtTonKho.Text = "";
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            if (rdBanLe.Checked == true)
            {
                getPriceIsRetails(double.Parse(txtbDonGia.Text));
                txtbDonGia.Text = priceIsRetails.ToString();
                addBill(txtbBarcode.Text,txtbTenThuoc.Text, int.Parse(txtbSoLuong.Text), double.Parse(txtbDonGia.Text));
                MessageBox.Show("Thêm vào đơn hành thành công", "Thông báo");
                clearInfo();
                dgvHoaDon.Refresh();
            }
            else if (rdBanHop.Checked == true)
            {
                addBill(txtbBarcode.Text, txtbTenThuoc.Text, int.Parse(txtbSoLuong.Text), double.Parse(txtbDonGia.Text));
                MessageBox.Show("Thêm vào đơn hành thành công", "Thông báo");
                clearInfo();
                dgvHoaDon.Refresh();
            }
        }
        private int getQuantity(string barcode)
        {
            warehouse.Barcode = barcode;
            dt = busMedicSell.getQuantity(warehouse);
            if (dt.Rows.Count > 0)
                return Int32.Parse(dt.Rows[0][1].ToString());
            else return -1;
        }
        private int calculateQuantity(int impquantity, string barcode)
        {
            if (getQuantity(barcode) > 0)
                return getQuantity(barcode) - impquantity;
            else return -1;
        }
        private double getPriceIsRetails(double a)
        {
            if (rdBanLe.Checked == true)
            {
                double b = a / 100;
                return priceIsRetails = b * 10;
            }
            return priceIsRetails;
        }
        private void addBill(string barcode,string nameMedic, int quantity, double price)
        {
            double sum = 0;
            sum = double.Parse(quantity.ToString()) * price;
            string time = DateTime.Now.ToString();
            dgvHoaDon.Rows.Add(txtbSoHoaDon.Text,barcode,nameMedic, price, quantity, time, sum);
            sumMoney();
        }

        private void FormMediSell_Load(object sender, EventArgs e)
        {
            dt = busMedicSell.getCountIdOrder();
            if(dt.Rows.Count > 0)
            {
                count = Int32.Parse(dt.Rows[0][0].ToString());
                count += 1;
                txtbSoHoaDon.Text = count.ToString();
            }
        }
        private void sumMoney()
        {
            double sum = 0;
            for (int i = 0; i < dgvHoaDon.Rows.Count; i++)
            {
                sum += Convert.ToInt32(dgvHoaDon.Rows[i].Cells[6].Value);
            }
            txtbTSTD.Text = sum.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.Rows.Count == 0 || string.IsNullOrEmpty(txtbSTT.Text))
                MessageBox.Show("Chưa có thuốc trong đơn hoặc chưa tính tiền trả khách", "Thông báo");
            else
            {
                insertOrder();
                insertOrderDetails();
                MessageBox.Show("Lưu đơn hàng thành công", "Thông báo");
                dgvHoaDon.Rows.Clear();
                clearInfo();
                txtbSTKD.Text = "";
                txtbSTT.Text = "";
                txtbTSTD.Text = "";
            }
        }
        private void insertOrder()
        {
            order order = new order();
            order.SumMoney = double.Parse(txtbTSTD.Text);
            order.DateCreate = DateTime.Now;
            busMedicSell.insertNewOrder(order);
        }
        private void insertOrderDetails()
        {
            for (int i = 0; i < dgvHoaDon.Rows.Count; i++)
            {
                orderDetails orderDetails = new orderDetails();
                orderDetails.IdOrder = Int32.Parse(txtbSoHoaDon.Text);
                orderDetails.Barcode = dgvHoaDon.Rows[i].Cells[1].Value.ToString();
                orderDetails.Price = double.Parse(dgvHoaDon.Rows[i].Cells[3].Value.ToString());
                orderDetails.Quantity = Int32.Parse(dgvHoaDon.Rows[i].Cells[4].Value.ToString());
                orderDetails.Total = double.Parse(dgvHoaDon.Rows[i].Cells[6].Value.ToString());
                busMedicSell.insertNewOrderDetails(orderDetails);
            }
            for (int i = 0; i < dgvHoaDon.RowCount; i++) 
            {
                warehouse wh = new warehouse();
                wh.Barcode = dgvHoaDon.Rows[i].Cells[1].Value.ToString();
                wh.Quantity = Int32.Parse(dgvHoaDon.Rows[i].Cells[4].Value.ToString());
                dt = busMedicSell.searchBarcodeInWareHouse(wh);
                if(dt.Rows.Count > 0)
                {
                    int quantity = calculateQuantity(wh.Quantity, wh.Barcode);
                    wh.Quantity = quantity;
                    busMedicSell.updateQuantity(wh);
                }
            }
        }
        private void btnSumMoney_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbSTKD.Text) == true || double.Parse(txtbSTKD.Text) <= 0)
                MessageBox.Show("Bạn chưa nhập số tiền khách đưa hoặc số tiền = 0", "Thông báo");
            else
            {
                double sum = double.Parse(txtbSTKD.Text) - double.Parse(txtbTSTD.Text);
                txtbSTT.Text = sum.ToString();
            }
        }

        private void btnPrintBil_Click(object sender, EventArgs e)
        {
                FormPayment formPayment = new FormPayment(userName, Int32.Parse(txtbSoHoaDon.Text));
                formPayment.Show();
                FormMediSell_Load(sender, e);
        }
        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvHoaDon.Columns[e.ColumnIndex].Name == "dgvUpdate")
            {
                if (isCheckValuesDgvHoaDon() == false)
                {
                    MessageBox.Show("Chưa nhập đủ dữ liệu", "Thông báo");
                }
                else
                {
                    updateDgvHoaDon();
                    MessageBox.Show("Sửa hóa đơn thành công", "Thông báo");
                    dgvHoaDon.Refresh();
                }
            }
            else if(dgvHoaDon.Columns[e.ColumnIndex].Name == "dgvDelete")
            {
                int i = dgvHoaDon.CurrentRow.Index;
                dgvHoaDon.Rows.RemoveAt(i);
                MessageBox.Show("Xóa thành công", "Thông báo");
                dgvHoaDon.Refresh();
                sumMoney();
            }
        }
        private void updateDgvHoaDon()
        {
           int i = dgvHoaDon.CurrentRow.Index;
           orderDetails orderDetails = new orderDetails();
           orderDetails.IdOrder = Int32.Parse(txtbSoHoaDon.Text);
           orderDetails.Barcode = dgvHoaDon.Rows[i].Cells[1].Value.ToString();
           orderDetails.Price = double.Parse(dgvHoaDon.Rows[i].Cells[3].Value.ToString());
           orderDetails.Quantity = Int32.Parse(dgvHoaDon.Rows[i].Cells[4].Value.ToString());
           double total = orderDetails.Price * orderDetails.Quantity;
           orderDetails.Total = total;
           dgvHoaDon.Rows.RemoveAt(i);
           updateBill(orderDetails.Barcode, orderDetails.Quantity, orderDetails.Price, orderDetails.Total);
        }
        private bool isCheckValuesDgvHoaDon()
        {
            foreach (DataGridViewRow row in dgvHoaDon.Rows)
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value == null || string.IsNullOrWhiteSpace(cell.Value.ToString()))
                        return false;
                }
            return true;
        }
        private void updateBill(string barcode, int quantity, double price, double sum)
        {
            string time = DateTime.Now.ToString();
            dgvHoaDon.Rows.Add(txtbSoHoaDon.Text, barcode, price, quantity, time, sum);
            sumMoney();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (captureDevice.IsRunning)
                captureDevice.Stop();
            timer1.Stop();
            MessageBox.Show("Đã tắt scan mã barcode", "Thông báo");
        }

        private void btnQLHoaDon_Click(object sender, EventArgs e)
        {
            FormSell formSell = new FormSell();
            formSell.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtbSearch.Text == null || string.IsNullOrWhiteSpace(txtbSearch.Text) == true)
                MessageBox.Show("Hãy nhập số hóa đơn cần tìm", "Thông báo");
            else
            {
                order.IdOrder = Int16.Parse(txtbSearch.Text);
                dt = busMedicSell.searchOrder(order);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Tìm thấy hóa đơn số " + order.IdOrder);
                    FormPayment form = new FormPayment(userName, order.IdOrder);
                    form.Show();
                }
                else
                    MessageBox.Show("Không tìm thấy hóa đơn");
            }
        }
    }
}
