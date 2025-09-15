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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Main_Home));
            this.panelTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelSide = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnsales = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.memberbtn = new System.Windows.Forms.Button();
            this.btnMail = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.employees1 = new App.UI_Forms.Admin.Employees();
            this.home1 = new App.UI_Forms.Manager.Home();
            this.panelTop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelSide.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelTop.Controls.Add(this.btnMail);
            this.panelTop.Controls.Add(this.btnInfo);
            this.panelTop.Controls.Add(this.btnMenu);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1093, 66);
            this.panelTop.TabIndex = 0;
            this.panelTop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTop_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amin_Home";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.panelSide);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.memberbtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 519);
            this.panel2.TabIndex = 1;
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panelSide.Controls.Add(this.btnSetting);
            this.panelSide.Controls.Add(this.btnReport);
            this.panelSide.Controls.Add(this.btnsales);
            this.panelSide.Controls.Add(this.btnProduct);
            this.panelSide.Controls.Add(this.btnEmployee);
            this.panelSide.Controls.Add(this.btnHome);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 0);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(239, 519);
            this.panelSide.TabIndex = 6;
            this.panelSide.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSide_Paint);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(391, 162);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(197, 40);
            this.button4.TabIndex = 2;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.employees1);
            this.panelMain.Controls.Add(this.home1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(239, 66);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(854, 519);
            this.panelMain.TabIndex = 3;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.Gray;
            this.btnSetting.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(4, 403);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.btnSetting.Size = new System.Drawing.Size(231, 69);
            this.btnSetting.TabIndex = 9;
            this.btnSetting.Text = "Settings";
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.Gray;
            this.btnReport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(4, 324);
            this.btnReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReport.Name = "btnReport";
            this.btnReport.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.btnReport.Size = new System.Drawing.Size(231, 69);
            this.btnReport.TabIndex = 8;
            this.btnReport.Text = "Reports";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnsales
            // 
            this.btnsales.BackColor = System.Drawing.Color.Gray;
            this.btnsales.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsales.Location = new System.Drawing.Point(4, 245);
            this.btnsales.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnsales.Name = "btnsales";
            this.btnsales.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.btnsales.Size = new System.Drawing.Size(231, 69);
            this.btnsales.TabIndex = 7;
            this.btnsales.Text = "Sales";
            this.btnsales.UseVisualStyleBackColor = false;
            this.btnsales.Click += new System.EventHandler(this.btnsales_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.Gray;
            this.btnProduct.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.Location = new System.Drawing.Point(4, 166);
            this.btnProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.btnProduct.Size = new System.Drawing.Size(231, 69);
            this.btnProduct.TabIndex = 6;
            this.btnProduct.Text = "Products";
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.Gray;
            this.btnEmployee.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.Location = new System.Drawing.Point(4, 87);
            this.btnEmployee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.btnEmployee.Size = new System.Drawing.Size(231, 69);
            this.btnEmployee.TabIndex = 5;
            this.btnEmployee.Text = "Employees";
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Gray;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(4, 8);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(231, 69);
            this.btnHome.TabIndex = 4;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.button8_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Gray;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(4, 96);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(231, 69);
            this.button6.TabIndex = 5;
            this.button6.Text = "Members";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // memberbtn
            // 
            this.memberbtn.BackColor = System.Drawing.Color.Gray;
            this.memberbtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberbtn.Image = ((System.Drawing.Image)(resources.GetObject("memberbtn.Image")));
            this.memberbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.memberbtn.Location = new System.Drawing.Point(4, 8);
            this.memberbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.memberbtn.Name = "memberbtn";
            this.memberbtn.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.memberbtn.Size = new System.Drawing.Size(231, 69);
            this.memberbtn.TabIndex = 4;
            this.memberbtn.Text = "Members";
            this.memberbtn.UseVisualStyleBackColor = false;
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
            this.btnMenu.Location = new System.Drawing.Point(182, 10);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(57, 40);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // employees1
            // 
            this.employees1.Location = new System.Drawing.Point(0, 3);
            this.employees1.Name = "employees1";
            this.employees1.Size = new System.Drawing.Size(851, 516);
            this.employees1.TabIndex = 1;
            // 
            // home1
            // 
            this.home1.Location = new System.Drawing.Point(24, 27);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(806, 468);
            this.home1.TabIndex = 0;
            // 
            // Admin_Main_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 585);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_Main_Home";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Main_Home";
            this.Load += new System.EventHandler(this.Admin_Main_Home_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelSide.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnMail;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnsales;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button memberbtn;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Panel panelMain;
        private Manager.Home home1;
        private Employees employees1;
    }
}