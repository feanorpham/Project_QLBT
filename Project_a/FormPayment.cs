using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using DTO;
using BUS;
using RestSharp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.IO;
using Microsoft.Reporting.WinForms;

namespace Project_a
{
    public partial class FormPayment : Form
    {
        public userName userName = new userName();
        public order order = new order();
        public busMedicSell busMedicSell = new busMedicSell();
        int bin_viettinbank = 970415;
        int bin_vietcombank = 970436;
        string name = "PHAM THE HUNG";
        billOrderPrill billOrderPrill;
        DataTable dt;
        public string total = "";
        public string isTotal = "";
        public FormPayment(userName user, int idOrder)
        {
            InitializeComponent();
            userName = new userName(user.UserName, user.Password, user.STK, user.NganHang,user.NameAcc);
            order.IdOrder = idOrder;
        }
        public void load_QRpay()
        {
            dt = busMedicSell.getBank(userName);
            if(dt.Rows.Count > 0)
            {
                removeString();
                var apiResquest = new ApiResquest();
                apiResquest.acqId = Convert.ToInt32(dt.Rows[0][0].ToString());
                apiResquest.accountNo = long.Parse(userName.STK.ToString());
                apiResquest.accountName = userName.NameAcc;
                apiResquest.amount = Convert.ToInt32(total);
                apiResquest.format = "text";
                apiResquest.template = "compact2";
                var jsonRequest = JsonConvert.SerializeObject(apiResquest);
                var client = new RestClient("https://api.vietqr.io/v2/generate");
                var request = new RestRequest();

                request.Method = Method.Post;
                request.AddHeader("Accept", "application/json");
                request.AddParameter("application/json", jsonRequest, ParameterType.RequestBody);

                var response = client.Execute(request);
                var content = response.Content;
                var dataResult = JsonConvert.DeserializeObject<ApiResponse>(content);
                var image = Base64ToImage(dataResult.data.qrDataURL.Replace("data:image/png;base64,", ""));
                pbQR.Image = image;
            }
        }
        public Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);
            return image;
        }
        private void FormPayment_Load(object sender, EventArgs e)
        {
            using (WebClient client = new WebClient())
            {
                var htmlData = client.DownloadData("https://api.vietqr.io/v2/banks");
                var bankRawJson = Encoding.UTF8.GetString(htmlData);
                var listBankData = JsonConvert.DeserializeObject<bank>(bankRawJson);
            }
            getTotalOrder();
            this.rpViewBill.RefreshReport();
            getBillOrderPrint();
            load_QRpay();
        }
        public void getBillOrderPrint()
        {
            dt = busMedicSell.getBillOrderPrint(order);
            if (dt.Rows.Count > 0) 
            {
                ReportDataSource reportData = new ReportDataSource("billOrderPrill", dt);
                this.rpViewBill.LocalReport.DataSources.Clear();
                this.rpViewBill.LocalReport.DataSources.Add(reportData);
                this.rpViewBill.RefreshReport();
          /*      DateTime date1 = DateTime.Now;
                string datetime = date1.ToString();
                ReportParameter date = new ReportParameter("datePar", datetime, false);
                rpViewBill.LocalReport.SetParameters(date);
          */
                //  MessageBox.Show("" + billOrderPrill.ToString());
            }
        }
        private void getTotalOrder()
        {
            dt = busMedicSell.getTotalOrder(order);
            if (dt.Rows.Count > 0)
            {
                isTotal = dt.Rows[0][0].ToString();
            }
        }
        private string removeString()
        {
            double a = double.Parse(isTotal);
            string b = a.ToString("0.0000");
            string c = b.Replace(".", "");
            if (c.Length > 0)
            {
                string d = c.Substring(0, c.Length - 1);
                total = d.ToString();
            }
            return total;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormMediSell formMediSell = new FormMediSell(userName);
            formMediSell.Show();
            this.Hide();
        }
    }
}
