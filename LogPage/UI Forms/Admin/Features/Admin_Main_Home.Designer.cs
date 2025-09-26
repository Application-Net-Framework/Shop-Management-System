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
            this.label1 = new System.Windows.Forms.Label();
            this.reportpnl = new System.Windows.Forms.FlowLayoutPanel();
            this.Salepnl = new System.Windows.Forms.Panel();
            this.Productpnl = new System.Windows.Forms.Panel();
            this.pnlEmployee = new System.Windows.Forms.Panel();
            this.ReportTimer = new System.Windows.Forms.Timer(this.components);
            this.EmployeeTimer = new System.Windows.Forms.Timer(this.components);
            this.ProductTimer = new System.Windows.Forms.Timer(this.components);
            this.SalesTimer = new System.Windows.Forms.Timer(this.components);
            this.SideContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.btnContainer = new System.Windows.Forms.Timer(this.components);
            this.FeatureHolder = new System.Windows.Forms.Panel();
            this.featurePanel = new System.Windows.Forms.Panel();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.home1 = new App.UI_Forms.Manager.Home();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnManageEmployee = new System.Windows.Forms.Button();
            this.btnManageProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnsales = new System.Windows.Forms.Button();
            this.btnMonthlySales = new System.Windows.Forms.Button();
            this.btnDailySales = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnAdminInfo = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.addEmployee1 = new App.UI_Forms.Admin.Features.addEmployee();
            this.product1 = new App.UI_Forms.Admin.Product();
            this.employeesSearch = new App.UI_Forms.Admin.Employees();
            this.addProduct1 = new App.UI_Forms.Admin.Features.addProduct();
            this.panelTop.SuspendLayout();
            this.reportpnl.SuspendLayout();
            this.Salepnl.SuspendLayout();
            this.Productpnl.SuspendLayout();
            this.pnlEmployee.SuspendLayout();
            this.SideContainer.SuspendLayout();
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
            this.panelTop.Margin = new System.Windows.Forms.Padding(2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(800, 49);
            this.panelTop.TabIndex = 0;
            this.panelTop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTop_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amin_Home";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // reportpnl
            // 
            this.reportpnl.Controls.Add(this.btnSetting);
            this.reportpnl.Controls.Add(this.btnAdminInfo);
            this.reportpnl.Controls.Add(this.btnLogOut);
            this.reportpnl.Location = new System.Drawing.Point(1, 164);
            this.reportpnl.Margin = new System.Windows.Forms.Padding(1);
            this.reportpnl.Name = "reportpnl";
            this.reportpnl.Size = new System.Drawing.Size(175, 53);
            this.reportpnl.TabIndex = 2;
            // 
            // Salepnl
            // 
            this.Salepnl.Controls.Add(this.btnsales);
            this.Salepnl.Controls.Add(this.btnMonthlySales);
            this.Salepnl.Controls.Add(this.btnDailySales);
            this.Salepnl.Location = new System.Drawing.Point(1, 109);
            this.Salepnl.Margin = new System.Windows.Forms.Padding(1);
            this.Salepnl.Name = "Salepnl";
            this.Salepnl.Size = new System.Drawing.Size(175, 53);
            this.Salepnl.TabIndex = 12;
            // 
            // Productpnl
            // 
            this.Productpnl.Controls.Add(this.btnManageProduct);
            this.Productpnl.Controls.Add(this.btnAddProduct);
            this.Productpnl.Controls.Add(this.btnProduct);
            this.Productpnl.Location = new System.Drawing.Point(1, 55);
            this.Productpnl.Margin = new System.Windows.Forms.Padding(1);
            this.Productpnl.Name = "Productpnl";
            this.Productpnl.Size = new System.Drawing.Size(175, 52);
            this.Productpnl.TabIndex = 7;
            // 
            // pnlEmployee
            // 
            this.pnlEmployee.Controls.Add(this.btnEmployee);
            this.pnlEmployee.Controls.Add(this.btnAddEmployee);
            this.pnlEmployee.Controls.Add(this.btnManageEmployee);
            this.pnlEmployee.Location = new System.Drawing.Point(1, 1);
            this.pnlEmployee.Margin = new System.Windows.Forms.Padding(1);
            this.pnlEmployee.Name = "pnlEmployee";
            this.pnlEmployee.Size = new System.Drawing.Size(175, 52);
            this.pnlEmployee.TabIndex = 11;
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
            this.SideContainer.Controls.Add(this.pnlEmployee);
            this.SideContainer.Controls.Add(this.Productpnl);
            this.SideContainer.Controls.Add(this.Salepnl);
            this.SideContainer.Controls.Add(this.reportpnl);
            this.SideContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideContainer.Location = new System.Drawing.Point(0, 49);
            this.SideContainer.Name = "SideContainer";
            this.SideContainer.Size = new System.Drawing.Size(179, 471);
            this.SideContainer.TabIndex = 3;
            this.SideContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.SideContainer_Paint_1);
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
            this.FeatureHolder.Location = new System.Drawing.Point(179, 49);
            this.FeatureHolder.Margin = new System.Windows.Forms.Padding(2);
            this.FeatureHolder.Name = "FeatureHolder";
            this.FeatureHolder.Size = new System.Drawing.Size(621, 471);
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
            this.featurePanel.Name = "featurePanel";
            this.featurePanel.Size = new System.Drawing.Size(621, 471);
            this.featurePanel.TabIndex = 0;
            // 
            // home1
            // 
            this.home1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.home1.Location = new System.Drawing.Point(0, 0);
            this.home1.Margin = new System.Windows.Forms.Padding(2);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(621, 471);
            this.home1.TabIndex = 0;
            this.home1.Load += new System.EventHandler(this.home1_Load);
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.White;
            this.btnEmployee.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployee.Image")));
            this.btnEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.Location = new System.Drawing.Point(1, 0);
            this.btnEmployee.Margin = new System.Windows.Forms.Padding(1);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnEmployee.Size = new System.Drawing.Size(173, 52);
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
            this.btnAddEmployee.Location = new System.Drawing.Point(1, 51);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Padding = new System.Windows.Forms.Padding(33, 0, 0, 0);
            this.btnAddEmployee.Size = new System.Drawing.Size(173, 52);
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
            this.btnManageEmployee.Location = new System.Drawing.Point(0, 103);
            this.btnManageEmployee.Margin = new System.Windows.Forms.Padding(0);
            this.btnManageEmployee.Name = "btnManageEmployee";
            this.btnManageEmployee.Padding = new System.Windows.Forms.Padding(33, 0, 0, 0);
            this.btnManageEmployee.Size = new System.Drawing.Size(175, 52);
            this.btnManageEmployee.TabIndex = 6;
            this.btnManageEmployee.Text = "   Manage";
            this.btnManageEmployee.UseVisualStyleBackColor = false;
            this.btnManageEmployee.Click += new System.EventHandler(this.btnManageEmployee_Click_1);
            // 
            // btnManageProduct
            // 
            this.btnManageProduct.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnManageProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnManageProduct.Image")));
            this.btnManageProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageProduct.Location = new System.Drawing.Point(0, 103);
            this.btnManageProduct.Margin = new System.Windows.Forms.Padding(0);
            this.btnManageProduct.Name = "btnManageProduct";
            this.btnManageProduct.Padding = new System.Windows.Forms.Padding(33, 0, 0, 0);
            this.btnManageProduct.Size = new System.Drawing.Size(175, 52);
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
            this.btnAddProduct.Location = new System.Drawing.Point(0, 53);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Padding = new System.Windows.Forms.Padding(33, 0, 0, 0);
            this.btnAddProduct.Size = new System.Drawing.Size(175, 52);
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
            this.btnProduct.Location = new System.Drawing.Point(0, 1);
            this.btnProduct.Margin = new System.Windows.Forms.Padding(0);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.btnProduct.Size = new System.Drawing.Size(175, 52);
            this.btnProduct.TabIndex = 6;
            this.btnProduct.Text = "Products";
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnsales
            // 
            this.btnsales.BackColor = System.Drawing.Color.White;
            this.btnsales.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsales.Image = ((System.Drawing.Image)(resources.GetObject("btnsales.Image")));
            this.btnsales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsales.Location = new System.Drawing.Point(0, 0);
            this.btnsales.Margin = new System.Windows.Forms.Padding(1);
            this.btnsales.Name = "btnsales";
            this.btnsales.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnsales.Size = new System.Drawing.Size(173, 53);
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
            this.btnMonthlySales.Location = new System.Drawing.Point(0, 98);
            this.btnMonthlySales.Margin = new System.Windows.Forms.Padding(0);
            this.btnMonthlySales.Name = "btnMonthlySales";
            this.btnMonthlySales.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnMonthlySales.Size = new System.Drawing.Size(173, 52);
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
            this.btnDailySales.Location = new System.Drawing.Point(0, 49);
            this.btnDailySales.Margin = new System.Windows.Forms.Padding(0);
            this.btnDailySales.Name = "btnDailySales";
            this.btnDailySales.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnDailySales.Size = new System.Drawing.Size(173, 52);
            this.btnDailySales.TabIndex = 8;
            this.btnDailySales.Text = "  Daily Sales";
            this.btnDailySales.UseVisualStyleBackColor = false;
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
            this.btnSetting.Padding = new System.Windows.Forms.Padding(33, 0, 0, 0);
            this.btnSetting.Size = new System.Drawing.Size(173, 52);
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
            this.btnAdminInfo.Location = new System.Drawing.Point(0, 52);
            this.btnAdminInfo.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdminInfo.Name = "btnAdminInfo";
            this.btnAdminInfo.Padding = new System.Windows.Forms.Padding(33, 0, 0, 0);
            this.btnAdminInfo.Size = new System.Drawing.Size(173, 52);
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
            this.btnLogOut.Location = new System.Drawing.Point(0, 104);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Padding = new System.Windows.Forms.Padding(33, 0, 0, 0);
            this.btnLogOut.Size = new System.Drawing.Size(173, 52);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMenu.BackgroundImage")));
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Location = new System.Drawing.Point(15, 8);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(42, 35);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // addEmployee1
            // 
            this.addEmployee1.BackColor = System.Drawing.Color.White;
            this.addEmployee1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addEmployee1.Location = new System.Drawing.Point(0, 0);
            this.addEmployee1.Name = "addEmployee1";
            this.addEmployee1.Size = new System.Drawing.Size(621, 471);
            this.addEmployee1.TabIndex = 1;
            this.addEmployee1.Load += new System.EventHandler(this.addEmployee1_Load);
            // 
            // product1
            // 
            this.product1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.product1.Location = new System.Drawing.Point(0, 0);
            this.product1.Margin = new System.Windows.Forms.Padding(2);
            this.product1.Name = "product1";
            this.product1.Size = new System.Drawing.Size(621, 471);
            this.product1.TabIndex = 2;
            this.product1.Load += new System.EventHandler(this.product1_Load);
            // 
            // employeesSearch
            // 
            this.employeesSearch.BackColor = System.Drawing.Color.White;
            this.employeesSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeesSearch.Location = new System.Drawing.Point(0, 0);
            this.employeesSearch.Margin = new System.Windows.Forms.Padding(2);
            this.employeesSearch.Name = "employeesSearch";
            this.employeesSearch.Size = new System.Drawing.Size(621, 471);
            this.employeesSearch.TabIndex = 3;
            this.employeesSearch.Load += new System.EventHandler(this.employeesSearch_Load);
            // 
            // addProduct1
            // 
            this.addProduct1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addProduct1.Location = new System.Drawing.Point(0, 0);
            this.addProduct1.Name = "addProduct1";
            this.addProduct1.Size = new System.Drawing.Size(621, 471);
            this.addProduct1.TabIndex = 4;
            this.addProduct1.Load += new System.EventHandler(this.addProduct1_Load);
            // 
            // Admin_Main_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.FeatureHolder);
            this.Controls.Add(this.SideContainer);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
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
    }
}