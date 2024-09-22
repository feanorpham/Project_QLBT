namespace Project_a
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sidebar = new Guna.UI2.WinForms.Guna2Panel();
            this.btnTK = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
            this.btnSettings = new Guna.UI2.WinForms.Guna2Button();
            this.btnQLKH = new Guna.UI2.WinForms.Guna2Button();
            this.btnQLDH = new Guna.UI2.WinForms.Guna2Button();
            this.btnQLT = new Guna.UI2.WinForms.Guna2Button();
            this.btnDB = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lbHello = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbDate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvSearch = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameMedic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.impPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isReatil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mfgD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lesUse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeSpl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtbSreach = new Guna.UI2.WinForms.Guna2TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sidebar.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(107)))), ((int)(((byte)(250)))));
            this.sidebar.Controls.Add(this.btnTK);
            this.sidebar.Controls.Add(this.guna2Button6);
            this.sidebar.Controls.Add(this.btnSettings);
            this.sidebar.Controls.Add(this.btnQLKH);
            this.sidebar.Controls.Add(this.btnQLDH);
            this.sidebar.Controls.Add(this.btnQLT);
            this.sidebar.Controls.Add(this.btnDB);
            this.sidebar.Location = new System.Drawing.Point(-7, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(86, 708);
            this.sidebar.TabIndex = 0;
            // 
            // btnTK
            // 
            this.btnTK.Animated = true;
            this.btnTK.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnTK.CustomBorderThickness = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnTK.CustomImages.CheckedImage = global::Project_a.Properties.Resources.icons8_graph_report_script_48;
            this.btnTK.CustomImages.HoveredImage = global::Project_a.Properties.Resources.icons8_graph_report_script_48;
            this.btnTK.CustomImages.Image = global::Project_a.Properties.Resources.icons8_graph_report_script_48;
            this.btnTK.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnTK.CustomImages.ImageOffset = new System.Drawing.Point(0, -2);
            this.btnTK.CustomImages.ImageSize = new System.Drawing.Size(24, 24);
            this.btnTK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(107)))), ((int)(((byte)(250)))));
            this.btnTK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTK.ForeColor = System.Drawing.Color.White;
            this.btnTK.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnTK.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btnTK.Location = new System.Drawing.Point(2, 346);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(83, 40);
            this.btnTK.TabIndex = 7;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // guna2Button6
            // 
            this.guna2Button6.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2Button6.CustomBorderThickness = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.guna2Button6.CustomImages.CheckedImage = global::Project_a.Properties.Resources.icons8_pharmacy_shop_64;
            this.guna2Button6.CustomImages.HoveredImage = global::Project_a.Properties.Resources.icons8_pharmacy_shop_64;
            this.guna2Button6.CustomImages.Image = global::Project_a.Properties.Resources.icons8_pharmacy_shop_64;
            this.guna2Button6.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2Button6.CustomImages.ImageOffset = new System.Drawing.Point(0, -2);
            this.guna2Button6.CustomImages.ImageSize = new System.Drawing.Size(24, 24);
            this.guna2Button6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(107)))), ((int)(((byte)(250)))));
            this.guna2Button6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button6.ForeColor = System.Drawing.Color.White;
            this.guna2Button6.HoverState.BorderColor = System.Drawing.Color.White;
            this.guna2Button6.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.guna2Button6.Location = new System.Drawing.Point(0, 12);
            this.guna2Button6.Name = "guna2Button6";
            this.guna2Button6.Size = new System.Drawing.Size(83, 40);
            this.guna2Button6.TabIndex = 6;
            // 
            // btnSettings
            // 
            this.btnSettings.Animated = true;
            this.btnSettings.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnSettings.CustomBorderThickness = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnSettings.CustomImages.CheckedImage = global::Project_a.Properties.Resources.icons8_setting_32;
            this.btnSettings.CustomImages.HoveredImage = global::Project_a.Properties.Resources.icons8_setting_32;
            this.btnSettings.CustomImages.Image = global::Project_a.Properties.Resources.icons8_setting_32;
            this.btnSettings.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSettings.CustomImages.ImageOffset = new System.Drawing.Point(0, -2);
            this.btnSettings.CustomImages.ImageSize = new System.Drawing.Size(24, 24);
            this.btnSettings.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSettings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSettings.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSettings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSettings.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(107)))), ((int)(((byte)(250)))));
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnSettings.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btnSettings.Location = new System.Drawing.Point(3, 656);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(83, 40);
            this.btnSettings.TabIndex = 5;
            // 
            // btnQLKH
            // 
            this.btnQLKH.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnQLKH.CustomBorderThickness = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnQLKH.CustomImages.CheckedImage = global::Project_a.Properties.Resources.icons8_warehouse_64;
            this.btnQLKH.CustomImages.HoveredImage = global::Project_a.Properties.Resources.icons8_warehouse_64;
            this.btnQLKH.CustomImages.Image = global::Project_a.Properties.Resources.icons8_warehouse_64;
            this.btnQLKH.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnQLKH.CustomImages.ImageOffset = new System.Drawing.Point(0, -2);
            this.btnQLKH.CustomImages.ImageSize = new System.Drawing.Size(24, 24);
            this.btnQLKH.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQLKH.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQLKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQLKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQLKH.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(107)))), ((int)(((byte)(250)))));
            this.btnQLKH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnQLKH.ForeColor = System.Drawing.Color.White;
            this.btnQLKH.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnQLKH.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btnQLKH.Location = new System.Drawing.Point(3, 298);
            this.btnQLKH.Name = "btnQLKH";
            this.btnQLKH.Size = new System.Drawing.Size(83, 40);
            this.btnQLKH.TabIndex = 4;
            this.btnQLKH.Click += new System.EventHandler(this.btnQLKH_Click);
            // 
            // btnQLDH
            // 
            this.btnQLDH.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnQLDH.CustomBorderThickness = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnQLDH.CustomImages.CheckedImage = global::Project_a.Properties.Resources.icons8_fast_cart_32;
            this.btnQLDH.CustomImages.HoveredImage = global::Project_a.Properties.Resources.icons8_fast_cart_32;
            this.btnQLDH.CustomImages.Image = global::Project_a.Properties.Resources.icons8_fast_cart_32;
            this.btnQLDH.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnQLDH.CustomImages.ImageOffset = new System.Drawing.Point(0, -2);
            this.btnQLDH.CustomImages.ImageSize = new System.Drawing.Size(24, 24);
            this.btnQLDH.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQLDH.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQLDH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQLDH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQLDH.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(107)))), ((int)(((byte)(250)))));
            this.btnQLDH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnQLDH.ForeColor = System.Drawing.Color.White;
            this.btnQLDH.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnQLDH.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btnQLDH.Location = new System.Drawing.Point(3, 253);
            this.btnQLDH.Name = "btnQLDH";
            this.btnQLDH.Size = new System.Drawing.Size(83, 40);
            this.btnQLDH.TabIndex = 3;
            this.btnQLDH.Click += new System.EventHandler(this.btnQLDH_Click);
            // 
            // btnQLT
            // 
            this.btnQLT.Animated = true;
            this.btnQLT.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnQLT.CustomBorderThickness = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnQLT.CustomImages.CheckedImage = global::Project_a.Properties.Resources.icons8_pill_26;
            this.btnQLT.CustomImages.HoveredImage = global::Project_a.Properties.Resources.icons8_pill_26;
            this.btnQLT.CustomImages.Image = global::Project_a.Properties.Resources.icons8_pill_26;
            this.btnQLT.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnQLT.CustomImages.ImageOffset = new System.Drawing.Point(0, -2);
            this.btnQLT.CustomImages.ImageSize = new System.Drawing.Size(24, 24);
            this.btnQLT.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQLT.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQLT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQLT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQLT.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(107)))), ((int)(((byte)(250)))));
            this.btnQLT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnQLT.ForeColor = System.Drawing.Color.White;
            this.btnQLT.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnQLT.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btnQLT.Location = new System.Drawing.Point(3, 208);
            this.btnQLT.Name = "btnQLT";
            this.btnQLT.Size = new System.Drawing.Size(83, 40);
            this.btnQLT.TabIndex = 2;
            this.btnQLT.Click += new System.EventHandler(this.btnQLT_Click);
            // 
            // btnDB
            // 
            this.btnDB.Animated = true;
            this.btnDB.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnDB.CustomBorderThickness = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnDB.CustomImages.CheckedImage = global::Project_a.Properties.Resources.icons8_dashboard_32;
            this.btnDB.CustomImages.HoveredImage = global::Project_a.Properties.Resources.icons8_dashboard_32;
            this.btnDB.CustomImages.Image = global::Project_a.Properties.Resources.icons8_dashboard_32;
            this.btnDB.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDB.CustomImages.ImageOffset = new System.Drawing.Point(0, -2);
            this.btnDB.CustomImages.ImageSize = new System.Drawing.Size(24, 24);
            this.btnDB.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(107)))), ((int)(((byte)(250)))));
            this.btnDB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDB.ForeColor = System.Drawing.Color.White;
            this.btnDB.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnDB.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btnDB.Location = new System.Drawing.Point(3, 162);
            this.btnDB.Name = "btnDB";
            this.btnDB.Size = new System.Drawing.Size(83, 40);
            this.btnDB.TabIndex = 1;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this.sidebar;
            // 
            // lbHello
            // 
            this.lbHello.BackColor = System.Drawing.Color.Transparent;
            this.lbHello.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHello.Location = new System.Drawing.Point(89, 12);
            this.lbHello.Name = "lbHello";
            this.lbHello.Size = new System.Drawing.Size(216, 27);
            this.lbHello.TabIndex = 2;
            this.lbHello.Text = "Xin chào, Dược sĩ Hùng!!";
            // 
            // lbDate
            // 
            this.lbDate.BackColor = System.Drawing.Color.Transparent;
            this.lbDate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(89, 45);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(170, 23);
            this.lbDate.TabIndex = 5;
            this.lbDate.Text = "Ngày 19, Tháng 7, 2024";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvSearch);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(89, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1077, 602);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách tìm kiếm";
            // 
            // dgvSearch
            // 
            this.dgvSearch.AllowUserToAddRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dgvSearch.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSearch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvSearch.ColumnHeadersHeight = 44;
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.nameMedic,
            this.impPrice,
            this.price,
            this.isReatil,
            this.mfgD,
            this.expD,
            this.lesUse,
            this.codeSpl});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSearch.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvSearch.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSearch.Location = new System.Drawing.Point(7, 29);
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.RowHeadersVisible = false;
            this.dgvSearch.Size = new System.Drawing.Size(1064, 558);
            this.dgvSearch.TabIndex = 0;
            this.dgvSearch.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSearch.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvSearch.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvSearch.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvSearch.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvSearch.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvSearch.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSearch.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvSearch.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSearch.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSearch.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvSearch.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvSearch.ThemeStyle.HeaderStyle.Height = 44;
            this.dgvSearch.ThemeStyle.ReadOnly = false;
            this.dgvSearch.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSearch.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSearch.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSearch.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvSearch.ThemeStyle.RowsStyle.Height = 22;
            this.dgvSearch.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSearch.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.DataPropertyName = "barcode";
            this.Column1.HeaderText = "barcode";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 94;
            // 
            // nameMedic
            // 
            this.nameMedic.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameMedic.DataPropertyName = "nameMedic";
            this.nameMedic.HeaderText = "Tên thuốc";
            this.nameMedic.Name = "nameMedic";
            this.nameMedic.ReadOnly = true;
            // 
            // impPrice
            // 
            this.impPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.impPrice.DataPropertyName = "impPrice";
            this.impPrice.HeaderText = "Giá nhập";
            this.impPrice.Name = "impPrice";
            this.impPrice.ReadOnly = true;
            this.impPrice.Width = 88;
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "Giá bán";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 80;
            // 
            // isReatil
            // 
            this.isReatil.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.isReatil.DataPropertyName = "isReatil";
            this.isReatil.HeaderText = "Bán lẻ";
            this.isReatil.Name = "isReatil";
            this.isReatil.ReadOnly = true;
            this.isReatil.Width = 71;
            // 
            // mfgD
            // 
            this.mfgD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.mfgD.DataPropertyName = "mfgD";
            this.mfgD.HeaderText = "Ngày sản xuất";
            this.mfgD.Name = "mfgD";
            this.mfgD.ReadOnly = true;
            this.mfgD.Width = 95;
            // 
            // expD
            // 
            this.expD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.expD.DataPropertyName = "expD";
            this.expD.HeaderText = "Ngày hết hạn";
            this.expD.Name = "expD";
            this.expD.ReadOnly = true;
            this.expD.Width = 95;
            // 
            // lesUse
            // 
            this.lesUse.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lesUse.DataPropertyName = "lesUse";
            this.lesUse.HeaderText = "Công dụng";
            this.lesUse.Name = "lesUse";
            this.lesUse.ReadOnly = true;
            // 
            // codeSpl
            // 
            this.codeSpl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.codeSpl.DataPropertyName = "codeSpl";
            this.codeSpl.HeaderText = "Mã nhà cung cấp";
            this.codeSpl.Name = "codeSpl";
            this.codeSpl.ReadOnly = true;
            this.codeSpl.Width = 119;
            // 
            // txtbSreach
            // 
            this.txtbSreach.Animated = true;
            this.txtbSreach.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(193)))), ((int)(((byte)(251)))));
            this.txtbSreach.BorderRadius = 5;
            this.txtbSreach.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbSreach.DefaultText = "";
            this.txtbSreach.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbSreach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbSreach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbSreach.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbSreach.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbSreach.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtbSreach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(188)))), ((int)(((byte)(206)))));
            this.txtbSreach.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbSreach.IconRight = global::Project_a.Properties.Resources.icons8_search_96;
            this.txtbSreach.IconRightOffset = new System.Drawing.Point(8, 0);
            this.txtbSreach.IconRightSize = new System.Drawing.Size(18, 16);
            this.txtbSreach.Location = new System.Drawing.Point(784, 31);
            this.txtbSreach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbSreach.Name = "txtbSreach";
            this.txtbSreach.PasswordChar = '\0';
            this.txtbSreach.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(193)))), ((int)(((byte)(251)))));
            this.txtbSreach.PlaceholderText = "Tìm Kiếm Thuốc";
            this.txtbSreach.SelectedText = "";
            this.txtbSreach.Size = new System.Drawing.Size(382, 44);
            this.txtbSreach.TabIndex = 1;
            this.txtbSreach.TextOffset = new System.Drawing.Point(16, 0);
            this.txtbSreach.TextChanged += new System.EventHandler(this.txtbSreach_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 698);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbHello);
            this.Controls.Add(this.txtbSreach);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.sidebar.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel sidebar;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btnDB;
        private Guna.UI2.WinForms.Guna2Button btnQLKH;
        private Guna.UI2.WinForms.Guna2Button btnQLDH;
        private Guna.UI2.WinForms.Guna2Button btnQLT;
        private Guna.UI2.WinForms.Guna2Button guna2Button6;
        private Guna.UI2.WinForms.Guna2Button btnSettings;
        private Guna.UI2.WinForms.Guna2Button btnTK;
        private Guna.UI2.WinForms.Guna2TextBox txtbSreach;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbHello;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameMedic;
        private System.Windows.Forms.DataGridViewTextBoxColumn impPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn isReatil;
        private System.Windows.Forms.DataGridViewTextBoxColumn mfgD;
        private System.Windows.Forms.DataGridViewTextBoxColumn expD;
        private System.Windows.Forms.DataGridViewTextBoxColumn lesUse;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeSpl;
    }
}