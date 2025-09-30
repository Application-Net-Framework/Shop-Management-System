namespace App.UI_Forms.Manager.User_Control_Form
{
    partial class tarminationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tarminationForm));
            this.tarminationpnl = new System.Windows.Forms.Panel();
            this.TarminationEmployee = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.undobtn = new System.Windows.Forms.Button();
            this.tarminationbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EmployeeData = new System.Windows.Forms.DataGridView();
            this.picturepnl = new System.Windows.Forms.Panel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tarminationpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TarminationEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeData)).BeginInit();
            this.picturepnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tarminationpnl
            // 
            this.tarminationpnl.Controls.Add(this.TarminationEmployee);
            this.tarminationpnl.Controls.Add(this.undobtn);
            this.tarminationpnl.Controls.Add(this.tarminationbtn);
            this.tarminationpnl.Controls.Add(this.label1);
            this.tarminationpnl.Controls.Add(this.label2);
            this.tarminationpnl.Controls.Add(this.EmployeeData);
            this.tarminationpnl.Controls.Add(this.picturepnl);
            this.tarminationpnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tarminationpnl.Location = new System.Drawing.Point(0, 0);
            this.tarminationpnl.Name = "tarminationpnl";
            this.tarminationpnl.Size = new System.Drawing.Size(1100, 600);
            this.tarminationpnl.TabIndex = 0;
            // 
            // TarminationEmployee
            // 
            this.TarminationEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TarminationEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.TarminationEmployee.Location = new System.Drawing.Point(602, 251);
            this.TarminationEmployee.Name = "TarminationEmployee";
            this.TarminationEmployee.RowHeadersWidth = 51;
            this.TarminationEmployee.Size = new System.Drawing.Size(475, 281);
            this.TarminationEmployee.TabIndex = 39;
            this.TarminationEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TarminationEmployee_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "UserName";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Role";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // undobtn
            // 
            this.undobtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.undobtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.undobtn.ForeColor = System.Drawing.Color.White;
            this.undobtn.Location = new System.Drawing.Point(754, 537);
            this.undobtn.Name = "undobtn";
            this.undobtn.Size = new System.Drawing.Size(196, 38);
            this.undobtn.TabIndex = 38;
            this.undobtn.Text = "Undo tarmination";
            this.undobtn.UseVisualStyleBackColor = false;
            this.undobtn.Click += new System.EventHandler(this.undobtn_Click);
            // 
            // tarminationbtn
            // 
            this.tarminationbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.tarminationbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tarminationbtn.ForeColor = System.Drawing.Color.White;
            this.tarminationbtn.Location = new System.Drawing.Point(90, 538);
            this.tarminationbtn.Name = "tarminationbtn";
            this.tarminationbtn.Size = new System.Drawing.Size(196, 38);
            this.tarminationbtn.TabIndex = 37;
            this.tarminationbtn.Text = "Tarmination";
            this.tarminationbtn.UseVisualStyleBackColor = false;
            this.tarminationbtn.Click += new System.EventHandler(this.tarminationbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(27, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Employees";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(597, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tarmination Employees";
            // 
            // EmployeeData
            // 
            this.EmployeeData.BackgroundColor = System.Drawing.Color.DimGray;
            this.EmployeeData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeData.GridColor = System.Drawing.Color.Black;
            this.EmployeeData.Location = new System.Drawing.Point(32, 251);
            this.EmployeeData.Name = "EmployeeData";
            this.EmployeeData.RowHeadersWidth = 51;
            this.EmployeeData.Size = new System.Drawing.Size(444, 281);
            this.EmployeeData.TabIndex = 1;
            this.EmployeeData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeeData_CellContentClick);
            // 
            // picturepnl
            // 
            this.picturepnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(228)))), ((int)(((byte)(155)))));
            this.picturepnl.Controls.Add(this.guna2CirclePictureBox1);
            this.picturepnl.Controls.Add(this.pictureBox1);
            this.picturepnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.picturepnl.Location = new System.Drawing.Point(0, 0);
            this.picturepnl.Name = "picturepnl";
            this.picturepnl.Size = new System.Drawing.Size(1100, 116);
            this.picturepnl.TabIndex = 0;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(829, 0);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(152, 113);
            this.guna2CirclePictureBox1.TabIndex = 13;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(184, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(627, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tarminationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tarminationpnl);
            this.Name = "tarminationForm";
            this.Size = new System.Drawing.Size(1100, 600);
            this.tarminationpnl.ResumeLayout(false);
            this.tarminationpnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TarminationEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeData)).EndInit();
            this.picturepnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel tarminationpnl;
        private System.Windows.Forms.Panel picturepnl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView EmployeeData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button undobtn;
        private System.Windows.Forms.Button tarminationbtn;
        private System.Windows.Forms.DataGridView TarminationEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}
