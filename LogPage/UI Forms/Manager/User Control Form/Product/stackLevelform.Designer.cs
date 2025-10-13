namespace App.UI_Forms.Manager
{
    partial class stackLevelform
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stackLevelform));
            this.stackLevelPanel = new System.Windows.Forms.Panel();
            this.StackLevelchartpnl = new System.Windows.Forms.Panel();
            this.HighStack = new System.Windows.Forms.DataGridView();
            this.LowStack = new System.Windows.Forms.DataGridView();
            this.searchProductManager = new App.UI_Forms.Manager.User_Control_Form.searchProduct();
            this.productAddManager = new App.UI_Forms.Manager.User_Control_Form.productAdd();
            this.refreashbtn = new System.Windows.Forms.Button();
            this.addproductpnlbtn = new System.Windows.Forms.Button();
            this.serchpnlbtn = new System.Windows.Forms.Button();
            this.employeChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.stackLevelPanel.SuspendLayout();
            this.StackLevelchartpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HighStack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowStack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeChart)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // stackLevelPanel
            // 
            this.stackLevelPanel.Controls.Add(this.StackLevelchartpnl);
            this.stackLevelPanel.Controls.Add(this.panel2);
            this.stackLevelPanel.Controls.Add(this.panel1);
            this.stackLevelPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stackLevelPanel.Location = new System.Drawing.Point(0, 0);
            this.stackLevelPanel.Name = "stackLevelPanel";
            this.stackLevelPanel.Size = new System.Drawing.Size(1200, 600);
            this.stackLevelPanel.TabIndex = 0;
            // 
            // StackLevelchartpnl
            // 
            this.StackLevelchartpnl.Controls.Add(this.HighStack);
            this.StackLevelchartpnl.Controls.Add(this.LowStack);
            this.StackLevelchartpnl.Controls.Add(this.searchProductManager);
            this.StackLevelchartpnl.Controls.Add(this.productAddManager);
            this.StackLevelchartpnl.Controls.Add(this.refreashbtn);
            this.StackLevelchartpnl.Controls.Add(this.addproductpnlbtn);
            this.StackLevelchartpnl.Controls.Add(this.serchpnlbtn);
            this.StackLevelchartpnl.Controls.Add(this.employeChart);
            this.StackLevelchartpnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StackLevelchartpnl.Location = new System.Drawing.Point(0, 162);
            this.StackLevelchartpnl.Name = "StackLevelchartpnl";
            this.StackLevelchartpnl.Size = new System.Drawing.Size(1200, 438);
            this.StackLevelchartpnl.TabIndex = 86;
            // 
            // HighStack
            // 
            this.HighStack.AllowUserToResizeRows = false;
            this.HighStack.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.HighStack.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.HighStack.BackgroundColor = System.Drawing.Color.DimGray;
            this.HighStack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HighStack.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.HighStack.GridColor = System.Drawing.Color.Black;
            this.HighStack.Location = new System.Drawing.Point(26, 42);
            this.HighStack.Name = "HighStack";
            this.HighStack.RowHeadersVisible = false;
            this.HighStack.RowHeadersWidth = 51;
            this.HighStack.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Green;
            this.HighStack.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.HighStack.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.HighStack.Size = new System.Drawing.Size(260, 267);
            this.HighStack.TabIndex = 92;
            this.HighStack.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HighStack_CellContentClick);
            // 
            // LowStack
            // 
            this.LowStack.AllowUserToResizeRows = false;
            this.LowStack.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LowStack.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.LowStack.BackgroundColor = System.Drawing.Color.DimGray;
            this.LowStack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LowStack.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.LowStack.GridColor = System.Drawing.Color.Black;
            this.LowStack.Location = new System.Drawing.Point(832, 42);
            this.LowStack.Name = "LowStack";
            this.LowStack.RowHeadersVisible = false;
            this.LowStack.RowHeadersWidth = 51;
            this.LowStack.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.IndianRed;
            this.LowStack.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.LowStack.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LowStack.Size = new System.Drawing.Size(250, 267);
            this.LowStack.TabIndex = 91;
            this.LowStack.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LowStack_CellContentClick);
            // 
            // searchProductManager
            // 
            this.searchProductManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchProductManager.Location = new System.Drawing.Point(0, 0);
            this.searchProductManager.Name = "searchProductManager";
            this.searchProductManager.Size = new System.Drawing.Size(1200, 438);
            this.searchProductManager.TabIndex = 88;
            this.searchProductManager.Load += new System.EventHandler(this.searchProductManager_Load);
            // 
            // productAddManager
            // 
            this.productAddManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productAddManager.Location = new System.Drawing.Point(0, 0);
            this.productAddManager.Name = "productAddManager";
            this.productAddManager.Size = new System.Drawing.Size(1200, 438);
            this.productAddManager.TabIndex = 87;
            // 
            // refreashbtn
            // 
            this.refreashbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.refreashbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreashbtn.ForeColor = System.Drawing.Color.White;
            this.refreashbtn.Location = new System.Drawing.Point(668, 345);
            this.refreashbtn.Name = "refreashbtn";
            this.refreashbtn.Size = new System.Drawing.Size(126, 38);
            this.refreashbtn.TabIndex = 86;
            this.refreashbtn.Text = "Load";
            this.refreashbtn.UseVisualStyleBackColor = false;
            this.refreashbtn.Click += new System.EventHandler(this.refreashbtn_Click);
            // 
            // addproductpnlbtn
            // 
            this.addproductpnlbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.addproductpnlbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addproductpnlbtn.ForeColor = System.Drawing.Color.White;
            this.addproductpnlbtn.Location = new System.Drawing.Point(492, 345);
            this.addproductpnlbtn.Name = "addproductpnlbtn";
            this.addproductpnlbtn.Size = new System.Drawing.Size(126, 38);
            this.addproductpnlbtn.TabIndex = 85;
            this.addproductpnlbtn.Text = "Add";
            this.addproductpnlbtn.UseVisualStyleBackColor = false;
            this.addproductpnlbtn.Click += new System.EventHandler(this.addproductpnlbtn_Click);
            // 
            // serchpnlbtn
            // 
            this.serchpnlbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.serchpnlbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serchpnlbtn.ForeColor = System.Drawing.Color.White;
            this.serchpnlbtn.Location = new System.Drawing.Point(316, 345);
            this.serchpnlbtn.Name = "serchpnlbtn";
            this.serchpnlbtn.Size = new System.Drawing.Size(126, 38);
            this.serchpnlbtn.TabIndex = 84;
            this.serchpnlbtn.Text = "Search";
            this.serchpnlbtn.UseVisualStyleBackColor = false;
            this.serchpnlbtn.Click += new System.EventHandler(this.serchpnlbtn_Click);
            // 
            // employeChart
            // 
            this.employeChart.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.employeChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.employeChart.Legends.Add(legend1);
            this.employeChart.Location = new System.Drawing.Point(330, 42);
            this.employeChart.Margin = new System.Windows.Forms.Padding(2);
            this.employeChart.Name = "employeChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Stack";
            this.employeChart.Series.Add(series1);
            this.employeChart.Size = new System.Drawing.Size(453, 267);
            this.employeChart.TabIndex = 7;
            this.employeChart.Text = "EmployeesChart";
            this.employeChart.Click += new System.EventHandler(this.employeChart_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.panel2.Controls.Add(this.label11);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 41);
            this.panel2.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(3, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(180, 20);
            this.label11.TabIndex = 14;
            this.label11.Text = "Stack Level And Products";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(228)))), ((int)(((byte)(155)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 121);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(316, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(403, 100);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // stackLevelform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.stackLevelPanel);
            this.Name = "stackLevelform";
            this.Size = new System.Drawing.Size(1200, 600);
            this.stackLevelPanel.ResumeLayout(false);
            this.StackLevelchartpnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HighStack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowStack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeChart)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel stackLevelPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel StackLevelchartpnl;
        private System.Windows.Forms.DataVisualization.Charting.Chart employeChart;
        private System.Windows.Forms.Button refreashbtn;
        private System.Windows.Forms.Button addproductpnlbtn;
        private System.Windows.Forms.Button serchpnlbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private User_Control_Form.searchProduct searchProductManager;
        private User_Control_Form.productAdd productAddManager;
        private System.Windows.Forms.DataGridView HighStack;
        private System.Windows.Forms.DataGridView LowStack;
    }
}
