namespace App.UI_Forms.Admin
{
    partial class Admin_Main_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Main_Home));
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.reportpnl = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnAdminInfo = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.Salepnl = new System.Windows.Forms.Panel();
            this.btnsales = new System.Windows.Forms.Button();
            this.btnMonthlySales = new System.Windows.Forms.Button();
            this.btnDailySales = new System.Windows.Forms.Button();
            this.Productpnl = new System.Windows.Forms.Panel();
            this.btnManageProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.pnlEmployee = new System.Windows.Forms.Panel();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnManageEmployee = new System.Windows.Forms.Button();
            this.ReportTimer = new System.Windows.Forms.Timer(this.components);
            this.EmployeeTimer = new System.Windows.Forms.Timer(this.components);
            this.ProductTimer = new System.Windows.Forms.Timer(this.components);
            this.SalesTimer = new System.Windows.Forms.Timer(this.components);
            this.SideContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.idlb = new System.Windows.Forms.Label();
            this.userlb = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnContainer = new System.Windows.Forms.Timer(this.components);
            this.FeatureHolder = new System.Windows.Forms.Panel();
            this.featurePanel = new System.Windows.Forms.Panel();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.addProduct1 = new App.UI_Forms.Admin.Features.addProduct();
            this.employeesSearch = new App.UI_Forms.Admin.Employees();
            this.product1 = new App.UI_Forms.Admin.Product();
            this.addEmployee1 = new App.UI_Forms.Admin.Features.addEmployee();
            this.home1 = new App.UI_Forms.Manager.Home();
            this.panelTop.SuspendLayout();
            this.reportpnl.SuspendLayout();
            this.Salepnl.SuspendLayout();
            this.Productpnl.SuspendLayout();
            this.pnlEmployee.SuspendLayout();
            this.SideContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.FeatureHolder.SuspendLayout();
            this.featurePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelTop.Controls.Add(this.btnMenu);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1200, 75);
            this.panelTop.TabIndex = 0;
            this.panelTop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTop_Paint);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMenu.BackgroundImage")));
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Location = new System.Drawing.Point(22, 12);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(63, 54);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amin_Home";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // reportpnl
            // 
            this.reportpnl.Controls.Add(this.btnSetting);
            this.reportpnl.Controls.Add(this.btnAdminInfo);
            this.reportpnl.Controls.Add(this.btnLogOut);
            this.reportpnl.Location = new System.Drawing.Point(2, 438);
            this.reportpnl.Margin = new System.Windows.Forms.Padding(2);
            this.reportpnl.Name = "reportpnl";
            this.reportpnl.Size = new System.Drawing.Size(262, 82);
            this.reportpnl.TabIndex = 2;
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.White;
            this.btnSetting.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnSetting.Image")));
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(0, 0);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(0);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnSetting.Size = new System.Drawing.Size(260, 80);
            this.btnSetting.TabIndex = 9;
            this.btnSetting.Text = "Settings";
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnAdminInfo
            // 
            this.btnAdminInfo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdminInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnAdminInfo.Image")));
            this.btnAdminInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminInfo.Location = new System.Drawing.Point(0, 80);
            this.btnAdminInfo.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdminInfo.Name = "btnAdminInfo";
            this.btnAdminInfo.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnAdminInfo.Size = new System.Drawing.Size(260, 80);
            this.btnAdminInfo.TabIndex = 8;
            this.btnAdminInfo.Text = "About";
            this.btnAdminInfo.UseVisualStyleBackColor = false;
            this.btnAdminInfo.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(0, 160);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnLogOut.Size = new System.Drawing.Size(260, 80);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.button8_Click);
            // 
            // Salepnl
            // 
            this.Salepnl.Controls.Add(this.btnsales);
            this.Salepnl.Controls.Add(this.btnMonthlySales);
            this.Salepnl.Controls.Add(this.btnDailySales);
            this.Salepnl.Location = new System.Drawing.Point(2, 351);
            this.Salepnl.Margin = new System.Windows.Forms.Padding(2);
            this.Salepnl.Name = "Salepnl";
            this.Salepnl.Size = new System.Drawing.Size(262, 83);
            this.Salepnl.TabIndex = 12;
            // 
            // btnsales
            // 
            this.btnsales.BackColor = System.Drawing.Color.White;
            this.btnsales.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsales.Image = ((System.Drawing.Image)(resources.GetObject("btnsales.Image")));
            this.btnsales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsales.Location = new System.Drawing.Point(0, 0);
            this.btnsales.Margin = new System.Windows.Forms.Padding(2);
            this.btnsales.Name = "btnsales";
            this.btnsales.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnsales.Size = new System.Drawing.Size(260, 82);
            this.btnsales.TabIndex = 7;
            this.btnsales.Text = "Report";
            this.btnsales.UseVisualStyleBackColor = false;
            this.btnsales.Click += new System.EventHandler(this.btnsales_Click);
            // 
            // btnMonthlySales
            // 
            this.btnMonthlySales.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMonthlySales.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonthlySales.Image = ((System.Drawing.Image)(resources.GetObject("btnMonthlySales.Image")));
            this.btnMonthlySales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMonthlySales.Location = new System.Drawing.Point(0, 151);
            this.btnMonthlySales.Margin = new System.Windows.Forms.Padding(0);
            this.btnMonthlySales.Name = "btnMonthlySales";
            this.btnMonthlySales.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnMonthlySales.Size = new System.Drawing.Size(260, 80);
            this.btnMonthlySales.TabIndex = 9;
            this.btnMonthlySales.Text = "      Monthly Sales";
            this.btnMonthlySales.UseVisualStyleBackColor = false;
            // 
            // btnDailySales
            // 
            this.btnDailySales.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDailySales.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDailySales.Image = ((System.Drawing.Image)(resources.GetObject("btnDailySales.Image")));
            this.btnDailySales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDailySales.Location = new System.Drawing.Point(0, 75);
            this.btnDailySales.Margin = new System.Windows.Forms.Padding(0);
            this.btnDailySales.Name = "btnDailySales";
            this.btnDailySales.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnDailySales.Size = new System.Drawing.Size(260, 80);
            this.btnDailySales.TabIndex = 8;
            this.btnDailySales.Text = "  Daily Sales";
            this.btnDailySales.UseVisualStyleBackColor = false;
            // 
            // Productpnl
            // 
            this.Productpnl.Controls.Add(this.btnManageProduct);
            this.Productpnl.Controls.Add(this.btnAddProduct);
            this.Productpnl.Controls.Add(this.btnProduct);
            this.Productpnl.Location = new System.Drawing.Point(2, 267);
            this.Productpnl.Margin = new System.Windows.Forms.Padding(2);
            this.Productpnl.Name = "Productpnl";
            this.Productpnl.Size = new System.Drawing.Size(262, 80);
            this.Productpnl.TabIndex = 7;
            // 
            // btnManageProduct
            // 
            this.btnManageProduct.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnManageProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnManageProduct.Image")));
            this.btnManageProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageProduct.Location = new System.Drawing.Point(0, 158);
            this.btnManageProduct.Margin = new System.Windows.Forms.Padding(0);
            this.btnManageProduct.Name = "btnManageProduct";
            this.btnManageProduct.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnManageProduct.Size = new System.Drawing.Size(262, 80);
            this.btnManageProduct.TabIndex = 8;
            this.btnManageProduct.Text = "   Manage";
            this.btnManageProduct.UseVisualStyleBackColor = false;
            this.btnManageProduct.Click += new System.EventHandler(this.btnManageProduct_Click_1);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProduct.Image")));
            this.btnAddProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProduct.Location = new System.Drawing.Point(0, 82);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnAddProduct.Size = new System.Drawing.Size(262, 80);
            this.btnAddProduct.TabIndex = 7;
            this.btnAddProduct.Text = " Add";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click_1);
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.White;
            this.btnProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnProduct.Image")));
            this.btnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.Location = new System.Drawing.Point(0, 2);
            this.btnProduct.Margin = new System.Windows.Forms.Padding(0);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnProduct.Size = new System.Drawing.Size(262, 80);
            this.btnProduct.TabIndex = 6;
            this.btnProduct.Text = "Products";
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // pnlEmployee
            // 
            this.pnlEmployee.Controls.Add(this.btnEmployee);
            this.pnlEmployee.Controls.Add(this.btnAddEmployee);
            this.pnlEmployee.Controls.Add(this.btnManageEmployee);
            this.pnlEmployee.Location = new System.Drawing.Point(2, 181);
            this.pnlEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.pnlEmployee.Name = "pnlEmployee";
            this.pnlEmployee.Size = new System.Drawing.Size(262, 82);
            this.pnlEmployee.TabIndex = 11;
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.White;
            this.btnEmployee.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployee.Image")));
            this.btnEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.Location = new System.Drawing.Point(2, 0);
            this.btnEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnEmployee.Size = new System.Drawing.Size(260, 80);
            this.btnEmployee.TabIndex = 5;
            this.btnEmployee.Text = "    Employees";
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddEmployee.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmployee.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnAddEmployee.Image")));
            this.btnAddEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddEmployee.Location = new System.Drawing.Point(2, 78);
            this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnAddEmployee.Size = new System.Drawing.Size(260, 80);
            this.btnAddEmployee.TabIndex = 5;
            this.btnAddEmployee.Text = "Add";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnManageEmployee
            // 
            this.btnManageEmployee.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnManageEmployee.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnManageEmployee.Image")));
            this.btnManageEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageEmployee.Location = new System.Drawing.Point(0, 158);
            this.btnManageEmployee.Margin = new System.Windows.Forms.Padding(0);
            this.btnManageEmployee.Name = "btnManageEmployee";
            this.btnManageEmployee.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnManageEmployee.Size = new System.Drawing.Size(262, 80);
            this.btnManageEmployee.TabIndex = 6;
            this.btnManageEmployee.Text = "   Manage";
            this.btnManageEmployee.UseVisualStyleBackColor = false;
            this.btnManageEmployee.Click += new System.EventHandler(this.btnManageEmployee_Click_1);
            // 
            // ReportTimer
            // 
            this.ReportTimer.Interval = 10;
            this.ReportTimer.Tick += new System.EventHandler(this.ReportTimer_Tick);
            // 
            // EmployeeTimer
            // 
            this.EmployeeTimer.Interval = 10;
            this.EmployeeTimer.Tick += new System.EventHandler(this.EmployeeTimer_Tick);
            // 
            // ProductTimer
            // 
            this.ProductTimer.Interval = 10;
            this.ProductTimer.Tick += new System.EventHandler(this.ProductTimer_Tick);
            // 
            // SalesTimer
            // 
            this.SalesTimer.Interval = 10;
            this.SalesTimer.Tick += new System.EventHandler(this.SalesTimer_Tick);
            // 
            // SideContainer
            // 
            this.SideContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            this.SideContainer.Controls.Add(this.panel1);
            this.SideContainer.Controls.Add(this.pnlEmployee);
            this.SideContainer.Controls.Add(this.Productpnl);
            this.SideContainer.Controls.Add(this.Salepnl);
            this.SideContainer.Controls.Add(this.reportpnl);
            this.SideContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideContainer.Location = new System.Drawing.Point(0, 75);
            this.SideContainer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SideContainer.Name = "SideContainer";
            this.SideContainer.Size = new System.Drawing.Size(270, 725);
            this.SideContainer.TabIndex = 3;
            this.SideContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.SideContainer_Paint_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.idlb);
            this.panel1.Controls.Add(this.userlb);
            this.panel1.Controls.Add(this.guna2CirclePictureBox1);
            this.panel1.Location = new System.Drawing.Point(4, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 169);
            this.panel1.TabIndex = 13;
            // 
            // idlb
            // 
            this.idlb.AutoSize = true;
            this.idlb.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idlb.Location = new System.Drawing.Point(43, 131);
            this.idlb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idlb.Name = "idlb";
            this.idlb.Size = new System.Drawing.Size(135, 31);
            this.idlb.TabIndex = 15;
            this.idlb.Text = "23-53027-3";
            // 
            // userlb
            // 
            this.userlb.AutoSize = true;
            this.userlb.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userlb.Location = new System.Drawing.Point(12, 100);
            this.userlb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userlb.Name = "userlb";
            this.userlb.Size = new System.Drawing.Size(239, 31);
            this.userlb.TabIndex = 14;
            this.userlb.Text = "Sumaiya Akter Roshni";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(79, 5);
            this.guna2CirclePictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(90, 90);
            this.guna2CirclePictureBox1.TabIndex = 13;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // btnContainer
            // 
            this.btnContainer.Interval = 10;
            this.btnContainer.Tick += new System.EventHandler(this.btnContainer_Tick);
            // 
            // FeatureHolder
            // 
            this.FeatureHolder.Controls.Add(this.featurePanel);
            this.FeatureHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FeatureHolder.Location = new System.Drawing.Point(270, 75);
            this.FeatureHolder.Name = "FeatureHolder";
            this.FeatureHolder.Size = new System.Drawing.Size(930, 725);
            this.FeatureHolder.TabIndex = 4;
            // 
            // featurePanel
            // 
            this.featurePanel.Controls.Add(this.addProduct1);
            this.featurePanel.Controls.Add(this.employeesSearch);
            this.featurePanel.Controls.Add(this.product1);
            this.featurePanel.Controls.Add(this.addEmployee1);
            this.featurePanel.Controls.Add(this.home1);
            this.featurePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.featurePanel.Location = new System.Drawing.Point(0, 0);
            this.featurePanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.featurePanel.Name = "featurePanel";
            this.featurePanel.Size = new System.Drawing.Size(930, 725);
            this.featurePanel.TabIndex = 0;
            // 
            // addProduct1
            // 
            this.addProduct1.BackColor = System.Drawing.Color.White;
            this.addProduct1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addProduct1.Location = new System.Drawing.Point(0, 0);
            this.addProduct1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.addProduct1.Name = "addProduct1";
            this.addProduct1.Size = new System.Drawing.Size(930, 725);
            this.addProduct1.TabIndex = 4;
            this.addProduct1.Load += new System.EventHandler(this.addProduct1_Load);
            // 
            // employeesSearch
            // 
            this.employeesSearch.BackColor = System.Drawing.Color.White;
            this.employeesSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeesSearch.Location = new System.Drawing.Point(0, 0);
            this.employeesSearch.Name = "employeesSearch";
            this.employeesSearch.Size = new System.Drawing.Size(930, 725);
            this.employeesSearch.TabIndex = 3;
            this.employeesSearch.Load += new System.EventHandler(this.employeesSearch_Load);
            // 
            // product1
            // 
            this.product1.BackColor = System.Drawing.Color.White;
            this.product1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.product1.Location = new System.Drawing.Point(0, 0);
            this.product1.Name = "product1";
            this.product1.Size = new System.Drawing.Size(930, 725);
            this.product1.TabIndex = 2;
            this.product1.Load += new System.EventHandler(this.product1_Load);
            // 
            // addEmployee1
            // 
            this.addEmployee1.BackColor = System.Drawing.Color.White;
            this.addEmployee1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addEmployee1.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee1.Location = new System.Drawing.Point(0, 0);
            this.addEmployee1.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.addEmployee1.Name = "addEmployee1";
            this.addEmployee1.Size = new System.Drawing.Size(930, 725);
            this.addEmployee1.TabIndex = 1;
            this.addEmployee1.Load += new System.EventHandler(this.addEmployee1_Load);
            // 
            // home1
            // 
            this.home1.BackColor = System.Drawing.Color.White;
            this.home1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.home1.Location = new System.Drawing.Point(0, 0);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(930, 725);
            this.home1.TabIndex = 0;
            this.home1.Load += new System.EventHandler(this.home1_Load);
            // 
            // Admin_Main_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.FeatureHolder);
            this.Controls.Add(this.SideContainer);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_Main_Home";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Admin_Main_Home_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.reportpnl.ResumeLayout(false);
            this.Salepnl.ResumeLayout(false);
            this.Productpnl.ResumeLayout(false);
            this.pnlEmployee.ResumeLayout(false);
            this.SideContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.FeatureHolder.ResumeLayout(false);
            this.featurePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnAdminInfo;
        private System.Windows.Forms.Button btnsales;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.FlowLayoutPanel reportpnl;
        private System.Windows.Forms.Timer ReportTimer;
        private System.Windows.Forms.Timer EmployeeTimer;
        private System.Windows.Forms.Timer ProductTimer;
        private System.Windows.Forms.Panel pnlEmployee;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnManageEmployee;
        private System.Windows.Forms.Panel Productpnl;
        private System.Windows.Forms.Button btnManageProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Panel Salepnl;
        private System.Windows.Forms.Button btnMonthlySales;
        private System.Windows.Forms.Button btnDailySales;
        private System.Windows.Forms.Timer SalesTimer;
        private System.Windows.Forms.FlowLayoutPanel SideContainer;
        private System.Windows.Forms.Timer btnContainer;
        private System.Windows.Forms.Panel FeatureHolder;
        private System.Windows.Forms.Panel featurePanel;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Manager.Home home1;
        private Features.addEmployee addEmployee1;
        private Product product1;
        private Employees employeesSearch;
        private Features.addProduct addProduct1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label idlb;
        private System.Windows.Forms.Label userlb;
    }
}