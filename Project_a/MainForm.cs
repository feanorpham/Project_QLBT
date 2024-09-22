using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
namespace Project_a
{
    public partial class MainForm : Form
    {
        public userName userName = new userName();
        public busMain busMain = new busMain();
        public DataTable dt = new DataTable();
        public MainForm()
        {
            InitializeComponent();
        }
        public MainForm(userName user)
        {
            InitializeComponent();
            userName = new userName(user.UserName, user.Password, user.STK, user.NganHang, user.NameAcc);
            lbHello.Text = "Xin chào, " + userName.NameAcc;
        }

        private void btnQLT_Click(object sender, EventArgs e)
        {
            FormMediMgn formMediMgn = new FormMediMgn(userName);
            formMediMgn.Show();
            this.Hide();
        }
        private void btnQLDH_Click(object sender, EventArgs e)
        {
            FormMediSell formMediSell = new FormMediSell(userName);
            formMediSell.Show();
            this.Hide();
        }

        private void btnQLKH_Click(object sender, EventArgs e)
        {
            FormStockMgn form  = new FormStockMgn(userName);
            form.Show();
            this.Hide();
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            FormThongKe formThongKe = new FormThongKe(userName);
            formThongKe.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbDate.Text = DateTime.Now.ToString();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            dt = busMain.getMedicData();
            if (dt.Rows.Count > 0)
                dgvSearch.DataSource = dt;
        }

        private void txtbSreach_TextChanged(object sender, EventArgs e)
        {
            medicine medicine = new medicine();
            medicine.Name = txtbSreach.Text;
            dt = busMain.sreachName(medicine);
            if (dt.Rows.Count > 0)
                dgvSearch.DataSource = dt;
        }
    }
}
