using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BUS;
using DTO;
namespace Project_a
{
    public partial class FormThongKe : Form
    {
        public BusThongKe BusThongKe = new BusThongKe();
        public DataTable dt = new DataTable();
        public userName userName = new userName();
        public FormThongKe(userName user)
        {
            InitializeComponent();
            txtDTThang.Enabled = false;
            txtTSBR.Enabled = false;
            txtTSNV.Enabled = false;
            userName = new userName(user.UserName, user.Password, user.STK, user.NganHang, user.NameAcc);
            labHello.Text = "Xin chào, " + userName.NameAcc;
        }

        private void FormThongKe_Load(object sender, EventArgs e)
        {
            loadMedicSell();
            loadMedicImp();
            loadTotalMonth();
        }
        private void loadMedicSell()
        {
            dt = BusThongKe.getMedicSell();
            if (dt.Rows.Count > 0) {
                totalDay.Series.Clear();
                Series series = new Series("Số lượng thuốc bán ra");
              //  series.ChartType = SeriesChartType.Pie;
                series.Points.DataBind(dt.DefaultView, "nameMedic", "sumQuantity", null);
                totalDay.Series.Add(series);
                totalDay.ChartAreas[0].AxisX.Title = "nameMedic";
                totalDay.ChartAreas[0].AxisY.Title = "sumQuantity";
            }
        }
        private void loadMedicImp()
        {
            dt = BusThongKe.getMedicImp();
            if (dt.Rows.Count > 0)
            {
                char3.Series.Clear();
                Series series = new Series("Số lượng thuốc nhập vào");
                //  series.ChartType = SeriesChartType.Pie;
                series.Points.DataBind(dt.DefaultView, "nameMedic", "quantity", null);
                char3.Series.Add(series);
                char3.ChartAreas[0].AxisX.Title = "nameMedic";
                char3.ChartAreas[0].AxisY.Title = "quantity";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labDate.Text = DateTime.Now.ToString();
        }
        private void loadTotalMonth()
        {
            int month = DateTime.Now.Month;
            dt = BusThongKe.getTotalMonth(month);
            if(dt.Rows.Count > 0)
                txtDTThang.Text = dt.Rows[0][0].ToString();
            dt = BusThongKe.countMonthSell(month);
            if (dt.Rows.Count > 0)
                txtTSBR.Text = dt.Rows[0][0].ToString();
            dt = BusThongKe.countMonthImp(month);
            if (dt.Rows.Count > 0)
                txtTSNV.Text = dt.Rows[0][0].ToString();

        }
    }
}
