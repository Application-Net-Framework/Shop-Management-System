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
            this.panel3 = new System.Windows.Forms.Panel();
            this.aboutTxtboxName = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.userNamelb = new System.Windows.Forms.Label();
            this.invalidUsernamelb = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tarminationpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TarminationEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeData)).BeginInit();
            this.picturepnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tarminationpnl
            // 
            this.tarminationpnl.Controls.Add(this.panel1);
            this.tarminationpnl.Controls.Add(this.panel2);
            this.tarminationpnl.Controls.Add(this.label4);
            this.tarminationpnl.Controls.Add(this.panel3);
            this.tarminationpnl.Controls.Add(this.panel4);
            this.tarminationpnl.Controls.Add(this.invalidUsernamelb);
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
            this.TarminationEmployee.BackgroundColor = System.Drawing.Color.DimGray;
            this.TarminationEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TarminationEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.TarminationEmployee.Location = new System.Drawing.Point(583, 236);
            this.TarminationEmployee.Name = "TarminationEmployee";
            this.TarminationEmployee.RowHeadersWidth = 51;
            this.TarminationEmployee.Size = new System.Drawing.Size(473, 281);
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
            this.undobtn.Location = new System.Drawing.Point(739, 520);
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
            this.tarminationbtn.Location = new System.Drawing.Point(155, 523);
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
            this.label1.Size = new System.Drawing.Size(89, 21);
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
            this.label2.Size = new System.Drawing.Size(178, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tarmination Employees";
            // 
            // EmployeeData
            // 
            this.EmployeeData.BackgroundColor = System.Drawing.Color.DimGray;
            this.EmployeeData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeData.GridColor = System.Drawing.Color.Black;
            this.EmployeeData.Location = new System.Drawing.Point(34, 236);
            this.EmployeeData.Name = "EmployeeData";
            this.EmployeeData.RowHeadersWidth = 51;
            this.EmployeeData.Size = new System.Drawing.Size(467, 281);
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.aboutTxtboxName);
            this.panel3.Location = new System.Drawing.Point(180, 166);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(319, 37);
            this.panel3.TabIndex = 42;
            // 
            // aboutTxtboxName
            // 
            this.aboutTxtboxName.BackColor = System.Drawing.Color.White;
            this.aboutTxtboxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.aboutTxtboxName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutTxtboxName.Location = new System.Drawing.Point(4, 9);
            this.aboutTxtboxName.Margin = new System.Windows.Forms.Padding(4);
            this.aboutTxtboxName.Name = "aboutTxtboxName";
            this.aboutTxtboxName.Size = new System.Drawing.Size(311, 20);
            this.aboutTxtboxName.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.panel4.Controls.Add(this.userNamelb);
            this.panel4.Location = new System.Drawing.Point(32, 166);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(151, 37);
            this.panel4.TabIndex = 40;
            // 
            // userNamelb
            // 
            this.userNamelb.AutoSize = true;
            this.userNamelb.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNamelb.ForeColor = System.Drawing.Color.White;
            this.userNamelb.Location = new System.Drawing.Point(7, 9);
            this.userNamelb.Name = "userNamelb";
            this.userNamelb.Size = new System.Drawing.Size(94, 20);
            this.userNamelb.TabIndex = 1;
            this.userNamelb.Text = "User Name :";
            // 
            // invalidUsernamelb
            // 
            this.invalidUsernamelb.AutoSize = true;
            this.invalidUsernamelb.ForeColor = System.Drawing.Color.IndianRed;
            this.invalidUsernamelb.Location = new System.Drawing.Point(31, 204);
            this.invalidUsernamelb.Name = "invalidUsernamelb";
            this.invalidUsernamelb.Size = new System.Drawing.Size(93, 13);
            this.invalidUsernamelb.TabIndex = 41;
            this.invalidUsernamelb.Text = "Invalid  user name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(732, 166);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 37);
            this.panel1.TabIndex = 45;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(4, 9);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(311, 20);
            this.textBox1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(584, 166);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(151, 37);
            this.panel2.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "User Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.IndianRed;
            this.label4.Location = new System.Drawing.Point(583, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Invalid  user name";
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
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox aboutTxtboxName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label userNamelb;
        private System.Windows.Forms.Label invalidUsernamelb;
    }
}
