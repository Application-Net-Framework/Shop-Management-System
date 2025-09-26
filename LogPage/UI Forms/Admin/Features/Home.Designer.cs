namespace App.UI_Forms.Manager
{
    partial class Home
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
            this.pnlTotalSale = new System.Windows.Forms.Panel();
            this.totalProduct = new System.Windows.Forms.Panel();
            this.totalEmp = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTotalSale
            // 
            this.pnlTotalSale.BackColor = System.Drawing.Color.LightGray;
            this.pnlTotalSale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotalSale.Location = new System.Drawing.Point(80, 40);
            this.pnlTotalSale.Name = "pnlTotalSale";
            this.pnlTotalSale.Size = new System.Drawing.Size(251, 149);
            this.pnlTotalSale.TabIndex = 1;
            this.pnlTotalSale.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTotalSale_Paint);
            // 
            // totalProduct
            // 
            this.totalProduct.BackColor = System.Drawing.Color.LightGray;
            this.totalProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalProduct.Location = new System.Drawing.Point(429, 40);
            this.totalProduct.Name = "totalProduct";
            this.totalProduct.Size = new System.Drawing.Size(251, 149);
            this.totalProduct.TabIndex = 2;
            // 
            // totalEmp
            // 
            this.totalEmp.BackColor = System.Drawing.Color.LightGray;
            this.totalEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalEmp.Location = new System.Drawing.Point(771, 40);
            this.totalEmp.Name = "totalEmp";
            this.totalEmp.Size = new System.Drawing.Size(251, 149);
            this.totalEmp.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Beige;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 263);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1068, 427);
            this.dataGridView1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(14, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Employee Record";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.totalEmp);
            this.Controls.Add(this.totalProduct);
            this.Controls.Add(this.pnlTotalSale);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(1292, 800);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlTotalSale;
        private System.Windows.Forms.Panel totalProduct;
        private System.Windows.Forms.Panel totalEmp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}
