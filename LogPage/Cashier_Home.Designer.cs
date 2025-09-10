namespace App
{
    partial class Cashier_Home
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
            this.sidePnl = new System.Windows.Forms.Panel();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.profilebtn = new System.Windows.Forms.Button();
            this.posBtn = new System.Windows.Forms.Button();
            this.returnBtn = new System.Windows.Forms.Button();
            this.stockBtn = new System.Windows.Forms.Button();
            this.reportBtn = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.Button();
            this.headerPnl = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.mainPnl = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.salaryBtn = new System.Windows.Forms.Button();
            this.sidePnl.SuspendLayout();
            this.mainPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePnl
            // 
            this.sidePnl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sidePnl.BackColor = System.Drawing.Color.DimGray;
            this.sidePnl.Controls.Add(this.salaryBtn);
            this.sidePnl.Controls.Add(this.logoutBtn);
            this.sidePnl.Controls.Add(this.profilebtn);
            this.sidePnl.Controls.Add(this.posBtn);
            this.sidePnl.Controls.Add(this.returnBtn);
            this.sidePnl.Controls.Add(this.stockBtn);
            this.sidePnl.Controls.Add(this.reportBtn);
            this.sidePnl.Controls.Add(this.homeBtn);
            this.sidePnl.Location = new System.Drawing.Point(-1, 35);
            this.sidePnl.Name = "sidePnl";
            this.sidePnl.Size = new System.Drawing.Size(169, 419);
            this.sidePnl.TabIndex = 0;
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.DimGray;
            this.logoutBtn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.Color.Transparent;
            this.logoutBtn.Image = global::App.Properties.Resources.logout;
            this.logoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.Location = new System.Drawing.Point(13, 355);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(126, 37);
            this.logoutBtn.TabIndex = 8;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // profilebtn
            // 
            this.profilebtn.BackColor = System.Drawing.Color.DimGray;
            this.profilebtn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profilebtn.ForeColor = System.Drawing.Color.Transparent;
            this.profilebtn.Image = global::App.Properties.Resources.user;
            this.profilebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.profilebtn.Location = new System.Drawing.Point(13, 312);
            this.profilebtn.Name = "profilebtn";
            this.profilebtn.Size = new System.Drawing.Size(126, 37);
            this.profilebtn.TabIndex = 7;
            this.profilebtn.Text = "Profile";
            this.profilebtn.UseVisualStyleBackColor = false;
            this.profilebtn.Click += new System.EventHandler(this.profilebtn_Click);
            // 
            // posBtn
            // 
            this.posBtn.BackColor = System.Drawing.Color.DimGray;
            this.posBtn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posBtn.ForeColor = System.Drawing.Color.Transparent;
            this.posBtn.Image = global::App.Properties.Resources.pos1;
            this.posBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.posBtn.Location = new System.Drawing.Point(13, 51);
            this.posBtn.Name = "posBtn";
            this.posBtn.Size = new System.Drawing.Size(126, 37);
            this.posBtn.TabIndex = 5;
            this.posBtn.Text = "POS";
            this.posBtn.UseVisualStyleBackColor = false;
            this.posBtn.Click += new System.EventHandler(this.posBtn_Click);
            // 
            // returnBtn
            // 
            this.returnBtn.BackColor = System.Drawing.Color.DimGray;
            this.returnBtn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBtn.ForeColor = System.Drawing.Color.Transparent;
            this.returnBtn.Image = global::App.Properties.Resources.return_box;
            this.returnBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.returnBtn.Location = new System.Drawing.Point(13, 94);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(126, 37);
            this.returnBtn.TabIndex = 4;
            this.returnBtn.Text = "Return";
            this.returnBtn.UseVisualStyleBackColor = false;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // stockBtn
            // 
            this.stockBtn.BackColor = System.Drawing.Color.DimGray;
            this.stockBtn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockBtn.ForeColor = System.Drawing.Color.Transparent;
            this.stockBtn.Image = global::App.Properties.Resources.product;
            this.stockBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stockBtn.Location = new System.Drawing.Point(13, 137);
            this.stockBtn.Name = "stockBtn";
            this.stockBtn.Size = new System.Drawing.Size(126, 37);
            this.stockBtn.TabIndex = 2;
            this.stockBtn.Text = "Stock";
            this.stockBtn.UseVisualStyleBackColor = false;
            this.stockBtn.Click += new System.EventHandler(this.stockBtn_Click);
            // 
            // reportBtn
            // 
            this.reportBtn.BackColor = System.Drawing.Color.DimGray;
            this.reportBtn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportBtn.ForeColor = System.Drawing.Color.Transparent;
            this.reportBtn.Image = global::App.Properties.Resources.report;
            this.reportBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportBtn.Location = new System.Drawing.Point(13, 180);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Size = new System.Drawing.Size(126, 37);
            this.reportBtn.TabIndex = 1;
            this.reportBtn.Text = "Report";
            this.reportBtn.UseVisualStyleBackColor = false;
            this.reportBtn.Click += new System.EventHandler(this.reportBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.BackColor = System.Drawing.Color.DimGray;
            this.homeBtn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.ForeColor = System.Drawing.Color.Transparent;
            this.homeBtn.Image = global::App.Properties.Resources.home1;
            this.homeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeBtn.Location = new System.Drawing.Point(13, 8);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(126, 37);
            this.homeBtn.TabIndex = 0;
            this.homeBtn.Text = "Home";
            this.homeBtn.UseVisualStyleBackColor = false;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // headerPnl
            // 
            this.headerPnl.BackColor = System.Drawing.Color.DimGray;
            this.headerPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPnl.Location = new System.Drawing.Point(0, 0);
            this.headerPnl.Name = "headerPnl";
            this.headerPnl.Size = new System.Drawing.Size(799, 37);
            this.headerPnl.TabIndex = 1;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // mainPnl
            // 
            this.mainPnl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mainPnl.BackgroundImage = global::App.Properties.Resources.delivery_concept_handsome_african_american_delivery_man_carrying_package_box_grocery_food_drink_from_store_isolated_grey_studio_background_copy_space;
            this.mainPnl.Controls.Add(this.label1);
            this.mainPnl.Location = new System.Drawing.Point(174, 38);
            this.mainPnl.Name = "mainPnl";
            this.mainPnl.Size = new System.Drawing.Size(625, 416);
            this.mainPnl.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = " Welcome to Deshi Grocery Shop";
            // 
            // salaryBtn
            // 
            this.salaryBtn.BackColor = System.Drawing.Color.DimGray;
            this.salaryBtn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaryBtn.ForeColor = System.Drawing.Color.Transparent;
            this.salaryBtn.Image = global::App.Properties.Resources.report;
            this.salaryBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salaryBtn.Location = new System.Drawing.Point(13, 223);
            this.salaryBtn.Name = "salaryBtn";
            this.salaryBtn.Size = new System.Drawing.Size(126, 37);
            this.salaryBtn.TabIndex = 9;
            this.salaryBtn.Text = "Salary";
            this.salaryBtn.UseVisualStyleBackColor = false;
            // 
            // Cashier_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(799, 450);
            this.Controls.Add(this.mainPnl);
            this.Controls.Add(this.headerPnl);
            this.Controls.Add(this.sidePnl);
            this.Name = "Cashier_Home";
            this.Text = "Cashier_Home";
            this.Load += new System.EventHandler(this.Cashier_Home_Load);
            this.sidePnl.ResumeLayout(false);
            this.mainPnl.ResumeLayout(false);
            this.mainPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePnl;
        private System.Windows.Forms.Panel headerPnl;
        private System.Windows.Forms.Panel mainPnl;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button profilebtn;
        private System.Windows.Forms.Button posBtn;
        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.Button stockBtn;
        private System.Windows.Forms.Button reportBtn;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button salaryBtn;
    }
}