namespace App.UI_Forms.Admin
{
    partial class Product
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPID = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.txtPID = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTProduct = new System.Windows.Forms.Label();
            this.txtTProduct = new System.Windows.Forms.TextBox();
            this.lblAProduct = new System.Windows.Forms.Label();
            this.txtAProduct = new System.Windows.Forms.TextBox();
            this.lblSearchID = new System.Windows.Forms.Label();
            this.txtSearchId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(522, 248);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(124, 31);
            this.lblNumber.TabIndex = 37;
            this.lblNumber.Text = "Category:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(616, 203);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(0, 20);
            this.lblEmail.TabIndex = 36;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(522, 151);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(179, 31);
            this.lblName.TabIndex = 35;
            this.lblName.Text = "ProductName:";
            // 
            // lblPID
            // 
            this.lblPID.AutoSize = true;
            this.lblPID.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPID.Location = new System.Drawing.Point(25, 151);
            this.lblPID.Name = "lblPID";
            this.lblPID.Size = new System.Drawing.Size(132, 31);
            this.lblPID.TabIndex = 34;
            this.lblPID.Text = "ProductId:";
            // 
            // txtCategory
            // 
            this.txtCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCategory.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategory.Location = new System.Drawing.Point(528, 282);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(370, 38);
            this.txtCategory.TabIndex = 33;
            // 
            // txtPrice
            // 
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(31, 282);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(370, 38);
            this.txtPrice.TabIndex = 32;
            // 
            // txtPName
            // 
            this.txtPName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPName.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPName.Location = new System.Drawing.Point(528, 185);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(370, 38);
            this.txtPName.TabIndex = 31;
            // 
            // txtPID
            // 
            this.txtPID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPID.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPID.Location = new System.Drawing.Point(31, 185);
            this.txtPID.Name = "txtPID";
            this.txtPID.Size = new System.Drawing.Size(370, 38);
            this.txtPID.TabIndex = 30;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(821, 705);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(152, 57);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Gainsboro;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(464, 712);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(152, 55);
            this.btnUpdate.TabIndex = 28;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(72, 705);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(152, 62);
            this.btnRefresh.TabIndex = 27;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 344);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(805, 340);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(25, 248);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(76, 31);
            this.lblPrice.TabIndex = 38;
            this.lblPrice.Text = "Price:";
            // 
            // lblTProduct
            // 
            this.lblTProduct.AutoSize = true;
            this.lblTProduct.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTProduct.Location = new System.Drawing.Point(847, 374);
            this.lblTProduct.Name = "lblTProduct";
            this.lblTProduct.Size = new System.Drawing.Size(167, 31);
            this.lblTProduct.TabIndex = 39;
            this.lblTProduct.Text = "TotalProduct:";
            // 
            // txtTProduct
            // 
            this.txtTProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTProduct.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTProduct.Location = new System.Drawing.Point(853, 419);
            this.txtTProduct.Name = "txtTProduct";
            this.txtTProduct.Size = new System.Drawing.Size(161, 38);
            this.txtTProduct.TabIndex = 40;
            // 
            // lblAProduct
            // 
            this.lblAProduct.AutoSize = true;
            this.lblAProduct.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAProduct.Location = new System.Drawing.Point(847, 506);
            this.lblAProduct.Name = "lblAProduct";
            this.lblAProduct.Size = new System.Drawing.Size(213, 31);
            this.lblAProduct.TabIndex = 41;
            this.lblAProduct.Text = "AvailableProduct:";
            // 
            // txtAProduct
            // 
            this.txtAProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAProduct.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAProduct.Location = new System.Drawing.Point(853, 553);
            this.txtAProduct.Name = "txtAProduct";
            this.txtAProduct.Size = new System.Drawing.Size(161, 38);
            this.txtAProduct.TabIndex = 42;
            // 
            // lblSearchID
            // 
            this.lblSearchID.AutoSize = true;
            this.lblSearchID.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchID.ForeColor = System.Drawing.Color.Red;
            this.lblSearchID.Location = new System.Drawing.Point(25, 78);
            this.lblSearchID.Name = "lblSearchID";
            this.lblSearchID.Size = new System.Drawing.Size(122, 31);
            this.lblSearchID.TabIndex = 43;
            this.lblSearchID.Text = "SearchID:";
            // 
            // txtSearchId
            // 
            this.txtSearchId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchId.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchId.Location = new System.Drawing.Point(162, 76);
            this.txtSearchId.Name = "txtSearchId";
            this.txtSearchId.Size = new System.Drawing.Size(370, 38);
            this.txtSearchId.TabIndex = 44;
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtSearchId);
            this.Controls.Add(this.lblSearchID);
            this.Controls.Add(this.txtAProduct);
            this.Controls.Add(this.lblAProduct);
            this.Controls.Add(this.txtTProduct);
            this.Controls.Add(this.lblTProduct);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblPID);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtPName);
            this.Controls.Add(this.txtPID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Product";
            this.Size = new System.Drawing.Size(1093, 800);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPID;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.TextBox txtPID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTProduct;
        private System.Windows.Forms.TextBox txtTProduct;
        private System.Windows.Forms.Label lblAProduct;
        private System.Windows.Forms.TextBox txtAProduct;
        private System.Windows.Forms.Label lblSearchID;
        private System.Windows.Forms.TextBox txtSearchId;
    }
}
