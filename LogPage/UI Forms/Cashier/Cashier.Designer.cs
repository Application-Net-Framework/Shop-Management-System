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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
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
            this.pnlProfile.SuspendLayout();
            this.pnlWelcome.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnOrder);
            this.panel1.Controls.Add(this.btnProduct);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Location = new System.Drawing.Point(25, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 523);
            this.panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.Location = new System.Drawing.Point(27, 460);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(149, 40);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.btnOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnOrder.Location = new System.Drawing.Point(27, 142);
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
            this.btnProduct.Location = new System.Drawing.Point(27, 85);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(149, 40);
            this.btnProduct.TabIndex = 1;
            this.btnProduct.Text = "Products";
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            this.btnProduct.MouseLeave += new System.EventHandler(this.btnProduct_MouseLeave);
            this.btnProduct.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnProduct_MouseMove);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(27, 28);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(149, 40);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            this.btnHome.MouseLeave += new System.EventHandler(this.btnHome_MouseLeave);
            this.btnHome.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnHome_MouseMove);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 8;
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
            this.pnlWelcome.Resize += new System.EventHandler(this.pnlWelcome_Resize);
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
            this.ucPnl_Product1.Size = new System.Drawing.Size(952, 602);
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
            this.ClientSize = new System.Drawing.Size(1182, 585);
            this.Controls.Add(this.ucPnl_Product1);
            this.Controls.Add(this.ucPnl_Order1);
            this.Controls.Add(this.ucPnl_Home1);
            this.Controls.Add(this.pnlWelcome);
            this.Controls.Add(this.pnlProfile);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "mainCashier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cashier";
            this.Load += new System.EventHandler(this.Cashier_Load);
            this.panel1.ResumeLayout(false);
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
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse g2E_pnlProduct;
        private System.Windows.Forms.Panel pnlProfile;
        private System.Windows.Forms.Label lable10;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2Elipse g2E_pnlCart;
        private Guna.UI2.WinForms.Guna2Elipse g2E_pnlCartView;
        private System.Windows.Forms.Label lblWelcome;
        private Guna.UI2.WinForms.Guna2Elipse g2E__pnlWelcome;
        private System.Windows.Forms.Panel pnlWelcome;
        private System.Windows.Forms.Label lblTimer;
        private UI_Forms.Cashier.ucPnl_Home ucPnl_Home1;
        private UI_Forms.Cashier.ucPnl_Order ucPnl_Order1;
        private UI_Forms.Cashier.ucPnl_Product ucPnl_Product1;
        private System.Windows.Forms.Button btnLogout;
    }
}