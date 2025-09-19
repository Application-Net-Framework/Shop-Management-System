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
            this.btnCross = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnFullScreen = new System.Windows.Forms.Button();
            this.btnMail = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.reportpnl = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnAdminInfo = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.Salepnl = new System.Windows.Forms.Panel();
            this.btnMonthlySales = new System.Windows.Forms.Button();
            this.btnDailySales = new System.Windows.Forms.Button();
            this.btnsales = new System.Windows.Forms.Button();
            this.Productpnl = new System.Windows.Forms.Panel();
            this.btnManageProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.pnlEmployee = new System.Windows.Forms.Panel();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnEmpReports = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnManageEmployee = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ReportTimer = new System.Windows.Forms.Timer(this.components);
            this.EmployeeTimer = new System.Windows.Forms.Timer(this.components);
            this.ProductTimer = new System.Windows.Forms.Timer(this.components);
            this.SalesTimer = new System.Windows.Forms.Timer(this.components);
            this.SideContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTop.SuspendLayout();
            this.reportpnl.SuspendLayout();
            this.Salepnl.SuspendLayout();
            this.Productpnl.SuspendLayout();
            this.pnlEmployee.SuspendLayout();
            this.SideContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelTop.Controls.Add(this.btnCross);
            this.panelTop.Controls.Add(this.btnMinimize);
            this.panelTop.Controls.Add(this.btnFullScreen);
            this.panelTop.Controls.Add(this.btnMail);
            this.panelTop.Controls.Add(this.btnInfo);
            this.panelTop.Controls.Add(this.btnMenu);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1200, 75);
            this.panelTop.TabIndex = 0;
            this.panelTop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTop_Paint);
            // 
            // btnCross
            // 
            this.btnCross.BackColor = System.Drawing.Color.White;
            this.btnCross.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCross.FlatAppearance.BorderSize = 0;
            this.btnCross.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCross.Image = ((System.Drawing.Image)(resources.GetObject("btnCross.Image")));
            this.btnCross.Location = new System.Drawing.Point(668, 12);
            this.btnCross.Name = "btnCross";
            this.btnCross.Size = new System.Drawing.Size(57, 40);
            this.btnCross.TabIndex = 6;
            this.btnCross.UseVisualStyleBackColor = false;
            this.btnCross.Click += new System.EventHandler(this.btnCross_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.White;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(596, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(57, 40);
            this.btnMinimize.TabIndex = 5;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnFullScreen
            // 
            this.btnFullScreen.BackColor = System.Drawing.Color.White;
            this.btnFullScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFullScreen.FlatAppearance.BorderSize = 0;
            this.btnFullScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFullScreen.Location = new System.Drawing.Point(507, 12);
            this.btnFullScreen.Name = "btnFullScreen";
            this.btnFullScreen.Size = new System.Drawing.Size(57, 40);
            this.btnFullScreen.TabIndex = 4;
            this.btnFullScreen.UseVisualStyleBackColor = false;
            this.btnFullScreen.Click += new System.EventHandler(this.btnFullScreen_Click);
            // 
            // btnMail
            // 
            this.btnMail.BackColor = System.Drawing.Color.Transparent;
            this.btnMail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMail.BackgroundImage")));
            this.btnMail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMail.FlatAppearance.BorderSize = 0;
            this.btnMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMail.Location = new System.Drawing.Point(950, 12);
            this.btnMail.Name = "btnMail";
            this.btnMail.Size = new System.Drawing.Size(57, 40);
            this.btnMail.TabIndex = 3;
            this.btnMail.UseVisualStyleBackColor = false;
            this.btnMail.Click += new System.EventHandler(this.btnMail_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInfo.BackgroundImage")));
            this.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Location = new System.Drawing.Point(1024, 12);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(57, 40);
            this.btnInfo.TabIndex = 2;
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.button2_Click);
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
            this.label1.Location = new System.Drawing.Point(107, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amin_Home";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // reportpnl
            // 
            this.reportpnl.Controls.Add(this.btnAdminInfo);
            this.reportpnl.Controls.Add(this.btnSetting);
            this.reportpnl.Controls.Add(this.btnLogOut);
            this.reportpnl.Location = new System.Drawing.Point(2, 2);
            this.reportpnl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reportpnl.Name = "reportpnl";
            this.reportpnl.Size = new System.Drawing.Size(244, 87);
            this.reportpnl.TabIndex = 2;
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.DarkGray;
            this.btnSetting.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnSetting.Image")));
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(4, 95);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.btnSetting.Size = new System.Drawing.Size(231, 80);
            this.btnSetting.TabIndex = 9;
            this.btnSetting.Text = "Settings";
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnAdminInfo
            // 
            this.btnAdminInfo.BackColor = System.Drawing.Color.DarkGray;
            this.btnAdminInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnAdminInfo.Image")));
            this.btnAdminInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminInfo.Location = new System.Drawing.Point(4, 5);
            this.btnAdminInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdminInfo.Name = "btnAdminInfo";
            this.btnAdminInfo.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.btnAdminInfo.Size = new System.Drawing.Size(231, 80);
            this.btnAdminInfo.TabIndex = 8;
            this.btnAdminInfo.Text = "Admin Info";
            this.btnAdminInfo.UseVisualStyleBackColor = false;
            this.btnAdminInfo.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(4, 185);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.btnLogOut.Size = new System.Drawing.Size(231, 80);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.button8_Click);
            // 
            // Salepnl
            // 
            this.Salepnl.Controls.Add(this.btnMonthlySales);
            this.Salepnl.Controls.Add(this.btnDailySales);
            this.Salepnl.Controls.Add(this.btnsales);
            this.Salepnl.Controls.Add(this.btnEmpReports);
            this.Salepnl.Location = new System.Drawing.Point(2, 264);
            this.Salepnl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Salepnl.Name = "Salepnl";
            this.Salepnl.Size = new System.Drawing.Size(244, 83);
            this.Salepnl.TabIndex = 12;
            // 
            // btnMonthlySales
            // 
            this.btnMonthlySales.BackColor = System.Drawing.Color.DarkGray;
            this.btnMonthlySales.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonthlySales.Image = ((System.Drawing.Image)(resources.GetObject("btnMonthlySales.Image")));
            this.btnMonthlySales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMonthlySales.Location = new System.Drawing.Point(0, 166);
            this.btnMonthlySales.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMonthlySales.Name = "btnMonthlySales";
            this.btnMonthlySales.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.btnMonthlySales.Size = new System.Drawing.Size(231, 80);
            this.btnMonthlySales.TabIndex = 9;
            this.btnMonthlySales.Text = "   Monthly Sales";
            this.btnMonthlySales.UseVisualStyleBackColor = false;
            this.btnMonthlySales.Click += new System.EventHandler(this.btnMonthlySales_Click);
            // 
            // btnDailySales
            // 
            this.btnDailySales.BackColor = System.Drawing.Color.DarkGray;
            this.btnDailySales.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDailySales.Image = ((System.Drawing.Image)(resources.GetObject("btnDailySales.Image")));
            this.btnDailySales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDailySales.Location = new System.Drawing.Point(0, 82);
            this.btnDailySales.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDailySales.Name = "btnDailySales";
            this.btnDailySales.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.btnDailySales.Size = new System.Drawing.Size(231, 80);
            this.btnDailySales.TabIndex = 8;
            this.btnDailySales.Text = "Daily Sales";
            this.btnDailySales.UseVisualStyleBackColor = false;
            this.btnDailySales.Click += new System.EventHandler(this.btnDailySales_Click);
            // 
            // btnsales
            // 
            this.btnsales.BackColor = System.Drawing.Color.DarkGray;
            this.btnsales.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsales.Image = ((System.Drawing.Image)(resources.GetObject("btnsales.Image")));
            this.btnsales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsales.Location = new System.Drawing.Point(0, 0);
            this.btnsales.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnsales.Name = "btnsales";
            this.btnsales.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.btnsales.Size = new System.Drawing.Size(231, 80);
            this.btnsales.TabIndex = 7;
            this.btnsales.Text = "Report";
            this.btnsales.UseVisualStyleBackColor = false;
            this.btnsales.Click += new System.EventHandler(this.btnsales_Click);
            // 
            // Productpnl
            // 
            this.Productpnl.Controls.Add(this.btnManageProduct);
            this.Productpnl.Controls.Add(this.btnAddProduct);
            this.Productpnl.Controls.Add(this.btnProduct);
            this.Productpnl.Location = new System.Drawing.Point(2, 177);
            this.Productpnl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Productpnl.Name = "Productpnl";
            this.Productpnl.Size = new System.Drawing.Size(244, 83);
            this.Productpnl.TabIndex = 7;
            // 
            // btnManageProduct
            // 
            this.btnManageProduct.BackColor = System.Drawing.Color.DarkGray;
            this.btnManageProduct.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnManageProduct.Image")));
            this.btnManageProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageProduct.Location = new System.Drawing.Point(0, 166);
            this.btnManageProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnManageProduct.Name = "btnManageProduct";
            this.btnManageProduct.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.btnManageProduct.Size = new System.Drawing.Size(231, 80);
            this.btnManageProduct.TabIndex = 8;
            this.btnManageProduct.Text = "   Manage Products";
            this.btnManageProduct.UseVisualStyleBackColor = false;
            this.btnManageProduct.Click += new System.EventHandler(this.btnManageProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.DarkGray;
            this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProduct.Image")));
            this.btnAddProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProduct.Location = new System.Drawing.Point(0, 82);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.btnAddProduct.Size = new System.Drawing.Size(231, 80);
            this.btnAddProduct.TabIndex = 7;
            this.btnAddProduct.Text = " Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.DarkGray;
            this.btnProduct.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnProduct.Image")));
            this.btnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.Location = new System.Drawing.Point(4, 0);
            this.btnProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.btnProduct.Size = new System.Drawing.Size(231, 80);
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
            this.pnlEmployee.Location = new System.Drawing.Point(2, 93);
            this.pnlEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlEmployee.Name = "pnlEmployee";
            this.pnlEmployee.Size = new System.Drawing.Size(244, 80);
            this.pnlEmployee.TabIndex = 11;
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.DarkGray;
            this.btnEmployee.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployee.Image")));
            this.btnEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.Location = new System.Drawing.Point(2, 0);
            this.btnEmployee.Margin = new System.Windows.Forms.Padding(0);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.btnEmployee.Size = new System.Drawing.Size(231, 80);
            this.btnEmployee.TabIndex = 5;
            this.btnEmployee.Text = "  Employees";
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnEmpReports
            // 
            this.btnEmpReports.BackColor = System.Drawing.Color.DarkGray;
            this.btnEmpReports.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpReports.Image = ((System.Drawing.Image)(resources.GetObject("btnEmpReports.Image")));
            this.btnEmpReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpReports.Location = new System.Drawing.Point(0, 256);
            this.btnEmpReports.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEmpReports.Name = "btnEmpReports";
            this.btnEmpReports.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.btnEmpReports.Size = new System.Drawing.Size(231, 80);
            this.btnEmpReports.TabIndex = 10;
            this.btnEmpReports.Text = "Employees";
            this.btnEmpReports.UseVisualStyleBackColor = false;
            this.btnEmpReports.Click += new System.EventHandler(this.btnEmpReports_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.Color.DarkGray;
            this.btnAddEmployee.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmployee.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnAddEmployee.Image")));
            this.btnAddEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddEmployee.Location = new System.Drawing.Point(2, 85);
            this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.btnAddEmployee.Size = new System.Drawing.Size(231, 80);
            this.btnAddEmployee.TabIndex = 5;
            this.btnAddEmployee.Text = "    Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnManageEmployee
            // 
            this.btnManageEmployee.BackColor = System.Drawing.Color.DarkGray;
            this.btnManageEmployee.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnManageEmployee.Image")));
            this.btnManageEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageEmployee.Location = new System.Drawing.Point(0, 175);
            this.btnManageEmployee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnManageEmployee.Name = "btnManageEmployee";
            this.btnManageEmployee.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.btnManageEmployee.Size = new System.Drawing.Size(231, 80);
            this.btnManageEmployee.TabIndex = 6;
            this.btnManageEmployee.Text = "Manage Employees";
            this.btnManageEmployee.UseVisualStyleBackColor = false;
            this.btnManageEmployee.Click += new System.EventHandler(this.btnManageEmployee_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(392, 162);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(196, 40);
            this.button4.TabIndex = 2;
            this.button4.UseVisualStyleBackColor = false;
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
            this.SideContainer.BackColor = System.Drawing.Color.Gainsboro;
            this.SideContainer.Controls.Add(this.reportpnl);
            this.SideContainer.Controls.Add(this.pnlEmployee);
            this.SideContainer.Controls.Add(this.Productpnl);
            this.SideContainer.Controls.Add(this.Salepnl);
            this.SideContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideContainer.Location = new System.Drawing.Point(0, 75);
            this.SideContainer.Name = "SideContainer";
            this.SideContainer.Size = new System.Drawing.Size(239, 573);
            this.SideContainer.TabIndex = 3;
            // 
            // Admin_Main_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1200, 648);
            this.Controls.Add(this.SideContainer);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_Main_Home";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Admin_Main_Home";
            this.Load += new System.EventHandler(this.Admin_Main_Home_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.reportpnl.ResumeLayout(false);
            this.Salepnl.ResumeLayout(false);
            this.Productpnl.ResumeLayout(false);
            this.pnlEmployee.ResumeLayout(false);
            this.SideContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnMail;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnAdminInfo;
        private System.Windows.Forms.Button btnsales;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnCross;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnFullScreen;
        private System.Windows.Forms.FlowLayoutPanel reportpnl;
        private System.Windows.Forms.Timer ReportTimer;
        private System.Windows.Forms.Timer EmployeeTimer;
        private System.Windows.Forms.Timer ProductTimer;
        private System.Windows.Forms.Panel pnlEmployee;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnEmpReports;
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
    }
}