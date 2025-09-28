namespace App.UI_Forms.Manager.User_Control_Form
{
    partial class report
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(report));
            this.panel1 = new System.Windows.Forms.Panel();
            this.refreashbtn = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.salemanLb = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cashierEmpLb = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.totalsalelb = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.totalpricepnl = new System.Windows.Forms.Panel();
            this.totalpricelb = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.saleManSalary = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.salaryManager = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.cashierSalary = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.totalpricepnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.refreashbtn);
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.totalpricepnl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(831, 536);
            this.panel1.TabIndex = 2;
            // 
            // refreashbtn
            // 
            this.refreashbtn.ForeColor = System.Drawing.Color.Black;
            this.refreashbtn.Location = new System.Drawing.Point(366, 491);
            this.refreashbtn.Name = "refreashbtn";
            this.refreashbtn.Size = new System.Drawing.Size(103, 30);
            this.refreashbtn.TabIndex = 12;
            this.refreashbtn.Text = "Refreash";
            this.refreashbtn.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(27, 151);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Total Price";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Total Sale";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Cashier";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Sales Man";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(575, 308);
            this.chart1.TabIndex = 11;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.salemanLb);
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(649, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(155, 91);
            this.panel3.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 15);
            this.label10.TabIndex = 6;
            this.label10.Text = "Sales Man";
            // 
            // salemanLb
            // 
            this.salemanLb.AutoSize = true;
            this.salemanLb.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salemanLb.Location = new System.Drawing.Point(83, 62);
            this.salemanLb.Name = "salemanLb";
            this.salemanLb.Size = new System.Drawing.Size(58, 17);
            this.salemanLb.TabIndex = 2;
            this.salemanLb.Text = "Amount";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(10, 43);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 40);
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 15);
            this.label9.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(0)))), ((int)(((byte)(13)))));
            this.panel2.Controls.Add(this.cashierEmpLb);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(445, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(155, 91);
            this.panel2.TabIndex = 9;
            // 
            // cashierEmpLb
            // 
            this.cashierEmpLb.AutoSize = true;
            this.cashierEmpLb.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierEmpLb.Location = new System.Drawing.Point(83, 62);
            this.cashierEmpLb.Name = "cashierEmpLb";
            this.cashierEmpLb.Size = new System.Drawing.Size(58, 17);
            this.cashierEmpLb.TabIndex = 2;
            this.cashierEmpLb.Text = "Amount";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(10, 46);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 40);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Cashier";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Khaki;
            this.panel4.Controls.Add(this.totalsalelb);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(239, 15);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(155, 91);
            this.panel4.TabIndex = 8;
            // 
            // totalsalelb
            // 
            this.totalsalelb.AutoSize = true;
            this.totalsalelb.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalsalelb.Location = new System.Drawing.Point(83, 62);
            this.totalsalelb.Name = "totalsalelb";
            this.totalsalelb.Size = new System.Drawing.Size(58, 17);
            this.totalsalelb.TabIndex = 2;
            this.totalsalelb.Text = "Amount";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(10, 43);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tatal Sale";
            // 
            // totalpricepnl
            // 
            this.totalpricepnl.BackColor = System.Drawing.Color.Blue;
            this.totalpricepnl.Controls.Add(this.totalpricelb);
            this.totalpricepnl.Controls.Add(this.pictureBox1);
            this.totalpricepnl.Controls.Add(this.label2);
            this.totalpricepnl.Location = new System.Drawing.Point(27, 15);
            this.totalpricepnl.Name = "totalpricepnl";
            this.totalpricepnl.Size = new System.Drawing.Size(155, 91);
            this.totalpricepnl.TabIndex = 7;
            // 
            // totalpricelb
            // 
            this.totalpricelb.AutoSize = true;
            this.totalpricelb.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalpricelb.Location = new System.Drawing.Point(83, 62);
            this.totalpricelb.Name = "totalpricelb";
            this.totalpricelb.Size = new System.Drawing.Size(58, 17);
            this.totalpricelb.TabIndex = 2;
            this.totalpricelb.Text = "Amount";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Price";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gray;
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.saleManSalary);
            this.panel5.Controls.Add(this.pictureBox5);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(649, 265);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(155, 91);
            this.panel5.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sales Man Salary";
            // 
            // saleManSalary
            // 
            this.saleManSalary.AutoSize = true;
            this.saleManSalary.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleManSalary.Location = new System.Drawing.Point(83, 62);
            this.saleManSalary.Name = "saleManSalary";
            this.saleManSalary.Size = new System.Drawing.Size(58, 17);
            this.saleManSalary.TabIndex = 2;
            this.saleManSalary.Text = "Amount";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(10, 43);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(40, 40);
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DimGray;
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.salaryManager);
            this.panel6.Controls.Add(this.pictureBox6);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Location = new System.Drawing.Point(649, 142);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(155, 84);
            this.panel6.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Manager Salary";
            // 
            // salaryManager
            // 
            this.salaryManager.AutoSize = true;
            this.salaryManager.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaryManager.Location = new System.Drawing.Point(83, 62);
            this.salaryManager.Name = "salaryManager";
            this.salaryManager.Size = new System.Drawing.Size(58, 17);
            this.salaryManager.TabIndex = 2;
            this.salaryManager.Text = "Amount";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(10, 43);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(40, 40);
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(7, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 15);
            this.label11.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.ForestGreen;
            this.panel7.Controls.Add(this.label12);
            this.panel7.Controls.Add(this.cashierSalary);
            this.panel7.Controls.Add(this.pictureBox7);
            this.panel7.Controls.Add(this.label14);
            this.panel7.Location = new System.Drawing.Point(649, 397);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(155, 91);
            this.panel7.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(7, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 15);
            this.label12.TabIndex = 6;
            this.label12.Text = "Cashier Salary";
            // 
            // cashierSalary
            // 
            this.cashierSalary.AutoSize = true;
            this.cashierSalary.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierSalary.Location = new System.Drawing.Point(83, 62);
            this.cashierSalary.Name = "cashierSalary";
            this.cashierSalary.Size = new System.Drawing.Size(58, 17);
            this.cashierSalary.TabIndex = 2;
            this.cashierSalary.Text = "Amount";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(10, 43);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(40, 40);
            this.pictureBox7.TabIndex = 5;
            this.pictureBox7.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(7, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 15);
            this.label14.TabIndex = 2;
            // 
            // report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "report";
            this.Size = new System.Drawing.Size(831, 536);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.totalpricepnl.ResumeLayout(false);
            this.totalpricepnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label cashierSalary;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label salaryManager;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label saleManSalary;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button refreashbtn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label salemanLb;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label cashierEmpLb;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label totalsalelb;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel totalpricepnl;
        private System.Windows.Forms.Label totalpricelb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}
