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
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;


namespace Project_a
{
    public partial class FormMediMgn : Form
    {
        public FilterInfoCollection filter;
        public VideoCaptureDevice captureDevice;
        public Bitmap bitmap = null;
        public userName userName = new userName();
        public medicine medicine = new medicine();
        public supplier supplier = new supplier();
        public busMedicMgn busMedicMgn = new busMedicMgn();
        public busSplMgn busSplMgn = new busSplMgn();
        public DataTable dt = new DataTable();
        int i;
        public FormMediMgn(userName user)
        {
            InitializeComponent();
            userName = new userName(user.UserName, user.Password, user.STK, user.NganHang, user.NameAcc);
            lbHellot.Text = "Xin chào, " + userName.NameAcc;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm(userName);
            mainForm.Show();
            this.Hide();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
           if(bitmap != null)
            {
                BarcodeReader reader = new BarcodeReader();
                Result result = reader.Decode(bitmap);
                if(result != null)
                {
                    txtbBarcode.Text = result.ToString();
                    medicine.Barcode = txtbBarcode.Text;
                    dt = busMedicMgn.selectMedic(medicine);
                    if (dt.Rows.Count > 0)
                    {
                        string a = txtbBarcode.Text.ToString();
                        importMedic(dt, a);
                        MessageBox.Show("Tìm thấy thuốc","Thông báo");
                    }
                    else
                    {
                        string a = txtbBarcode.Text;
                        string b = a.Substring(0, 7);
                        if (isExistCodeSpl(b) == false)
                        {
                            MessageBox.Show("Mã nhà cung cấp chưa có trong csdl, hãy thê mới nhà cung cấp", "Thông báo");
                            txtbMaNCC.Text = b;
                            txtbMaNCC.Enabled = false;
                        }
                        else if (isExistBarcode(a) == false)
                        {
                            MessageBox.Show("Thuốc chưa có trên csdl, hãy thêm mới thuốc", "Thông báo");
                            txtbMaNhaCC.Text = b;
                            txtbBarcode.Enabled = false;
                            txtbMaNhaCC.Enabled = false;
                        }

                    }
                }
            }
        }
        private void btnScan_Click(object sender, EventArgs e)
        {
            filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            captureDevice = new VideoCaptureDevice(filter[0].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();
        }
        private void isStopScan()
        {
            if(captureDevice.IsRunning)
                captureDevice.Stop();
            timer1.Stop();
        }
        private void CaptureDevice_NewFrame(Object sender, NewFrameEventArgs e)
        {
            bitmap = (Bitmap)e.Frame.Clone();
        }

        private void FormMediMgn_Load(object sender, EventArgs e)
        {
            dt = busMedicMgn.getDataMedic();
            if(dt.Rows.Count > 0)
            {
                medicine medicine = new medicine();
                medicine.Barcode = dt.Rows[0][0].ToString();
                medicine.Name = dt.Rows[0][1].ToString();
                medicine.ImpPrice = Double.Parse(dt.Rows[0][2].ToString());
                medicine.Price = Double.Parse(dt.Rows[0][3].ToString());
                medicine.IsReatil = Int16.Parse(dt.Rows[0][4].ToString());;
                medicine.MfgD = DateTime.Parse(dt.Rows[0][5].ToString());
                medicine.ExpD = DateTime.Parse(dt.Rows[0][6].ToString());
                medicine.LesUse = dt.Rows[0][7].ToString();
                medicine.CodeSupplier = dt.Rows[0][8].ToString();
                //dgvThuoc.DataSource = medicine;
                dgvThuoc.DataSource = dt;
            }
            dt = busSplMgn.getDatSpl();
            if(dt.Rows.Count > 0)
            {
                supplier = new supplier();
                supplier.CodeSupplier = dt.Rows[0][0].ToString();
                supplier.NameSupplier = dt.Rows[0][1].ToString();
                dgvSpl.DataSource = dt;
            }
        }
        private void rdThuoc_CheckedChanged(object sender, EventArgs e)
        {
            if(rdThuoc.Checked == true)
            {
                gbThuoc.Enabled = true;
                gbNCC.Enabled = false;
            }
            else
            {
                gbThuoc.Enabled = false;
                gbNCC.Enabled = true;
            }
        }

        private void dgvThuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvThuoc.CurrentRow.Index;
            if (dgvThuoc.Columns[e.ColumnIndex].Name == "dgvUpdate")
            {
                if (checkDgvThuoc() == false)
                    MessageBox.Show("Nhập thiếu giá trị trên các ô hãy nhập lại", "Thông báo");
                else
                {
                    medicine medicine = new medicine();
                    medicine.Barcode = dgvThuoc.Rows[i].Cells[2].Value.ToString();
                    medicine.Name = dgvThuoc.Rows[i].Cells[3].Value.ToString();
                    medicine.ImpPrice = Double.Parse(dgvThuoc.Rows[i].Cells[4].Value.ToString());
                    medicine.Price = Double.Parse(dgvThuoc.Rows[i].Cells[5].Value.ToString());
                    medicine.IsReatil = Int16.Parse(dgvThuoc.Rows[i].Cells[6].Value.ToString());
                    medicine.MfgD = DateTime.Parse(dgvThuoc.Rows[i].Cells[7].Value.ToString());
                    medicine.ExpD = DateTime.Parse(dgvThuoc.Rows[i].Cells[8].Value.ToString());
                    medicine.LesUse = dgvThuoc.Rows[i].Cells[9].Value.ToString();
                    medicine.CodeSupplier = dgvThuoc.Rows[i].Cells[10].Value.ToString();
                    busMedicMgn.updateMedic(medicine);
                    MessageBox.Show("Cập nhập thông tin thuốc thành công", "Thông báo");
                    FormMediMgn_Load(sender, e);
                }
            }
            else if (dgvThuoc.Columns[e.ColumnIndex].Name == "dgvDelete")
            {
                medicine medicine = new medicine();
                medicine.Barcode = dgvThuoc.Rows[i].Cells[2].Value.ToString();
                medicine.Name = dgvThuoc.Rows[i].Cells[3].Value.ToString();
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa thuốc " + medicine.Name + " không?","Thông báo",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    busMedicMgn.deleteMedic(medicine);
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    FormMediMgn_Load(sender, e);
                }
            }
        }
        private bool checkDgvThuoc()
        {
            foreach (DataGridViewRow row in dgvThuoc.Rows)
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value == null || string.IsNullOrWhiteSpace(cell.Value.ToString()))
                        return false;
                }
            return true;
        }
        private bool checkDgvSpl()
        {
            int i = dgvSpl.CurrentRow.Index;
            return (dgvSpl.Rows[i].Cells[3].Value.ToString() == null || string.IsNullOrWhiteSpace(dgvSpl.Rows[i].Cells[3].Value.ToString())) ? true : false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (rdThuoc.Checked == true)
            {
                if (checkTxtb() == false)
                    MessageBox.Show("Chưa nhập đủ dữ liệu", "Thông báo");
                else
                {
                    insertMedic();
                    FormMediMgn_Load(sender, e);
                }
            }
            else if (rdNCC.Checked == true) 
            {
                if (checkTbSpl() == true)
                    MessageBox.Show("Chưa nhập đủ dữ liệu", "Thông báo");
                else 
                { 
                    insertSpl();
                    FormMediMgn_Load(sender, e);
                }
            }
        }

        private void dgvSpl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvSpl.CurrentRow.Index;
            if (dgvSpl.Columns[e.ColumnIndex].Name == "dgvUpdateSpl")
            {
                if (checkDgvSpl() == true)
                    MessageBox.Show("Bạn chưa nhập tên nhà cung cấp", "Thông báo");
                else
                {
                    supplier supplier = new supplier();
                    supplier.CodeSupplier = dgvSpl.Rows[i].Cells[2].Value.ToString();
                    supplier.NameSupplier = dgvSpl.Rows[i].Cells[3].Value.ToString();
                    busSplMgn.updateSpl(supplier);
                    MessageBox.Show("Cập nhập thông tin nhà cung cấp thành công", "Thông báo");
                    FormMediMgn_Load(sender, e);
                }
            }
            else if(dgvSpl.Columns[e.ColumnIndex].Name == "dgvDeleteSpl")
            {
                supplier.NameSupplier = dgvSpl.Rows[i].Cells[3].Value.ToString();
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhà cung cấp " + supplier.NameSupplier + " không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                    supplier.CodeSupplier = dgvSpl.Rows[i].Cells[2].Value.ToString();
                    busSplMgn.deleteSpl(supplier);
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    FormMediMgn_Load(sender, e);
                }
            }
        }
        private bool checkTxtb()
        {
            return (string.IsNullOrWhiteSpace(txtbBarcode.Text) || string.IsNullOrWhiteSpace(txtbTenThuoc.Text) || string.IsNullOrEmpty(txtbGiaNhap.Text) ||
                string.IsNullOrWhiteSpace(txtbGiaBan.Text) || string.IsNullOrWhiteSpace(txtbCongDung.Text) || string.IsNullOrWhiteSpace(txtbMaNhaCC.Text)) ? false : true;
        }
        private void importMedic(DataTable dt, string a)
        {
            string b = a.Substring(0,7);
            medicine medicine = new medicine();
            medicine.Barcode = txtbBarcode.Text = dt.Rows[0][0].ToString();
            medicine.Name = txtbTenThuoc.Text =dt.Rows[0][1].ToString();
            medicine.ImpPrice = Double.Parse(dt.Rows[0][2].ToString());
            txtbGiaNhap.Text = dt.Rows[0][2].ToString();
            medicine.Price = Double.Parse(dt.Rows[0][3].ToString());
            txtbGiaBan.Text = dt.Rows[0][3].ToString();
            int i = Int16.Parse(dt.Rows[0][4].ToString());
            if(i == 1)
            {
                rbBanTheoHop.Checked = true;
                rbBanTheoVi.Checked = false;
            }
            else if(i == 0)
            {
                rbBanTheoVi.Checked = true;
                rbBanTheoHop.Checked = false;
            }
            medicine.MfgD = DateTime.Parse(dt.Rows[0][5].ToString());
            medicine.ExpD = DateTime.Parse(dt.Rows[0][6].ToString());
            dtpNSX.Text = dt.Rows[0][5].ToString();
            dtpNHH.Text = dt.Rows[0][6].ToString();
            medicine.LesUse = txtbCongDung.Text = dt.Rows[0][7].ToString();
            medicine.CodeSupplier = txtbMaNhaCC.Text = dt.Rows[0][8].ToString();

        }

        private void btnStopScan_Click(object sender, EventArgs e)
        {
            if(captureDevice.IsRunning)
                captureDevice.Stop();
            timer1.Stop();
            MessageBox.Show("Đã tắt scan mã barcode", "Thông báo");
        }
        private void insertMedic()
        {
            medicine medicine = new medicine();
            medicine.Barcode = txtbBarcode.Text;
            medicine.Name = txtbTenThuoc.Text;
            medicine.ImpPrice = Double.Parse(txtbGiaNhap.Text);
            medicine.Price = Double.Parse(txtbGiaBan.Text);
            getIsReatil();
            if (i == 0)
                medicine.IsReatil = i;
            else if (i == 1) medicine.IsReatil = i;
            medicine.MfgD = DateTime.Parse(dtpNSX.Text);
            medicine.ExpD = DateTime.Parse(dtpNHH.Text);
            medicine.LesUse = txtbCongDung.Text;
            medicine.CodeSupplier = txtbMaNhaCC.Text;
            busMedicMgn.insertMedic(medicine);
            MessageBox.Show("Thêm thuốc mới thành công", "Thông báo");
            clearInfo();
        }
        private void insertSpl()
        {
            supplier supplier = new supplier();
            supplier.CodeSupplier = txtbMaNCC.Text;
            supplier.NameSupplier = txtbTenNhaCC.Text;
            busSplMgn.insertSpl(supplier);
            MessageBox.Show("Thêm mới nhà cung cấp thành công", "Thông báo");
            clearInfo();
        }
        private int getIsReatil()
        {
            if (rbBanTheoVi.Checked == true)
                return i = 0;
            else if (rbBanTheoHop.Checked == true)
                return i = 1;
            return i;
        }
        private bool isExistCodeSpl(string a)
        {
            supplier.CodeSupplier = a;
            dt = busSplMgn.isExistCodeSpl(supplier);
            return (dt.Rows.Count > 0) ? true : false;
        }
        private bool isExistBarcode(string a)
        {
            medicine.Barcode = a;
            dt = busMedicMgn.isExistBarcode(medicine);
            return (dt.Rows.Count > 0) ? true : false;
        }
        private bool checkTbSpl()
        {
            return (string.IsNullOrWhiteSpace(txtbMaNCC.Text) || string.IsNullOrWhiteSpace(txtbTenNhaCC.Text)) ? true : false;
        }
        private void clearInfo()
        {
            txtbBarcode.Text = "";
            txtbTenThuoc.Text = "";
            txtbGiaBan.Text = "";
            txtbGiaNhap.Text = "";
            rbBanTheoHop.Checked = false;
            rbBanTheoVi.Checked = false;
            txtbCongDung.Text = "";
            txtbMaNCC.Text = "";
            txtbMaNhaCC.Text = "";
            txtbTenNhaCC.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearInfo();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            labDate.Text = DateTime.Now.ToString();
        }
    }
}
