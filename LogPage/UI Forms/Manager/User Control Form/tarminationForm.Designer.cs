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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tarminationForm));
            this.tarminationpnl = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.TarminationEmployee = new System.Windows.Forms.DataGridView();
            this.undobtn = new System.Windows.Forms.Button();
            this.picturepnl = new System.Windows.Forms.Panel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.warningMassage = new System.Windows.Forms.Panel();
            this.deginepnl = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.notFoundlb = new System.Windows.Forms.Label();
            this.adminPermission = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tarminationpnl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TarminationEmployee)).BeginInit();
            this.picturepnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.warningMassage.SuspendLayout();
            this.deginepnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tarminationpnl
            // 
            this.tarminationpnl.Controls.Add(this.pictureBox2);
            this.tarminationpnl.Controls.Add(this.deginepnl);
            this.tarminationpnl.Controls.Add(this.warningMassage);
            this.tarminationpnl.Controls.Add(this.panel1);
            this.tarminationpnl.Controls.Add(this.panel2);
            this.tarminationpnl.Controls.Add(this.TarminationEmployee);
            this.tarminationpnl.Controls.Add(this.undobtn);
            this.tarminationpnl.Controls.Add(this.picturepnl);
            this.tarminationpnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tarminationpnl.Location = new System.Drawing.Point(0, 0);
            this.tarminationpnl.Name = "tarminationpnl";
            this.tarminationpnl.Size = new System.Drawing.Size(1100, 600);
            this.tarminationpnl.TabIndex = 0;
            this.tarminationpnl.Paint += new System.Windows.Forms.PaintEventHandler(this.tarminationpnl_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(304, 181);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 37);
            this.panel1.TabIndex = 45;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(6, 7);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(460, 20);
            this.textBox1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(220, 181);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(85, 37);
            this.panel2.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Search";
            // 
            // TarminationEmployee
            // 
            this.TarminationEmployee.AllowUserToResizeRows = false;
            this.TarminationEmployee.BackgroundColor = System.Drawing.Color.DimGray;
            this.TarminationEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TarminationEmployee.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.TarminationEmployee.GridColor = System.Drawing.Color.Black;
            this.TarminationEmployee.Location = new System.Drawing.Point(75, 234);
            this.TarminationEmployee.Name = "TarminationEmployee";
            this.TarminationEmployee.RowHeadersVisible = false;
            this.TarminationEmployee.RowHeadersWidth = 51;
            this.TarminationEmployee.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.IndianRed;
            this.TarminationEmployee.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TarminationEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TarminationEmployee.Size = new System.Drawing.Size(897, 280);
            this.TarminationEmployee.TabIndex = 39;
            this.TarminationEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TarminationEmployee_CellContentClick);
            // 
            // undobtn
            // 
            this.undobtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.undobtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.undobtn.ForeColor = System.Drawing.Color.White;
            this.undobtn.Location = new System.Drawing.Point(393, 520);
            this.undobtn.Name = "undobtn";
            this.undobtn.Size = new System.Drawing.Size(196, 38);
            this.undobtn.TabIndex = 38;
            this.undobtn.Text = "Undo tarmination";
            this.undobtn.UseVisualStyleBackColor = false;
            this.undobtn.Click += new System.EventHandler(this.undobtn_Click);
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
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(771, 0);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(152, 113);
            this.guna2CirclePictureBox1.TabIndex = 13;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(341, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(417, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // warningMassage
            // 
            this.warningMassage.BackColor = System.Drawing.Color.IndianRed;
            this.warningMassage.Controls.Add(this.adminPermission);
            this.warningMassage.Controls.Add(this.notFoundlb);
            this.warningMassage.Dock = System.Windows.Forms.DockStyle.Top;
            this.warningMassage.Location = new System.Drawing.Point(0, 116);
            this.warningMassage.Name = "warningMassage";
            this.warningMassage.Size = new System.Drawing.Size(1100, 24);
            this.warningMassage.TabIndex = 47;
            // 
            // deginepnl
            // 
            this.deginepnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.deginepnl.Controls.Add(this.label11);
            this.deginepnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.deginepnl.Location = new System.Drawing.Point(0, 140);
            this.deginepnl.Name = "deginepnl";
            this.deginepnl.Size = new System.Drawing.Size(1100, 28);
            this.deginepnl.TabIndex = 48;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(3, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(167, 20);
            this.label11.TabIndex = 14;
            this.label11.Text = "Tarminated Employees ";
            // 
            // notFoundlb
            // 
            this.notFoundlb.AutoSize = true;
            this.notFoundlb.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notFoundlb.ForeColor = System.Drawing.Color.White;
            this.notFoundlb.Location = new System.Drawing.Point(494, 3);
            this.notFoundlb.Name = "notFoundlb";
            this.notFoundlb.Size = new System.Drawing.Size(154, 20);
            this.notFoundlb.TabIndex = 15;
            this.notFoundlb.Text = "Employee Not Found";
            // 
            // adminPermission
            // 
            this.adminPermission.AutoSize = true;
            this.adminPermission.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminPermission.ForeColor = System.Drawing.Color.White;
            this.adminPermission.Location = new System.Drawing.Point(364, 1);
            this.adminPermission.Name = "adminPermission";
            this.adminPermission.Size = new System.Drawing.Size(413, 20);
            this.adminPermission.TabIndex = 16;
            this.adminPermission.Text = "You Can not Change This You need Permission From Admin";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(773, 181);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 90;
            this.pictureBox2.TabStop = false;
            // 
            // tarminationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tarminationpnl);
            this.Name = "tarminationForm";
            this.Size = new System.Drawing.Size(1100, 600);
            this.tarminationpnl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TarminationEmployee)).EndInit();
            this.picturepnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.warningMassage.ResumeLayout(false);
            this.warningMassage.PerformLayout();
            this.deginepnl.ResumeLayout(false);
            this.deginepnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel tarminationpnl;
        private System.Windows.Forms.Panel picturepnl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Button undobtn;
        private System.Windows.Forms.DataGridView TarminationEmployee;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel warningMassage;
        private System.Windows.Forms.Panel deginepnl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label notFoundlb;
        private System.Windows.Forms.Label adminPermission;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
