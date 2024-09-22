namespace Project_a
{
    partial class FormPayment
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pbQR = new System.Windows.Forms.PictureBox();
            this.rpViewBill = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            // 
            // pbQR
            // 
            this.pbQR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbQR.Location = new System.Drawing.Point(541, 7);
            this.pbQR.Name = "pbQR";
            this.pbQR.Size = new System.Drawing.Size(532, 676);
            this.pbQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbQR.TabIndex = 5;
            this.pbQR.TabStop = false;
            // 
            // rpViewBill
            // 
            this.rpViewBill.LocalReport.ReportEmbeddedResource = "Project_a.billPrint.rdlc";
            this.rpViewBill.Location = new System.Drawing.Point(12, 5);
            this.rpViewBill.Name = "rpViewBill";
            this.rpViewBill.ServerReport.BearerToken = null;
            this.rpViewBill.Size = new System.Drawing.Size(523, 678);
            this.rpViewBill.TabIndex = 7;
            // 
            // FormPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 688);
            this.Controls.Add(this.rpViewBill);
            this.Controls.Add(this.pbQR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPayment";
            this.Load += new System.EventHandler(this.FormPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbQR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.PictureBox pbQR;
        private Microsoft.Reporting.WinForms.ReportViewer rpViewBill;
    }
}