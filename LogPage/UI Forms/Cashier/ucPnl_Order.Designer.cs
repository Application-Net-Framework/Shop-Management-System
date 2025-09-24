namespace App.UI_Forms.Cashier
{
    partial class ucPnl_Order
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblReceipt_home = new System.Windows.Forms.Label();
            this.lblProductDetails_order = new System.Windows.Forms.Label();
            this.btnRefresh_order = new System.Windows.Forms.Button();
            this.dgvOrderDetails_order = new System.Windows.Forms.DataGridView();
            this.lblOrderDetails_order = new System.Windows.Forms.Label();
            this.dgvOrders_order = new System.Windows.Forms.DataGridView();
            this.txtSearch_order = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSearchPhn_order = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails_order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders_order)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReceipt_home
            // 
            this.lblReceipt_home.AutoSize = true;
            this.lblReceipt_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.lblReceipt_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblReceipt_home.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceipt_home.ForeColor = System.Drawing.Color.White;
            this.lblReceipt_home.Location = new System.Drawing.Point(517, 121);
            this.lblReceipt_home.Name = "lblReceipt_home";
            this.lblReceipt_home.Size = new System.Drawing.Size(108, 20);
            this.lblReceipt_home.TabIndex = 29;
            this.lblReceipt_home.Text = "  Print Receipt ";
            this.lblReceipt_home.Click += new System.EventHandler(this.lblReceipt_home_Click);
            // 
            // lblProductDetails_order
            // 
            this.lblProductDetails_order.AutoSize = true;
            this.lblProductDetails_order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.lblProductDetails_order.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductDetails_order.ForeColor = System.Drawing.Color.White;
            this.lblProductDetails_order.Location = new System.Drawing.Point(60, 313);
            this.lblProductDetails_order.Name = "lblProductDetails_order";
            this.lblProductDetails_order.Size = new System.Drawing.Size(129, 20);
            this.lblProductDetails_order.TabIndex = 28;
            this.lblProductDetails_order.Text = "  Product Details  ";
            // 
            // btnRefresh_order
            // 
            this.btnRefresh_order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.btnRefresh_order.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh_order.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnRefresh_order.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.btnRefresh_order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh_order.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh_order.ForeColor = System.Drawing.Color.White;
            this.btnRefresh_order.Location = new System.Drawing.Point(478, 49);
            this.btnRefresh_order.Name = "btnRefresh_order";
            this.btnRefresh_order.Size = new System.Drawing.Size(96, 34);
            this.btnRefresh_order.TabIndex = 22;
            this.btnRefresh_order.Text = "Refresh";
            this.btnRefresh_order.UseVisualStyleBackColor = false;
            this.btnRefresh_order.Click += new System.EventHandler(this.btnRefresh_order_Click_1);
            // 
            // dgvOrderDetails_order
            // 
            this.dgvOrderDetails_order.AllowUserToAddRows = false;
            this.dgvOrderDetails_order.AllowUserToDeleteRows = false;
            this.dgvOrderDetails_order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderDetails_order.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrderDetails_order.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvOrderDetails_order.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderDetails_order.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrderDetails_order.ColumnHeadersHeight = 20;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrderDetails_order.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrderDetails_order.EnableHeadersVisualStyles = false;
            this.dgvOrderDetails_order.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvOrderDetails_order.Location = new System.Drawing.Point(60, 336);
            this.dgvOrderDetails_order.Name = "dgvOrderDetails_order";
            this.dgvOrderDetails_order.ReadOnly = true;
            this.dgvOrderDetails_order.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderDetails_order.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOrderDetails_order.RowHeadersVisible = false;
            this.dgvOrderDetails_order.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderDetails_order.Size = new System.Drawing.Size(565, 138);
            this.dgvOrderDetails_order.TabIndex = 13;
            // 
            // lblOrderDetails_order
            // 
            this.lblOrderDetails_order.AutoSize = true;
            this.lblOrderDetails_order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.lblOrderDetails_order.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderDetails_order.ForeColor = System.Drawing.Color.White;
            this.lblOrderDetails_order.Location = new System.Drawing.Point(60, 121);
            this.lblOrderDetails_order.Name = "lblOrderDetails_order";
            this.lblOrderDetails_order.Size = new System.Drawing.Size(115, 20);
            this.lblOrderDetails_order.TabIndex = 26;
            this.lblOrderDetails_order.Text = "  Order Details  ";
            // 
            // dgvOrders_order
            // 
            this.dgvOrders_order.AllowUserToAddRows = false;
            this.dgvOrders_order.AllowUserToDeleteRows = false;
            this.dgvOrders_order.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrders_order.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvOrders_order.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrders_order.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvOrders_order.ColumnHeadersHeight = 20;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrders_order.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvOrders_order.EnableHeadersVisualStyles = false;
            this.dgvOrders_order.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvOrders_order.Location = new System.Drawing.Point(60, 143);
            this.dgvOrders_order.Name = "dgvOrders_order";
            this.dgvOrders_order.ReadOnly = true;
            this.dgvOrders_order.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrders_order.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvOrders_order.RowHeadersVisible = false;
            this.dgvOrders_order.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders_order.Size = new System.Drawing.Size(565, 138);
            this.dgvOrders_order.TabIndex = 25;
            this.dgvOrders_order.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvOrders_order_CellMouseClick_1);
            // 
            // txtSearch_order
            // 
            this.txtSearch_order.BorderRadius = 4;
            this.txtSearch_order.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch_order.DefaultText = "";
            this.txtSearch_order.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch_order.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch_order.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch_order.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch_order.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch_order.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtSearch_order.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch_order.Location = new System.Drawing.Point(163, 49);
            this.txtSearch_order.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch_order.Name = "txtSearch_order";
            this.txtSearch_order.PlaceholderText = "Search by Phone number or OrderID";
            this.txtSearch_order.SelectedText = "";
            this.txtSearch_order.Size = new System.Drawing.Size(308, 34);
            this.txtSearch_order.TabIndex = 24;
            this.txtSearch_order.TextChanged += new System.EventHandler(this.txtSearch_order_TextChanged_1);
            // 
            // lblSearchPhn_order
            // 
            this.lblSearchPhn_order.AutoSize = true;
            this.lblSearchPhn_order.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchPhn_order.Location = new System.Drawing.Point(98, 55);
            this.lblSearchPhn_order.Name = "lblSearchPhn_order";
            this.lblSearchPhn_order.Size = new System.Drawing.Size(62, 23);
            this.lblSearchPhn_order.TabIndex = 23;
            this.lblSearchPhn_order.Text = "Search";
            // 
            // ucPnl_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.Controls.Add(this.lblReceipt_home);
            this.Controls.Add(this.lblProductDetails_order);
            this.Controls.Add(this.btnRefresh_order);
            this.Controls.Add(this.dgvOrderDetails_order);
            this.Controls.Add(this.lblOrderDetails_order);
            this.Controls.Add(this.dgvOrders_order);
            this.Controls.Add(this.txtSearch_order);
            this.Controls.Add(this.lblSearchPhn_order);
            this.Name = "ucPnl_Order";
            this.Size = new System.Drawing.Size(684, 523);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails_order)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders_order)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReceipt_home;
        private System.Windows.Forms.Label lblProductDetails_order;
        private System.Windows.Forms.Button btnRefresh_order;
        private System.Windows.Forms.DataGridView dgvOrderDetails_order;
        private System.Windows.Forms.Label lblOrderDetails_order;
        private System.Windows.Forms.DataGridView dgvOrders_order;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch_order;
        private System.Windows.Forms.Label lblSearchPhn_order;
    }
}
