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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.cManagementBtn = new System.Windows.Forms.Button();
            this.pQueryBtn = new System.Windows.Forms.Button();
            this.feedbackBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lowStockGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.supplierRequestBtn = new System.Windows.Forms.Button();
            this.supplierRequestGrid = new System.Windows.Forms.DataGridView();
            this.supplyRequestBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.sidePnl.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lowStockGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierRequestGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePnl
            // 
            this.sidePnl.BackColor = System.Drawing.Color.DimGray;
            this.sidePnl.Controls.Add(this.cManagementBtn);
            this.sidePnl.Controls.Add(this.pQueryBtn);
            this.sidePnl.Controls.Add(this.feedbackBtn);
            this.sidePnl.Controls.Add(this.logoutBtn);
            this.sidePnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePnl.Location = new System.Drawing.Point(0, 0);
            this.sidePnl.Name = "sidePnl";
            this.sidePnl.Size = new System.Drawing.Size(154, 521);
            this.sidePnl.TabIndex = 0;
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
            // cManagementBtn
            // 
            this.cManagementBtn.BackColor = System.Drawing.Color.DimGray;
            this.cManagementBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cManagementBtn.ForeColor = System.Drawing.Color.Transparent;
            this.cManagementBtn.Image = global::App.Properties.Resources.user1;
            this.cManagementBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cManagementBtn.Location = new System.Drawing.Point(12, 102);
            this.cManagementBtn.Name = "cManagementBtn";
            this.cManagementBtn.Size = new System.Drawing.Size(135, 37);
            this.cManagementBtn.TabIndex = 12;
            this.cManagementBtn.Text = "CUSTOMER";
            this.cManagementBtn.UseVisualStyleBackColor = false;
            this.cManagementBtn.Click += new System.EventHandler(this.cManagementBtn_Click);
            // 
            // pQueryBtn
            // 
            this.pQueryBtn.BackColor = System.Drawing.Color.DimGray;
            this.pQueryBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pQueryBtn.ForeColor = System.Drawing.Color.Transparent;
            this.pQueryBtn.Image = global::App.Properties.Resources.product1;
            this.pQueryBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pQueryBtn.Location = new System.Drawing.Point(12, 59);
            this.pQueryBtn.Name = "pQueryBtn";
            this.pQueryBtn.Size = new System.Drawing.Size(135, 37);
            this.pQueryBtn.TabIndex = 11;
            this.pQueryBtn.Text = "PRODUCT";
            this.pQueryBtn.UseVisualStyleBackColor = false;
            this.pQueryBtn.Click += new System.EventHandler(this.pQueryBtn_Click);
            // 
            // feedbackBtn
            // 
            this.feedbackBtn.BackColor = System.Drawing.Color.DimGray;
            this.feedbackBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedbackBtn.ForeColor = System.Drawing.Color.Transparent;
            this.feedbackBtn.Image = global::App.Properties.Resources.feedback;
            this.feedbackBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.feedbackBtn.Location = new System.Drawing.Point(12, 16);
            this.feedbackBtn.Name = "feedbackBtn";
            this.feedbackBtn.Size = new System.Drawing.Size(135, 37);
            this.feedbackBtn.TabIndex = 10;
            this.feedbackBtn.Text = "FEEDBACK";
            this.feedbackBtn.UseVisualStyleBackColor = false;
            this.feedbackBtn.Click += new System.EventHandler(this.feedbackBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.DimGray;
            this.logoutBtn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.Color.Transparent;
            this.logoutBtn.Image = global::App.Properties.Resources.logout;
            this.logoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.Location = new System.Drawing.Point(12, 472);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(135, 37);
            this.logoutBtn.TabIndex = 8;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(334, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "SALESMAN HOME ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(153, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(928, 53);
            this.panel1.TabIndex = 2;
            // 
            // lowStockGrid
            // 
            this.lowStockGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.lowStockGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lowStockGrid.GridColor = System.Drawing.Color.BurlyWood;
            this.lowStockGrid.Location = new System.Drawing.Point(633, 265);
            this.lowStockGrid.Name = "lowStockGrid";
            this.lowStockGrid.Size = new System.Drawing.Size(339, 205);
            this.lowStockGrid.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkCyan;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(711, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Low Stock Product";
            // 
            // supplierRequestBtn
            // 
            this.supplierRequestBtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.supplierRequestBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierRequestBtn.ForeColor = System.Drawing.Color.Transparent;
            this.supplierRequestBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.supplierRequestBtn.Location = new System.Drawing.Point(694, 472);
            this.supplierRequestBtn.Name = "supplierRequestBtn";
            this.supplierRequestBtn.Size = new System.Drawing.Size(212, 37);
            this.supplierRequestBtn.TabIndex = 13;
            this.supplierRequestBtn.Text = "Recommend for Supply";
            this.supplierRequestBtn.UseVisualStyleBackColor = false;
            this.supplierRequestBtn.Click += new System.EventHandler(this.supplierRequestBtn_Click_1);
            // 
            // supplierRequestGrid
            // 
            this.supplierRequestGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.supplierRequestGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplierRequestGrid.GridColor = System.Drawing.Color.BurlyWood;
            this.supplierRequestGrid.Location = new System.Drawing.Point(268, 265);
            this.supplierRequestGrid.Name = "supplierRequestGrid";
            this.supplierRequestGrid.Size = new System.Drawing.Size(339, 205);
            this.supplierRequestGrid.TabIndex = 14;
            // 
            // supplyRequestBtn
            // 
            this.supplyRequestBtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.supplyRequestBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplyRequestBtn.ForeColor = System.Drawing.Color.Transparent;
            this.supplyRequestBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.supplyRequestBtn.Location = new System.Drawing.Point(351, 476);
            this.supplyRequestBtn.Name = "supplyRequestBtn";
            this.supplyRequestBtn.Size = new System.Drawing.Size(152, 37);
            this.supplyRequestBtn.TabIndex = 15;
            this.supplyRequestBtn.Text = "See Supply Request";
            this.supplyRequestBtn.UseVisualStyleBackColor = false;
            this.supplyRequestBtn.Click += new System.EventHandler(this.supplyRequestBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkCyan;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(334, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "Requested Products";
            // 
            // Salesman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1079, 521);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.supplyRequestBtn);
            this.Controls.Add(this.supplierRequestGrid);
            this.Controls.Add(this.supplierRequestBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lowStockGrid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sidePnl);
            this.MaximumSize = new System.Drawing.Size(1095, 560);
            this.MinimumSize = new System.Drawing.Size(1095, 560);
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
    }
}