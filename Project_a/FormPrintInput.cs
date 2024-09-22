using BUS;
using BUS.Properties;
using DTO;
using Microsoft.Reporting.WinForms;
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
    public partial class FormPrintInput : Form
    {
        public orderStock orderStock = new orderStock();
        public userName userName = new userName();
        public busStockMgn busStockMgn = new busStockMgn();
        public DataTable dt;
        public FormPrintInput(userName user, orderStock order)
        {
            InitializeComponent();
            userName = new userName(user.UserName, user.Password, user.STK, user.NganHang, user.NameAcc);
            orderStock.IdOrderWh = order.IdOrderWh;
        }
        private void FormPrintInput_Load(object sender, EventArgs e)
        {
            getIdOrderWh();
            this.rpv.RefreshReport();
            getInputBillPrint();
        }
        private void getInputBillPrint()
        {
            dt = busStockMgn.getInpBillWh(orderStock);
            if (dt.Rows.Count > 0)
            {
                ReportDataSource reportData = new ReportDataSource("inpBillPrint", dt);
                this.rpv.LocalReport.DataSources.Clear();
                this.rpv.LocalReport.DataSources.Add(reportData);
                this.rpv.RefreshReport();
            }
        }
        private void getIdOrderWh()
        {
            dt = busStockMgn.getIdOrderWh();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                    cmbPhieuNhap.Items.Add(row["idOrderWh"].ToString());
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            orderStock.IdOrderWh = Int32.Parse(cmbPhieuNhap.Text);
            dt = busStockMgn.getInpBillWh(orderStock);
            if (dt.Rows.Count > 0)
            {
                ReportDataSource reportData = new ReportDataSource("inpBillPrint", dt);
                this.rpv.LocalReport.DataSources.Clear();
                this.rpv.LocalReport.DataSources.Add(reportData);
                this.rpv.RefreshReport();
            }
        }
    }
}
