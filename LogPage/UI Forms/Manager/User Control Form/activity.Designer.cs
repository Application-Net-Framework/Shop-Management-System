namespace App.UI_Forms.Manager
{
    partial class activity
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(activity));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.homemnager = new System.Windows.Forms.Panel();
            this.DailyRecordsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.salemanLb = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cashierEmpLb = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.totalsalelb = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.totalpricepnl = new System.Windows.Forms.Panel();
            this.totalpricelb = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.employeChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.homemnager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DailyRecordsChart)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.totalpricepnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeChart)).BeginInit();
            this.SuspendLayout();
            // 
            // homemnager
            // 
            this.homemnager.Controls.Add(this.employeChart);
            this.homemnager.Controls.Add(this.DailyRecordsChart);
            this.homemnager.Controls.Add(this.panel3);
            this.homemnager.Controls.Add(this.panel2);
            this.homemnager.Controls.Add(this.panel1);
            this.homemnager.Controls.Add(this.totalpricepnl);
            this.homemnager.Location = new System.Drawing.Point(47, 4);
            this.homemnager.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.homemnager.Name = "homemnager";
            this.homemnager.Size = new System.Drawing.Size(1329, 656);
            this.homemnager.TabIndex = 23;
            // 
            // DailyRecordsChart
            // 
            this.DailyRecordsChart.BorderlineColor = System.Drawing.Color.Black;
            chartArea2.Name = "ChartArea1";
            this.DailyRecordsChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.DailyRecordsChart.Legends.Add(legend2);
            this.DailyRecordsChart.Location = new System.Drawing.Point(27, 161);
            this.DailyRecordsChart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DailyRecordsChart.Name = "DailyRecordsChart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Total Price";
            series3.YValuesPerPoint = 2;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Total Sale";
            this.DailyRecordsChart.Series.Add(series3);
            this.DailyRecordsChart.Series.Add(series4);
            this.DailyRecordsChart.Size = new System.Drawing.Size(689, 417);
            this.DailyRecordsChart.TabIndex = 5;
            this.DailyRecordsChart.Text = "chart1";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.salemanLb);
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(1064, 26);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(207, 112);
            this.panel3.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 11);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "Sales Man";
            // 
            // salemanLb
            // 
            this.salemanLb.AutoSize = true;
            this.salemanLb.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salemanLb.Location = new System.Drawing.Point(111, 76);
            this.salemanLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.salemanLb.Name = "salemanLb";
            this.salemanLb.Size = new System.Drawing.Size(72, 23);
            this.salemanLb.TabIndex = 2;
            this.salemanLb.Text = "Amount";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(13, 53);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(53, 49);
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 11);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 20);
            this.label9.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(0)))), ((int)(((byte)(13)))));
            this.panel2.Controls.Add(this.cashierEmpLb);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(820, 26);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 112);
            this.panel2.TabIndex = 3;
            // 
            // cashierEmpLb
            // 
            this.cashierEmpLb.AutoSize = true;
            this.cashierEmpLb.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierEmpLb.Location = new System.Drawing.Point(111, 76);
            this.cashierEmpLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cashierEmpLb.Name = "cashierEmpLb";
            this.cashierEmpLb.Size = new System.Drawing.Size(72, 23);
            this.cashierEmpLb.TabIndex = 2;
            this.cashierEmpLb.Text = "Amount";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(15, 62);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(56, 41);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Cashier";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.Controls.Add(this.totalsalelb);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(416, 26);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 112);
            this.panel1.TabIndex = 2;
            // 
            // totalsalelb
            // 
            this.totalsalelb.AutoSize = true;
            this.totalsalelb.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalsalelb.Location = new System.Drawing.Point(111, 76);
            this.totalsalelb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalsalelb.Name = "totalsalelb";
            this.totalsalelb.Size = new System.Drawing.Size(72, 23);
            this.totalsalelb.TabIndex = 2;
            this.totalsalelb.Text = "Amount";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(13, 53);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 49);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tatal Sale";
            // 
            // totalpricepnl
            // 
            this.totalpricepnl.BackColor = System.Drawing.Color.Blue;
            this.totalpricepnl.Controls.Add(this.totalpricelb);
            this.totalpricepnl.Controls.Add(this.pictureBox1);
            this.totalpricepnl.Controls.Add(this.label2);
            this.totalpricepnl.Location = new System.Drawing.Point(68, 26);
            this.totalpricepnl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.totalpricepnl.Name = "totalpricepnl";
            this.totalpricepnl.Size = new System.Drawing.Size(207, 112);
            this.totalpricepnl.TabIndex = 1;
            // 
            // totalpricelb
            // 
            this.totalpricelb.AutoSize = true;
            this.totalpricelb.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalpricelb.Location = new System.Drawing.Point(111, 76);
            this.totalpricelb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalpricelb.Name = "totalpricelb";
            this.totalpricelb.Size = new System.Drawing.Size(72, 23);
            this.totalpricelb.TabIndex = 2;
            this.totalpricelb.Text = "Amount";
            this.totalpricelb.Click += new System.EventHandler(this.totalpricelb_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 66);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 42);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Price";
            // 
            // employeChart
            // 
            this.employeChart.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.employeChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.employeChart.Legends.Add(legend1);
            this.employeChart.Location = new System.Drawing.Point(809, 161);
            this.employeChart.Name = "employeChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Cashier";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "SalesMan";
            this.employeChart.Series.Add(series1);
            this.employeChart.Series.Add(series2);
            this.employeChart.Size = new System.Drawing.Size(495, 417);
            this.employeChart.TabIndex = 6;
            this.employeChart.Text = "Employees";
            // 
            // activity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.homemnager);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "activity";
            this.Size = new System.Drawing.Size(1600, 686);
            this.Load += new System.EventHandler(this.activity_Load);
            this.homemnager.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DailyRecordsChart)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.totalpricepnl.ResumeLayout(false);
            this.totalpricepnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel homemnager;
        private System.Windows.Forms.DataVisualization.Charting.Chart DailyRecordsChart;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label salemanLb;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label cashierEmpLb;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label totalsalelb;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel totalpricepnl;
        private System.Windows.Forms.Label totalpricelb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart employeChart;
    }
}
