namespace App
{
    partial class Salesman
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
            this.Profile = new System.Windows.Forms.Button();
            this.preOrderBtn = new System.Windows.Forms.Button();
            this.cManagementBtn = new System.Windows.Forms.Button();
            this.pQueryBtn = new System.Windows.Forms.Button();
            this.feedbackBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lowStockGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.supplierRequestBtn = new System.Windows.Forms.Button();
            this.supplierRequestGrid = new System.Windows.Forms.DataGridView();
            this.supplyRequestBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.welcomeLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.sidePnl.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lowStockGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierRequestGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePnl
            // 
            this.sidePnl.BackColor = System.Drawing.Color.Azure;
            this.sidePnl.Controls.Add(this.Profile);
            this.sidePnl.Controls.Add(this.preOrderBtn);
            this.sidePnl.Controls.Add(this.cManagementBtn);
            this.sidePnl.Controls.Add(this.pQueryBtn);
            this.sidePnl.Controls.Add(this.feedbackBtn);
            this.sidePnl.Controls.Add(this.logoutBtn);
            this.sidePnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePnl.Location = new System.Drawing.Point(0, 0);
            this.sidePnl.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.sidePnl.Name = "sidePnl";
            this.sidePnl.Size = new System.Drawing.Size(308, 1017);
            this.sidePnl.TabIndex = 0;
            // 
            // Profile
            // 
            this.Profile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Profile.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Profile.ForeColor = System.Drawing.Color.Transparent;
            this.Profile.Image = global::App.Properties.Resources.user;
            this.Profile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Profile.Location = new System.Drawing.Point(24, 360);
            this.Profile.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Profile.Name = "Profile";
            this.Profile.Size = new System.Drawing.Size(270, 71);
            this.Profile.TabIndex = 23;
            this.Profile.Text = "Profile";
            this.Profile.UseVisualStyleBackColor = false;
            this.Profile.Click += new System.EventHandler(this.Profile_Click);
            // 
            // preOrderBtn
            // 
            this.preOrderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.preOrderBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preOrderBtn.ForeColor = System.Drawing.Color.Transparent;
            this.preOrderBtn.Image = global::App.Properties.Resources.cart;
            this.preOrderBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.preOrderBtn.Location = new System.Drawing.Point(24, 279);
            this.preOrderBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.preOrderBtn.Name = "preOrderBtn";
            this.preOrderBtn.Size = new System.Drawing.Size(270, 71);
            this.preOrderBtn.TabIndex = 22;
            this.preOrderBtn.Text = "Pre-Order";
            this.preOrderBtn.UseVisualStyleBackColor = false;
            this.preOrderBtn.Click += new System.EventHandler(this.preOrderBtn_Click);
            // 
            // cManagementBtn
            // 
            this.cManagementBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cManagementBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cManagementBtn.ForeColor = System.Drawing.Color.Transparent;
            this.cManagementBtn.Image = global::App.Properties.Resources.user1;
            this.cManagementBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cManagementBtn.Location = new System.Drawing.Point(24, 196);
            this.cManagementBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cManagementBtn.Name = "cManagementBtn";
            this.cManagementBtn.Size = new System.Drawing.Size(270, 71);
            this.cManagementBtn.TabIndex = 12;
            this.cManagementBtn.Text = "CUSTOMER";
            this.cManagementBtn.UseVisualStyleBackColor = false;
            this.cManagementBtn.Click += new System.EventHandler(this.cManagementBtn_Click);
            // 
            // pQueryBtn
            // 
            this.pQueryBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.pQueryBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pQueryBtn.ForeColor = System.Drawing.Color.Transparent;
            this.pQueryBtn.Image = global::App.Properties.Resources.product1;
            this.pQueryBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pQueryBtn.Location = new System.Drawing.Point(24, 113);
            this.pQueryBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pQueryBtn.Name = "pQueryBtn";
            this.pQueryBtn.Size = new System.Drawing.Size(270, 71);
            this.pQueryBtn.TabIndex = 11;
            this.pQueryBtn.Text = "PRODUCT";
            this.pQueryBtn.UseVisualStyleBackColor = false;
            this.pQueryBtn.Click += new System.EventHandler(this.pQueryBtn_Click);
            // 
            // feedbackBtn
            // 
            this.feedbackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.feedbackBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedbackBtn.ForeColor = System.Drawing.Color.Transparent;
            this.feedbackBtn.Image = global::App.Properties.Resources.feedback;
            this.feedbackBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.feedbackBtn.Location = new System.Drawing.Point(24, 31);
            this.feedbackBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.feedbackBtn.Name = "feedbackBtn";
            this.feedbackBtn.Size = new System.Drawing.Size(270, 71);
            this.feedbackBtn.TabIndex = 10;
            this.feedbackBtn.Text = "FEEDBACK";
            this.feedbackBtn.UseVisualStyleBackColor = false;
            this.feedbackBtn.Click += new System.EventHandler(this.feedbackBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.logoutBtn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.Color.Transparent;
            this.logoutBtn.Image = global::App.Properties.Resources.logout;
            this.logoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.Location = new System.Drawing.Point(24, 908);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(270, 71);
            this.logoutBtn.TabIndex = 8;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Azure;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(582, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 65);
            this.label1.TabIndex = 1;
            this.label1.Text = "SALESMAN HOME ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(306, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1664, 102);
            this.panel1.TabIndex = 2;
            // 
            // lowStockGrid
            // 
            this.lowStockGrid.BackgroundColor = System.Drawing.Color.Azure;
            this.lowStockGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lowStockGrid.GridColor = System.Drawing.Color.BurlyWood;
            this.lowStockGrid.Location = new System.Drawing.Point(1164, 392);
            this.lowStockGrid.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lowStockGrid.Name = "lowStockGrid";
            this.lowStockGrid.RowHeadersWidth = 82;
            this.lowStockGrid.Size = new System.Drawing.Size(678, 394);
            this.lowStockGrid.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(1320, 287);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(352, 51);
            this.label2.TabIndex = 2;
            this.label2.Text = "Low Stock Product";
            // 
            // supplierRequestBtn
            // 
            this.supplierRequestBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.supplierRequestBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierRequestBtn.ForeColor = System.Drawing.Color.Transparent;
            this.supplierRequestBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.supplierRequestBtn.Location = new System.Drawing.Point(1286, 790);
            this.supplierRequestBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.supplierRequestBtn.Name = "supplierRequestBtn";
            this.supplierRequestBtn.Size = new System.Drawing.Size(424, 71);
            this.supplierRequestBtn.TabIndex = 13;
            this.supplierRequestBtn.Text = "Recommend for Supply";
            this.supplierRequestBtn.UseVisualStyleBackColor = false;
            this.supplierRequestBtn.Click += new System.EventHandler(this.supplierRequestBtn_Click_1);
            // 
            // supplierRequestGrid
            // 
            this.supplierRequestGrid.BackgroundColor = System.Drawing.Color.Azure;
            this.supplierRequestGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplierRequestGrid.GridColor = System.Drawing.Color.BurlyWood;
            this.supplierRequestGrid.Location = new System.Drawing.Point(434, 392);
            this.supplierRequestGrid.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.supplierRequestGrid.Name = "supplierRequestGrid";
            this.supplierRequestGrid.RowHeadersWidth = 82;
            this.supplierRequestGrid.Size = new System.Drawing.Size(678, 394);
            this.supplierRequestGrid.TabIndex = 14;
            // 
            // supplyRequestBtn
            // 
            this.supplyRequestBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.supplyRequestBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplyRequestBtn.ForeColor = System.Drawing.Color.Transparent;
            this.supplyRequestBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.supplyRequestBtn.Location = new System.Drawing.Point(600, 798);
            this.supplyRequestBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.supplyRequestBtn.Name = "supplyRequestBtn";
            this.supplyRequestBtn.Size = new System.Drawing.Size(304, 71);
            this.supplyRequestBtn.TabIndex = 15;
            this.supplyRequestBtn.Text = "See Supply Request";
            this.supplyRequestBtn.UseVisualStyleBackColor = false;
            this.supplyRequestBtn.Click += new System.EventHandler(this.supplyRequestBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(566, 287);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(380, 51);
            this.label3.TabIndex = 16;
            this.label3.Text = "Requested Products";
            // 
            // welcomeLbl
            // 
            this.welcomeLbl.AutoSize = true;
            this.welcomeLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            this.welcomeLbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.welcomeLbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.welcomeLbl.Location = new System.Drawing.Point(450, 162);
            this.welcomeLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Size = new System.Drawing.Size(0, 51);
            this.welcomeLbl.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(1324, 360);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(353, 32);
            this.label4.TabIndex = 18;
            this.label4.Text = "List of products under 5 units";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(942, 138);
            this.welcomeLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(52, 44);
            this.welcomeLabel.TabIndex = 20;
            this.welcomeLabel.Text = ":::";
            // 
            // Salesman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1948, 1017);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.welcomeLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.supplyRequestBtn);
            this.Controls.Add(this.supplierRequestGrid);
            this.Controls.Add(this.supplierRequestBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lowStockGrid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sidePnl);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximumSize = new System.Drawing.Size(1974, 1088);
            this.MinimumSize = new System.Drawing.Size(1974, 1088);
            this.Name = "Salesman";
            this.Text = "Salesman";
            this.Load += new System.EventHandler(this.Cashier_Home_Load);
            this.sidePnl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lowStockGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierRequestGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel sidePnl;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Button feedbackBtn;
        private System.Windows.Forms.Button cManagementBtn;
        private System.Windows.Forms.Button pQueryBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView lowStockGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button supplierRequestBtn;
        private System.Windows.Forms.DataGridView supplierRequestGrid;
        private System.Windows.Forms.Button supplyRequestBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button preOrderBtn;
        private System.Windows.Forms.Label welcomeLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button Profile;
    }
}