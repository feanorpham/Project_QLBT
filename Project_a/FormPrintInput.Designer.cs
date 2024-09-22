namespace Project_a
{
    partial class FormPrintInput
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.inpBillPrintBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inpBillPrint = new Project_a.inpBillPrint();
            this.getInputBillBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBTDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnPrint = new Guna.UI2.WinForms.Guna2Button();
            this.cmbPhieuNhap = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rpv = new Microsoft.Reporting.WinForms.ReportViewer();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.inpBillPrintBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inpBillPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getInputBillBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBTDataSetBindingSource)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inpBillPrintBindingSource
            // 
            this.inpBillPrintBindingSource.DataSource = this.inpBillPrint;
            this.inpBillPrintBindingSource.Position = 0;
            // 
            // inpBillPrint
            // 
            this.inpBillPrint.DataSetName = "inpBillPrint";
            this.inpBillPrint.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getInputBillBindingSource
            // 
            this.getInputBillBindingSource.DataSource = this.qLBTDataSetBindingSource;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.guna2GroupBox1.Controls.Add(this.btnPrint);
            this.guna2GroupBox1.Controls.Add(this.cmbPhieuNhap);
            this.guna2GroupBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(13, 13);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(783, 107);
            this.guna2GroupBox1.TabIndex = 1;
            this.guna2GroupBox1.Text = "In phiếu nhập";
            // 
            // btnPrint
            // 
            this.btnPrint.Animated = true;
            this.btnPrint.CustomImages.CheckedImage = global::Project_a.Properties.Resources.icons8_print_50;
            this.btnPrint.CustomImages.HoveredImage = global::Project_a.Properties.Resources.icons8_print_50;
            this.btnPrint.CustomImages.Image = global::Project_a.Properties.Resources.icons8_print_50;
            this.btnPrint.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPrint.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrint.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrint.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrint.FillColor = System.Drawing.Color.DarkGray;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.Black;
            this.btnPrint.Location = new System.Drawing.Point(245, 55);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(85, 35);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // cmbPhieuNhap
            // 
            this.cmbPhieuNhap.FormattingEnabled = true;
            this.cmbPhieuNhap.Location = new System.Drawing.Point(7, 60);
            this.cmbPhieuNhap.Name = "cmbPhieuNhap";
            this.cmbPhieuNhap.Size = new System.Drawing.Size(232, 28);
            this.cmbPhieuNhap.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rpv);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(783, 779);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phiếu nhập";
            // 
            // rpv
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.inpBillPrintBindingSource;
            this.rpv.LocalReport.DataSources.Add(reportDataSource1);
            this.rpv.LocalReport.ReportEmbeddedResource = "Project_a.inputPrint.rdlc";
            this.rpv.Location = new System.Drawing.Point(7, 20);
            this.rpv.Name = "rpv";
            this.rpv.ServerReport.BearerToken = null;
            this.rpv.Size = new System.Drawing.Size(765, 753);
            this.rpv.TabIndex = 0;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // FormPrintInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 917);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.guna2GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormPrintInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrintInput";
            this.Load += new System.EventHandler(this.FormPrintInput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inpBillPrintBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inpBillPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getInputBillBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBTDataSetBindingSource)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Microsoft.Reporting.WinForms.ReportViewer rpv;
        private System.Windows.Forms.ComboBox cmbPhieuNhap;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.BindingSource qLBTDataSetBindingSource;
        private System.Windows.Forms.BindingSource getInputBillBindingSource;
        private Guna.UI2.WinForms.Guna2Button btnPrint;
        private System.Windows.Forms.BindingSource inpBillPrintBindingSource;
        private inpBillPrint inpBillPrint;
    }
}