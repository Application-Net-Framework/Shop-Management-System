namespace App
{
    partial class mainCashier
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.dgvProduct_Test = new System.Windows.Forms.DataGridView();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblPaymentMethod_order = new System.Windows.Forms.Label();
            this.lblCustomerName_order = new System.Windows.Forms.Label();
            this.lblTotal_order = new System.Windows.Forms.Label();
            this.lblOrderDate_order = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.g2E_pnlProduct = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnlProfile = new System.Windows.Forms.Panel();
            this.lable10 = new System.Windows.Forms.Label();
            this.g2E_pnlCart = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.g2E_pnlCartView = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lblWelcome = new System.Windows.Forms.Label();
            this.g2E__pnlWelcome = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnlWelcome = new System.Windows.Forms.Panel();
            this.lblTimer = new System.Windows.Forms.Label();
            this.ucPnl_Product1 = new App.UI_Forms.Cashier.ucPnl_Product();
            this.ucPnl_Order1 = new App.UI_Forms.Cashier.ucPnl_Order();
            this.ucPnl_Home1 = new App.UI_Forms.Cashier.ucPnl_Home();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct_Test)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.pnlProfile.SuspendLayout();
            this.pnlWelcome.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnOrder);
            this.panel1.Controls.Add(this.btnProduct);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnProfile);
            this.panel1.Controls.Add(this.dgvProduct_Test);
            this.panel1.Controls.Add(this.guna2Panel1);
            this.panel1.Location = new System.Drawing.Point(25, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 523);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(64, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "   Cart   ";
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.btnOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnOrder.Location = new System.Drawing.Point(29, 142);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(149, 40);
            this.btnOrder.TabIndex = 2;
            this.btnOrder.Text = "Orders";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            this.btnOrder.MouseLeave += new System.EventHandler(this.btnOrder_MouseLeave);
            this.btnOrder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnOrder_MouseMove);
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.btnProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProduct.FlatAppearance.BorderSize = 0;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnProduct.Location = new System.Drawing.Point(29, 85);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(149, 40);
            this.btnProduct.TabIndex = 1;
            this.btnProduct.Text = "Products";
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            this.btnProduct.MouseLeave += new System.EventHandler(this.btnProduct_MouseLeave);
            this.btnProduct.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnProduct_MouseMove);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView2.ColumnHeadersHeight = 20;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView2.Location = new System.Drawing.Point(29, 275);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(51, 61);
            this.dataGridView2.TabIndex = 5;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(29, 28);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(149, 40);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            this.btnHome.MouseLeave += new System.EventHandler(this.btnHome_MouseLeave);
            this.btnHome.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnHome_MouseMove);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnProfile.Location = new System.Drawing.Point(29, 204);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(149, 40);
            this.btnProfile.TabIndex = 4;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            this.btnProfile.MouseLeave += new System.EventHandler(this.btnProfile_MouseLeave);
            this.btnProfile.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnProfile_MouseMove);
            // 
            // dgvProduct_Test
            // 
            this.dgvProduct_Test.AllowUserToAddRows = false;
            this.dgvProduct_Test.AllowUserToDeleteRows = false;
            this.dgvProduct_Test.BackgroundColor = System.Drawing.Color.White;
            this.dgvProduct_Test.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProduct_Test.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct_Test.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvProduct_Test.ColumnHeadersHeight = 20;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduct_Test.DefaultCellStyle = dataGridViewCellStyle17;
            this.dgvProduct_Test.EnableHeadersVisualStyles = false;
            this.dgvProduct_Test.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvProduct_Test.Location = new System.Drawing.Point(103, 275);
            this.dgvProduct_Test.Name = "dgvProduct_Test";
            this.dgvProduct_Test.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct_Test.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvProduct_Test.RowHeadersVisible = false;
            this.dgvProduct_Test.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct_Test.Size = new System.Drawing.Size(63, 61);
            this.dgvProduct_Test.TabIndex = 3;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.lblPaymentMethod_order);
            this.guna2Panel1.Controls.Add(this.lblCustomerName_order);
            this.guna2Panel1.Controls.Add(this.lblTotal_order);
            this.guna2Panel1.Controls.Add(this.lblOrderDate_order);
            this.guna2Panel1.Location = new System.Drawing.Point(29, 349);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(168, 123);
            this.guna2Panel1.TabIndex = 18;
            // 
            // lblPaymentMethod_order
            // 
            this.lblPaymentMethod_order.AutoSize = true;
            this.lblPaymentMethod_order.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold);
            this.lblPaymentMethod_order.Location = new System.Drawing.Point(6, 90);
            this.lblPaymentMethod_order.Name = "lblPaymentMethod_order";
            this.lblPaymentMethod_order.Size = new System.Drawing.Size(143, 23);
            this.lblPaymentMethod_order.TabIndex = 17;
            this.lblPaymentMethod_order.Text = "Payment method";
            // 
            // lblCustomerName_order
            // 
            this.lblCustomerName_order.AutoSize = true;
            this.lblCustomerName_order.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold);
            this.lblCustomerName_order.Location = new System.Drawing.Point(20, 11);
            this.lblCustomerName_order.Name = "lblCustomerName_order";
            this.lblCustomerName_order.Size = new System.Drawing.Size(117, 23);
            this.lblCustomerName_order.TabIndex = 14;
            this.lblCustomerName_order.Text = "Phone Nmber";
            // 
            // lblTotal_order
            // 
            this.lblTotal_order.AutoSize = true;
            this.lblTotal_order.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold);
            this.lblTotal_order.Location = new System.Drawing.Point(20, 67);
            this.lblTotal_order.Name = "lblTotal_order";
            this.lblTotal_order.Size = new System.Drawing.Size(111, 23);
            this.lblTotal_order.TabIndex = 16;
            this.lblTotal_order.Text = "Total amount";
            // 
            // lblOrderDate_order
            // 
            this.lblOrderDate_order.AutoSize = true;
            this.lblOrderDate_order.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold);
            this.lblOrderDate_order.Location = new System.Drawing.Point(3, 41);
            this.lblOrderDate_order.Name = "lblOrderDate_order";
            this.lblOrderDate_order.Size = new System.Drawing.Size(95, 23);
            this.lblOrderDate_order.TabIndex = 15;
            this.lblOrderDate_order.Text = "Order Date";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this.panel1;
            // 
            // g2E_pnlProduct
            // 
            this.g2E_pnlProduct.BorderRadius = 10;
            // 
            // pnlProfile
            // 
            this.pnlProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.pnlProfile.Controls.Add(this.lable10);
            this.pnlProfile.Location = new System.Drawing.Point(8535, 375);
            this.pnlProfile.Name = "pnlProfile";
            this.pnlProfile.Size = new System.Drawing.Size(615, 469);
            this.pnlProfile.TabIndex = 5;
            this.pnlProfile.Visible = false;
            // 
            // lable10
            // 
            this.lable10.AutoSize = true;
            this.lable10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable10.Location = new System.Drawing.Point(39, 38);
            this.lable10.Name = "lable10";
            this.lable10.Size = new System.Drawing.Size(53, 20);
            this.lable10.TabIndex = 0;
            this.lable10.Text = "Profile";
            // 
            // g2E_pnlCart
            // 
            this.g2E_pnlCart.BorderRadius = 15;
            // 
            // g2E_pnlCartView
            // 
            this.g2E_pnlCartView.BorderRadius = 10;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(361, 5);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(126, 21);
            this.lblWelcome.TabIndex = 19;
            this.lblWelcome.Text = "Welcome, Hacin";
            // 
            // g2E__pnlWelcome
            // 
            this.g2E__pnlWelcome.TargetControl = this.pnlWelcome;
            // 
            // pnlWelcome
            // 
            this.pnlWelcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.pnlWelcome.Controls.Add(this.lblTimer);
            this.pnlWelcome.Controls.Add(this.lblWelcome);
            this.pnlWelcome.Location = new System.Drawing.Point(25, 6);
            this.pnlWelcome.Name = "pnlWelcome";
            this.pnlWelcome.Size = new System.Drawing.Size(904, 32);
            this.pnlWelcome.TabIndex = 6;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(675, 5);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(54, 21);
            this.lblTimer.TabIndex = 20;
            this.lblTimer.Text = "Today";
            // 
            // ucPnl_Product1
            // 
            this.ucPnl_Product1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.ucPnl_Product1.Location = new System.Drawing.Point(245, 46);
            this.ucPnl_Product1.Name = "ucPnl_Product1";
            this.ucPnl_Product1.Size = new System.Drawing.Size(925, 523);
            this.ucPnl_Product1.TabIndex = 10;
            // 
            // ucPnl_Order1
            // 
            this.ucPnl_Order1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.ucPnl_Order1.Location = new System.Drawing.Point(245, 46);
            this.ucPnl_Order1.Name = "ucPnl_Order1";
            this.ucPnl_Order1.Size = new System.Drawing.Size(684, 523);
            this.ucPnl_Order1.TabIndex = 10;
            // 
            // ucPnl_Home1
            // 
            this.ucPnl_Home1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.ucPnl_Home1.Location = new System.Drawing.Point(245, 46);
            this.ucPnl_Home1.Name = "ucPnl_Home1";
            this.ucPnl_Home1.Size = new System.Drawing.Size(684, 524);
            this.ucPnl_Home1.TabIndex = 9;
            // 
            // mainCashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1182, 602);
            this.Controls.Add(this.ucPnl_Product1);
            this.Controls.Add(this.ucPnl_Order1);
            this.Controls.Add(this.ucPnl_Home1);
            this.Controls.Add(this.pnlWelcome);
            this.Controls.Add(this.pnlProfile);
            this.Controls.Add(this.panel1);
            this.Name = "mainCashier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesMan_Home";
            this.Load += new System.EventHandler(this.Cashier_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct_Test)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.pnlProfile.ResumeLayout(false);
            this.pnlProfile.PerformLayout();
            this.pnlWelcome.ResumeLayout(false);
            this.pnlWelcome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnProfile;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse g2E_pnlProduct;
        private System.Windows.Forms.Panel pnlProfile;
        private System.Windows.Forms.Label lable10;
        private System.Windows.Forms.DataGridView dgvProduct_Test;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private Guna.UI2.WinForms.Guna2Elipse g2E_pnlCart;
        private Guna.UI2.WinForms.Guna2Elipse g2E_pnlCartView;
        private System.Windows.Forms.Label lblPaymentMethod_order;
        private System.Windows.Forms.Label lblTotal_order;
        private System.Windows.Forms.Label lblOrderDate_order;
        private System.Windows.Forms.Label lblCustomerName_order;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lblWelcome;
        private Guna.UI2.WinForms.Guna2Elipse g2E__pnlWelcome;
        private System.Windows.Forms.Panel pnlWelcome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTimer;
        private UI_Forms.Cashier.ucPnl_Home ucPnl_Home1;
        private UI_Forms.Cashier.ucPnl_Order ucPnl_Order1;
        private UI_Forms.Cashier.ucPnl_Product ucPnl_Product1;
    }
}