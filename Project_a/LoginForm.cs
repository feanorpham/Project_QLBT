using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using static System.Net.Mime.MediaTypeNames;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;

namespace Project_a
{
    public partial class LoginForm : Form
    {
        public userName user = new userName();
        public busLogin bus = new busLogin();
        DataTable db = new DataTable();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (checkTextbox(txtbUserName.Text, txtbPassword.Text) == true) { 
                user.UserName = txtbUserName.Text;
                user.Password = txtbPassword.Text;
                db = bus.loginUser(user);
                if (db.Rows.Count > 0)
                {
                    MessageBox.Show("Đăng nhập thành công");
                    user.UserName = db.Rows[0][0].ToString();
                    user.Password = db.Rows[0][1].ToString();
                    user.STK = double.Parse(db.Rows[0][2].ToString());
                    user.NganHang = db.Rows[0][3].ToString();
                    user.NameAcc = db.Rows[0][4].ToString();
                    MainForm mainForm = new MainForm(user);
                    mainForm.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Đăng nhập thất bại");
            }       
        }

        private bool checkTextbox(string a, string b)
        {
            return (a != null || b != null) ? true : false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labDate.Text = DateTime.Now.ToString();
        }
    }
}
