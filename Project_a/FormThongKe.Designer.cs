namespace Project_a
{
    partial class FormThongKe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.totalDay = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.char3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtTSNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtTSBR = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtDTThang = new Guna.UI2.WinForms.Guna2TextBox();
            this.labHello = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labDate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.totalDay)).BeginInit();
            this.guna2GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.char3)).BeginInit();
            this.guna2GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(107)))), ((int)(((byte)(250)))));
            this.guna2Panel1.Location = new System.Drawing.Point(1, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(67, 849);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.totalDay);
            this.guna2GroupBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(74, 12);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(740, 448);
            this.guna2GroupBox1.TabIndex = 1;
            this.guna2GroupBox1.Text = "Số lượng thuốc bán ra";
            // 
            // totalDay
            // 
            chartArea1.Name = "ChartArea1";
            this.totalDay.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.totalDay.Legends.Add(legend1);
            this.totalDay.Location = new System.Drawing.Point(7, 44);
            this.totalDay.Name = "totalDay";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.totalDay.Series.Add(series1);
            this.totalDay.Size = new System.Drawing.Size(725, 401);
            this.totalDay.TabIndex = 0;
            this.totalDay.Text = "chart1";
            // 
            // guna2GroupBox3
            // 
            this.guna2GroupBox3.Controls.Add(this.char3);
            this.guna2GroupBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox3.Location = new System.Drawing.Point(74, 466);
            this.guna2GroupBox3.Name = "guna2GroupBox3";
            this.guna2GroupBox3.Size = new System.Drawing.Size(740, 385);
            this.guna2GroupBox3.TabIndex = 3;
            this.guna2GroupBox3.Text = "Số lượng thuốc nhập vào";
            // 
            // char3
            // 
            chartArea2.Name = "ChartArea1";
            this.char3.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.char3.Legends.Add(legend2);
            this.char3.Location = new System.Drawing.Point(4, 44);
            this.char3.Name = "char3";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.YValuesPerPoint = 2;
            this.char3.Series.Add(series2);
            this.char3.Size = new System.Drawing.Size(728, 338);
            this.char3.TabIndex = 0;
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.Controls.Add(this.guna2HtmlLabel3);
            this.guna2GroupBox2.Controls.Add(this.txtTSNV);
            this.guna2GroupBox2.Controls.Add(this.guna2HtmlLabel2);
            this.guna2GroupBox2.Controls.Add(this.txtTSBR);
            this.guna2GroupBox2.Controls.Add(this.guna2HtmlLabel1);
            this.guna2GroupBox2.Controls.Add(this.txtDTThang);
            this.guna2GroupBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox2.Location = new System.Drawing.Point(820, 12);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(514, 221);
            this.guna2GroupBox2.TabIndex = 4;
            this.guna2GroupBox2.Text = "Thống kê tháng";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(26, 170);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(132, 15);
            this.guna2HtmlLabel3.TabIndex = 5;
            this.guna2HtmlLabel3.Text = "Tổng số thuốc nhập tháng:";
            // 
            // txtTSNV
            // 
            this.txtTSNV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(193)))), ((int)(((byte)(251)))));
            this.txtTSNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTSNV.DefaultText = "";
            this.txtTSNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTSNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTSNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTSNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTSNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTSNV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTSNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTSNV.Location = new System.Drawing.Point(285, 164);
            this.txtTSNV.Name = "txtTSNV";
            this.txtTSNV.PasswordChar = '\0';
            this.txtTSNV.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(193)))), ((int)(((byte)(251)))));
            this.txtTSNV.PlaceholderText = "";
            this.txtTSNV.SelectedText = "";
            this.txtTSNV.Size = new System.Drawing.Size(220, 36);
            this.txtTSNV.TabIndex = 4;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(26, 128);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(165, 15);
            this.guna2HtmlLabel2.TabIndex = 3;
            this.guna2HtmlLabel2.Text = "Tổng số thuốc bán ra trong tháng:";
            // 
            // txtTSBR
            // 
            this.txtTSBR.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(193)))), ((int)(((byte)(251)))));
            this.txtTSBR.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTSBR.DefaultText = "";
            this.txtTSBR.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTSBR.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTSBR.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTSBR.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTSBR.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTSBR.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTSBR.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTSBR.Location = new System.Drawing.Point(285, 122);
            this.txtTSBR.Name = "txtTSBR";
            this.txtTSBR.PasswordChar = '\0';
            this.txtTSBR.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(193)))), ((int)(((byte)(251)))));
            this.txtTSBR.PlaceholderText = "";
            this.txtTSBR.SelectedText = "";
            this.txtTSBR.Size = new System.Drawing.Size(220, 36);
            this.txtTSBR.TabIndex = 2;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(26, 80);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(86, 15);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "Doanh thu tháng:";
            // 
            // txtDTThang
            // 
            this.txtDTThang.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(193)))), ((int)(((byte)(251)))));
            this.txtDTThang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDTThang.DefaultText = "";
            this.txtDTThang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDTThang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDTThang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDTThang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDTThang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDTThang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDTThang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDTThang.Location = new System.Drawing.Point(285, 80);
            this.txtDTThang.Name = "txtDTThang";
            this.txtDTThang.PasswordChar = '\0';
            this.txtDTThang.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(193)))), ((int)(((byte)(251)))));
            this.txtDTThang.PlaceholderText = "";
            this.txtDTThang.SelectedText = "";
            this.txtDTThang.Size = new System.Drawing.Size(220, 36);
            this.txtDTThang.TabIndex = 0;
            // 
            // labHello
            // 
            this.labHello.BackColor = System.Drawing.Color.Transparent;
            this.labHello.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labHello.Location = new System.Drawing.Point(832, 252);
            this.labHello.Name = "labHello";
            this.labHello.Size = new System.Drawing.Size(172, 23);
            this.labHello.TabIndex = 6;
            this.labHello.Text = "Xin chào dược sĩ hùng !";
            // 
            // labDate
            // 
            this.labDate.BackColor = System.Drawing.Color.Transparent;
            this.labDate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDate.Location = new System.Drawing.Point(832, 281);
            this.labDate.Name = "labDate";
            this.labDate.Size = new System.Drawing.Size(208, 23);
            this.labDate.TabIndex = 7;
            this.labDate.Text = "Ngày 17, Tháng 7, Năm 2024";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 863);
            this.Controls.Add(this.labDate);
            this.Controls.Add(this.labHello);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.guna2GroupBox3);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống Kê";
            this.Load += new System.EventHandler(this.FormThongKe_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.totalDay)).EndInit();
            this.guna2GroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.char3)).EndInit();
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart totalDay;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox3;
        private System.Windows.Forms.DataVisualization.Charting.Chart char3;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtDTThang;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox txtTSNV;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox txtTSBR;
        private Guna.UI2.WinForms.Guna2HtmlLabel labHello;
        private Guna.UI2.WinForms.Guna2HtmlLabel labDate;
        private System.Windows.Forms.Timer timer1;
    }
}